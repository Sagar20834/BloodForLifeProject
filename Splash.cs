using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BloodForLifeProject
{
    public partial class Splash : Form
    {
        public Splash()
        {
            InitializeComponent();
        }
        int startpos=0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            startpos += 10;
            progresscirlce.Value = startpos;
            if(progresscirlce.Value==100)
            {
                progresscirlce.Value = 0;
                timer1.Stop();
                Login l = new Login();
                l.Show();
                this.Hide();
            }
        }

        private void Splash_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void progresscirlce_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
