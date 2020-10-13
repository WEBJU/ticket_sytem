namespace Work_Ticketing_System
{
    partial class UsserInputForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UsserInputForm));
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnback = new System.Windows.Forms.Button();
            this.txtBoxTicketNo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBoxEmployeeIDNo = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dgvworkersdata = new System.Windows.Forms.DataGridView();
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.issuestxb = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvworkersdata)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
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
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.SandyBrown;
            this.btnSubmit.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold);
            this.btnSubmit.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnSubmit.Location = new System.Drawing.Point(1139, 0);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(131, 48);
            this.btnSubmit.TabIndex = 61;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightGray;
            this.panel2.Controls.Add(this.btnback);
            this.panel2.Controls.Add(this.btnEdit);
            this.panel2.Location = new System.Drawing.Point(257, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(630, 41);
            this.panel2.TabIndex = 83;
            // 
            // btnback
            // 
            this.btnback.BackColor = System.Drawing.Color.Tomato;
            this.btnback.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold);
            this.btnback.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnback.Location = new System.Drawing.Point(260, 3);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(133, 36);
            this.btnback.TabIndex = 20;
            this.btnback.Text = "Back";
            this.btnback.UseVisualStyleBackColor = false;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // txtBoxTicketNo
            // 
            this.txtBoxTicketNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.txtBoxTicketNo.HideSelection = false;
            this.txtBoxTicketNo.Location = new System.Drawing.Point(237, 36);
            this.txtBoxTicketNo.Name = "txtBoxTicketNo";
            this.txtBoxTicketNo.Size = new System.Drawing.Size(531, 24);
            this.txtBoxTicketNo.TabIndex = 82;
            this.txtBoxTicketNo.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 14.25F);
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(27, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 21);
            this.label1.TabIndex = 81;
            this.label1.Text = "Ticket_No";
            this.label1.Visible = false;
            // 
            // txtBoxEmployeeIDNo
            // 
            this.txtBoxEmployeeIDNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.txtBoxEmployeeIDNo.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtBoxEmployeeIDNo.Location = new System.Drawing.Point(239, 88);
            this.txtBoxEmployeeIDNo.Name = "txtBoxEmployeeIDNo";
            this.txtBoxEmployeeIDNo.Size = new System.Drawing.Size(531, 24);
            this.txtBoxEmployeeIDNo.TabIndex = 80;
            this.txtBoxEmployeeIDNo.Text = "Should be 4 digits.eg 1212";
            this.txtBoxEmployeeIDNo.TextChanged += new System.EventHandler(this.txtBoxEmployeeIDNo_TextChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "yyyy-MM-dd";
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(237, 403);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(531, 24);
            this.dateTimePicker1.TabIndex = 79;
            // 
            // dgvworkersdata
            // 
            this.dgvworkersdata.AllowUserToOrderColumns = true;
            this.dgvworkersdata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvworkersdata.Location = new System.Drawing.Point(1277, 120);
            this.dgvworkersdata.Name = "dgvworkersdata";
            this.dgvworkersdata.Size = new System.Drawing.Size(65, 185);
            this.dgvworkersdata.TabIndex = 78;
            this.dgvworkersdata.Visible = false;
            // 
            // lblClockIn_Number
            // 
            this.lblClockIn_Number.AutoSize = true;
            this.lblClockIn_Number.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblClockIn_Number.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblClockIn_Number.Location = new System.Drawing.Point(29, 88);
            this.lblClockIn_Number.Name = "lblClockIn_Number";
            this.lblClockIn_Number.Size = new System.Drawing.Size(142, 21);
            this.lblClockIn_Number.TabIndex = 77;
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
            this.cmbBoxDepartment.Location = new System.Drawing.Point(239, 189);
            this.cmbBoxDepartment.Name = "cmbBoxDepartment";
            this.cmbBoxDepartment.Size = new System.Drawing.Size(531, 26);
            this.cmbBoxDepartment.TabIndex = 76;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox6.Location = new System.Drawing.Point(7, 6);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(171, 65);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 75;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox4.Location = new System.Drawing.Point(1162, 12);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(43, 23);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 74;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox3.Location = new System.Drawing.Point(1264, 12);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(44, 23);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 73;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox2.Location = new System.Drawing.Point(1211, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(47, 23);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 72;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // txtBoxOther_Comlements
            // 
            this.txtBoxOther_Comlements.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.txtBoxOther_Comlements.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtBoxOther_Comlements.Location = new System.Drawing.Point(237, 540);
            this.txtBoxOther_Comlements.Multiline = true;
            this.txtBoxOther_Comlements.Name = "txtBoxOther_Comlements";
            this.txtBoxOther_Comlements.Size = new System.Drawing.Size(531, 65);
            this.txtBoxOther_Comlements.TabIndex = 71;
            this.txtBoxOther_Comlements.Text = "If non you can leave blank";
            this.txtBoxOther_Comlements.TextChanged += new System.EventHandler(this.txtBoxOther_Comlements_TextChanged);
            // 
            // lblOther
            // 
            this.lblOther.AutoSize = true;
            this.lblOther.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblOther.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblOther.Location = new System.Drawing.Point(27, 539);
            this.lblOther.Name = "lblOther";
            this.lblOther.Size = new System.Drawing.Size(186, 21);
            this.lblOther.TabIndex = 70;
            this.lblOther.Text = "Other_Complements";
            // 
            // txtBoxIssue_Description
            // 
            this.txtBoxIssue_Description.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.txtBoxIssue_Description.Location = new System.Drawing.Point(237, 285);
            this.txtBoxIssue_Description.Multiline = true;
            this.txtBoxIssue_Description.Name = "txtBoxIssue_Description";
            this.txtBoxIssue_Description.Size = new System.Drawing.Size(531, 76);
            this.txtBoxIssue_Description.TabIndex = 68;
            // 
            // txtBoxFull_Names
            // 
            this.txtBoxFull_Names.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.txtBoxFull_Names.Location = new System.Drawing.Point(239, 144);
            this.txtBoxFull_Names.Name = "txtBoxFull_Names";
            this.txtBoxFull_Names.Size = new System.Drawing.Size(531, 24);
            this.txtBoxFull_Names.TabIndex = 67;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblDate.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblDate.Location = new System.Drawing.Point(27, 403);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(51, 21);
            this.lblDate.TabIndex = 66;
            this.lblDate.Text = "Date";
            // 
            // lblIssues
            // 
            this.lblIssues.AutoSize = true;
            this.lblIssues.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblIssues.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblIssues.Location = new System.Drawing.Point(27, 239);
            this.lblIssues.Name = "lblIssues";
            this.lblIssues.Size = new System.Drawing.Size(63, 21);
            this.lblIssues.TabIndex = 64;
            this.lblIssues.Text = "Issues";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblDescription.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblDescription.Location = new System.Drawing.Point(27, 305);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(171, 21);
            this.lblDescription.TabIndex = 65;
            this.lblDescription.Text = "Issue_Description";
            // 
            // lblDapartment
            // 
            this.lblDapartment.AutoSize = true;
            this.lblDapartment.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblDapartment.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblDapartment.Location = new System.Drawing.Point(29, 187);
            this.lblDapartment.Name = "lblDapartment";
            this.lblDapartment.Size = new System.Drawing.Size(111, 21);
            this.lblDapartment.TabIndex = 63;
            this.lblDapartment.Text = "Department";
            // 
            // lblFullNames
            // 
            this.lblFullNames.AutoSize = true;
            this.lblFullNames.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblFullNames.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblFullNames.Location = new System.Drawing.Point(29, 147);
            this.lblFullNames.Name = "lblFullNames";
            this.lblFullNames.Size = new System.Drawing.Size(119, 21);
            this.lblFullNames.TabIndex = 62;
            this.lblFullNames.Text = "Full_Names";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox1.Location = new System.Drawing.Point(876, 73);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(395, 456);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 84;
            this.pictureBox1.TabStop = false;
            // 
            // issuestxb
            // 
            this.issuestxb.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.issuestxb.Location = new System.Drawing.Point(239, 239);
            this.issuestxb.Name = "issuestxb";
            this.issuestxb.Size = new System.Drawing.Size(531, 24);
            this.issuestxb.TabIndex = 86;
            this.issuestxb.Text = "Software issues(SAP, Emails,Login etc)";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.btnSubmit);
            this.panel1.Location = new System.Drawing.Point(1, 656);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1307, 51);
            this.panel1.TabIndex = 109;
            // 
            // UsserInputForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1320, 703);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.issuestxb);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtBoxTicketNo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBoxEmployeeIDNo);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.dgvworkersdata);
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
            this.MinimumSize = new System.Drawing.Size(1320, 703);
            this.Name = "UsserInputForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UsserInputForm";
            this.Load += new System.EventHandler(this.UsserInputForm_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvworkersdata)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnback;
        public System.Windows.Forms.TextBox txtBoxTicketNo;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtBoxEmployeeIDNo;
        public System.Windows.Forms.DateTimePicker dateTimePicker1;
        public System.Windows.Forms.DataGridView dgvworkersdata;
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
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.TextBox issuestxb;
        private System.Windows.Forms.Panel panel1;
    }
}