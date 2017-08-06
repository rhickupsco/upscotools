using System;
using System.Linq;
using System.Windows.Forms;
using System.IO;
using System.Data;
using System.Drawing;
using System.Configuration;
using System.Threading.Tasks;
using System.ComponentModel;

namespace DocScanWO
{
    public partial class frmMain : Form
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



        public static Splash f = new Splash();


        public frmMain()
        {

           f.Show();
           f.Refresh();
           // InitializeComponent();
           f.Refresh();
            System.Threading.Thread.Sleep(2000);
           // backgroundWorker1.WorkerReportsProgress = true;
           // backgroundWorker1.WorkerSupportsCancellation = false;
            f.Refresh();

            this.Close();


        }

        private void frmMain_Load(object sender, EventArgs e)
        {

            LoadNames();
            f.Refresh();
            WebSearchURL = ConfigurationManager.AppSettings["WebSearchURL"];
            f.Refresh();
            f.Hide();

            /////this hides the maintenance mode button in Release Mode and shows in Debug mode
            if (System.Diagnostics.Debugger.IsAttached) { this.linkLabel2.Visible = true; }

            Refresh();

        }

        private void Abort(string location)
        {
            MessageBox.Show("Someting went wrong in :" + location.ToString() + " please stop using and contact IT @ X142" );
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

        private void MoveDataAsync()
        {

            if (backgroundWorker1.IsBusy != true)
            {
                backgroundWorker1.DoWork +=
                   new DoWorkEventHandler(backgroundWorker1_DoWork);
                backgroundWorker1.RunWorkerCompleted +=
                    new RunWorkerCompletedEventHandler(
                backgroundWorker1_RunWorkerCompleted);
         
            }
            Task.Factory.StartNew(() =>
            {
                MoveFile();
                DeleteTrigger();
            });
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;

        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Error != null)
            {
                Abort(e.Error.ToString());
            }
            else
            {


            }
        }

  
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //changing to remove UI elements

            lblToValue.Text = comboBox1.SelectedValue.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.BackColor = goodColor;
            button1.Text = "Monitoring For Scanned Files";

            LaunchFileWatcher();
            button1.Refresh();
            System.Threading.Thread.Sleep(2000);
            WindowState = FormWindowState.Minimized;
            button1.Enabled = false;
            button1.Refresh();

        }

        private void LaunchFileWatcher()
        {
            fileSystemWatcher1.Path = lblToValue.Text.ToString();
            // Watch only for changes to *.pdf files.
            //we are changing this to look for the *.xml or *.xst files instead as they are written after the *.pdf is done
            if (comboBox1.Text.ToString().ToUpper() == "RANDI")
            {
                TriggerType = ConfigurationManager.AppSettings["TriggerTypeXST"];
                fileSystemWatcher1.Filter = "*" + TriggerType;
            }
            else
            {
                TriggerType = ConfigurationManager.AppSettings["TriggerTypeXML"];
                fileSystemWatcher1.Filter = "*" + TriggerType;
            }

            fileSystemWatcher1.IncludeSubdirectories = false;
            fileSystemWatcher1.InternalBufferSize = 32768;
            // Enable the component to begin watching for changes.
            fileSystemWatcher1.EnableRaisingEvents = true;
            // Filter for Last Write changes.
            fileSystemWatcher1.InternalBufferSize = 32768;
            //fileSystemWatcher1.NotifyFilter = System.IO.NotifyFilters.LastWrite;            
            fileSystemWatcher1.Created += FileSystemWatcher1_Created;
            // fileSystemWatcher1.Deleted += FileSystemWatcher1_Deleted;
            label5.Text = TriggerType;
            groupBox1.Refresh();
        }

        private void FileSystemWatcher1_Created(object sender, FileSystemEventArgs e)
        {
            string tmpFileExtenstion = TriggerType;

            string soNumber = e.Name.Remove(0, 3).Replace(tmpFileExtenstion, "");
            if (soNumber.ToString().ToUpper().Contains("A"))
            {
                soNumber = soNumber.Remove(soNumber.Length - 1);
                FileType = "A";

            }
            else
            {
                FileType = "W";
            }
            groupBox1.BackColor = goodColor;
            lblStatus.Text = "File Received";
            if (GatherInfoToSave(soNumber))
            {
                AssignUIValues();
                groupBox2.Visible = true;
                //changing to remove UI elements          

                //gathers file name information
                FullURL = Path.GetDirectoryName(e.FullPath);

                //this is where the name of the trigger file ".xml" or ".xst" gets renamed to the .pdf filename
                CurrentFileName = e.Name.Replace(tmpFileExtenstion, ".pdf");
                label5.Text = GetFileTypeName();
                WindowState = FormWindowState.Normal;
            }
            else {
                WindowState = FormWindowState.Normal;
                MessageBox.Show("Please check to ensure " + soNumber + " is a valid Work Order Number - " + "Please Scan Your Packet Again");
                //Delete the trigger File
                File.Delete(Path.Combine(Path.GetDirectoryName(e.FullPath), e.Name));
                //Delete the pdf File
                File.Delete(Path.Combine(Path.GetDirectoryName(e.FullPath), e.Name.Replace(tmpFileExtenstion, ".pdf")));
                ResetAll();
            }

        }

        private string GetFileTypeName()
        {
            if (FileType == "A")
                return "Attachment";
            else if (FileType == "W")
                return "WorkOrder";
            else
                return TriggerType;
        }

        private void AssignUIValues()
        {
            lblWOShipDate.Text = OrderDate.ToString();
            lblWONumber.Text = WONumber.ToString();
            lblcustomerName.Text = VendorName.ToString();
            lblNumDescValue.Text = ItemName + " : " + ItemDesc;
            lblStdValue.Text = StdLabor.ToString();
            lblActualValue.Text = ActLabor;
            lblMakeForValue.Text = MakeFor;
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
             //   string sourceFile = Path.Combine(FullURL, CurrentFileName);
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
                Abort(e.InnerException.InnerException.InnerException.ToString());
            }
        }

        private void DeleteFile(string sourceFile) {
            File.Delete(sourceFile);
        }

        private void DeletePDF()
        {
            System.Threading.Thread.Sleep(2000);
            try
            {               
                //this deletes the PDF file
                File.Delete(SourceFile);
            }
            catch (Exception e)
            {
                Abort("In DeletePDF " + e.ToString());
            }
        }

        private void DeleteTrigger()
        {
            string tmpFileExtenstion = TriggerType;

            try
            {
                string triggerFile = Path.Combine(FullURL, CurrentFileName.Replace(".pdf",
                tmpFileExtenstion));
                //this deletes the trigger file
                File.Delete(triggerFile);
            }
            catch (Exception e)
            {
               Abort("In DeleteTrigger " + e.ToString());
            }
        }

        private bool GatherInfoToSave(string woNumber)
        {

            bool found = false;
            DataTable localDt = new DataTable();
            localDt = Data_Access.CommonData.GetWorkOrderData(woNumber);

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
                    var tmpStr = "0000000";

                    while (VendorName == "Vendor Name Not Found" || VendorName == null) {
                        tmpStr = FindParentSO(MakeFor);
                    }
                    //once found, the Sales Order number of the child WO is set to the SalesOrder number of the Parent WO
                    MakeFor = tmpStr;
                }
                else {
                    ParentWO = WONumber;
                    GetVendorName(); 
                }

                found = true;
            }
            catch (Exception e)
            {

                found = false;
                Abort("In GatherInforToSave " + e.InnerException.ToString());
            }

            return found;
          
        }


        private void ResetAll()
        {
            try
            {
                DeleteFile(SourceFile);
            }
            catch
            {
                System.Threading.Thread.Sleep(2000);
                try
                {
                    DeleteFile(SourceFile);
                }
                catch
                {

                }
            }
            groupBox2.Visible = false;
            groupBox1.BackColor = badColor;
            lblStatus.Text = "File Not Received";
            label5.Text = TriggerType;
            WindowState = FormWindowState.Minimized;

        }

        private void GetVendorName()
        {
            DataTable localDt = new DataTable();
            localDt = Data_Access.CommonData.GetCustomerInfo(VendorNo);
            VendorName = localDt.Rows[0]["CustomerName"].ToString();

        }


        private void btnSave_Click_1(object sender, EventArgs e)
        {
            SourceFile = Path.Combine(FullURL, CurrentFileName);

            bool boolFileSaved = false;
            int intNextId = 0;
                   
            using (DocScanArchiveEntities sdd = new DocScanArchiveEntities())
            {
                WorkOrderArchive soa = new WorkOrderArchive();
                soa.FileName = CurrentFileName;
                soa.WorkOrderNumber = WONumber;
                soa.WODate = Data_Access.CommonData.ConvertToDate(lblWOShipDate.Text);
                soa.VendorName = lblcustomerName.Text;
                soa.ScanDate = DateTime.Now.ToLocalTime();
                soa.ItemDescription = ItemDesc;
                soa.ItemNumber = ItemName;
                soa.LaborHoursActual = Data_Access.CommonData.ConvertToNumber(ActLabor);
                soa.LaborHoursStandard = Data_Access.CommonData.ConvertToNumber(StdLabor);
                ////----TODO: Check to see if this is a SalesOrder or WorkOrder that is being referred to ------  If SALES ORDER then Set PARENT WO to WONUMBER else set to MAKEFOR

                soa.ParentWorkOrderNumber = ParentWO;
                soa.SalesOrderNumber = MakeFor;
                soa.FileType = FileType;
                ////jic it is updated after one of the functions
                soa.VendorName = VendorName;
             

                //Insert a record into the FilesStorage Table and get back the Id
                FileStorage Fist = new FileStorage();
                Fist.Notes = "no notes available";
                Fist.File = ConvertFileToStream(SourceFile);

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
                    MoveDataAsync();

                    //Save the record to the database
                    try
                    {
                        soa.FileId = intNextId;
                        sdd.WorkOrderArchives.Add(soa);
                        sdd.SaveChanges();
                        MSG = "Information Saved";
                    }
                    catch (Exception)
                    {

                        MSG += "Errors exist in the database";
                    }
                }

                if (MSG.ToString().Contains("Errors"))
                {
                    Abort("In Save " + MSG.ToString());
                }

                ResetAll();

                ////Save the record to the database
                //try
                //{
                //    sdd.WorkOrdersArchives.InsertOnSubmit(soa);
                //    sdd.SubmitChanges();
                //    MSG = "Information Saved";
                //}
                //catch (Exception)
                //{

                //    MSG += "Errors exist in the database";
                //}

            
                //ResetAll();
            }
        }

        //private string GetWOParent(string MakeFor, string VendorName, string WONumber) {
        //    if (VendorName == null || VendorName == "Vendor Name Not Found")
        //    {
        //        return MakeFor;
        //    }
        //    else
        //        return WONumber;
        //}

        private string GetSOParent(string MakeFor, string VendorName, string WONumber) {
            if (VendorName == null || VendorName == "Vendor Name Not Found")
            {
                
                return FindParentSO(MakeFor);                
            }
            else
                return MakeFor;
        }

        private string FindParentSO (string makeFor){
            DataTable dtNorthWO = new DataTable();
           dtNorthWO = Data_Access.CommonData.GetWorkOrderData(makeFor);
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


    public static byte[] ConvertFileToStream(string filePath)
        {
            FileStream stream = new FileStream(
                filePath, FileMode.Open, FileAccess.Read);
            BinaryReader reader = new BinaryReader(stream);

            byte[] dbFile = reader.ReadBytes((int)stream.Length);

            reader.Close();
            stream.Close();

            return dbFile;
        }
        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(WebSearchURL);
        }

        public class StubPropertyType
        {
            public StubPropertyType(Type type)
            {
                this.StubPropertyTypeName = type.Name;
            }

            public string StubPropertyTypeName = string.Empty;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //TODO - DELETE FILE AT THIS POINT, THEY WILL RECREATE NEW FILE
            DeletePDF();
            DeleteTrigger();
            ResetAll();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DocScanWO.frmAutoScanHelper maintForm = new frmAutoScanHelper();
            maintForm.Show();
        }
    }
}
