using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
namespace Work_Ticketing_System
{
    public partial class Dashboard : Form
    {
       // private string uname;

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRgn")]

        private static extern IntPtr CreateRoundRgn(
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse


         );
        public Dashboard()
        {
            InitializeComponent();
            //Region = System.Drawing.Region.FromHrgn(CreateRoundRgn(0,0,Width,Height,25,25));
        }

       

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void label27_Click(object sender, EventArgs e)
        {

        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            UsersList list = new UsersList();
            list.Show();
            this.Hide();
        }

        private void btnTickets_Click(object sender, EventArgs e)
        {
            Tickets tickets = new Tickets();
            tickets.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Homepage homepage = new Homepage();
            homepage.Show();
            this.Hide();
        }
    }
}
