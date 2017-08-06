using System;
using System.Linq;
using System.Windows.Forms;
using System.IO;
using DocScan.Data_Access;
using System.Data;
using System.Drawing;
using System.Configuration;
using System.Threading.Tasks;
using System.ComponentModel;

namespace DocScan
{

   
    public partial class frmWOScan : Form
    {

        public string CurrentFileName { get; set; }
        public string WONumber { get; set; }
        public string OrderDate { get; set; }
        public string VendorName { get; set; }
        public string VendorNo { get; set; }

        public string ItemNo { get; set; }

        public string ParentSONumber { get; set; }

        public double LaborHours { get; set; }


        public static readonly Color goodColor = Color.LightGreen;
        public static readonly Color badColor = SystemColors.Control;
        public string WebSearchURL { get; set; }
       


        public static Splash f = new Splash();

    
        public frmWOScan()
        {
            
            f.Show();
            f.Refresh();
            InitializeComponent();
            f.Refresh();
            System.Threading.Thread.Sleep(3000);
            backgroundWorker1.WorkerReportsProgress = false;
            backgroundWorker1.WorkerSupportsCancellation = false;
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

        private void LoadAllData() {

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
            //Task.Factory.StartNew(() => { CommonData.GetAllData(); 
            //if(CommonData.AllData.Tables[0].Rows.Count>0) {
            //        comboBox1.Refresh();
            //        LoadSalesOrderNumbers();
            //        cbSoNumbers.Refresh();
            //        LoadDataBindings();
            //    }

            //});
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
                //changing to remove UI elements
              //  comboBox1.Refresh();
               // LoadSalesOrderNumbers();
              //  cbSoNumbers.Refresh();
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
            fileSystemWatcher1.Filter = "*.pdf";
            fileSystemWatcher1.IncludeSubdirectories = false;
            // Enable the component to begin watching for changes.
            fileSystemWatcher1.EnableRaisingEvents = true;
            // Filter for Last Write changes.
            //fileSystemWatcher1.NotifyFilter = System.IO.NotifyFilters.LastWrite;            
            fileSystemWatcher1.Created += FileSystemWatcher1_Created;
            fileSystemWatcher1.Deleted += FileSystemWatcher1_Deleted;
            groupBox1.Refresh();
        }

        private void FileSystemWatcher1_Deleted(object sender, FileSystemEventArgs e)
        {            
            groupBox1.BackColor = goodColor;
            WindowState = FormWindowState.Normal;    
        }

        private void FileSystemWatcher1_Created(object sender, FileSystemEventArgs e)
        {
          MoveFile(Path.GetDirectoryName(e.FullPath),e.Name);
            string soNumber = e.Name.Remove(0, 3).Replace(".pdf", "");
            groupBox1.BackColor = goodColor;
            lblStatus.Text = "File Received";
            GatherInfoToSave(soNumber);
            lblSODate.Text = OrderDate.ToString();
            lblSONumber.Text = WONumber.ToString();
            lblcustomerName.Text = VendorName.ToString();
            groupBox2.Visible = true;
            //changing to remove UI elements                
            
        }


        private void MoveFile(string path, string fileName)
        {

            try
            {
                CurrentFileName = fileName;

                System.Threading.Thread.Sleep(2000);
                string NewDir = Path.Combine(path,"Archive");

                //creates the new directory if it does not exist
                if (!(Directory.Exists(NewDir))){
                    Directory.CreateDirectory(NewDir);
                }
                string sourceFile = Path.Combine(path, fileName);               
                File.Move(sourceFile, Path.Combine(NewDir, fileName));
            }
            catch (Exception e)
            {
                Console.WriteLine("The process failed: {0}", e.ToString());
            }
        }

        private void GatherInfoToSave(string soNumber)
        {
            DataTable localDt = new DataTable();
            localDt = CommonData.GetSalesOrderData(soNumber);
            WONumber = localDt.Rows[0]["WorkOrderNo"].ToString();
            OrderDate = localDt.Rows[0]["OrderDate"].ToString();
            VendorNo = localDt.Rows[0]["CustomerNo"].ToString();
            GetVendorName();       
        }

     
         private void ResetAll()
        {
           groupBox2.Visible = false;
            groupBox1.BackColor = badColor;
            lblStatus.Text="File Not Received";
            System.Threading.Thread.Sleep(3000);
            this.WindowState = FormWindowState.Minimized;

        }

        private void GetVendorName()
        {
            DataTable localDt = new DataTable();
            localDt = CommonData.GetCustomerInfo(VendorNo);
            VendorName = localDt.Rows[0]["CustomerName"].ToString();
        }


        private void btnSave_Click_1(object sender, EventArgs e)
        {
            string msg = "Information was not saved";
            using (ScanModelDataContext sdd = new ScanModelDataContext())
            {
                SalesOrdersArchive soa = new SalesOrdersArchive();
                soa.FileName = CurrentFileName;
                soa.SODate = CommonData.ConvertToDate(lblSODate.Text);
                soa.VendorName = lblcustomerName.Text;
                soa.SONumber = lblSONumber.Text;
                soa.ScanDate = DateTime.Now;
                //Save the record to the database
                try
                {
                    sdd.SalesOrdersArchives.InsertOnSubmit(soa);
                    sdd.SubmitChanges();
                    msg = "Information Saved";
                }
                catch (Exception)
                {

                    msg += "Errors exist in the database";
                }

                MessageBox.Show(msg);
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
    }
}
