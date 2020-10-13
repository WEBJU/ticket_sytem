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
    public partial class Issue_Description : Form
    {
        public Issue_Description()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Homepage hm = new Homepage();
            hm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            UserInputSoft us = new UserInputSoft();
            us.Show();
            Hide();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UsserInputForm user = new UsserInputForm();
            user.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UserInputHD userHd = new UserInputHD();
            userHd.Show();
        }
    }
}
