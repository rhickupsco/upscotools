namespace LabelPrinter
{
    partial class MasterUserForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblPrintQuantity = new System.Windows.Forms.Label();
            this.txtPrintQuantity = new System.Windows.Forms.TextBox();
            this.lblWorkOrder = new System.Windows.Forms.Label();
            this.txtWONumber = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbPreview = new System.Windows.Forms.CheckBox();
            this.lblChosenTemplate = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbTemplates = new System.Windows.Forms.ComboBox();
            this.lblListTemplates = new System.Windows.Forms.Label();
            this.pnlMatching = new System.Windows.Forms.Panel();
            this.lblVerifyDescriptions = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.lblAdditionalInfo = new System.Windows.Forms.Label();
            this.lblStartingSerNo = new System.Windows.Forms.Label();
            this.txtStartingSerNo = new System.Windows.Forms.TextBox();
            this.lblWhichItem = new System.Windows.Forms.Label();
            this.cbShippingItems = new System.Windows.Forms.ComboBox();
            this.cbIsMedium = new System.Windows.Forms.CheckBox();
            this.lbCustomerPartNumber = new System.Windows.Forms.Label();
            this.txtCustomerPartNumber = new System.Windows.Forms.TextBox();
            this.lblQuantityInBox = new System.Windows.Forms.Label();
            this.txtQuantityInBox = new System.Windows.Forms.TextBox();
            this.btnContinue = new System.Windows.Forms.Button();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBoxPreview = new System.Windows.Forms.PictureBox();
            this.ttUserInput = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnPrint = new System.Windows.Forms.Button();
            this.pnlOverrideValues = new System.Windows.Forms.Panel();
            this.numAdjust = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.pnlMatching.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPreview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ttUserInput)).BeginInit();
            this.pnlOverrideValues.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAdjust)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPrintQuantity
            // 
            this.lblPrintQuantity.AutoSize = true;
            this.lblPrintQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblPrintQuantity.Location = new System.Drawing.Point(12, 66);
            this.lblPrintQuantity.Name = "lblPrintQuantity";
            this.lblPrintQuantity.Size = new System.Drawing.Size(126, 20);
            this.lblPrintQuantity.TabIndex = 1;
            this.lblPrintQuantity.Text = "Quantity to Print:";
            // 
            // txtPrintQuantity
            // 
            this.txtPrintQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtPrintQuantity.Location = new System.Drawing.Point(144, 63);
            this.txtPrintQuantity.Name = "txtPrintQuantity";
            this.txtPrintQuantity.Size = new System.Drawing.Size(44, 26);
            this.txtPrintQuantity.TabIndex = 1;
            this.txtPrintQuantity.Text = "1";
            // 
            // lblWorkOrder
            // 
            this.lblWorkOrder.AutoSize = true;
            this.lblWorkOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblWorkOrder.Location = new System.Drawing.Point(12, 12);
            this.lblWorkOrder.Name = "lblWorkOrder";
            this.lblWorkOrder.Size = new System.Drawing.Size(260, 20);
            this.lblWorkOrder.TabIndex = 7;
            this.lblWorkOrder.Text = "Work Order or Sales Order Number:";
            // 
            // txtWONumber
            // 
            this.txtWONumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtWONumber.Location = new System.Drawing.Point(144, 35);
            this.txtWONumber.Name = "txtWONumber";
            this.txtWONumber.Size = new System.Drawing.Size(113, 26);
            this.txtWONumber.TabIndex = 0;
            this.txtWONumber.TextChanged += new System.EventHandler(this.txtWONumber_TextChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cbPreview);
            this.panel1.Controls.Add(this.lblChosenTemplate);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cbTemplates);
            this.panel1.Controls.Add(this.lblListTemplates);
            this.panel1.Location = new System.Drawing.Point(284, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(542, 76);
            this.panel1.TabIndex = 46;
            this.panel1.Visible = false;
            // 
            // cbPreview
            // 
            this.cbPreview.AutoSize = true;
            this.cbPreview.Checked = true;
            this.cbPreview.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbPreview.Location = new System.Drawing.Point(393, 14);
            this.cbPreview.Name = "cbPreview";
            this.cbPreview.Size = new System.Drawing.Size(140, 17);
            this.cbPreview.TabIndex = 9;
            this.cbPreview.Text = "Always Refresh Preview";
            this.cbPreview.UseVisualStyleBackColor = true;
            // 
            // lblChosenTemplate
            // 
            this.lblChosenTemplate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblChosenTemplate.AutoSize = true;
            this.lblChosenTemplate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblChosenTemplate.Location = new System.Drawing.Point(145, 44);
            this.lblChosenTemplate.Name = "lblChosenTemplate";
            this.lblChosenTemplate.Size = new System.Drawing.Size(211, 20);
            this.lblChosenTemplate.TabIndex = 8;
            this.lblChosenTemplate.Text = "choose label template above";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(1, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Selected Template:";
            // 
            // cbTemplates
            // 
            this.cbTemplates.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbTemplates.FormattingEnabled = true;
            this.cbTemplates.Location = new System.Drawing.Point(149, 12);
            this.cbTemplates.Name = "cbTemplates";
            this.cbTemplates.Size = new System.Drawing.Size(238, 21);
            this.cbTemplates.TabIndex = 4;
            this.cbTemplates.Tag = "";
            this.cbTemplates.SelectedIndexChanged += new System.EventHandler(this.cbTemplates_SelectedIndexChanged);
            // 
            // lblListTemplates
            // 
            this.lblListTemplates.AutoSize = true;
            this.lblListTemplates.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblListTemplates.Location = new System.Drawing.Point(3, 12);
            this.lblListTemplates.Name = "lblListTemplates";
            this.lblListTemplates.Size = new System.Drawing.Size(134, 20);
            this.lblListTemplates.TabIndex = 5;
            this.lblListTemplates.Tag = "";
            this.lblListTemplates.Text = "Choose Template";
            // 
            // pnlMatching
            // 
            this.pnlMatching.Controls.Add(this.lblVerifyDescriptions);
            this.pnlMatching.Location = new System.Drawing.Point(823, 2);
            this.pnlMatching.Name = "pnlMatching";
            this.pnlMatching.Size = new System.Drawing.Size(95, 76);
            this.pnlMatching.TabIndex = 49;
            this.pnlMatching.Visible = false;
            // 
            // lblVerifyDescriptions
            // 
            this.lblVerifyDescriptions.AutoSize = true;
            this.lblVerifyDescriptions.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblVerifyDescriptions.Location = new System.Drawing.Point(0, 0);
            this.lblVerifyDescriptions.Margin = new System.Windows.Forms.Padding(2);
            this.lblVerifyDescriptions.Name = "lblVerifyDescriptions";
            this.lblVerifyDescriptions.Size = new System.Drawing.Size(98, 13);
            this.lblVerifyDescriptions.TabIndex = 0;
            this.lblVerifyDescriptions.Text = "Descriptions Match";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel1.Controls.Add(this.lblAdditionalInfo);
            this.flowLayoutPanel1.Controls.Add(this.lblStartingSerNo);
            this.flowLayoutPanel1.Controls.Add(this.txtStartingSerNo);
            this.flowLayoutPanel1.Controls.Add(this.lblWhichItem);
            this.flowLayoutPanel1.Controls.Add(this.cbShippingItems);
            this.flowLayoutPanel1.Controls.Add(this.cbIsMedium);
            this.flowLayoutPanel1.Controls.Add(this.lbCustomerPartNumber);
            this.flowLayoutPanel1.Controls.Add(this.txtCustomerPartNumber);
            this.flowLayoutPanel1.Controls.Add(this.lblQuantityInBox);
            this.flowLayoutPanel1.Controls.Add(this.txtQuantityInBox);
            this.flowLayoutPanel1.Controls.Add(this.btnContinue);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 95);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(10);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(266, 334);
            this.flowLayoutPanel1.TabIndex = 50;
            this.flowLayoutPanel1.Visible = false;
            // 
            // lblAdditionalInfo
            // 
            this.lblAdditionalInfo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblAdditionalInfo.BackColor = System.Drawing.Color.Green;
            this.lblAdditionalInfo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblAdditionalInfo.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdditionalInfo.ForeColor = System.Drawing.Color.White;
            this.lblAdditionalInfo.Location = new System.Drawing.Point(13, 10);
            this.lblAdditionalInfo.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
            this.lblAdditionalInfo.Name = "lblAdditionalInfo";
            this.lblAdditionalInfo.Size = new System.Drawing.Size(243, 21);
            this.lblAdditionalInfo.TabIndex = 56;
            this.lblAdditionalInfo.Text = "Additional Info Needed";
            this.lblAdditionalInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblStartingSerNo
            // 
            this.lblStartingSerNo.AutoSize = true;
            this.lblStartingSerNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblStartingSerNo.Location = new System.Drawing.Point(13, 41);
            this.lblStartingSerNo.Name = "lblStartingSerNo";
            this.lblStartingSerNo.Size = new System.Drawing.Size(190, 20);
            this.lblStartingSerNo.TabIndex = 52;
            this.lblStartingSerNo.Text = "Starting Serial Number ? :";
            this.lblStartingSerNo.Visible = false;
            // 
            // txtStartingSerNo
            // 
            this.txtStartingSerNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtStartingSerNo.Location = new System.Drawing.Point(13, 64);
            this.txtStartingSerNo.Name = "txtStartingSerNo";
            this.txtStartingSerNo.Size = new System.Drawing.Size(177, 26);
            this.txtStartingSerNo.TabIndex = 54;
            this.txtStartingSerNo.Visible = false;
            // 
            // lblWhichItem
            // 
            this.lblWhichItem.AutoSize = true;
            this.lblWhichItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblWhichItem.Location = new System.Drawing.Point(13, 93);
            this.lblWhichItem.Name = "lblWhichItem";
            this.lblWhichItem.Size = new System.Drawing.Size(106, 20);
            this.lblWhichItem.TabIndex = 57;
            this.lblWhichItem.Text = "Which Item ?:";
            this.lblWhichItem.Visible = false;
            // 
            // cbShippingItems
            // 
            this.cbShippingItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cbShippingItems.FormattingEnabled = true;
            this.cbShippingItems.Location = new System.Drawing.Point(13, 116);
            this.cbShippingItems.Name = "cbShippingItems";
            this.cbShippingItems.Size = new System.Drawing.Size(253, 28);
            this.cbShippingItems.TabIndex = 58;
            this.cbShippingItems.Visible = false;
            this.cbShippingItems.SelectedIndexChanged += new System.EventHandler(this.cbShippingItems_SelectedIndexChanged);
            // 
            // cbIsMedium
            // 
            this.cbIsMedium.AutoSize = true;
            this.cbIsMedium.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cbIsMedium.Location = new System.Drawing.Point(13, 157);
            this.cbIsMedium.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.cbIsMedium.Name = "cbIsMedium";
            this.cbIsMedium.Padding = new System.Windows.Forms.Padding(3);
            this.cbIsMedium.Size = new System.Drawing.Size(216, 30);
            this.cbIsMedium.TabIndex = 59;
            this.cbIsMedium.Text = "Is This Medium Pressure?";
            this.cbIsMedium.UseVisualStyleBackColor = true;
            this.cbIsMedium.Visible = false;
            // 
            // lbCustomerPartNumber
            // 
            this.lbCustomerPartNumber.AutoSize = true;
            this.lbCustomerPartNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbCustomerPartNumber.Location = new System.Drawing.Point(13, 190);
            this.lbCustomerPartNumber.Name = "lbCustomerPartNumber";
            this.lbCustomerPartNumber.Size = new System.Drawing.Size(184, 20);
            this.lbCustomerPartNumber.TabIndex = 61;
            this.lbCustomerPartNumber.Text = "Customer Part Number?:";
            this.lbCustomerPartNumber.Visible = false;
            // 
            // txtCustomerPartNumber
            // 
            this.txtCustomerPartNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtCustomerPartNumber.Location = new System.Drawing.Point(13, 213);
            this.txtCustomerPartNumber.Name = "txtCustomerPartNumber";
            this.txtCustomerPartNumber.Size = new System.Drawing.Size(235, 26);
            this.txtCustomerPartNumber.TabIndex = 62;
            this.txtCustomerPartNumber.Visible = false;
            // 
            // lblQuantityInBox
            // 
            this.lblQuantityInBox.AutoSize = true;
            this.lblQuantityInBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblQuantityInBox.Location = new System.Drawing.Point(13, 242);
            this.lblQuantityInBox.Name = "lblQuantityInBox";
            this.lblQuantityInBox.Size = new System.Drawing.Size(170, 20);
            this.lblQuantityInBox.TabIndex = 63;
            this.lblQuantityInBox.Text = "Quantity to go in box ?:";
            this.lblQuantityInBox.Visible = false;
            // 
            // txtQuantityInBox
            // 
            this.txtQuantityInBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtQuantityInBox.Location = new System.Drawing.Point(13, 265);
            this.txtQuantityInBox.Name = "txtQuantityInBox";
            this.txtQuantityInBox.Size = new System.Drawing.Size(235, 26);
            this.txtQuantityInBox.TabIndex = 64;
            this.txtQuantityInBox.Visible = false;
            // 
            // btnContinue
            // 
            this.btnContinue.Location = new System.Drawing.Point(13, 297);
            this.btnContinue.Name = "btnContinue";
            this.btnContinue.Size = new System.Drawing.Size(235, 31);
            this.btnContinue.TabIndex = 60;
            this.btnContinue.Text = "Update Label Information";
            this.btnContinue.UseVisualStyleBackColor = true;
            this.btnContinue.Click += new System.EventHandler(this.btnContinue_Click);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(291, 84);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(541, 336);
            this.flowLayoutPanel2.TabIndex = 51;
            // 
            // pictureBoxPreview
            // 
            this.pictureBoxPreview.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBoxPreview.BackColor = System.Drawing.SystemColors.WindowText;
            this.pictureBoxPreview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxPreview.Location = new System.Drawing.Point(291, 95);
            this.pictureBoxPreview.Name = "pictureBoxPreview";
            this.pictureBoxPreview.Size = new System.Drawing.Size(535, 319);
            this.pictureBoxPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxPreview.TabIndex = 49;
            this.pictureBoxPreview.TabStop = false;
            this.pictureBoxPreview.Visible = false;
            // 
            // ttUserInput
            // 
            this.ttUserInput.ContainerControl = this;
            // 
            // btnPrint
            // 
            this.btnPrint.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPrint.BackColor = System.Drawing.Color.Lime;
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPrint.Font = new System.Drawing.Font("Gorilla", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPrint.Location = new System.Drawing.Point(736, 528);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(170, 51);
            this.btnPrint.TabIndex = 52;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Visible = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click_1);
            // 
            // pnlOverrideValues
            // 
            this.pnlOverrideValues.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlOverrideValues.AutoSize = true;
            this.pnlOverrideValues.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlOverrideValues.Controls.Add(this.numAdjust);
            this.pnlOverrideValues.Controls.Add(this.label2);
            this.pnlOverrideValues.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pnlOverrideValues.Location = new System.Drawing.Point(12, 435);
            this.pnlOverrideValues.Name = "pnlOverrideValues";
            this.pnlOverrideValues.Size = new System.Drawing.Size(215, 26);
            this.pnlOverrideValues.TabIndex = 53;
            this.pnlOverrideValues.Visible = false;
            // 
            // numAdjust
            // 
            this.numAdjust.Location = new System.Drawing.Point(149, 3);
            this.numAdjust.Name = "numAdjust";
            this.numAdjust.Size = new System.Drawing.Size(63, 20);
            this.numAdjust.TabIndex = 47;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 13);
            this.label2.TabIndex = 46;
            this.label2.Text = "Adjust Quantity to ship:";
            // 
            // MasterUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 591);
            this.Controls.Add(this.pictureBoxPreview);
            this.Controls.Add(this.pnlOverrideValues);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.pnlMatching);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtWONumber);
            this.Controls.Add(this.lblWorkOrder);
            this.Controls.Add(this.txtPrintQuantity);
            this.Controls.Add(this.lblPrintQuantity);
            this.Name = "MasterUserForm";
            this.Text = "UPSCO Labels Command Center";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlMatching.ResumeLayout(false);
            this.pnlMatching.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPreview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ttUserInput)).EndInit();
            this.pnlOverrideValues.ResumeLayout(false);
            this.pnlOverrideValues.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAdjust)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblPrintQuantity;
        private System.Windows.Forms.TextBox txtPrintQuantity;
        private System.Windows.Forms.Label lblWorkOrder;
        private System.Windows.Forms.TextBox txtWONumber;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbTemplates;
        private System.Windows.Forms.Label lblListTemplates;
        private System.Windows.Forms.Label lblChosenTemplate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlMatching;
        private System.Windows.Forms.Label lblVerifyDescriptions;
        private System.Windows.Forms.CheckBox cbPreview;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label lblAdditionalInfo;
        private System.Windows.Forms.Label lblStartingSerNo;
        private System.Windows.Forms.TextBox txtStartingSerNo;
        private System.Windows.Forms.Label lblWhichItem;
        private System.Windows.Forms.ComboBox cbShippingItems;
        private System.Windows.Forms.CheckBox cbIsMedium;
        private System.Windows.Forms.Button btnContinue;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.PictureBox pictureBoxPreview;
        private System.Windows.Forms.Label lbCustomerPartNumber;
        private System.Windows.Forms.TextBox txtCustomerPartNumber;
        private System.Windows.Forms.Label lblQuantityInBox;
        private System.Windows.Forms.TextBox txtQuantityInBox;
        private System.Windows.Forms.ErrorProvider ttUserInput;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Panel pnlOverrideValues;
        private System.Windows.Forms.NumericUpDown numAdjust;
        private System.Windows.Forms.Label label2;
    }
}

