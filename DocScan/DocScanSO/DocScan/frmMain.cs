using System;
using System.Linq;
using System.Windows.Forms;
using System.IO;
using System.Data;
using System.Drawing;
using System.Configuration;
using System.Threading.Tasks;
using System.ComponentModel;

namespace DocScanSO
{

   
    public partial class frmMain : Form
    {

        public string CurrentFileName { get; set; }
        public string SONumber { get; set; }
        public string OrderDate { get; set; }
        public string VendorName { get; set; }
        public string VendorNo { get; set; }

        public static readonly Color goodColor = Color.LightGreen;
        public static readonly Color badColor = SystemColors.Control;
        public string WebSearchURL { get; set; }
        public string FullURL { get; set; }
        public string SourceFile { get; set; }
        public string TriggerType { get; set; }
        public string MSG = "The Save Operation Failed";
        public string FileType { get; set; }
       


        public static Splash f = new Splash();

    
        public frmMain()
        {
            
            f.Show();
            f.Refresh();
            InitializeComponent();
            f.Refresh();
            System.Threading.Thread.Sleep(3000);
            backgroundWorker1.WorkerReportsProgress = true;
            backgroundWorker1.WorkerSupportsCancellation = false;

            //TODO: Check to see if file path exists, it cannot monitor the path if the path is not visible to the client
            f.Refresh();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            
            LoadNames();
            f.Refresh();
            WebSearchURL = ConfigurationManager.AppSettings["SearchURL"];          
            f.Refresh();
            f.Hide();
            Refresh();
            /////this hides the maintenance mode button in Release Mode and shows in Debug mode
            if (System.Diagnostics.Debugger.IsAttached) { this.linkLabel2.Visible = true; }

            Refresh();




        }



        private void LoadNames()
        {

            using (DocScan.DocScanArchiveEntities sd = new DocScan.DocScanArchiveEntities())
            {
                comboBox1.DataSource = sd.SetupInfoes.ToList();                
                comboBox1.DisplayMember = "operatorName";
                comboBox1.ValueMember = "watchFileLocation";
                lblToValue.Text = comboBox1.SelectedValue.ToString();
                FileType = "S";
            }


        }

        private void MoveDataAsync() {

        if(backgroundWorker1.IsBusy != true)
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
                MessageBox.Show("Error: " + e.Error.Message);
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
            System.Threading.Thread.Sleep(5000);
            WindowState = FormWindowState.Minimized;
            button1.Enabled = false;
            button1.Refresh();

        }

        private void LaunchFileWatcher()
        {
            fileSystemWatcher1.Path = lblToValue.Text.ToString(); 

            // Watch only for changes to *.pdf files.
            //we are changing this to look for the *.xml or *.xst files instead as they are written after the *.pdf is done
            if(comboBox1.Text.ToString().ToUpper() == "RANDI") {
                TriggerType = ConfigurationManager.AppSettings["TriggerTypeXST"];
                fileSystemWatcher1.Filter = "*" + TriggerType;                
            }
            else {
                TriggerType = ConfigurationManager.AppSettings["TriggerTypeXML"];
                fileSystemWatcher1.Filter = "*" + TriggerType;
            }
        
            fileSystemWatcher1.IncludeSubdirectories = false;
            fileSystemWatcher1.InternalBufferSize = 32768;
            // Enable the component to begin watching for changes.
            fileSystemWatcher1.EnableRaisingEvents = true;
            // Filter for Last Write changes.
            //fileSystemWatcher1.NotifyFilter = System.IO.NotifyFilters.LastWrite;            
            fileSystemWatcher1.Created += FileSystemWatcher1_Created;
            // fileSystemWatcher1.Deleted += FileSystemWatcher1_Deleted;
            label5.Text = TriggerType;
            groupBox1.Refresh();
        }
        
        private void FileSystemWatcher1_Created(object sender, FileSystemEventArgs e)
        {
            string tmpFileExtenstion = TriggerType;

            string soNumber = e.Name.Remove(0, 3).Replace(tmpFileExtenstion , "");
            if(soNumber.ToString().ToUpper().Contains("A"))
            {
                soNumber = soNumber.Remove(soNumber.Length - 1);
                FileType = "A";
            }
            else {
                FileType = "S";
            }
            groupBox1.BackColor = goodColor;
            lblStatus.Text = "File Received";
            if (GatherInfoToSave(soNumber))
            {

                AssignUIValues();
                groupBox2.Visible = true;

                //gathers file name information
                FullURL = Path.GetDirectoryName(e.FullPath);


                //this is where the name of the trigger file ".xml" or ".xst" gets renamed to the .pdf filename
                CurrentFileName = e.Name.Replace(tmpFileExtenstion, ".pdf");
                label5.Text = GetFileTypeName();
                WindowState = FormWindowState.Normal;
            }
            else{
                WindowState = FormWindowState.Normal;
                MessageBox.Show("Please check to ensure " + soNumber + " is a valid Sales Order Number - " + "Please Scan Your Packet Again");
                //Delete the trigger File
                File.Delete(Path.Combine(Path.GetDirectoryName(e.FullPath), e.Name));
                //Delete the pdf File
                File.Delete(Path.Combine(Path.GetDirectoryName(e.FullPath), e.Name.Replace(tmpFileExtenstion, ".pdf")));
                ResetAll();
            }

        }

        private void AssignUIValues()
        {
            lblSODate.Text = OrderDate.ToString();
            lblSONumber.Text = SONumber.ToString();
            lblcustomerName.Text = VendorName.ToString();
        }

        private string GetFileTypeName()
        {
            if (FileType == "A")
                return "Attachment";
            else if (FileType == "S")
                return "SalesOrder";
            else
                return TriggerType;
        }


        private void MoveFile()
        {
      
            try
            {
                 string NewDir = Path.Combine(FullURL,"Archive");

                //creates the new directory if it does not exist
                if (!(Directory.Exists(NewDir)))
                {
                    Directory.CreateDirectory(NewDir);
                }
                
                string destFile = Path.Combine(NewDir, CurrentFileName);

                File.Copy(SourceFile, destFile);

                //File.Move(sourceFile, Path.Combine(NewDir, CurrentFileName)); <----- OLD WAY CHANGED ON 12-20-2016

                //Allow the system to move the file
                System.Threading.Thread.Sleep(6000);

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
              System.Threading.Thread.Sleep(5000);
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
                Console.WriteLine("The process failed: {0}", e.ToString());
            }
        }

        private bool GatherInfoToSave(string soNumber)
        {
            bool found = false;
            DataTable localDt = new DataTable();
            localDt = Data_Access.CommonData.GetSalesOrderData(soNumber);
            try
            {

                SONumber = localDt.Rows[0]["SalesOrderNo"].ToString();
                OrderDate = localDt.Rows[0]["OrderDate"].ToString();
                VendorNo = localDt.Rows[0]["CustomerNo"].ToString();
                GetVendorName();
                found = true;
            }
            catch (Exception)
            {
                found = false;               
            }

            return found;

        }

     
         private void ResetAll()
        {
           try {
                DeleteFile(SourceFile);
            }
           catch {
                System.Threading.Thread.Sleep(2000);
                try
                {
                    DeleteFile(SourceFile);
                }
                catch {
                    
                }
            }
            groupBox2.Visible = false;
            groupBox1.BackColor = badColor;
            lblStatus.Text="File Not Received";
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

            using (DocScan.DocScanArchiveEntities sdd = new DocScan.DocScanArchiveEntities())
            {
                DocScan.SalesOrderArchive soa = new DocScan.SalesOrderArchive();
                soa.FileName = CurrentFileName;
                soa.SODate = Data_Access.CommonData.ConvertToDate(lblSODate.Text);
                soa.VendorName = lblcustomerName.Text;
                soa.SalesOrderNumber = lblSONumber.Text;
                soa.ScanDate = DateTime.Now.ToLocalTime();
                soa.FileType = FileType;

                //Insert a record into the FilesStorage Table and get back the Id
                DocScan.FileStorage Fist = new DocScan.FileStorage();
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
                        soa.FileID = intNextId;
                        sdd.SalesOrderArchives.Add(soa);
                        sdd.SaveChanges();
                        MSG = "Information Saved";
                    }
                    catch (Exception)
                    {

                        MSG += "Errors exist in the database";
                    }
                }

                ResetAll();
               

            }
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
           
           //DELETE FILE AT THIS POINT, THEY WILL RECREATE NEW FILE
            DeletePDF();
            DeleteTrigger(); 
            ResetAll();
        }

        private void lblToValue_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DocScan.maintenanceForm mf = new DocScan.maintenanceForm();          
            mf.Show();
            DocScanSO.frmMain fm = this;
            fm.WindowState = FormWindowState.Minimized;


        }
    }
}
