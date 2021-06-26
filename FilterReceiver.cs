using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DGVPrinterHelper;
namespace BloodForLifeProject
{
    public partial class FilterReceiver : Form
    {
        DGVPrinter printer = new DGVPrinter();
        public FilterReceiver()
        {
            InitializeComponent();
        }
        public void refresh()
        {
            this.Hide();
            FilterReceiver r = new FilterReceiver();
            r.Show();
        }
       

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button_search_Click(object sender, EventArgs e)
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
                SqlCommand c = new SqlCommand("select id,Fname,Lname,Phone,Address,dateofbirth,gender,bloodgroup,bloodunit from RequestDetail WHERE Fname like'" + textBox_search.Text + "%'", con.getconnection);
                SqlDataAdapter dap = new SqlDataAdapter(c);
                DataTable dt = new DataTable();
                dap.Fill(dt);
                gridFilter.DataSource = dt;
                c.ExecuteNonQuery();
                con.closeConnection();



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DBConection con = new DBConection();
            con.openConnection();
            if (cbByGroup.SelectedIndex == 0)
            {
                SqlCommand c = new SqlCommand("select id,Fname,Lname,Phone,Address,dateofbirth,gender,bloodgroup,bloodunit from RequestDetail WHERE bloodgroup ='" + cbByGroup.Text + "'", con.getconnection);
                SqlDataAdapter dap = new SqlDataAdapter(c);
                DataTable dt = new DataTable();
                dap.Fill(dt);
                if (dt.Rows.Count > 0)

                {
                    gridFilter.DataSource = dt;
                    c.ExecuteNonQuery();
                    con.closeConnection();
                    cbByGroup.SelectedText = "";
                }
                else
                {
                    MessageBox.Show("No Record Found on Filter ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    refresh();

                }
            }
           else if (cbByGroup.SelectedIndex == 1)
            {
                SqlCommand c = new SqlCommand("select id,Fname,Lname,Phone,Address,dateofbirth,gender,bloodgroup,bloodunit from RequestDetail WHERE bloodgroup ='" + cbByGroup.Text + "'", con.getconnection);
                SqlDataAdapter dap = new SqlDataAdapter(c);
                DataTable dt = new DataTable();
                dap.Fill(dt);
                if (dt.Rows.Count > 0)

                {
                    gridFilter.DataSource = dt;
                    c.ExecuteNonQuery();
                    con.closeConnection();
                    cbByGroup.SelectedText = "";
                }
                else
                {
                   MessageBox.Show("No Record Found on Filter ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    refresh();
                    
                }
            }
            else if (cbByGroup.SelectedIndex == 2)
            {
                SqlCommand c = new SqlCommand("select id,Fname,Lname,Phone,Address,dateofbirth,gender,bloodgroup,bloodunit from RequestDetail WHERE bloodgroup ='" + cbByGroup.Text + "'", con.getconnection);
                SqlDataAdapter dap = new SqlDataAdapter(c);
                DataTable dt = new DataTable();
                dap.Fill(dt);
                if (dt.Rows.Count > 0)

                {
                    gridFilter.DataSource = dt;
                    c.ExecuteNonQuery();
                    con.closeConnection();
                    cbByGroup.SelectedText = "";
                }
                else
                {
                   MessageBox.Show("No Record Found on Filter ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    refresh();
                }
            }
            else if (cbByGroup.SelectedIndex == 3)
            {
                SqlCommand c = new SqlCommand("select id,Fname,Lname,Phone,Address,dateofbirth,gender,bloodgroup,bloodunit from RequestDetail WHERE bloodgroup ='" + cbByGroup.Text + "'", con.getconnection);
                SqlDataAdapter dap = new SqlDataAdapter(c);
                DataTable dt = new DataTable();
                dap.Fill(dt);
                if (dt.Rows.Count > 0)

                {
                    gridFilter.DataSource = dt;
                    c.ExecuteNonQuery();
                    con.closeConnection();
                    cbByGroup.SelectedText = "";
                }
                else
                {
                   MessageBox.Show("No Record Found on Filter ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    refresh();
                }
            }
            else if (cbByGroup.SelectedIndex == 4)
            {
                SqlCommand c = new SqlCommand("select id,Fname,Lname,Phone,Address,dateofbirth,gender,bloodgroup,bloodunit from RequestDetail WHERE bloodgroup ='" + cbByGroup.Text + "'", con.getconnection);
                SqlDataAdapter dap = new SqlDataAdapter(c);
                DataTable dt = new DataTable();
                dap.Fill(dt);
                if (dt.Rows.Count > 0)

                {
                    gridFilter.DataSource = dt;
                    c.ExecuteNonQuery();
                    con.closeConnection();
                    cbByGroup.SelectedText = "";
                }
                else
                {
                   MessageBox.Show("No Record Found on Filter ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    refresh();
                }
            }
            else if (cbByGroup.SelectedIndex == 5)
            {
                SqlCommand c = new SqlCommand("select id,Fname,Lname,Phone,Address,dateofbirth,gender,bloodgroup,bloodunit from RequestDetail WHERE bloodgroup ='" + cbByGroup.Text + "'", con.getconnection);
                SqlDataAdapter dap = new SqlDataAdapter(c);
                DataTable dt = new DataTable();
                dap.Fill(dt);
                if (dt.Rows.Count > 0)

                {
                    gridFilter.DataSource = dt;
                    c.ExecuteNonQuery();
                    con.closeConnection();
                    cbByGroup.SelectedText = "";
                }
                else
                {
                   MessageBox.Show("No Record Found on Filter ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    refresh();
                }
            }
            else if (cbByGroup.SelectedIndex == 6)
            {
                SqlCommand c = new SqlCommand("select id,Fname,Lname,Phone,Address,dateofbirth,gender,bloodgroup,bloodunit from RequestDetail WHERE bloodgroup ='" + cbByGroup.Text + "'", con.getconnection);
                SqlDataAdapter dap = new SqlDataAdapter(c);
                DataTable dt = new DataTable();
                dap.Fill(dt);
                if (dt.Rows.Count > 0)

                {
                    gridFilter.DataSource = dt;
                    c.ExecuteNonQuery();
                    con.closeConnection();
                    cbByGroup.SelectedText = "";
                }
                else
                {
                   MessageBox.Show("No Record Found on Filter ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    refresh();
                }
            }
            else if (cbByGroup.SelectedIndex == 7)
            {
                SqlCommand c = new SqlCommand("select id,Fname,Lname,Phone,Address,dateofbirth,gender,bloodgroup,bloodunit from RequestDetail WHERE bloodgroup ='" + cbByGroup.Text + "'", con.getconnection);
                SqlDataAdapter dap = new SqlDataAdapter(c);
                DataTable dt = new DataTable();
                dap.Fill(dt);

                if (dt.Rows.Count > 0)

                {
                    gridFilter.DataSource = dt;
                    c.ExecuteNonQuery();
                    con.closeConnection();
                    cbByGroup.SelectedText = "";
                }
                else
                {
                   MessageBox.Show("No Record Found on Filter ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    refresh();
                }
            }
            else
            {
                MessageBox.Show("Error ! Please choose any Blood Group ");
            }
        }

        private void cbByGender_SelectedIndexChanged(object sender, EventArgs e)
        {

            DBConection con = new DBConection();
            con.openConnection();
            if (cbByGender.SelectedIndex == 0)
            {
                SqlCommand c = new SqlCommand("select id,Fname,Lname,Phone,Address,dateofbirth,gender,bloodgroup,bloodunit from RequestDetail WHERE gender ='" + cbByGender.Text + "'", con.getconnection);
                SqlDataAdapter dap = new SqlDataAdapter(c);
                DataTable dt = new DataTable();
                dap.Fill(dt);
                if (dt.Rows.Count > 0)

                {
                    gridFilter.DataSource = dt;
                    c.ExecuteNonQuery();
                    con.closeConnection();
                    cbByGender.SelectedText = "";
                }
                else
                {
                   MessageBox.Show("No Record Found on Filter ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    refresh();

                }
            }
            else if (cbByGender.SelectedIndex == 1)
            {
                SqlCommand c = new SqlCommand("select id,Fname,Lname,Phone,Address,dateofbirth,gender,bloodgroup,bloodunit from RequestDetail WHERE gender ='" + cbByGender.Text + "'", con.getconnection);
                SqlDataAdapter dap = new SqlDataAdapter(c);
                DataTable dt = new DataTable();
                dap.Fill(dt);
                if (dt.Rows.Count > 0)

                {
                    gridFilter.DataSource = dt;
                    c.ExecuteNonQuery();
                    con.closeConnection();
                    cbByGender.SelectedText = "";
                }
                else
                {
                   MessageBox.Show("No Record Found on Filter ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    refresh();

                }
            }
        }

        private void btngSearch_Click(object sender, EventArgs e)
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
                SqlCommand c = new SqlCommand("select id,Fname,Lname,Phone,Address,dateofbirth,gender,bloodgroup,bloodunit from RequestDetail WHERE Fname like'" + textBox_search.Text + "%'", con.getconnection);
                SqlDataAdapter dap = new SqlDataAdapter(c);
                DataTable dt = new DataTable();
                dap.Fill(dt);
                gridFilter.DataSource = dt;
                c.ExecuteNonQuery();
                con.closeConnection();



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btngGoback_Click(object sender, EventArgs e)
        {
            Home hs = new Home();
            this.Hide();
            hs.Show();
        }

        private void btngPrint_Click(object sender, EventArgs e)
        {

            printer.Title = "Receivers List";
            printer.SubTitle = string.Format("DateTime: " + Convert.ToDateTime(DateTime.Today));
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.Footer = "Blood For Life ";
            printer.FooterSpacing = 15;
            printer.printDocument.DefaultPageSettings.Landscape = true;
            printer.PrintDataGridView(gridFilter);
        }
    }
}
