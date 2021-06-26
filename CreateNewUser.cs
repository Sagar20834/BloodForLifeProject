using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using System.IO;

namespace BloodForLifeProject
{
   
    public partial class CreateNewUser : Form
    {
        Image file;

        public CreateNewUser()
        {
            InitializeComponent();
        }
        bool verify()
        {
            if ((tbUserName.Text == "") || (tbFullName.Text == "") ||
                (tbPassword.Text == "") || (tbAddress.Text == "") ||
                (tbContactNo.Text == "") || (tbEmailID.Text == "") ||
                (pbProfile.Image == null))
            {
                return false;
            }
            else
                return true;
        }

        private void gbCreateNewUser_Enter(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Login l = new Login();
            this.Hide();
            l.Show();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {

            tbUserName.Text = "";
            tbPassword.Text = "";
            tbFullName.Text = "";
            tbAddress.Text = "";
            tbContactNo.Text = "";
            tbEmailID.Text = "";
            dateTimePicker1.Value = DateTime.Today;
            pbProfile.Image = null;
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Select Photo(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";
            if (open.ShowDialog() == DialogResult.OK)
            {
                file = Image.FromFile(open.FileName);
                pbProfile.Image = file;
            }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                DBConection cn = new DBConection();
                cn.openConnection();
                if ((( tbUserName.Text == "")||( tbPassword.Text=="")||( tbFullName.Text =="" ) || (tbAddress.Text == "") || (tbContactNo.Text == "") || (tbEmailID.Text == "") || (dateTimePicker1.Text == "")) || (pbProfile.Image == null))
                {
                    MessageBox.Show("Enter all Fields Value");
                }
                else
                {
                    SqlCommand cmmd = new SqlCommand("insert into NewUserReg Values('" + tbUserName.Text + "','" + tbPassword.Text + "','" + tbFullName.Text + "','" + tbAddress.Text + "','" + tbEmailID.Text + "','" + tbContactNo.Text + "','" + dateTimePicker1.Value + "','" + pbProfile.Image + "')", cn.getconnection);
                    cmmd.ExecuteNonQuery();
                    cn.closeConnection();
                    MessageBox.Show("New User Added", "Create New User", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    Login l = new Login();
                    l.Show();
                }
            }
            catch (Exception ex)

            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
