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
            this.label1.Location = new System.Drawing.Point(13, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select Source Files Location";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(234, 10);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(347, 24);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lblToValue
            // 
            this.lblToValue.AutoSize = true;
            this.lblToValue.Location = new System.Drawing.Point(121, 48);
            this.lblToValue.Name = "lblToValue";
            this.lblToValue.Size = new System.Drawing.Size(133, 17);
            this.lblToValue.TabIndex = 3;
            this.lblToValue.Text = "scan file destination";
            // 
            // lblToTitle
            // 
            this.lblToTitle.AutoSize = true;
            this.lblToTitle.Location = new System.Drawing.Point(13, 48);
            this.lblToTitle.Name = "lblToTitle";
            this.lblToTitle.Size = new System.Drawing.Size(92, 17);
            this.lblToTitle.TabIndex = 2;
            this.lblToTitle.Text = "Scanning To:";
            // 
            // btnGo
            // 
            this.btnGo.Location = new System.Drawing.Point(418, 92);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(163, 57);
            this.btnGo.TabIndex = 4;
            this.btnGo.Text = "Go";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Files Found:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Files Transferred:";
            // 
            // lblFileFoundCount
            // 
            this.lblFileFoundCount.AutoSize = true;
            this.lblFileFoundCount.Location = new System.Drawing.Point(121, 93);
            this.lblFileFoundCount.Name = "lblFileFoundCount";
            this.lblFileFoundCount.Size = new System.Drawing.Size(74, 17);
            this.lblFileFoundCount.TabIndex = 7;
            this.lblFileFoundCount.Text = "Qty Found";
            // 
            // lblQtyTransferred
            // 
            this.lblQtyTransferred.AutoSize = true;
            this.lblQtyTransferred.Location = new System.Drawing.Point(159, 132);
            this.lblQtyTransferred.Name = "lblQtyTransferred";
            this.lblQtyTransferred.Size = new System.Drawing.Size(109, 17);
            this.lblQtyTransferred.TabIndex = 8;
            this.lblQtyTransferred.Text = "Qty Transferred";
            // 
            // maintenanceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 162);
            this.Controls.Add(this.lblQtyTransferred);
            this.Controls.Add(this.lblFileFoundCount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnGo);
            this.Controls.Add(this.lblToValue);
            this.Controls.Add(this.lblToTitle);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Name = "maintenanceForm";
            this.Text = "Mass Upload Maintenance";
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