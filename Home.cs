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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void internationalBloodBankDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void dToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void addDonorToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            DonorRegisration s = new DonorRegisration();
            s.Show();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login l = new Login();
            l.Show();
        }

        private void addReceiverRequestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            NewRequest n = new NewRequest();
            n.Show();
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void aboutUsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            AboutUS ab = new AboutUS();
            ab.Show();

        }

        private void Home_Load(object sender, EventArgs e)
        {
            Login n = new Login();
            
        }

        private void viewRequestsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            RequestDetails f = new RequestDetails();
            f.Show();
        }

        private void filterRequestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FilterReceiver f = new FilterReceiver();
            f.Show();

        }
    }
}
