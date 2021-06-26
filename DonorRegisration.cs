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
    public partial class DonorRegisration : Form
    {
        Image file;
        public DonorRegisration()
        {
            InitializeComponent();
        }
        public void myclear()
        {
            tbid.Clear();
            tbFname.Clear();
            tbLname.Clear();
            tbPhone.Clear();
            tbAddress.Clear();
            cbBgroup.Text = "";
            rbmale.Checked = true;
            dtDRnow.Value = DateTime.Now;
            pbDRprofile.Image = null;
        }


       

       


        private void DonorRegisration_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bloodForLifeDataSet1.DonorDetail' table. You can move, or remove it, as needed.
            this.donorDetailTableAdapter.Fill(this.bloodForLifeDataSet1.DonorDetail);
            //  TODO: This line of code loads data into the 'bloodForLifeDataSet.DonorDetail' table.You can move, or remove it, as needed.
            // this.donorDetailTableAdapter.Fill(this.bloodForLifeDataSet.DonorDetail);
            DBConection con = new DBConection();
            con.openConnection();
            try
            {

                SqlCommand c = new SqlCommand("select id,Fname,Lname,Phone,Address,dateofbirth,gender,bloodgroup from DonorDetail  ;", con.getconnection);
                SqlDataAdapter dap = new SqlDataAdapter(c);
                DataTable dt = new DataTable();
                dap.Fill(dt);
                griddonor.DataSource = dt;
                c.ExecuteNonQuery();
                con.closeConnection();
                griddonor.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

      

      
       

        

      
        private void griddonor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                DataGridViewRow row = this.griddonor.Rows[e.RowIndex];
                tbid.Text= row.Cells[0].Value.ToString();
                tbFname.Text = row.Cells[1].Value.ToString();
                tbLname.Text = row.Cells[2].Value.ToString();
                tbPhone.Text = row.Cells[3].Value.ToString();
                tbAddress.Text = row.Cells[4].Value.ToString();
                dtDRnow.Text = row.Cells[5].Value.ToString();

                //rbmale.Text = row.Cells["gender"].Value.ToString();
                if (Convert.ToString(row.Cells[6].Value) == "Male")
                {
                    rbmale.Checked = true;
                }
                else
                {
                    rbfemale.Checked = true;
                }
                cbBgroup.Text = row.Cells[7].Value.ToString();
               // pbDRprofile.Image = row.Cells[8].Value.ToString();
               

                
            }
        }

       
        private void textBox_search_TextChanged(object sender, EventArgs e)
        {

        }

        private void btngUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Select Photo(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";
            if (open.ShowDialog() == DialogResult.OK)
            {
                file = Image.FromFile(open.FileName);
                pbDRprofile.Image = file;
            }
        }

        private void btngClear_Click(object sender, EventArgs e)
        {
            myclear();
        }

        private void btngDelete_Click(object sender, EventArgs e)
        {
            try
            {
                DBConection cn = new DBConection();
                cn.openConnection();


                SqlCommand cmmd = new SqlCommand("delete from DonorDetail where id='" + tbid.Text + "'", cn.getconnection);
                cmmd.ExecuteNonQuery();
                cn.closeConnection();
                MessageBox.Show(" Donor Deleted", "Delete  Donor", MessageBoxButtons.OK, MessageBoxIcon.Information);
                myclear();

            }
            catch (Exception ex)

            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btngUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                DBConection cn = new DBConection();
                cn.openConnection();
                if (((tbFname.Text == "") || (tbLname.Text == "") || (tbAddress.Text == "") || (tbPhone.Text == "") || (dtDRnow.Text == "")) || (pbDRprofile.Image == null))
                {
                    MessageBox.Show("Enter all Fields Value", "Donor ", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                }
                else
                {
                    string gender = rbmale.Checked ? "Male" : "Female";
                    SqlCommand cmmd = new SqlCommand("update  DonorDetail set Fname='" + tbFname.Text + "',Lname='" + tbLname.Text + "',Phone='" + tbPhone.Text + "',Address='" + tbAddress.Text + "',dateofbirth='" + dtDRnow.Value + "',gender='" + gender + "',bloodgroup='" + cbBgroup.Text + "',image='" + pbDRprofile.Image + "' where id='" + tbid.Text + "'", cn.getconnection);
                    cmmd.ExecuteNonQuery();
                    cn.closeConnection();
                    MessageBox.Show(" Donor Updated", "Update  Donor", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    myclear();
                }
            }
            catch (Exception ex)

            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btngSave_Click(object sender, EventArgs e)
        {

            try
            {
                DBConection cn = new DBConection();
                cn.openConnection();
                if (((tbFname.Text == "") || (tbLname.Text == "") || (tbAddress.Text == "") || (tbPhone.Text == "") || (dtDRnow.Text == "")) || (pbDRprofile.Image == null))
                {
                    MessageBox.Show("Enter all Fields Value", "Donor ", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                }
                else
                {
                    string gender = rbmale.Checked ? "Male" : "Female";
                    SqlCommand cmmd = new SqlCommand("insert into DonorDetail Values('" + tbid.Text + "','" + tbFname.Text + "','" + tbLname.Text + "','" + tbPhone.Text + "','" + tbAddress.Text + "','" + dtDRnow.Value + "','" + gender + "','" + cbBgroup.Text + "','" + pbDRprofile.Image + "')", cn.getconnection);
                    cmmd.ExecuteNonQuery();
                    cn.closeConnection();
                    MessageBox.Show("New Donor Added", "Create New Donor", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    myclear();
                }
            }
            catch (Exception ex)

            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btngback_Click(object sender, EventArgs e)
        {

            this.Hide();
            Home h = new Home();
            h.Show();
        }

        private void btngrefrexh_Click(object sender, EventArgs e)
        {
            this.Hide();
            DonorRegisration d = new DonorRegisration();
            d.Show();
        }

        private void btngsearch_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox_search.Text == "")
                {
                    MessageBox.Show("Please Enter  name to search ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox_search.Focus();
                    return;
                }
                DBConection con = new DBConection();
                con.openConnection();
                SqlCommand c = new SqlCommand("select id,Fname,Lname,Phone,Address,dateofbirth,gender,bloodgroup from DonorDetail WHERE Fname like'" + textBox_search.Text + "%'", con.getconnection);
                SqlDataAdapter dap = new SqlDataAdapter(c);
                DataTable dt = new DataTable();
                dap.Fill(dt);
                griddonor.DataSource = dt;
                c.ExecuteNonQuery();
                con.closeConnection();



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}


