using System;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using System.Data;
using Data_Access;
using NiceLabel.SDK;
using System.Collections.Generic;
using System.Drawing;

namespace LabelPrinter
{
    public partial class MasterUserForm : Form
    {

        public ILabel LabelTemplate;
        List<string> UserVariablesUsed = new List<string>();
        public Labels SelectedLabel { get; set; }

        public int QtyOverride { get; set; }
        public string AskType { get; set; }

        public bool MoreInfoNeeded { get; set; }
        public bool PrintMission { get; set; }

        public string ShippingItemInfo { get; set; }

        public bool Current { get; set; }

        public Font loadingFont = new Font("HelveticaNeue-Bold", 14, FontStyle.Bold);
        public Color loadingColor = Color.Red;
        public Font regularFont = new Font("HelveticaNeue-Bold", 12, FontStyle.Regular);
        public Color regularColor = Color.Black;
        public Color loadingBackColor = Color.Yellow;
        public Color standardBackColor = Color.Transparent;

    
        public bool RefreshAble { get { return cbPreview.Checked; } }



        public MasterUserForm()
        {
            
            this.InitializeComponent();
            this.Font = regularFont;
            this.InitializePrintEngine();
            this.LoadAllTemplatesList();

        }

        private void LoadAllTemplatesList()
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
        
        private void btnPrint_Click_1(object sender, EventArgs e)
        {
           // VerifyDescriptionsMatch();

            if (IsValid(lblChosenTemplate, txtWONumber.Text)){           

                int quantity = int.Parse(txtPrintQuantity.Text);

                DialogResult res = MessageBox.Show("Is this ok to print " + quantity.ToString() + " labels?", "Proceed to Print", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (res == DialogResult.Yes){
                    // Printing the specified number of labels
                    PrintMission = true;
                    LoadPreview("Gathering Info / Printing " + quantity.ToString() + " Labels");
                    try
                    {
                        LabelTemplate.Print(Convert.ToInt16(quantity));
                        LabelTemplate.Dispose();
                        ResetPanels();
                        ResetAdditional();
                    }
                    catch (Exception ex)
                    {
                        LoadPreview("Print Job Cancelled");
                        MessageBox.Show("Print Job Cancelled " + ex.Message.ToString());

                    }
                   
                }              
            }
        }



        private void VerifyDescriptionsMatch(Labels selectedLabel)
        {
           
        }

        private void LoadPreview(string status, string optionalParams = "none")
        {
            string woNumber = txtWONumber.Text.ToString().Trim();
            if (optionalParams != "none")
            {
               if(UserVariablesUsed.Contains("StartingSerialNumber")  && txtStartingSerNo.Text.Length > 1)
               {
                 LabelTemplate.Variables["StartingSerialNumber"].SetValue(txtStartingSerNo.Text);                    
               }

                //if(cbIsMedium.Visible == true) {
                //     string value = SelectedLabel.GetVariableValue;

                //        if(cbIsMedium.Checked) {
                //         value = "MP";
                //        }                    
                //     LabelTemplate.Variables["ItemCode"].SetValue(value);
                // }

                if (UserVariablesUsed.Contains("customerPartNumber") && ShippingItemInfo.Length > 1)
                {
                    string value = txtCustomerPartNumber.Text.Trim();
                    LabelTemplate.Variables["itemCode"].SetValue(ShippingItemInfo);
                    LabelTemplate.Variables["customerPartNumber"].SetValue(value);                
                }
                    MoreInfoNeeded = false;           
            }

            else
            {

                LoadingPreviewSwitch(status);
                 
                string query = SelectedLabel.GetQuery().Trim();


                if (query != "static" && MoreInfoNeeded == false)
                {

                    DataTable dt = new DataTable();

                    //if (flowLayoutPanel1.Visible == false && OtherInfoNeeded > 0)
                    //{
                    //    if (OtherInfoNeeded > 0) { MoreInfoNeeded = true; }
                    //    LoadUserInputVariables();
                    //    LoadPreview(status);
                    //    MoreInfoNeeded = true;
                    //    Refresh();

                    //}

                    dt = LoadLabelsInfo(query, woNumber);

                    /////this is the area that sets the values from USER INPUT FORM that will be sent along to the label template
                    if (UserVariablesUsed.Contains("IsMedium"))
                    {
                       
                        if (cbIsMedium.Visible == true)
                        {

                            string value = string.Empty;

                            try
                            {
                              value = dt.Rows[0]["ItemCodeDesc"].ToString();

                                if (cbIsMedium.Checked)
                                {
                                    value = value.Replace("HP", "MP");
                                }
                         
                            }
                            catch (Exception)
                            {

                                value = "VOID - NOT VALID";
                            }

                            LabelTemplate.Variables["ItemCode"].SetValue(value);
                        }
                    }
   

                    if (UserVariablesUsed.Contains("customerPartNumber")) {
                        string value = txtCustomerPartNumber.Text.Trim();
                        value = BreakOnDashes(value);
                        LabelTemplate.Variables["customerPartNumber"].SetValue(value);
                        }
                    if(UserVariablesUsed.Contains("Quantity")) {
                        string qtyValue = txtQuantityInBox.Text.Trim();                    
                        LabelTemplate.Variables["Quantity"].SetValue(qtyValue);
                    }
                    


                }

                if (MoreInfoNeeded == false && PrintMission == false)
                {

                    if (UserVariablesUsed.Count==0)
                    {
                        ResetAdditional();
                    }

                    // Set up LabelPreviewSettings to be passed to the GetLabelPreview method.
                    ILabelPreviewSettings labelPreviewSettings = new LabelPreviewSettings();

                    //check to see if there will be the main variable info to give to template
                    string WOExists = string.Empty;
                    try
                    {
                        WOExists = LabelTemplate.Variables[SelectedLabel.GetVariableValue(0)].CurrentValue.ToString();
                    }
                    catch (Exception)
                    {

                        WOExists = "not needed";
                    } 


                    int height = 0;
                    int width = 0;
                    string labelType = SelectedLabel.GetLabelType().TrimEnd();

                    if (labelType == "box")
                    {
                        width = 400;
                        height = 450;
                    }
                    else if (labelType == "fabrication")
                    {
                        width = 600;
                        height = 400;
                    }
                    else if (labelType == "location" || labelType == "pressure")
                    {
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
                                  // Which label side(s) to generate the image for.  

                    // Generate Preview File
                    object imageObj = new object();
                    labelPreviewSettings.FormatPreviewSide = FormatPreviewSide.FrontSide;
                    if (WOExists == string.Empty){
                                             
                        imageObj = WOExists;
                    }
                    else {
                    
                        imageObj = LabelTemplate.GetLabelPreview(labelPreviewSettings);
                        btnPrint.Visible = true;
                    }

                    
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
                        this.pictureBoxPreview.ImageLocation = String.Concat(Properties.Settings.Default.labelsPath.ToString(), "\\error.bmp");
                    }
                }
            }
            DoneLoadingPreviewSwitch();

        }

        private string BreakOnDashes(string value)
        {
            string newResult = string.Empty;
            int characterCount = value.Length;

            string printerCommand = "<LF>";
            char[] allChar = value.ToCharArray();

            foreach(char c in allChar)
            {
                string addOn = string.Empty;

                if(c == '-') {
                    addOn = c.ToString().ToUpper() + printerCommand;
                }
                else
                {
                    addOn = c.ToString().ToUpper();
                }
                newResult = newResult + addOn;
            }

            return newResult;
        }

        private void LoadShippingValuesForQuery(string soNumber, string itemCode, string queriedSql)
        {
            DataTable dt = new DataTable();
            dt = CommonData.GetShippingLabelData(soNumber,itemCode, Current, queriedSql);
        }

        private void LoadUserInputVariables()
        {
           int index = 0;
           //show the flowLayoutPanel that will turn on "Additional Info Needed" label
            flowLayoutPanel1.Visible = true;
            btnContinue.Visible = true;
            lblAdditionalInfo.Visible = true;

          while (index < SelectedLabel.userFormVarsCount)
           {
                string isVisible = SelectedLabel.GetUserVariableValue(index);
                ///this is the switch on for the user variables
                      switch(isVisible) { 
                     case "SalesOrderLineNumber":
                        UserVariablesUsed.Add("SalesOrderLineNumber");
                        //these all go with shipping
                        lblWhichItem.Visible = true;
                        cbShippingItems.Visible = true;
                        LoadSalesOrderItemsForThisSalesOrder(txtWONumber.Text.Trim());
                        if (cbShippingItems.Items.Count > 0) { 
                            ttUserInput.Dispose();
                             cbShippingItems.SelectedIndex = 0;
                        }
                        else {
                            flowLayoutPanel1.Visible = false;
                            ttUserInput.SetError(txtWONumber, "This is not a valid SO or WO Number"); 
                        }                      
                        this.Refresh();
                        break;
                     case "IsMedium":
                        UserVariablesUsed.Add("IsMedium");
                        cbIsMedium.Visible = true;
                        this.Refresh();
                        break;
                     case "StartingSerialNumber":
                        UserVariablesUsed.Add("StartingSerialNumber");
                        lblStartingSerNo.Visible = true;
                        txtStartingSerNo.Visible = true;
                        this.Refresh();
                        break;
                    case "Quantity":
                        UserVariablesUsed.Add("Quantity");
                        lblQuantityInBox.Visible = true;
                        txtQuantityInBox.Visible = true;
                        break;
                    case "customerPartNumber":
                        UserVariablesUsed.Add("customerPartNumber");
                        lbCustomerPartNumber.Visible = true;
                        txtCustomerPartNumber.Visible = true;
                        break;
                    default:                            
                        break;
                      }
                index += 1;
           }
        }

        private void LoadSalesOrderItemsForThisSalesOrder(string soNumber)
        {
            //clear all items prior to evaluating and filling
            cbShippingItems.Items.Clear();
            DataTable dt = CommonData.GetSalesOrderItems(soNumber);

            //THIS POPULATES ALL THE ITEMS and warehouse info FROM SAGE DATABASE

            if (dt.Rows.Count >= 1)
            {
                int totalVarCount = SelectedLabel.variableCount;
                int count = 0;

                foreach (DataRow items in dt.Rows)
                {
                    ComboItem item = new ComboItem();
                    item.Text = string.Concat(items["itemCode"].ToString(), " in WH - ", items["warehouseCode"].ToString(), " from line: ", items["linekey"].ToString()) ;
                    item.Value = items["linekey"].ToString();
                    cbShippingItems.Items.Add(item);
                    count += 1;
                }
                cbShippingItems.Items.Insert(0, "Select An Item");
            }
                      
        }

        private DataTable LoadLabelsInfo(string query, string woNumber)
        {

            DataTable dt = new DataTable();
            if (UserVariablesUsed.Contains("SalesOrderLineNumber"))
            {
                Current = !(cbShippingItems.SelectedItem as ComboItem).Value.ToString().Contains("closed");

                
                if (SelectedLabel.GetLabelType().ToString().TrimEnd() == "shipping")
                    dt = CommonData.GetShippingLabelData(woNumber, ShippingItemInfo, Current, SelectedLabel.GetQuery());
          
            }
            else if (UserVariablesUsed.Contains("StartingSerialNumber"))
            {
                if (SelectedLabel.GetLabelType().ToString().TrimEnd() == "box" || SelectedLabel.GetLabelType().ToString().TrimEnd() == "fabrication")                {
               
                    dt = CommonData.GetDataFromQuery(query, woNumber);
                }
            }

            else
            {
                dt = CommonData.GetDataFromQuery(query, woNumber);
            }

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
                else
                {
                    DataRow notValidRow = dt.NewRow();
                    notValidRow["workOrder"] = "9999999";
                    dt.Rows.Add(notValidRow);
                }

                return dt;
           
         
        }

        private bool IsValid(Label lblChosenTemplate, string woNumber)
        {
        
            if(cbTemplates.Text.ToString().Contains(".nlbl")) {
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
            //this checks to see if the entered value is workorder or sales order
            if (txtWONumber.Text.StartsWith("20")) { AskType = "WorkOrder"; }
            else if (txtWONumber.Text.StartsWith("01")) { AskType = "SalesOrder"; }
            else { AskType = "WorkOrder or SalesOrder"; }

            lblWorkOrder.Text = AskType.ToString() + " Number:";

            if (txtWONumber.Text.Length == 7) {  
                if (AskType == "WorkOrder" || AskType == "SalesOrder") { 
                    //LoadFilteredTemplateList(); 
                    panel1.Visible = true; }   
                else { lblWorkOrder.Text = "This is not a known #"; }                      
                }
            else {
                    ResetPanels();
                }
        }

        private void ResetPanels()
        {
            if (cbTemplates.SelectedIndex > 0)
            {
                cbTemplates.SelectedIndex = 0;
                pictureBoxPreview.Visible = false;
            }
        }

        private void LoadFilteredTemplateList()
        {
            DataTable dt = CommonData.GetFilteredTemplates(AskType);
            int templatesCount = dt.Rows.Count;
            int index = 0;

            //remove templates from list that are not of the correct type
            string[] allTemplateNames = new string[templatesCount];

            while (index < templatesCount)
            {
                allTemplateNames[index] = dt.Rows[index]["templateName"].ToString();
                index += 1;
            }
        }

        private void ResetAdditional()
        {
            this.flowLayoutPanel1.Visible = false;
            foreach(Control c in flowLayoutPanel1.Controls)
            {
                c.Visible = false;
            }
            PrintMission = false;
            UserVariablesUsed.Clear();

        }

        protected void cbTemplates_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnPrint.Visible = false;


            if (cbTemplates.SelectedIndex > 0)
            {
            ////////this is where i have left off needing to re-evaluate what user Inputs are needed
                string labelIndicator = (cbTemplates.SelectedItem as ComboItem).Text.ToString();
                SelectedLabel = new Labels();
                SelectedLabel.LoadTemplateInfo(labelIndicator);
                SelectedLabel.SetTemplateLocation((cbTemplates.SelectedItem as ComboItem).Value.ToString());
                LabelTemplate = PrintEngineFactory.PrintEngine.OpenLabel(SelectedLabel.GetTemplateLocation());
               
                MoreInfoNeeded = !SelectedLabel.userFormVarsCount.Equals(0);

                if (MoreInfoNeeded){
                    ResetAdditional();
                    flowLayoutPanel1.Visible = true;
                    LoadUserInputVariables();
                }

                if (RefreshAble && !MoreInfoNeeded)
                {
                    ResetAdditional();
                    LoadUserInputVariables();
                    pictureBoxPreview.Visible = false;
                    LoadPreview("Generating Label Preview");
                }

                DoneLoadingPreviewSwitch();
                lblChosenTemplate.Text = SelectedLabel.GetTemplateLocation();
            }
            else
            {
                pictureBoxPreview.Visible = false;
                //ResetAdditional();
                //this.Refresh();
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

        protected void btnContinue_Click(object sender, EventArgs e)
        {
           
    

            if (AllUserResponsesGathered()) {
                flowLayoutPanel1.BorderStyle = BorderStyle.None;
                flowLayoutPanel1.ForeColor = regularColor;
                LoadPreview("", "additional info added");
            }
            else {
                flowLayoutPanel1.BorderStyle = BorderStyle.FixedSingle;
                flowLayoutPanel1.ForeColor = loadingColor;

            }


            if (MoreInfoNeeded == false) { LoadPreview("Generating Label Preview"); }  
        }

        private bool AllUserResponsesGathered()
        {
            int[] responses = { 0,0,0,0,0 };
            int[] responsesExpected = { 0,0,0,0,0 };
            ttUserInput.Clear();

            /////this checks the value of the starting serial number
            if (UserVariablesUsed.Contains("StartingSerialNumber"))
            {
                responsesExpected[0] = 1;

                if (txtStartingSerNo.Text.Length > 0 && txtStartingSerNo.Text.IsNumeric())
                    responses[0] = 1;
                else
                    ttUserInput.SetError(txtStartingSerNo, "Are you sure this is a real number?");
            }

            /////this checks for the presence of the checkbox ("IS MEDIUM")
            if (UserVariablesUsed.Contains("isMedium"))
            {
                responsesExpected[1] = 1;
                responses[1] = 1;
            }

            /////this checks that an item has been selected
            if (UserVariablesUsed.Contains("SalesOrderLineNumber"))
                responsesExpected[2] = 1;
            if (ShippingItemInfo != null && cbShippingItems.SelectedIndex > 0)
                responses[2] = 1;
            else
                ttUserInput.SetError(cbShippingItems,"Please select an item in the list");

            /////this checks for the presence of a valid quantity
            if (UserVariablesUsed.Contains("Quantity"))
                responsesExpected[3] = 1;
                if (txtQuantityInBox.Text.Length >= 1 && txtQuantityInBox.Text.IsNumeric())
                    responses[3] = 1;
                else
                    ttUserInput.SetError(txtQuantityInBox, "Are you sure this is a real number?");

            /////this checks for the presence of a valid customer part number
            if (UserVariablesUsed.Contains("customerPartNumber"))
                responsesExpected[4] = 1;
            if (txtCustomerPartNumber.Text.Length >= 1)
            {
                responses[4] = 1;
            }
            else
                ttUserInput.SetError(txtCustomerPartNumber, "Did you forget this Customer's Part Number from the line item's comments?");
              
            //Collect all of the expected responses and the actual responses
            int responseTotal = GetTotal(responses, responsesExpected);

            //Get the difference between what is expected and valid values a responseTotal of 0 is what we are seeking ... all valid values
            return (responseTotal.CompareTo(0) == 0);
        }

        public int GetTotal(int[] responses, int[] responsesExpected) {
            int i = 0;
            int sum = 0;
            int sumTotalResponses = 0;

            while (i < responsesExpected.Length)
            {
                sumTotalResponses += responsesExpected[i];   // either sum = sum + ... or sum += ..., but not both
                i++;           // You need to increment the index at the end of the loop.
            }

            i = 0;

            while (i < responses.Length)
            {  
                sum += responses[i];   // either sum = sum + ... or sum += ..., but not both
                i++;           // You need to increment the index at the end of the loop.
            }
            return sumTotalResponses - sum;
        }

        private void cbShippingItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbShippingItems.SelectedIndex > 0)
            {
                int totalItemLength = (cbShippingItems.SelectedItem as ComboItem).Text.ToString().IndexOf(" in");
                ShippingItemInfo = (cbShippingItems.SelectedItem as ComboItem).Text.Substring(0, totalItemLength);

            }
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


public static class StringExtensions
{
    public static bool IsNumeric(this string input)
    {
        int number;
        return int.TryParse(input, out number);
    }
}
