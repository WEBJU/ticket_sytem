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
    public partial class UserInputSoft : Form
    {
        public UserInputSoft()
        {
            InitializeComponent();
        }
        workticketclass c = new workticketclass();
        public void clear()
        {
            txtBoxTicketNo.Text = "";
            txtBoxEmployeeIDNo.Text = "";
            txtBoxFull_Names.Text = "";
            cmbBoxDepartment.Text = "";
            issuestxb.Text = "";
            txtBoxIssue_Description.Text = "";
            dateTimePicker1.Text = "";
            txtBoxOther_Comlements.Text = "";
        }
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Do you want to exit?", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
            }
            else if (dialog == DialogResult.No)
            {
                //remain in the application
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
           /* //get the value from the input field
            c.EmployeeIDNo = txtBoxEmployeeIDNo.Text;
            c.Full_Names = txtBoxFull_Names.Text;
            c.Department = cmbBoxDepartment.Text;
            c.Issues = issuestxb.Text;
            c.Issue_Description = txtBoxIssue_Description.Text;
            c.Date = Convert.ToDateTime(dateTimePicker1.Text);
            c.Other_Complements = txtBoxOther_Comlements.Text;

            //inserting data to database
            bool success = c.insertNT(c);
            if (success == true)
            {
                if (txtBoxEmployeeIDNo.Text == "")
                {
                    MessageBox.Show("Please input your ID Number", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

                else if (txtBoxFull_Names.Text == "")
                {
                    MessageBox.Show("Names cannot be left blank!", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (cmbBoxDepartment.Text == "")
                {
                    MessageBox.Show("You have to choose your Department!", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (issuestxb.Text == "")
                {
                    MessageBox.Show("This sshould be Networking issues(eg. internet)", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (txtBoxIssue_Description.Text == "")
                {
                    MessageBox.Show("Give a brief Description of your Issue!", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {


                    MessageBox.Show("Your details have been submitted succesfully");
                    //call clear method here
                    clear();
                }
            }
            else { MessageBox.Show("Failed to input your request. Try again"); }*/
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Homepage hm = new Homepage();
            hm.Show();
            Hide();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            clear();
        }
    }
}
