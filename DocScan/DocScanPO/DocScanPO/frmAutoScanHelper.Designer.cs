namespace DocScanSO
{
    partial class frmAutoScanHelper
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAutoScanHelper));
            this.label6 = new System.Windows.Forms.Label();
            this.txtWorkOrderToDelete = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.flpRecentlyProcessed = new System.Windows.Forms.FlowLayoutPanel();
            this.lblQtyTransferred = new System.Windows.Forms.Label();
            this.lblFileFoundCount = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblToValue = new System.Windows.Forms.Label();
            this.lblToTitle = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoEllipsis = true;
            this.label6.Location = new System.Drawing.Point(17, 511);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(172, 62);
            this.label6.TabIndex = 26;
            this.label6.Text = "Enter the Purchase Order Number to delete from system if you make a mistake";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtWorkOrderToDelete
            // 
            this.txtWorkOrderToDelete.Location = new System.Drawing.Point(196, 513);
            this.txtWorkOrderToDelete.Name = "txtWorkOrderToDelete";
            this.txtWorkOrderToDelete.Size = new System.Drawing.Size(232, 20);
            this.txtWorkOrderToDelete.TabIndex = 25;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 169);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(318, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "You can click one of the buttons below to delete it from DocScan ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(19, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(259, 24);
            this.label4.TabIndex = 23;
            this.label4.Text = "Recently Processed Scans";
            // 
            // flpRecentlyProcessed
            // 
            this.flpRecentlyProcessed.BackColor = System.Drawing.Color.White;
            this.flpRecentlyProcessed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flpRecentlyProcessed.Font = new System.Drawing.Font("Cacophony Loud", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flpRecentlyProcessed.Location = new System.Drawing.Point(20, 188);
            this.flpRecentlyProcessed.Name = "flpRecentlyProcessed";
            this.flpRecentlyProcessed.Size = new System.Drawing.Size(409, 315);
            this.flpRecentlyProcessed.TabIndex = 22;
            // 
            // lblQtyTransferred
            // 
            this.lblQtyTransferred.AutoSize = true;
            this.lblQtyTransferred.Location = new System.Drawing.Point(126, 110);
            this.lblQtyTransferred.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblQtyTransferred.Name = "lblQtyTransferred";
            this.lblQtyTransferred.Size = new System.Drawing.Size(80, 13);
            this.lblQtyTransferred.TabIndex = 21;
            this.lblQtyTransferred.Text = "Qty Transferred";
            // 
            // lblFileFoundCount
            // 
            this.lblFileFoundCount.AutoSize = true;
            this.lblFileFoundCount.Location = new System.Drawing.Point(98, 79);
            this.lblFileFoundCount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFileFoundCount.Name = "lblFileFoundCount";
            this.lblFileFoundCount.Size = new System.Drawing.Size(56, 13);
            this.lblFileFoundCount.TabIndex = 20;
            this.lblFileFoundCount.Text = "Qty Found";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 110);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Files Transferred:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 79);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Files Found:";
            // 
            // lblToValue
            // 
            this.lblToValue.AutoSize = true;
            this.lblToValue.Location = new System.Drawing.Point(98, 42);
            this.lblToValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblToValue.Name = "lblToValue";
            this.lblToValue.Size = new System.Drawing.Size(100, 13);
            this.lblToValue.TabIndex = 17;
            this.lblToValue.Text = "scan file destination";
            // 
            // lblToTitle
            // 
            this.lblToTitle.AutoSize = true;
            this.lblToTitle.Location = new System.Drawing.Point(17, 42);
            this.lblToTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblToTitle.Name = "lblToTitle";
            this.lblToTitle.Size = new System.Drawing.Size(71, 13);
            this.lblToTitle.TabIndex = 16;
            this.lblToTitle.Text = "Scanning To:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(183, 11);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(244, 21);
            this.comboBox1.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Select Source Files Location";
            // 
            // btnDelete
            // 
            this.btnDelete.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnDelete.FlatAppearance.BorderSize = 3;
            this.btnDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnDelete.Location = new System.Drawing.Point(196, 539);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(233, 40);
            this.btnDelete.TabIndex = 27;
            this.btnDelete.Text = "Delete From DocScan";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // frmAutoScanHelper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 584);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtWorkOrderToDelete);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.flpRecentlyProcessed);
            this.Controls.Add(this.lblQtyTransferred);
            this.Controls.Add(this.lblFileFoundCount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblToValue);
            this.Controls.Add(this.lblToTitle);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAutoScanHelper";
            this.Text = "DocScan Helper";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtWorkOrderToDelete;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.FlowLayoutPanel flpRecentlyProcessed;
        private System.Windows.Forms.Label lblQtyTransferred;
        private System.Windows.Forms.Label lblFileFoundCount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblToValue;
        private System.Windows.Forms.Label lblToTitle;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDelete;
    }
}

