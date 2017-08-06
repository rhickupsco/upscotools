namespace DocScanWO
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.lblToTitle = new System.Windows.Forms.Label();
            this.lblToValue = new System.Windows.Forms.Label();
            this.lblAsTitle = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblNumDescValue = new System.Windows.Forms.Label();
            this.lblItemNum = new System.Windows.Forms.Label();
            this.lblMakeForValue = new System.Windows.Forms.Label();
            this.lblActualValue = new System.Windows.Forms.Label();
            this.lblStdValue = new System.Windows.Forms.Label();
            this.lblMakeFor = new System.Windows.Forms.Label();
            this.lblActualHours = new System.Windows.Forms.Label();
            this.lblStdHours = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblWOShipDate = new System.Windows.Forms.Label();
            this.lblWONumber = new System.Windows.Forms.Label();
            this.lblcustomerName = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label5 = new System.Windows.Forms.Label();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblToTitle
            // 
            this.lblToTitle.AutoSize = true;
            this.lblToTitle.Location = new System.Drawing.Point(9, 33);
            this.lblToTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblToTitle.Name = "lblToTitle";
            this.lblToTitle.Size = new System.Drawing.Size(71, 13);
            this.lblToTitle.TabIndex = 0;
            this.lblToTitle.Text = "Scanning To:";
            // 
            // lblToValue
            // 
            this.lblToValue.AutoSize = true;
            this.lblToValue.Location = new System.Drawing.Point(90, 33);
            this.lblToValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblToValue.Name = "lblToValue";
            this.lblToValue.Size = new System.Drawing.Size(100, 13);
            this.lblToValue.TabIndex = 1;
            this.lblToValue.Text = "scan file destination";
            // 
            // lblAsTitle
            // 
            this.lblAsTitle.AutoSize = true;
            this.lblAsTitle.Location = new System.Drawing.Point(10, 7);
            this.lblAsTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAsTitle.Name = "lblAsTitle";
            this.lblAsTitle.Size = new System.Drawing.Size(70, 13);
            this.lblAsTitle.TabIndex = 4;
            this.lblAsTitle.Text = "Scanning As:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(90, 7);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(212, 21);
            this.comboBox1.TabIndex = 5;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblStatus);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox1.Location = new System.Drawing.Point(10, 94);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(595, 60);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Document Status";
            // 
            // lblStatus
            // 
            this.lblStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblStatus.AutoSize = true;
            this.lblStatus.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(10, 15);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Padding = new System.Windows.Forms.Padding(30, 8, 8, 8);
            this.lblStatus.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblStatus.Size = new System.Drawing.Size(222, 42);
            this.lblStatus.TabIndex = 0;
            this.lblStatus.Text = "File Not Received";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 60);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(593, 29);
            this.button1.TabIndex = 7;
            this.button1.Text = "Enable Monitoring";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.tableLayoutPanel1);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.groupBox2.Location = new System.Drawing.Point(3, 170);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(688, 286);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sales Order Data";
            this.groupBox2.Visible = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(5, 257);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(679, 24);
            this.button2.TabIndex = 2;
            this.button2.Text = "CANCEL";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 43.94464F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 56.05536F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 97F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 177F));
            this.tableLayoutPanel1.Controls.Add(this.lblNumDescValue, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblItemNum, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblMakeForValue, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblActualValue, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblStdValue, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblMakeFor, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblActualHours, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblStdHours, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnSave, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblWOShipDate, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblWONumber, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblcustomerName, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(5, 13);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40.38462F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 59.61538F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 94F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(679, 245);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // lblNumDescValue
            // 
            this.lblNumDescValue.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.lblNumDescValue, 3);
            this.lblNumDescValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNumDescValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumDescValue.Location = new System.Drawing.Point(180, 199);
            this.lblNumDescValue.Name = "lblNumDescValue";
            this.lblNumDescValue.Size = new System.Drawing.Size(496, 46);
            this.lblNumDescValue.TabIndex = 18;
            this.lblNumDescValue.Text = "[itemPlaceholder]";
            // 
            // lblItemNum
            // 
            this.lblItemNum.AutoSize = true;
            this.lblItemNum.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblItemNum.Location = new System.Drawing.Point(2, 199);
            this.lblItemNum.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblItemNum.Name = "lblItemNum";
            this.lblItemNum.Padding = new System.Windows.Forms.Padding(4);
            this.lblItemNum.Size = new System.Drawing.Size(173, 21);
            this.lblItemNum.TabIndex = 17;
            this.lblItemNum.Text = "Item Number and description";
            // 
            // lblMakeForValue
            // 
            this.lblMakeForValue.AutoSize = true;
            this.lblMakeForValue.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblMakeForValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMakeForValue.Location = new System.Drawing.Point(180, 105);
            this.lblMakeForValue.Name = "lblMakeForValue";
            this.lblMakeForValue.Size = new System.Drawing.Size(221, 24);
            this.lblMakeForValue.TabIndex = 16;
            this.lblMakeForValue.Text = "[wonumplaceholder]";
            // 
            // lblActualValue
            // 
            this.lblActualValue.AutoSize = true;
            this.lblActualValue.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblActualValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActualValue.Location = new System.Drawing.Point(504, 30);
            this.lblActualValue.Name = "lblActualValue";
            this.lblActualValue.Size = new System.Drawing.Size(172, 24);
            this.lblActualValue.TabIndex = 15;
            this.lblActualValue.Text = "[actLOPlaceholder]";
            // 
            // lblStdValue
            // 
            this.lblStdValue.AutoSize = true;
            this.lblStdValue.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblStdValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStdValue.Location = new System.Drawing.Point(504, 0);
            this.lblStdValue.Name = "lblStdValue";
            this.lblStdValue.Size = new System.Drawing.Size(172, 24);
            this.lblStdValue.TabIndex = 14;
            this.lblStdValue.Text = "[stdLOPlaceholder]";
            // 
            // lblMakeFor
            // 
            this.lblMakeFor.AutoSize = true;
            this.lblMakeFor.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblMakeFor.Location = new System.Drawing.Point(2, 105);
            this.lblMakeFor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMakeFor.Name = "lblMakeFor";
            this.lblMakeFor.Padding = new System.Windows.Forms.Padding(4);
            this.lblMakeFor.Size = new System.Drawing.Size(173, 21);
            this.lblMakeFor.TabIndex = 13;
            this.lblMakeFor.Text = "Make For Sales Order Number";
            // 
            // lblActualHours
            // 
            this.lblActualHours.AutoSize = true;
            this.lblActualHours.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblActualHours.Location = new System.Drawing.Point(406, 30);
            this.lblActualHours.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblActualHours.Name = "lblActualHours";
            this.lblActualHours.Padding = new System.Windows.Forms.Padding(4);
            this.lblActualHours.Size = new System.Drawing.Size(93, 34);
            this.lblActualHours.TabIndex = 12;
            this.lblActualHours.Text = "Actual Labor Hours";
            // 
            // lblStdHours
            // 
            this.lblStdHours.AutoSize = true;
            this.lblStdHours.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblStdHours.Location = new System.Drawing.Point(406, 0);
            this.lblStdHours.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStdHours.Name = "lblStdHours";
            this.lblStdHours.Padding = new System.Windows.Forms.Padding(4);
            this.lblStdHours.Size = new System.Drawing.Size(93, 30);
            this.lblStdHours.TabIndex = 11;
            this.lblStdHours.Text = "Standard Labor Hours";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Location = new System.Drawing.Point(2, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(4);
            this.label2.Size = new System.Drawing.Size(173, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "Work Order Number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Location = new System.Drawing.Point(2, 30);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(4);
            this.label3.Size = new System.Drawing.Size(173, 21);
            this.label3.TabIndex = 1;
            this.label3.Text = "Customer Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.Location = new System.Drawing.Point(2, 74);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(4);
            this.label4.Size = new System.Drawing.Size(173, 21);
            this.label4.TabIndex = 2;
            this.label4.Text = "Work Order ShipDate";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.LawnGreen;
            this.tableLayoutPanel1.SetColumnSpan(this.btnSave, 2);
            this.btnSave.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(406, 76);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2);
            this.btnSave.Name = "btnSave";
            this.tableLayoutPanel1.SetRowSpan(this.btnSave, 2);
            this.btnSave.Size = new System.Drawing.Size(271, 121);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click_1);
            // 
            // lblWOShipDate
            // 
            this.lblWOShipDate.AutoSize = true;
            this.lblWOShipDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblWOShipDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWOShipDate.Location = new System.Drawing.Point(179, 74);
            this.lblWOShipDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblWOShipDate.Name = "lblWOShipDate";
            this.lblWOShipDate.Size = new System.Drawing.Size(223, 31);
            this.lblWOShipDate.TabIndex = 7;
            this.lblWOShipDate.Text = "[sdplacedholder]";
            this.lblWOShipDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblWONumber
            // 
            this.lblWONumber.AutoSize = true;
            this.lblWONumber.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblWONumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWONumber.Location = new System.Drawing.Point(180, 0);
            this.lblWONumber.Name = "lblWONumber";
            this.lblWONumber.Size = new System.Drawing.Size(221, 24);
            this.lblWONumber.TabIndex = 8;
            this.lblWONumber.Text = "[wonumplaceholder]";
            // 
            // lblcustomerName
            // 
            this.lblcustomerName.AutoEllipsis = true;
            this.lblcustomerName.AutoSize = true;
            this.lblcustomerName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblcustomerName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblcustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcustomerName.Location = new System.Drawing.Point(180, 30);
            this.lblcustomerName.Name = "lblcustomerName";
            this.lblcustomerName.Size = new System.Drawing.Size(221, 44);
            this.lblcustomerName.TabIndex = 9;
            this.lblcustomerName.Text = "[cnumplaceholder]";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.linkLabel1.Location = new System.Drawing.Point(610, 0);
            this.linkLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Padding = new System.Windows.Forms.Padding(8);
            this.linkLabel1.Size = new System.Drawing.Size(81, 29);
            this.linkLabel1.TabIndex = 9;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Search Tool";
            this.linkLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(610, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "________";
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Location = new System.Drawing.Point(549, 7);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(16, 13);
            this.linkLabel2.TabIndex = 11;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "M";
            this.linkLabel2.Visible = false;
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 469);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lblAsTitle);
            this.Controls.Add(this.lblToValue);
            this.Controls.Add(this.lblToTitle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmMain";
            this.Text = "Paperless Scan Helper";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblToTitle;
        private System.Windows.Forms.Label lblToValue;
        private System.Windows.Forms.Label lblAsTitle;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblWOShipDate;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label lblWONumber;
        private System.Windows.Forms.Label lblcustomerName;
        private System.Windows.Forms.Label lblMakeForValue;
        private System.Windows.Forms.Label lblActualValue;
        private System.Windows.Forms.Label lblStdValue;
        private System.Windows.Forms.Label lblMakeFor;
        private System.Windows.Forms.Label lblActualHours;
        private System.Windows.Forms.Label lblStdHours;
        private System.Windows.Forms.Label lblNumDescValue;
        private System.Windows.Forms.Label lblItemNum;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.LinkLabel linkLabel2;
    }
}

