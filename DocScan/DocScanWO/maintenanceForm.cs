using System;
using System.Linq;
using System.Windows.Forms;
using System.IO;
using System.Data;
using System.Drawing;
using System.Configuration;
using System.Threading.Tasks;
using System.ComponentModel;
using DocScanWO;

namespace DocScan
{
    public partial class maintenanceForm : Form
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

        public maintenanceForm()
        {
            InitializeComponent();
        }

        private void maintenanceForm_Load(object sender, EventArgs e)
        {
            LoadNames();
        }

        private void LoadNames() {
            using (DocScanArchiveEntities sd = new DocScanArchiveEntities ())
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
            string soNumber = string.Empty;
            int totalCount = 0;
            int processedCount = 0;
            TriggerType = ".pdf";

            string[] files = Directory.GetFiles(lblToValue.Text,"*" + TriggerType);

            foreach(string file in files) {
                ScannedDateTime = File.GetCreationTime(file);
                totalCount += CountFile(file);
                
                lblFileFoundCount.Text = totalCount.ToString();

                this.Refresh();
                ParseFileName();    
                if(GatherInfoToSave(CurrentFileName))   
                {
                    ProcessFile();
                    MoveFile();
                    DeletePDF();
                    processedCount += UpdateUI();
                    lblQtyTransferred.Text = processedCount.ToString();
                    Refresh();
                    
                }       
             
            }
          
        }

        private int CountFile(string fileName) {
            int success = 1;
            
            CurrentFileName = fileName.Substring(fileName.LastIndexOf('\\') + 1);
            
            FullURL = Path.GetFullPath(fileName.Replace(CurrentFileName,""));

            return success;
        }

        private int UpdateUI()
        {
            int success = 1;           

            return success;
        }
        private void ParseFileName() {
            string tmpFileExtenstion = TriggerType;

            string woNumber = CurrentFileName.Remove(0, 3).Replace(tmpFileExtenstion, "");

            if (woNumber.ToString().ToUpper().Contains("A"))
            {
                SONumber = woNumber.Remove(woNumber.Length - 1);
                FileType = "A";
            }
            else
            {
                SONumber = woNumber;
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
                woa.SalesOrderNumber = SONumber;
                woa.ScanDate = DateTime.Now.ToLocalTime();
                woa.FileType = FileType;
                woa.ItemDescription = ItemDesc;
                woa.ItemNumber = ItemName;
                woa.LaborHoursActual = DocScanWO.Data_Access.CommonData.ConvertToNumber(ActLabor);
                woa.LaborHoursStandard = DocScanWO.Data_Access.CommonData.ConvertToNumber(StdLabor);

                ////----TODO: Check to see if this is a SalesOrder or WorkOrder that is being referred to ------  If SALES ORDER then Set PARENT WO to WONUMBER else set to MAKEFOR

                woa.ParentWorkOrderNumber = ParentWO;
                woa.SalesOrderNumber = MakeFor;
                woa.FileType = FileType;
                ////jic it is updated after one of the functions
                woa.VendorName = VendorName;


                //Insert a record into the FilesStorage Table and get back the Id
                FileStorage Fist = new FileStorage();
                Fist.Notes = "no notes available";
                Fist.File = DocScanWO.Data_Access.CommonData.ConvertFileToStream(SourceFile);

                try
                {
                    sdd.FileStorages.Add(Fist);
                    sdd.SaveChanges();
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
                    catch (Exception)
                    {

                        MSG += "Errors exist in the database";
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

        private bool GatherInfoToSave(string woNumber)
        {
            bool found = false;
            DataTable localDt = new DataTable();
            localDt = DocScanWO.Data_Access.CommonData.GetWorkOrderData(woNumber);
            try
            {
                WONumber = localDt.Rows[0]["WorkOrder"].ToString();
                OrderDate = localDt.Rows[0]["WODueDate"].ToString();
                VendorNo = localDt.Rows[0]["SOCustNumber"].ToString().TrimEnd();
                StdLabor = localDt.Rows[0]["StdLaborCost"].ToString();
                ActLabor = localDt.Rows[0]["ActualLaborCost"].ToString();
                MakeFor = localDt.Rows[0]["MakeForOrderNumber"].ToString().TrimEnd();
                ItemName = localDt.Rows[0]["ItemBillNumber"].ToString().TrimEnd();
                ItemDesc = localDt.Rows[0]["ItemBillDescription"].ToString().TrimEnd();



                //determine if this is child or parent WorkOrder
                if (VendorNo.ToString() == null || VendorNo.Length < 2)
                {
                    ParentWO = localDt.Rows[0]["MakeForOrderNumber"].ToString().TrimEnd();
                    //recursively call the makeFor value until a parent Vendor Name is found
                    var tmpStr = "Vendor Name Not Found";

                    while (VendorName == "Vendor Name Not Found" || VendorName == null)
                    {
                        tmpStr = FindParentSO(MakeFor);
                    }
                }
                else { GetVendorName(); }

                found = true;
            }
            catch (Exception)
            {

                found = false;
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
                MakeFor = dtNorthWO.Rows[0]["MakeForOrderNumber"].ToString().TrimEnd();
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

                //Allow the system to move the file
                System.Threading.Thread.Sleep(2000);

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
            System.Threading.Thread.Sleep(500);
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
    }
}
