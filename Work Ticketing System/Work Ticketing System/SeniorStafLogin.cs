using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Work_Ticketing_System.class_folder;

namespace Work_Ticketing_System
{
    public partial class SeniorStafLogin : Form
    {
        public SeniorStafLogin()
        {
            InitializeComponent();
        }
        static string myconnstrng = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;
        workticketclass c = new workticketclass();
        public void clear()
        {
            txtBoxstaffnames.Text = "";
            txtBoxsecuritycode.Text = "";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            /*c.FullName = txtBoxstaffnames.Text;
            c.Passcode = txtBoxsecuritycode.Text;
            c.insertseniorstaff(c);

            if (txtBoxstaffnames.Text == "")
            {
                MessageBox.Show("Please input Two Staff Names", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            else if (txtBoxsecuritycode.Text == "")
            {
                MessageBox.Show("Security Code cannot be left blank!", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            else
            {

                //load data to database
                DataTable dt = c.select();
                MessageBox.Show("Senior Staff Signed UP succesfully");
                //call clear method here
                clear();
            }*/
        }

        private void checkBoxShow_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxShow.Checked)
            {

                txtBoxsecuritycode.UseSystemPasswordChar = false;
            }
            else
            {
                txtBoxsecuritycode.UseSystemPasswordChar = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
        }
    }
}
