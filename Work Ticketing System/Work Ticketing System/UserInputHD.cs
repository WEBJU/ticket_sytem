using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Work_Ticketing_System.class_folder;

namespace Work_Ticketing_System
{
    public partial class UserInputHD : Form
    {
        public UserInputHD()
        {
            InitializeComponent();
            refreshData();

        }

        private void refreshData()
        {
            DataRow dr;
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-V4CRUVI;Initial Catalog=WorkTicketingSystem;Integrated Security=True");
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from tickets",conn);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            dr = dt.NewRow();
            dr.ItemArray = new Object[] {0,"--Select Your Issues--"};
            dt.Rows.InsertAt(dr,0);
            cmbIssues.ValueMember = "Id";
            cmbIssues.DisplayMember = "ticket_name";
            cmbIssues.DataSource = dt;
            conn.Close();
            //throw new NotImplementedException();
        }

        workticketclass c = new workticketclass();
        public void clear()
        {
            txtBoxTicketNo.Text = "";
            txtBoxEmployeeIDNo.Text = "";
            txtBoxFull_Names.Text = "";
            cmbBoxDepartment.Text = "";
            cmbIssues.Text = "";
            txtBoxIssue_Description.Text = "";
            dateTimePicker1.Text = "";
            txtBoxOther_Comlements.Text = "";

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {

            //get the value from the input field

            c.employee_id = txtBoxEmployeeIDNo.Text;
            c.employee_name = txtBoxFull_Names.Text;
            c.Department = cmbBoxDepartment.Text;
            c.ticket_id = (int)cmbIssues.SelectedValue;
            c.description = txtBoxIssue_Description.Text;
            c.date_raised = Convert.ToDateTime(dateTimePicker1.Text);
            c.comments = txtBoxOther_Comlements.Text;


           /* //inserting data to database
            bool success = c.insertHD(c);
            if (success == true)
            {*/
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
                else if (cmbIssues.Text == "")
                {
                    MessageBox.Show("Choose Hardware Issues(Mouse, Keyboard,CPU,Printer) from the list", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (txtBoxIssue_Description.Text == "")
                {
                    MessageBox.Show("Give a brief Description of your Issue!", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                /* //load data on datagrid view
                 // DataTable dtHD = c.selectHD();
                 //HardwGV.DataSource = dtHD;*/
                //sql query to add data
                //SqlCommand cmd = new SqlCommand(sql, conn);
                //create parameters to add data
                SqlConnection conn = new SqlConnection("Data Source=DESKTOP-V4CRUVI;Initial Catalog=WorkTicketingSystem;Integrated Security=True");
                string sql = "INSERT INTO raised_tickets (employee_id,ticket_id,description,date_raised,comments,employee_name,employee_department) VALUES(@employee_id,@ticket_id,@description,@date_raised,@comments,@employee_name,@employee_department)";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@employee_id", c.employee_id);
                cmd.Parameters.AddWithValue("@ticket_id", c.ticket_id);
                cmd.Parameters.AddWithValue("@description", c.description);
                cmd.Parameters.AddWithValue("@date_raised", c.date_raised);
                cmd.Parameters.AddWithValue("@comments", c.comments);
                cmd.Parameters.AddWithValue("@employee_name", c.employee_name);
                cmd.Parameters.AddWithValue("@employee_department", c.Department);
                conn.Open();
                int i = cmd.ExecuteNonQuery();
                conn.Close();
                if (i!=0)
                {
                    MessageBox.Show("Your details have been submitted succesfully");
                    //call clear method here
                    clear();
                }
                

                   
                }
            }
           // else { MessageBox.Show("Data not submitted. Please retry"); }
            //}

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

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
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

        private void pictureBox3_Click(object sender, EventArgs e)
        {
                      DialogResult dialog = MessageBox.Show("Do you want to exit?", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
            }
            else if (dialog == DialogResult.No)
            {
            }
        }

        private void txtBoxOther_Comlements_TextChanged(object sender, EventArgs e)
        {

            if (txtBoxEmployeeIDNo.Text == "Optional")
            {
                txtBoxEmployeeIDNo.Text = "";

                txtBoxEmployeeIDNo.ForeColor = System.Drawing.Color.Black;
            }
        }

        private void txtBoxEmployeeIDNo_TextChanged(object sender, EventArgs e)
        {
            if (txtBoxEmployeeIDNo.Text == "Should be 4 digits.eg 1212")
            {
                txtBoxEmployeeIDNo.Text = "";

                txtBoxEmployeeIDNo.ForeColor = System.Drawing.Color.Black;
            }
        }

        private void UserInputHD_Load(object sender, EventArgs e)
        {

        }

        private void lblOther_Click(object sender, EventArgs e)
        {

        }

        private void lblDate_Click(object sender, EventArgs e)
        {

        }

        private void cmbBoxDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbIssues_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtBoxIssue_Description_TextChanged(object sender, EventArgs e)
        {
            if (txtBoxIssue_Description.Text== "Describe Your Problem")
            {
                txtBoxIssue_Description.Text = "";
                txtBoxIssue_Description.ForeColor = System.Drawing.Color.Black;
            }
        }
       /* public List<Tickets> GetTickets()
        {
           List<Tickets> ticketList = new List<Tickets>();
            String query = "SELECT Id,ticket_name FROM tickets";
            return ticketList;

        }*/
    }
}
