using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Work_Ticketing_System
{
    public partial class Reports : Form
    {
        public Reports()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Homepage hm = new Homepage();
            hm.Show();
            Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            StaffSignup sn = new StaffSignup();
            sn.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SeniorStafLogin sl = new SeniorStafLogin();
            sl.Show();
        }
    }
}
