namespace Work_Ticketing_System
{
    partial class UserInputSoft
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserInputSoft));
            this.btnSubmit = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.txtBoxTicketNo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBoxEmployeeIDNo = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.HardwGV = new System.Windows.Forms.DataGridView();
            this.lblClockIn_Number = new System.Windows.Forms.Label();
            this.cmbBoxDepartment = new System.Windows.Forms.ComboBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.txtBoxOther_Comlements = new System.Windows.Forms.TextBox();
            this.lblOther = new System.Windows.Forms.Label();
            this.txtBoxIssue_Description = new System.Windows.Forms.TextBox();
            this.txtBoxFull_Names = new System.Windows.Forms.TextBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblIssues = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblDapartment = new System.Windows.Forms.Label();
            this.lblFullNames = new System.Windows.Forms.Label();
            this.issuestxb = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HardwGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.SandyBrown;
            this.btnSubmit.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold);
            this.btnSubmit.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnSubmit.Location = new System.Drawing.Point(1130, 10);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(131, 41);
            this.btnSubmit.TabIndex = 111;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox1.Location = new System.Drawing.Point(854, 76);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(395, 456);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 134;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.Controls.Add(this.btnUpdate);
            this.panel2.Controls.Add(this.btnEdit);
            this.panel2.Location = new System.Drawing.Point(215, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(630, 41);
            this.panel2.TabIndex = 133;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Tomato;
            this.btnUpdate.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold);
            this.btnUpdate.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnUpdate.Location = new System.Drawing.Point(266, 3);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(133, 36);
            this.btnUpdate.TabIndex = 20;
            this.btnUpdate.Text = "Back";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.OrangeRed;
            this.btnEdit.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold);
            this.btnEdit.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnEdit.Location = new System.Drawing.Point(29, 3);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(112, 36);
            this.btnEdit.TabIndex = 19;
            this.btnEdit.Text = "Clear";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // txtBoxTicketNo
            // 
            this.txtBoxTicketNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.txtBoxTicketNo.HideSelection = false;
            this.txtBoxTicketNo.Location = new System.Drawing.Point(215, 39);
            this.txtBoxTicketNo.Name = "txtBoxTicketNo";
            this.txtBoxTicketNo.Size = new System.Drawing.Size(531, 24);
            this.txtBoxTicketNo.TabIndex = 132;
            this.txtBoxTicketNo.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 14.25F);
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(5, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 21);
            this.label1.TabIndex = 131;
            this.label1.Text = "Ticket_No";
            this.label1.Visible = false;
            // 
            // txtBoxEmployeeIDNo
            // 
            this.txtBoxEmployeeIDNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.txtBoxEmployeeIDNo.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtBoxEmployeeIDNo.Location = new System.Drawing.Point(217, 91);
            this.txtBoxEmployeeIDNo.Name = "txtBoxEmployeeIDNo";
            this.txtBoxEmployeeIDNo.Size = new System.Drawing.Size(531, 24);
            this.txtBoxEmployeeIDNo.TabIndex = 130;
            this.txtBoxEmployeeIDNo.Text = "Should be 4 digits.eg 1212";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "yyyy-MM-dd";
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(215, 406);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(531, 24);
            this.dateTimePicker1.TabIndex = 129;
            // 
            // HardwGV
            // 
            this.HardwGV.AllowUserToOrderColumns = true;
            this.HardwGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.HardwGV.Location = new System.Drawing.Point(1255, 123);
            this.HardwGV.Name = "HardwGV";
            this.HardwGV.Size = new System.Drawing.Size(65, 185);
            this.HardwGV.TabIndex = 128;
            this.HardwGV.Visible = false;
            // 
            // lblClockIn_Number
            // 
            this.lblClockIn_Number.AutoSize = true;
            this.lblClockIn_Number.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblClockIn_Number.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblClockIn_Number.Location = new System.Drawing.Point(7, 91);
            this.lblClockIn_Number.Name = "lblClockIn_Number";
            this.lblClockIn_Number.Size = new System.Drawing.Size(142, 21);
            this.lblClockIn_Number.TabIndex = 127;
            this.lblClockIn_Number.Text = "EmployeeIDNo";
            // 
            // cmbBoxDepartment
            // 
            this.cmbBoxDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.cmbBoxDepartment.FormattingEnabled = true;
            this.cmbBoxDepartment.Items.AddRange(new object[] {
            "BTC ",
            "ADMIN",
            "AGRO",
            "DETERGENTS",
            "SULPHONATION",
            "ECO LAB"});
            this.cmbBoxDepartment.Location = new System.Drawing.Point(217, 192);
            this.cmbBoxDepartment.Name = "cmbBoxDepartment";
            this.cmbBoxDepartment.Size = new System.Drawing.Size(531, 26);
            this.cmbBoxDepartment.TabIndex = 126;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox6.Location = new System.Drawing.Point(-15, 9);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(171, 65);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 125;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox4.Location = new System.Drawing.Point(1153, 9);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(43, 23);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 124;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox3.Location = new System.Drawing.Point(1255, 9);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(44, 23);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 123;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox2.Location = new System.Drawing.Point(1202, 9);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(47, 23);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 122;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // txtBoxOther_Comlements
            // 
            this.txtBoxOther_Comlements.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.txtBoxOther_Comlements.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtBoxOther_Comlements.Location = new System.Drawing.Point(215, 543);
            this.txtBoxOther_Comlements.Multiline = true;
            this.txtBoxOther_Comlements.Name = "txtBoxOther_Comlements";
            this.txtBoxOther_Comlements.Size = new System.Drawing.Size(531, 65);
            this.txtBoxOther_Comlements.TabIndex = 121;
            this.txtBoxOther_Comlements.Text = "If non you can leave blank";
            // 
            // lblOther
            // 
            this.lblOther.AutoSize = true;
            this.lblOther.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblOther.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblOther.Location = new System.Drawing.Point(5, 542);
            this.lblOther.Name = "lblOther";
            this.lblOther.Size = new System.Drawing.Size(186, 21);
            this.lblOther.TabIndex = 120;
            this.lblOther.Text = "Other_Complements";
            // 
            // txtBoxIssue_Description
            // 
            this.txtBoxIssue_Description.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.txtBoxIssue_Description.Location = new System.Drawing.Point(215, 288);
            this.txtBoxIssue_Description.Multiline = true;
            this.txtBoxIssue_Description.Name = "txtBoxIssue_Description";
            this.txtBoxIssue_Description.Size = new System.Drawing.Size(531, 76);
            this.txtBoxIssue_Description.TabIndex = 118;
            // 
            // txtBoxFull_Names
            // 
            this.txtBoxFull_Names.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.txtBoxFull_Names.Location = new System.Drawing.Point(217, 147);
            this.txtBoxFull_Names.Name = "txtBoxFull_Names";
            this.txtBoxFull_Names.Size = new System.Drawing.Size(531, 24);
            this.txtBoxFull_Names.TabIndex = 117;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblDate.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblDate.Location = new System.Drawing.Point(5, 406);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(51, 21);
            this.lblDate.TabIndex = 116;
            this.lblDate.Text = "Date";
            // 
            // lblIssues
            // 
            this.lblIssues.AutoSize = true;
            this.lblIssues.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblIssues.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblIssues.Location = new System.Drawing.Point(5, 242);
            this.lblIssues.Name = "lblIssues";
            this.lblIssues.Size = new System.Drawing.Size(63, 21);
            this.lblIssues.TabIndex = 114;
            this.lblIssues.Text = "Issues";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblDescription.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblDescription.Location = new System.Drawing.Point(5, 308);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(171, 21);
            this.lblDescription.TabIndex = 115;
            this.lblDescription.Text = "Issue_Description";
            // 
            // lblDapartment
            // 
            this.lblDapartment.AutoSize = true;
            this.lblDapartment.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblDapartment.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblDapartment.Location = new System.Drawing.Point(7, 190);
            this.lblDapartment.Name = "lblDapartment";
            this.lblDapartment.Size = new System.Drawing.Size(111, 21);
            this.lblDapartment.TabIndex = 113;
            this.lblDapartment.Text = "Department";
            // 
            // lblFullNames
            // 
            this.lblFullNames.AutoSize = true;
            this.lblFullNames.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblFullNames.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblFullNames.Location = new System.Drawing.Point(7, 150);
            this.lblFullNames.Name = "lblFullNames";
            this.lblFullNames.Size = new System.Drawing.Size(119, 21);
            this.lblFullNames.TabIndex = 112;
            this.lblFullNames.Text = "Full_Names";
            // 
            // issuestxb
            // 
            this.issuestxb.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.issuestxb.Location = new System.Drawing.Point(217, 239);
            this.issuestxb.Name = "issuestxb";
            this.issuestxb.Size = new System.Drawing.Size(531, 24);
            this.issuestxb.TabIndex = 136;
            this.issuestxb.Text = "Networking issues(eg. internet)";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.btnSubmit);
            this.panel1.Location = new System.Drawing.Point(0, 614);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1316, 51);
            this.panel1.TabIndex = 137;
            // 
            // UserInputSoft
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1304, 664);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.issuestxb);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtBoxTicketNo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBoxEmployeeIDNo);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.HardwGV);
            this.Controls.Add(this.lblClockIn_Number);
            this.Controls.Add(this.cmbBoxDepartment);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.txtBoxOther_Comlements);
            this.Controls.Add(this.lblOther);
            this.Controls.Add(this.txtBoxIssue_Description);
            this.Controls.Add(this.txtBoxFull_Names);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblIssues);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblDapartment);
            this.Controls.Add(this.lblFullNames);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UserInputSoft";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UserInputSoft";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.HardwGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnEdit;
        public System.Windows.Forms.TextBox txtBoxTicketNo;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtBoxEmployeeIDNo;
        public System.Windows.Forms.DateTimePicker dateTimePicker1;
        public System.Windows.Forms.DataGridView HardwGV;
        private System.Windows.Forms.Label lblClockIn_Number;
        public System.Windows.Forms.ComboBox cmbBoxDepartment;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        public System.Windows.Forms.TextBox txtBoxOther_Comlements;
        private System.Windows.Forms.Label lblOther;
        public System.Windows.Forms.TextBox txtBoxIssue_Description;
        public System.Windows.Forms.TextBox txtBoxFull_Names;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblIssues;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblDapartment;
        private System.Windows.Forms.Label lblFullNames;
        public System.Windows.Forms.TextBox issuestxb;
        private System.Windows.Forms.Panel panel1;
    }
}