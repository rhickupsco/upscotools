using System;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using System.Data;
using Data_Access;
using NiceLabel.SDK;
using System.Collections;
using System.Drawing;

namespace LabelPrinter
{
    public partial class MasterUserForm : Form
    {

        public ILabel LabelTemplate;
        public int QtyOverride { get; set; }

        public Font loadingFont = new Font("HelveticaNeue-Bold", 14, FontStyle.Bold);
        public Color loadingColor = Color.Red;
        public Font regularFont = new Font("HelveticaNeue-Bold", 12, FontStyle.Regular);
        public Color regularColor = Color.Black;
        public Color loadingBackColor = Color.Yellow;
        public Color standardBackColor = Color.Transparent;
        public bool RefreshAble { get { return cbPreview.Checked; } }
        public Labels SelectedLabel { get; set; }


        public MasterUserForm()
        {
            
            this.InitializeComponent();
            this.Font = regularFont;
            this.InitializePrintEngine();
            this.LoadTemplateList();
        }

        private void LoadTemplateList()
        {

            DirectoryInfo dInfo = new DirectoryInfo(Properties.Settings.Default.labelsPath);
            try
            {
                FileInfo[] Files = dInfo.GetFiles("*.nlbl");
               

                foreach (FileInfo file in Files)
                {
                    ComboItem templateFile = new ComboItem();
                    templateFile.Text = file.Name.ToString();
                    templateFile.Value = file.FullName.ToString();

                    cbTemplates.Items.Add(templateFile);
                }
                cbTemplates.Items.Insert(0, "Select A Template");

            }
            catch (Exception)
            {
                cbTemplates.Items.Insert(0, "No Label Templates Found");
            }

            cbTemplates.SelectedIndex = 0;




        }
        
        private void btnPrint_Click(object sender, EventArgs e)
        {
           // VerifyDescriptionsMatch();

            if (IsValid(lblChosenTemplate, txtWONumber.Text)){           

                int quantity = int.Parse(txtPrintQuantity.Text);

                DialogResult res = MessageBox.Show("Is this ok to print " + quantity.ToString() + " labels?", "Proceed to Print", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (res == DialogResult.Yes){
                    // Printing the specified number of labels
                    LoadPreview("Gathering Info / Printing " + quantity.ToString() + " Labels");
                    try
                    {
                        LabelTemplate.Print(Convert.ToInt16(quantity));
                        LabelTemplate.Dispose();
                    }
                    catch (Exception)
                    {
                        LoadPreview("You cancelled the print job");
                        MessageBox.Show("You cancelled the print job");

                    }
                   
                }              
            }
        }

        private void VerifyDescriptionsMatch(Labels selectedLabel)
        {
           
        }

        private void LoadPreview(string status)
        {
                 
            string woNumber = txtWONumber.Text.ToString().Trim();
            LoadingPreviewSwitch(status);
            string query = SelectedLabel.GetQuery().Trim();

            if (query != "static")
            {
                DataTable dt = new DataTable();

                dt = LoadLabelsInfo(query, woNumber);
              
            }
            

            // Set up LabelPreviewSettings to be passed to the GetLabelPreview method.
            ILabelPreviewSettings labelPreviewSettings = new LabelPreviewSettings();

            //TODO:  need to make ints for size 1 and size 2

            int height = 0;
            int width = 0;
            string labelType = SelectedLabel.GetLabelType().TrimEnd();

            if (labelType == "box") {
                width = 400;
                height = 450;
            }
            else if (labelType == "fabrication") {
                width = 600;
                height = 300;
            }
            else if (labelType == "location" || labelType == "pressure") {
                width = 600;
                height = 200;
            }

            else
            {
                width = 400;
                height = 450;
            }

            labelPreviewSettings.Width = width;                   // Width of image to generate
            labelPreviewSettings.Height = height;
            pictureBoxPreview.Height = height;
            pictureBoxPreview.Width = width;
            //labelPreviewSettings.PreviewToFile = this.checkBoxPreviewToFile.Checked;     // if true, result will be the file name, if false, result will be a byte array.
            labelPreviewSettings.ImageFormat = "PNG";                                    // file format of graphics.  Valid formats: JPG, PNG, BMP.
                     // Height of image to generate
          //  labelPreviewSettings.Destination = this.textBoxFileName.Text;                // If PrintToFile is true, this is the name of the file that will be generated.
            labelPreviewSettings.FormatPreviewSide = FormatPreviewSide.FrontSide;              // Which label side(s) to generate the image for.  

            // Generate Preview File
            object imageObj = LabelTemplate.GetLabelPreview(labelPreviewSettings);
            pictureBoxPreview.Visible = true;
            // Display image in UI
            if (imageObj is byte[])
            {
                // When PrintToFiles = false
                // Convert byte[] to Bitmap and set as image source for PictureBox control
                this.pictureBoxPreview.Image = this.ByteToImage((byte[])imageObj);
            }
            else if (imageObj is string)
            {
                // When PrintToFiles = true
                this.pictureBoxPreview.ImageLocation = (string)imageObj;
            }
            DoneLoadingPreviewSwitch();

        }

        private DataTable LoadLabelsInfo(string query, string woNumber)
        {

            
            DataTable dt = CommonData.GetDataFromQuery(query, woNumber);  
            //THIS POPULATES ALL THE NAMED VARIABLES FROM THE LABELS DATABASE
                //LABEL VARIABLES SHOULD MATCH DATABASE VARIABLES FOR THIS TO WORK
                if (dt.Rows.Count >= 1)
                {
                    int totalVarCount = SelectedLabel.variableCount;
                    int count = 0;

                    while (count < totalVarCount)
                    {
                        LabelTemplate.Variables[SelectedLabel.GetVariableValue(count)].
                        SetValue(dt.Rows[0][SelectedLabel.GetVariableValue(count).ToString()].ToString());
                        count += 1;
                    }
                }

            return dt;
         
        }

        private bool IsValid(Label lblChosenTemplate, string woNumber)
        {
        
            if(lblChosenTemplate.Text.ToString().Contains(".nlbl")) {
                if (woNumber.Length == 7) {
                    return true;
                }
                else {
                    return false;
                }
           
            }
            else {
                LoadingPreviewSwitch("Please select a valid Label Template from the list");
                return false;
            }
        }

               

        /// <summary>
        /// Helper method to convert Bytes to image.
        /// </summary>
        /// <param name="bytes">The image as a byte array.</param>
        /// <returns>Bitmap of the image.</returns>
        private Bitmap ByteToImage(byte[] bytes)
        {
            MemoryStream memoryStream = new MemoryStream();
            memoryStream.Write(bytes, 0, Convert.ToInt32(bytes.Length));
            Bitmap bm = new Bitmap(memoryStream, false);
            memoryStream.Dispose();
            return bm;
        }

        private void InitializePrintEngine()
        {
            try
            {
                string sdkFilesPath = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "..\\..\\..\\SDKFiles");
                if (Directory.Exists(sdkFilesPath))
                {
                    PrintEngineFactory.SDKFilesPath = sdkFilesPath;
                }

                PrintEngineFactory.PrintEngine.Initialize();
            }
            catch (SDKException exception)
            {
                MessageBox.Show("Initialization of the SDK failed." + Environment.NewLine + Environment.NewLine + exception.ToString());
                Application.Exit();
            }
        }


        private void numAdjust_ValueChanged(object sender, EventArgs e)
        {
            QtyOverride = Convert.ToInt32(numAdjust.Value);
            MessageBox.Show(QtyOverride.ToString());   
        }

        private void txtWONumber_TextChanged(object sender, EventArgs e)
        {
            if(txtWONumber.Text.Length == 7) {
                panel1.Visible = true;
            }
            else {
                ResetPanels();
            }
        }

        private void ResetPanels()
        {
            panel1.Visible = false;
            cbTemplates.SelectedIndex = 0;
            pictureBoxPreview.Visible = false;
        }

        private void cbTemplates_SelectedIndexChanged(object sender, EventArgs e)
        {
       
            if (cbTemplates.SelectedIndex > 0)
            {
               
                string labelIndicator = (cbTemplates.SelectedItem as ComboItem).Text.ToString().Substring(0, (cbTemplates.SelectedItem as ComboItem).Text.ToString().LastIndexOf("."));
                SelectedLabel = new Labels();
                SelectedLabel.LoadTemplateInfo(labelIndicator);
                SelectedLabel.SetTemplateLocation((cbTemplates.SelectedItem as ComboItem).Value.ToString());
                LabelTemplate = PrintEngineFactory.PrintEngine.OpenLabel(SelectedLabel.GetTemplateLocation());
                if (RefreshAble)
                {
                
                    pictureBoxPreview.Visible = false;
                    LoadPreview("Generating Label Preview");
                }
                DoneLoadingPreviewSwitch();
                lblChosenTemplate.Text = SelectedLabel.GetTemplateLocation();
            }
            else
            {
                pictureBoxPreview.Visible = false;
                lblChosenTemplate.Text = "No Label Template has been chosen";
            }
            }
        

        private void DoneLoadingPreviewSwitch()
        {
           
            lblChosenTemplate.Font = regularFont;
            lblChosenTemplate.BackColor = standardBackColor;
            lblChosenTemplate.ForeColor = regularColor;
            this.Refresh();
        }

        private void LoadingPreviewSwitch(string status)
        {
            lblChosenTemplate.Text = status;
            lblChosenTemplate.Font = loadingFont;
            lblChosenTemplate.ForeColor = loadingColor;
            lblChosenTemplate.BackColor = loadingBackColor;
            this.Refresh();
        }
    }

    public class ComboItem
    {
        public string Text { get; set; }
        public string Value { get; set; }

        public override string ToString()
        {
            return Text;
        }
    }

   
}
