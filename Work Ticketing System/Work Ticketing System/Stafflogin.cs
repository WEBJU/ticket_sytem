using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Work_Ticketing_System
{
    public partial class Stafflogin : Form
    {
        public Stafflogin()
        {
            InitializeComponent();
        }
        public void clear()
        {
            txtBoxNames.Text = "";
          //  cmbExpertise.Text = "";
            txtBoxPasscode.Text = "";
        }
        static string myconnstrng = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;
        private void button1_Click(object sender, EventArgs e)
        {

            //database connnection
                SqlConnection conn = new SqlConnection(myconnstrng);
                conn.Open();
                string sql = "select * from users where username ='" + txtBoxNames.Text.Trim() +  "' and Passcode ='" + txtBoxPasscode.Text.Trim() + "'";
                SqlCommand cmd = new SqlCommand();
                var result = cmd.ExecuteReader();
                var dataArr = new string[,] { };
                var counter = 0;
                    while (result.Read())
                    {
                         dataArr[counter, 0] =(string)result["Id"];
                     counter++;
                    }
            //var conn1 = new MySql.Data.MySqlClient.MySqlConnection();//for executing data reader
                SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);//for executing data reader
                DataTable dt = new DataTable();
               
                //adapter.Fill(dt);
                //for executing data reader
                //var cmd = new MySql.Data.MySqlClient.MySqlCommand(sql,conn1);
               

                try
                {
                    if (dt.Rows.Count == 1)
                    {
                        MessageBox.Show(" Logged in Succesfully ", "Welcome");
                        HardwIssues hd = new HardwIssues();
                        hd.Show();
                        Hide();
                        clear();
                    }
                    else
                    {
                        MessageBox.Show("Incorrect. Check your username and password", "", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Error!");
                }
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

        private void button2_Click(object sender, EventArgs e)
        {
            Homepage hm = new Homepage();
            hm.Show();
        }
    }
}
