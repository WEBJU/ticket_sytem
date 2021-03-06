﻿namespace Work_Ticketing_System
{
    partial class HardwIssues
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
            this.HdGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employee_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comments = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.HdGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // HdGridView
            // 
            this.HdGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.HdGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.HdGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.employee_name,
            this.description,
            this.comments,
            this.status});
            this.HdGridView.Location = new System.Drawing.Point(12, 54);
            this.HdGridView.Name = "HdGridView";
            this.HdGridView.Size = new System.Drawing.Size(897, 269);
            this.HdGridView.TabIndex = 35;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.label1.Location = new System.Drawing.Point(244, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(313, 29);
            this.label1.TabIndex = 34;
            this.label1.Text = "Manage Assigned Tickets";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(254)))));
            this.button4.Location = new System.Drawing.Point(12, 9);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(114, 35);
            this.button4.TabIndex = 33;
            this.button4.Text = "Logout";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Green;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.button5.Location = new System.Drawing.Point(421, 364);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(148, 35);
            this.button5.TabIndex = 32;
            this.button5.Text = "Update Status";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(217, 364);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(198, 35);
            this.textBox1.TabIndex = 36;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(254)))));
            this.label2.Location = new System.Drawing.Point(61, 367);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 25);
            this.label2.TabIndex = 37;
            this.label2.Text = "Ticket Status";
            // 
            // Id
            // 
            this.Id.HeaderText = "#";
            this.Id.Name = "Id";
            // 
            // employee_name
            // 
            this.employee_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.employee_name.HeaderText = "Employee Name";
            this.employee_name.Name = "employee_name";
            // 
            // description
            // 
            this.description.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.description.HeaderText = "Ticket Description";
            this.description.Name = "description";
            // 
            // comments
            // 
            this.comments.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.comments.HeaderText = "Employee Comments";
            this.comments.Name = "comments";
            // 
            // status
            // 
            this.status.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.status.HeaderText = "Ticket Status";
            this.status.Name = "status";
            // 
            // HardwIssues
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(919, 499);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.HdGridView);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HardwIssues";
            this.Text = "HardwIssues";
            this.Load += new System.EventHandler(this.HardwIssues_Load);
            ((System.ComponentModel.ISupportInitialize)(this.HdGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.DataGridView HdGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn employee_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn description;
        private System.Windows.Forms.DataGridViewTextBoxColumn comments;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
        private System.Windows.Forms.Label label2;
    }
}