using System;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace Work_Ticketing_System
{
    
    public partial class UsersList : Form
    {
        static string myconnstrng = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;
        public UsersList()
        {
            InitializeComponent();
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StaffSignup staff = new StaffSignup();
            staff.Show();
            this.Hide();

        }

        private void UsersList_Load(object sender, EventArgs e)
        {
            displayToGrid();
        }

         void displayToGrid()
        {
            using (SqlConnection conn = new SqlConnection(myconnstrng))
            {
                conn.Open();
                SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM users", conn);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridUsers.DataSource = dt;
            }
           
        }

    }
}
