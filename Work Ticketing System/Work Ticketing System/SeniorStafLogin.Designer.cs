namespace Work_Ticketing_System
{
    partial class SeniorStafLogin
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
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.checkBoxShow = new System.Windows.Forms.CheckBox();
            this.txtBoxsecuritycode = new System.Windows.Forms.TextBox();
            this.txtBoxstaffnames = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblStuff_Name = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Salmon;
            this.button2.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(147, 211);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(115, 36);
            this.button2.TabIndex = 43;
            this.button2.Text = "BACK";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.OliveDrab;
            this.button1.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(343, 211);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 36);
            this.button1.TabIndex = 42;
            this.button1.Text = "SUBMIT";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // checkBoxShow
            // 
            this.checkBoxShow.AutoSize = true;
            this.checkBoxShow.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxShow.Location = new System.Drawing.Point(490, 151);
            this.checkBoxShow.Name = "checkBoxShow";
            this.checkBoxShow.Size = new System.Drawing.Size(65, 22);
            this.checkBoxShow.TabIndex = 41;
            this.checkBoxShow.Text = "Show";
            this.checkBoxShow.UseVisualStyleBackColor = true;
            this.checkBoxShow.CheckedChanged += new System.EventHandler(this.checkBoxShow_CheckedChanged);
            // 
            // txtBoxsecuritycode
            // 
            this.txtBoxsecuritycode.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxsecuritycode.Location = new System.Drawing.Point(147, 145);
            this.txtBoxsecuritycode.Name = "txtBoxsecuritycode";
            this.txtBoxsecuritycode.Size = new System.Drawing.Size(326, 28);
            this.txtBoxsecuritycode.TabIndex = 40;
            this.txtBoxsecuritycode.UseSystemPasswordChar = true;
            // 
            // txtBoxstaffnames
            // 
            this.txtBoxstaffnames.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxstaffnames.Location = new System.Drawing.Point(147, 88);
            this.txtBoxstaffnames.Name = "txtBoxstaffnames";
            this.txtBoxstaffnames.Size = new System.Drawing.Size(326, 28);
            this.txtBoxstaffnames.TabIndex = 39;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.ForeColor = System.Drawing.Color.Black;
            this.lblPassword.Location = new System.Drawing.Point(32, 145);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblPassword.Size = new System.Drawing.Size(101, 18);
            this.lblPassword.TabIndex = 38;
            this.lblPassword.Text = "SecurityCode";
            // 
            // lblStuff_Name
            // 
            this.lblStuff_Name.AutoSize = true;
            this.lblStuff_Name.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStuff_Name.ForeColor = System.Drawing.Color.Black;
            this.lblStuff_Name.Location = new System.Drawing.Point(32, 98);
            this.lblStuff_Name.Name = "lblStuff_Name";
            this.lblStuff_Name.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblStuff_Name.Size = new System.Drawing.Size(92, 18);
            this.lblStuff_Name.TabIndex = 37;
            this.lblStuff_Name.Text = "StaffNames";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SteelBlue;
            this.label1.Location = new System.Drawing.Point(142, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(414, 29);
            this.label1.TabIndex = 36;
            this.label1.Text = "SENIOR STAFF SIGNUP PAGE";
            // 
            // SeniorStafLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 255);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.checkBoxShow);
            this.Controls.Add(this.txtBoxsecuritycode);
            this.Controls.Add(this.txtBoxstaffnames);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblStuff_Name);
            this.Controls.Add(this.label1);
            this.Name = "SeniorStafLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SeniorStafSignup";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox checkBoxShow;
        public System.Windows.Forms.TextBox txtBoxsecuritycode;
        public System.Windows.Forms.TextBox txtBoxstaffnames;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblStuff_Name;
        private System.Windows.Forms.Label label1;
    }
}