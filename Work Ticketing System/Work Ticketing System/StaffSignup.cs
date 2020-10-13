using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Work_Ticketing_System.class_folder;

namespace Work_Ticketing_System
{
    public partial class StaffSignup : Form
    {
        public StaffSignup()
        {
            InitializeComponent();
        }
        workticketclass c = new workticketclass();
        public void clear()
        {
            txtEmail.Text = "";
            txtDepartment.Text = "";
            txtUsername.Text = "";
            //cmbRole
            txtBoxNames.Text = "";
            cmbExpertise.Text = "";
            txtBoxPasscode.Text = "";
        }
        private void button1_Click(object sender, EventArgs e)
        {
             c.FullName = txtBoxNames.Text;
             c.Email = txtEmail.Text;
             c.Department = txtDepartment.Text;
             c.username = txtUsername.Text;
             c.UserRole = cmbRole.Text;
             c.Expertise = cmbExpertise.Text;
             c.Passcode = txtBoxPasscode.Text;

             c.addStaff(c);
                 if (txtBoxNames.Text == "")
                 {
                     MessageBox.Show("Please input Two Names", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                 }
                 else if (cmbExpertise.Text == "")
                 {
                     MessageBox.Show("Please insert your Expertise area!", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                 }

                 else if (txtBoxPasscode.Text == "")
                 {
                     MessageBox.Show("Password cannot be left blank!", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                 }

                 else
                 {

                     //load data to database
                     DataTable dt = c.select();
                     MessageBox.Show("User Account Created Successfully!!");
                     //call clear method here
                     clear();
                 }
         
           
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UsersList list = new UsersList();
            list.Show();
            this.Hide();
        }

        private void checkBoxShow_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxShow.Checked)
            {

                txtBoxPasscode.UseSystemPasswordChar = false;
            }
            else
            {
                txtBoxPasscode.UseSystemPasswordChar = true;
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
