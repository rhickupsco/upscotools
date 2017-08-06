using System;
using System.Linq;
using System.Windows.Forms;
using System.IO;
using System.Data;
using System.Drawing;

namespace DocScan
{
    public partial class maintenanceForm : Form
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

        public DateTime ScannedDateTime { get; set; }
        public string TriggerType { get; set; }
        public string MSG = "The Save Operation Failed";
        public string FileType { get; set; }

        public maintenanceForm()
        {
            InitializeComponent();
        }

        private void maintenanceForm_Load(object sender, EventArgs e)
        {
            LoadNames();

        }

        private void LoadNames() {
            using (DocScanArchiveEntities sd = new DocScanArchiveEntities())
            {
                comboBox1.DataSource = sd.SetupInfoes.ToList();
                comboBox1.DisplayMember = "operatorName";
                comboBox1.ValueMember = "watchFileLocation";
                lblToValue.Text = comboBox1.SelectedValue.ToString();
                FileType = "S";
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
                if(FileType != "J" && GatherInfoToSave(CurrentFileName))   
                {
                    ProcessFile();
                    MoveFile();
                    DeletePDF();
                    processedCount += UpdateUI();
                    lblQtyTransferred.Text = processedCount.ToString();
                }
               
                Refresh();

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

            string soNumber = CurrentFileName.Remove(0, 3).Replace(tmpFileExtenstion, "");
            //this is added to attempt to block out inadvertant scans or mistyped file names
            if (soNumber.Length >= 7)
            {
                if (soNumber.ToString().ToUpper().Contains("A"))
                {
                    SONumber = soNumber.Remove(soNumber.Length - 1);
                    FileType = "A";
                }
                else
                {
                    SONumber = soNumber;
                    FileType = "S";
                }
              
            }
            //mark this as junk
            else
            {
                FileType = "J";
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
                SalesOrderArchive soa = new SalesOrderArchive();
                soa.FileName = CurrentFileName;
                soa.SODate = DocScanSO.Data_Access.CommonData.ConvertToDate(OrderDate);
                soa.VendorName = VendorName;
                soa.SalesOrderNumber = SONumber;
                soa.ScanDate = ScannedDateTime.ToLocalTime();
                soa.FileType = FileType;

                //Insert a record into the FilesStorage Table and get back the Id
                DocScan.FileStorage Fist = new DocScan.FileStorage();
                Fist.Notes = "no notes available";
                Fist.File = DocScanSO.Data_Access.CommonData.ConvertFileToStream(SourceFile);

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

        private bool GatherInfoToSave(string soNumber)
        {
            bool found = false;
            DataTable localDt = new DataTable();
            localDt = DocScanSO.Data_Access.CommonData.GetSalesOrderData(SONumber);
            try
            {

                SONumber = localDt.Rows[0]["SalesOrderNo"].ToString();
                OrderDate = localDt.Rows[0]["OrderDate"].ToString();
                VendorNo = localDt.Rows[0]["CustomerNo"].ToString();
                VendorName = DocScanSO.Data_Access.CommonData.GetVendorName(VendorNo);
                found = true;
            }
            catch (Exception)
            {
                found = false;
            }

            return found;

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
