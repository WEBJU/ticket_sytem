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
    public partial class startuporm : Form
    {
        public startuporm()
        {
            InitializeComponent();
        }
        int move = 0;
        private void timerSplash_Tick(object sender, EventArgs e)
        {
            //show any loading animation
            timerSplash.Interval = 20;
            panel2.Width += 5;

            move += 5;
            //if the loading is comlple;
            if (move == 540)
            {
                //close the timer and the current page
                timerSplash.Stop();
                // dissplay the loin page
                this.Hide();

                //display homepage
                Homepage hm = new Homepage();
                hm.Show();
            }
        }

        private void startuporm_Load(object sender, EventArgs e)
        {
            //load the timer
            timerSplash.Start();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
