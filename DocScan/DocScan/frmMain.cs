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

        public string MSG = "The Save Operation Failed";
       


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



        }

        //private void LoadDataBindings()
        //{
        //    //Changing process to not have databinding, just get info
            
        //    lblcustomerName.DataBindings.Add("Text", VendorName, VendorName.ToString());
        //    lblSODate.DataBindings.Add("Text", OrderDate, OrderDate.ToString());
        //    lblSONumber.DataBindings.Add("Text", SONumber, SONumber.ToString());
        //}

        //private void LoadSalesOrderNumbers()
        //{
        //    //changing to remove UI elements
        //    lblSONumber.Text = SONumber;
        //    lblSODate.Text = DateTime.Now.ToShortDateString();
               
        //}

        private void LoadNames()
        {

            using (ScanModelDataContext sd = new ScanModelDataContext())
            {
                comboBox1.DataSource = sd.SetupInfos.ToList();                
                comboBox1.DisplayMember = "operatorName";
                comboBox1.ValueMember = "watchFileLocation";
                lblToValue.Text = comboBox1.SelectedValue.ToString();
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
                //changing to remove UI elements
//                backgroundWorker1.RunWorkerAsync(CommonData.GetAllData());


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



        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

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
         //   LoadAllData();
        }

        private void LaunchFileWatcher()
        {
            fileSystemWatcher1.Path = lblToValue.Text.ToString(); 
            // Watch only for changes to *.pdf files.
            //we are changing this to look for the *.xml files instead as they are written after the *.pdf is done
            fileSystemWatcher1.Filter = "*" + ConfigurationManager.AppSettings["TriggerType"];
            fileSystemWatcher1.IncludeSubdirectories = false;
            // Enable the component to begin watching for changes.
            fileSystemWatcher1.EnableRaisingEvents = true;
            // Filter for Last Write changes.
            //fileSystemWatcher1.NotifyFilter = System.IO.NotifyFilters.LastWrite;            
            fileSystemWatcher1.Created += FileSystemWatcher1_Created;
           // fileSystemWatcher1.Deleted += FileSystemWatcher1_Deleted;
            groupBox1.Refresh();
        }

        //private void FileSystemWatcher1_Deleted(object sender, FileSystemEventArgs e)
        //{            
        //    groupBox1.BackColor = goodColor;
        //    WindowState = FormWindowState.Normal;    
        //}

        private void FileSystemWatcher1_Created(object sender, FileSystemEventArgs e)
        {
            string tmpFileExtenstion = ConfigurationManager.AppSettings["TriggerType"].ToString();

            string soNumber = e.Name.Remove(0, 3).Replace(tmpFileExtenstion , "");
            groupBox1.BackColor = goodColor;
            lblStatus.Text = "File Received";
            GatherInfoToSave(soNumber);
            lblSODate.Text = OrderDate.ToString();
            lblSONumber.Text = SONumber.ToString();
            lblcustomerName.Text = VendorName.ToString();
            groupBox2.Visible = true;

            //gathers file name information
            FullURL = Path.GetDirectoryName(e.FullPath);


            //this is where the name of the trigger file ".xml" or ".xst" gets renamed to the .pdf filename
            CurrentFileName = e.Name.Replace(tmpFileExtenstion, ".pdf");

            WindowState = FormWindowState.Normal;

        }


        private void MoveFile()
        {
         //System.Threading.Thread.Sleep(60000);
            try
            {
                 string NewDir = Path.Combine(FullURL,"Archive");

                //creates the new directory if it does not exist
                if (!(Directory.Exists(NewDir))){
                    Directory.CreateDirectory(NewDir);
                }
                string sourceFile = Path.Combine(FullURL, CurrentFileName);               
                File.Move(sourceFile, Path.Combine(NewDir, CurrentFileName));


                //If all goes well with the operation, the message will be updated
                MSG = "The Save Operation Was Successful";

            }
            catch (Exception e)
            {
                Console.WriteLine("The process failed: {0}", e.ToString());
            }
        }

        private void DeletePDF()
        {
              System.Threading.Thread.Sleep(1000);
            try
            {
                string sourceFile = Path.Combine(FullURL, CurrentFileName);
                //this deletes the PDF file
                File.Delete(sourceFile);              
            }
            catch (Exception e)
            {
                Console.WriteLine("The process failed: {0}", e.ToString());
            }
        }

        private void DeleteTrigger()
        {
            string tmpFileExtenstion = ConfigurationManager.AppSettings["TriggerType"].ToString();

            try
            {
                string sourceFile = Path.Combine(FullURL, CurrentFileName.Replace(".pdf",
                tmpFileExtenstion));
                //this deletes the trigger file
                File.Delete(sourceFile);
            }
            catch (Exception e)
            {
                Console.WriteLine("The process failed: {0}", e.ToString());
            }
        }

        private void GatherInfoToSave(string soNumber)
        {
            DataTable localDt = new DataTable();
            localDt = Data_Access.CommonData.GetSalesOrderData(soNumber);
            SONumber = localDt.Rows[0]["SalesOrderNo"].ToString();
            OrderDate = localDt.Rows[0]["OrderDate"].ToString();
            VendorNo = localDt.Rows[0]["CustomerNo"].ToString();
            GetVendorName();       
        }

     
         private void ResetAll()
        {
            
            groupBox2.Visible = false;
            groupBox1.BackColor = badColor;
            lblStatus.Text="File Not Received";
            this.WindowState = FormWindowState.Minimized;

        }

        private void GetVendorName()
        {
            DataTable localDt = new DataTable();
            localDt = Data_Access.CommonData.GetCustomerInfo(VendorNo);
            VendorName = localDt.Rows[0]["CustomerName"].ToString();
        }


        private void btnSave_Click_1(object sender, EventArgs e)
        {
          
            MoveDataAsync();
            using (ScanModelDataContext sdd = new ScanModelDataContext())
            {
                SalesOrdersArchive soa = new SalesOrdersArchive();
                soa.FileName = CurrentFileName;
                soa.SODate = Data_Access.CommonData.ConvertToDate(lblSODate.Text);
                soa.VendorName = lblcustomerName.Text;
                soa.SONumber = lblSONumber.Text;
                soa.ScanDate = DateTime.Now;
                //Save the record to the database
                try
                {
                    sdd.SalesOrdersArchives.InsertOnSubmit(soa);
                    sdd.SubmitChanges();
                   MSG = "Information Saved";
                }
                catch (Exception)
                {

                    MSG += "Errors exist in the database";
                }

                MessageBox.Show(MSG);
                ResetAll();

            }
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
    }
}
