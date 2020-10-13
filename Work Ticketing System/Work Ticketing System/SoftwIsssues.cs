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
    public partial class SoftwIsssues : Form
    {
        public SoftwIsssues()
        {
            InitializeComponent();
        }
        workticketclass c = new workticketclass();
        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dt = c.select();
            dataGridView1.DataSource = dt;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Homepage hm = new Homepage();
            hm.Show();
            Hide();
        }
    }
}
