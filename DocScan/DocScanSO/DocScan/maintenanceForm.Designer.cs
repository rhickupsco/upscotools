namespace DocScan
{
    partial class maintenanceForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(maintenanceForm));
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblToValue = new System.Windows.Forms.Label();
            this.lblToTitle = new System.Windows.Forms.Label();
            this.btnGo = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblFileFoundCount = new System.Windows.Forms.Label();
            this.lblQtyTransferred = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select Source Files Location";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(176, 8);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(261, 21);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lblToValue
            // 
            this.lblToValue.AutoSize = true;
            this.lblToValue.Location = new System.Drawing.Point(91, 39);
            this.lblToValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblToValue.Name = "lblToValue";
            this.lblToValue.Size = new System.Drawing.Size(100, 13);
            this.lblToValue.TabIndex = 3;
            this.lblToValue.Text = "scan file destination";
            // 
            // lblToTitle
            // 
            this.lblToTitle.AutoSize = true;
            this.lblToTitle.Location = new System.Drawing.Point(10, 39);
            this.lblToTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblToTitle.Name = "lblToTitle";
            this.lblToTitle.Size = new System.Drawing.Size(71, 13);
            this.lblToTitle.TabIndex = 2;
            this.lblToTitle.Text = "Scanning To:";
            // 
            // btnGo
            // 
            this.btnGo.Location = new System.Drawing.Point(314, 75);
            this.btnGo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(122, 46);
            this.btnGo.TabIndex = 4;
            this.btnGo.Text = "Go";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 76);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Files Found:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 107);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Files Transferred:";
            // 
            // lblFileFoundCount
            // 
            this.lblFileFoundCount.AutoSize = true;
            this.lblFileFoundCount.Location = new System.Drawing.Point(91, 76);
            this.lblFileFoundCount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFileFoundCount.Name = "lblFileFoundCount";
            this.lblFileFoundCount.Size = new System.Drawing.Size(56, 13);
            this.lblFileFoundCount.TabIndex = 7;
            this.lblFileFoundCount.Text = "Qty Found";
            // 
            // lblQtyTransferred
            // 
            this.lblQtyTransferred.AutoSize = true;
            this.lblQtyTransferred.Location = new System.Drawing.Point(119, 107);
            this.lblQtyTransferred.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblQtyTransferred.Name = "lblQtyTransferred";
            this.lblQtyTransferred.Size = new System.Drawing.Size(80, 13);
            this.lblQtyTransferred.TabIndex = 8;
            this.lblQtyTransferred.Text = "Qty Transferred";
            // 
            // maintenanceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 132);
            this.Controls.Add(this.lblQtyTransferred);
            this.Controls.Add(this.lblFileFoundCount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnGo);
            this.Controls.Add(this.lblToValue);
            this.Controls.Add(this.lblToTitle);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "maintenanceForm";
            this.Text = "DOCSCAN Network Uploader";
            this.Load += new System.EventHandler(this.maintenanceForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lblToValue;
        private System.Windows.Forms.Label lblToTitle;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblFileFoundCount;
        private System.Windows.Forms.Label lblQtyTransferred;
    }
}