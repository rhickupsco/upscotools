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
            this.btnPrint = new System.Windows.Forms.Button();
            this.lblPrintQuantity = new System.Windows.Forms.Label();
            this.txtPrintQuantity = new System.Windows.Forms.TextBox();
            this.lblWorkOrder = new System.Windows.Forms.Label();
            this.txtWONumber = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbTemplates = new System.Windows.Forms.ComboBox();
            this.lblListTemplates = new System.Windows.Forms.Label();
            this.pictureBoxPreview = new System.Windows.Forms.PictureBox();
            this.pnlOverrideValues = new System.Windows.Forms.Panel();
            this.numAdjust = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.lblChosenTemplate = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlMatching = new System.Windows.Forms.Panel();
            this.lblVerifyDescriptions = new System.Windows.Forms.Label();
            this.cbPreview = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPreview)).BeginInit();
            this.pnlOverrideValues.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAdjust)).BeginInit();
            this.pnlMatching.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPrint
            // 
            this.btnPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnPrint.Location = new System.Drawing.Point(12, 550);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(228, 38);
            this.btnPrint.TabIndex = 3;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // lblPrintQuantity
            // 
            this.lblPrintQuantity.AutoSize = true;
            this.lblPrintQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblPrintQuantity.Location = new System.Drawing.Point(29, 47);
            this.lblPrintQuantity.Name = "lblPrintQuantity";
            this.lblPrintQuantity.Size = new System.Drawing.Size(126, 20);
            this.lblPrintQuantity.TabIndex = 1;
            this.lblPrintQuantity.Text = "Quantity to Print:";
            // 
            // txtPrintQuantity
            // 
            this.txtPrintQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtPrintQuantity.Location = new System.Drawing.Point(166, 44);
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
            this.lblWorkOrder.Size = new System.Drawing.Size(154, 20);
            this.lblWorkOrder.TabIndex = 7;
            this.lblWorkOrder.Text = "Work Order Number:";
            // 
            // txtWONumber
            // 
            this.txtWONumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtWONumber.Location = new System.Drawing.Point(165, 9);
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
            this.panel1.Size = new System.Drawing.Size(581, 76);
            this.panel1.TabIndex = 46;
            this.panel1.Visible = false;
            // 
            // cbTemplates
            // 
            this.cbTemplates.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbTemplates.FormattingEnabled = true;
            this.cbTemplates.Location = new System.Drawing.Point(142, 12);
            this.cbTemplates.Name = "cbTemplates";
            this.cbTemplates.Size = new System.Drawing.Size(244, 21);
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
            // pictureBoxPreview
            // 
            this.pictureBoxPreview.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxPreview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxPreview.Location = new System.Drawing.Point(248, 84);
            this.pictureBoxPreview.Name = "pictureBoxPreview";
            this.pictureBoxPreview.Size = new System.Drawing.Size(372, 411);
            this.pictureBoxPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxPreview.TabIndex = 47;
            this.pictureBoxPreview.TabStop = false;
            // 
            // pnlOverrideValues
            // 
            this.pnlOverrideValues.Controls.Add(this.numAdjust);
            this.pnlOverrideValues.Controls.Add(this.label2);
            this.pnlOverrideValues.Location = new System.Drawing.Point(15, 87);
            this.pnlOverrideValues.Name = "pnlOverrideValues";
            this.pnlOverrideValues.Size = new System.Drawing.Size(225, 68);
            this.pnlOverrideValues.TabIndex = 48;
            this.pnlOverrideValues.Visible = false;
            // 
            // numAdjust
            // 
            this.numAdjust.Location = new System.Drawing.Point(141, 24);
            this.numAdjust.Name = "numAdjust";
            this.numAdjust.Size = new System.Drawing.Size(63, 20);
            this.numAdjust.TabIndex = 47;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 13);
            this.label2.TabIndex = 46;
            this.label2.Text = "Adjust Quantity to ship:";
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
            // pnlMatching
            // 
            this.pnlMatching.Controls.Add(this.lblVerifyDescriptions);
            this.pnlMatching.Location = new System.Drawing.Point(16, 161);
            this.pnlMatching.Name = "pnlMatching";
            this.pnlMatching.Size = new System.Drawing.Size(106, 62);
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
            // MasterUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(877, 600);
            this.Controls.Add(this.pnlMatching);
            this.Controls.Add(this.pnlOverrideValues);
            this.Controls.Add(this.pictureBoxPreview);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtWONumber);
            this.Controls.Add(this.lblWorkOrder);
            this.Controls.Add(this.txtPrintQuantity);
            this.Controls.Add(this.lblPrintQuantity);
            this.Controls.Add(this.btnPrint);
            this.Name = "MasterUserForm";
            this.Text = "UPSCO Labels Command Center";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPreview)).EndInit();
            this.pnlOverrideValues.ResumeLayout(false);
            this.pnlOverrideValues.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAdjust)).EndInit();
            this.pnlMatching.ResumeLayout(false);
            this.pnlMatching.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Label lblPrintQuantity;
        private System.Windows.Forms.TextBox txtPrintQuantity;
        private System.Windows.Forms.Label lblWorkOrder;
        private System.Windows.Forms.TextBox txtWONumber;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbTemplates;
        private System.Windows.Forms.Label lblListTemplates;
        private System.Windows.Forms.PictureBox pictureBoxPreview;
        private System.Windows.Forms.Panel pnlOverrideValues;
        private System.Windows.Forms.NumericUpDown numAdjust;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblChosenTemplate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlMatching;
        private System.Windows.Forms.Label lblVerifyDescriptions;
        private System.Windows.Forms.CheckBox cbPreview;
    }
}

