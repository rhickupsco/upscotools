using System;
using System.Linq;
using System.Windows.Forms;
using System.IO;
using System.Data;
using System.Drawing;

namespace DocScanWO
{
    public partial class frmAutoScanHelper : Form
    {


        public string CurrentFileName { get; set; }
        public string WONumber { get; set; }

        public string StdLabor { get; set; }
        public string ActLabor { get; set; }
        public string ItemName { get; set; }
        public string ItemDesc { get; set; }

        public string OrderDate { get; set; }
        public string VendorName { get; set; }
        public string VendorNo { get; set; }

        public string MakeFor { get; set; }

        public string MakeForType { get; set; }

        public static readonly Color goodColor = Color.LightGreen;
        public static readonly Color badColor = SystemColors.Control;
        public string WebSearchURL { get; set; }
        public string FullURL { get; set; }
        public string SourceFile { get; set; }
        public string TriggerType { get; set; }
        public string MSG = "The Save Operation Failed";
        public string FileType { get; set; }
        public string ParentWO { get; set; }
        public string SONumber { get; set; }
        public DateTime ScannedDateTime { get; set; }

        public frmAutoScanHelper()
        {
            InitializeComponent();
        }

        private void maintenanceForm_Load(object sender, EventArgs e)
        {
            LoadNames();
        }

        private void LoadNames()
        {
            using (DocScanArchiveEntities sd = new DocScanArchiveEntities())
            {
                comboBox1.DataSource = sd.SetupInfoes.ToList();
                comboBox1.DisplayMember = "operatorName";
                comboBox1.ValueMember = "watchFileLocation";
                lblToValue.Text = comboBox1.SelectedValue.ToString();
                FileType = "W";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            string tmpFileExtenstion = TriggerType;
            string woNumber = string.Empty;
            int totalCount = 0;
            int processedCount = 0;
            TriggerType = ".pdf";

            string[] files = Directory.GetFiles(lblToValue.Text, "*" + TriggerType);

            foreach (string file in files)
            {
                //ScannedDateTime = File.GetCreationTime(file);
                totalCount += CountFile(file);

                lblFileFoundCount.Text = totalCount.ToString();
                this.btnGo.Text = "Processing";
                this.Refresh();
                ParseFileName();
                if (GatherInfoToSave(CurrentFileName))
                {
                   if(ProcessFile() == 1)
                   {
                        MoveFile();
                        AddToRecentScans(CurrentFileName);
                        DeletePDF();
                        processedCount += UpdateUI();
                        lblQtyTransferred.Text = processedCount.ToString();
                        this.BringToFront();
                        Refresh();

                    }
                   

                }

            }

        }

        private void AddToRecentScans(string currentFileName)
        {
            Button woButton = new Button();
            woButton.Name = WONumber;
            woButton.Click += (s, e) => { MarkForDelete(woButton.Name); };
            woButton.Width = 80;
            woButton.Height = 70;
            woButton.FlatStyle = FlatStyle.Flat;
            woButton.Font = new Font("Arial Black", 14);
            woButton.UseVisualStyleBackColor = true;
            woButton.FlatAppearance.BorderSize = 3;
            woButton.FlatAppearance.BorderColor = Color.Green;
            woButton.FlatAppearance.MouseDownBackColor = Color.Red;
            woButton.FlatAppearance.MouseOverBackColor = Color.LightPink;
            woButton.Text = WONumber.ToString();          
            flpRecentlyProcessed.Controls.Add(woButton);

            //this resets the text for Process Scans Button
            btnGo.Text = "Process Scans";
        }

        private void MarkForDelete(string WorkOrderNumber)
        {
            //MessageBox.Show("Scan :" + currentFileName.ToString() + " has been removed, please rescan ");
            Control[] thisControl = flpRecentlyProcessed.Controls.Find(WorkOrderNumber, false);
            Button thisButton = (Button)thisControl[0];

            if (thisButton.BackColor != Color.Red)
            {
                thisButton.BackColor = Color.Red;
                thisButton.ForeColor = Color.White;

                txtWorkOrderToDelete.Text = WorkOrderNumber.ToString();
            }
            else
            {
                thisButton.BackColor = Color.White;
                thisButton.ForeColor = Color.Black;

                txtWorkOrderToDelete.Text = string.Empty;
            }

        }

        private int CountFile(string fileName)
        {
            int success = 1;

            CurrentFileName = fileName.Substring(fileName.LastIndexOf('\\') + 1);

            FullURL = Path.GetFullPath(fileName.Replace(CurrentFileName, ""));

            return success;
        }

        private int UpdateUI()
        {
            int success = 1;

            return success;
        }
        private void ParseFileName()
        {
            string tmpFileExtenstion = TriggerType;

            string woNumber = CurrentFileName.Remove(0, 3).Replace(tmpFileExtenstion, "");

            if (woNumber.ToString().ToUpper().Contains("A"))
            {
                WONumber = woNumber.Remove(woNumber.Length - 1);
                FileType = "A";
            }
            else
            {
                WONumber = woNumber;
                FileType = "W";
            }
        }

        private int ProcessFile()
        {
            int success = 0;

            SourceFile = Path.Combine(FullURL, CurrentFileName);

            bool boolFileSaved = false;
            int intNextId = 0;

            using (DocScanArchiveEntities sdd = new DocScanArchiveEntities())
            {

                WorkOrderArchive woa = new WorkOrderArchive();
                woa.FileName = CurrentFileName;
                woa.WorkOrderNumber = WONumber;
                woa.WODate = DocScanWO.Data_Access.CommonData.ConvertToDate(OrderDate);
                woa.VendorName = VendorName;
                woa.SalesOrderNumber = MakeFor;
                woa.ScanDate = DateTime.Now.ToLocalTime();
                woa.FileType = FileType;
                woa.ItemDescription = ItemDesc;
                woa.ItemNumber = ItemName;
                woa.LaborHoursActual = DocScanWO.Data_Access.CommonData.ConvertToNumber(ActLabor);
                woa.LaborHoursStandard = DocScanWO.Data_Access.CommonData.ConvertToNumber(StdLabor);
                woa.ParentWorkOrderNumber = ParentWO;
                
                //Insert a record into the FilesStorage Table and get back the Id
                FileStorage Fist = new FileStorage();
                Fist.Notes = "no notes available";
                Fist.File = DocScanWO.Data_Access.CommonData.ConvertFileToStream(SourceFile);

                try
                {
                    sdd.FileStorages.Add(Fist);
                    System.Threading.Thread.Sleep(1000);
                    sdd.SaveChanges();
                    System.Threading.Thread.Sleep(3000);
                    boolFileSaved = true;
                    intNextId = Fist.FileId;
                }
                catch (Exception)
                {
                    boolFileSaved = false;
                    MSG += "Errors exist in the database";
                }

                if (boolFileSaved)
                {
                    // MoveDataAsync();
                    success = 1;
                    //Save the record to the database
                    try
                    {
                        woa.FileId = intNextId;
                        sdd.WorkOrderArchives.Add(woa);
                        sdd.SaveChanges();
                        MSG = "Information Saved";
                    }
                    catch  (Exception ex)
                    {

                        MSG += "Errors exist in the database: " + ex.ToString();
                    }
                }
                else
                {
                    success = 0;
                }


                return success;

            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblToValue.Text = comboBox1.SelectedValue.ToString();
        }

        private bool GatherInfoToSave(string woNumber, string optionalH = "no")
        {
            bool found = false;
            DataTable localDt = new DataTable();
            //just catching it, nothing done with this variable
            CurrentFileName = woNumber;

            if (optionalH == "history")
            {
                localDt = DocScanWO.Data_Access.CommonData.GetWorkOrderData(WONumber,"history");
            }
            else { localDt = DocScanWO.Data_Access.CommonData.GetWorkOrderData(WONumber); }
            
            try
            {
                WONumber = localDt.Rows[0]["WorkOrder"].ToString();
                MakeForType = localDt.Rows[0]["MakeFor"].ToString();
                OrderDate = localDt.Rows[0]["WODueDate"].ToString();
                VendorNo = localDt.Rows[0]["SOCustNumber"].ToString().TrimEnd();
                StdLabor = localDt.Rows[0]["StdLaborCost"].ToString();
                ActLabor = localDt.Rows[0]["ActualLaborCost"].ToString();
                MakeFor = localDt.Rows[0]["MakeForOrderNumber"].ToString().TrimEnd();
                ItemName = localDt.Rows[0]["ItemBillNumber"].ToString().TrimEnd();
                //this is the difference between fields in History table and WorkOrder master table
                if (optionalH == "history") { ItemDesc = localDt.Rows[0]["ItemDescription"].ToString().TrimEnd(); }
                else { ItemDesc = localDt.Rows[0]["ItemBillDescription"].ToString().TrimEnd(); }

                //determine if this is child or parent WorkOrder
                if (VendorNo.ToString() == null || VendorNo.Length < 2)
                {
                    //Clear out vendor name from previous iteration
                    VendorName = null;
                    ParentWO = localDt.Rows[0]["MakeForOrderNumber"].ToString().TrimEnd();
                    //recursively call the makeFor value until a parent Vendor Name is found
                    var tmpStr = "Vendor Name Not Found";

                    while (VendorName == "Vendor Name Not Found" || VendorName == null)
                    {
                        //this is a workOrder that is only made for Inventory
                        if ((MakeForType == "I") || (MakeFor=="I")) { tmpStr = "0000000"; VendorName = "INVENTORY";}
                          else { tmpStr = FindParentSO(MakeFor); }  
                    }
                    //once found, the Sales Order number of the child WO is set to the SalesOrder number of the Parent WO
                    MakeFor = tmpStr;
                }
                else
                {
                    ParentWO = WONumber;
                    GetVendorName();
                }

                found = true;
            }
            catch (Exception)
            {
            //we are starting to get into really old WorkOrders to be looked up in different tables
                if (GatherInfoToSave(woNumber,"history"))
                    { found = true; }
             else { found = false; } 
         
            }

            return found;

        }

        private void GetVendorName()
        {
            DataTable localDt = new DataTable();
            localDt = DocScanWO.Data_Access.CommonData.GetCustomerInfo(VendorNo);
            VendorName = localDt.Rows[0]["CustomerName"].ToString();
        }

        private string FindParentSO(string makeFor)
        {
            DataTable dtNorthWO = new DataTable();
            dtNorthWO = DocScanWO.Data_Access.CommonData.GetWorkOrderData(makeFor);
            try
            {
                //since the WO Numbers change, we have to find the Sales Order customer number on the parent Work Order
                MakeFor = dtNorthWO.Rows[0]["MakeFor"].ToString().TrimEnd();
                if (MakeFor == "W") { MakeFor = dtNorthWO.Rows[0]["MakeForOrderNumber"].ToString().TrimEnd(); } 
                VendorNo = dtNorthWO.Rows[0]["SOCustNumber"].ToString().TrimEnd();
                GetVendorName();
            }
            catch (Exception)
            {
                VendorName = "Vendor Name Not Found";
            }

            return MakeFor;

        }

        private void MoveFile()
        {

            try
            {
                string NewDir = Path.Combine(FullURL, "Archive");

                //creates the new directory if it does not exist
                if (!(Directory.Exists(NewDir)))
                {
                    Directory.CreateDirectory(NewDir);
                }

                string destFile = Path.Combine(NewDir, CurrentFileName);

                File.Copy(SourceFile, destFile);

                //File.Move(sourceFile, Path.Combine(NewDir, CurrentFileName)); <----- OLD WAY CHANGED ON 12-20-2016

      
                if (File.Exists(destFile))
                {
                    DeleteFile(SourceFile);
                }
                else
                {
                    DeleteFile(SourceFile);
                    MessageBox.Show("Cannot delete source file, it is still open");
                }

                //If all goes well with the operation, the message will be updated
                MSG = "The Save Operation Was Successful";

            }
            catch (Exception e)
            {
                Console.WriteLine("The process failed: {0}", e.ToString());
            }
        }

        private void DeleteFile(string sourceFile)
        {
            File.Delete(sourceFile);
        }

        private void DeletePDF()
        {

            try
            {
                //this deletes the PDF file
                File.Delete(SourceFile);
            }
            catch (Exception e)
            {
                Console.WriteLine("The process failed: {0}", e.ToString());
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //test to see if there is a number in the textbox
            if(string.Compare(txtWorkOrderToDelete.Text,string.Empty) == 1)
            {
                string thisWorkOrderNumber = txtWorkOrderToDelete.Text;
                DocScanArchiveEntities da = new DocScanArchiveEntities();
                da.DeleteBadScans(thisWorkOrderNumber);

                try
                {
                    Control[] thisControl = flpRecentlyProcessed.Controls.Find(thisWorkOrderNumber, false);
                    Button thisButton = (Button)thisControl[0];
                    flpRecentlyProcessed.Controls.Remove(thisButton);
                }
                catch (Exception)
                {
                
                  
                }
                finally {
                    txtWorkOrderToDelete.Text = string.Empty;
                }
                
            }
        }
    }
}
