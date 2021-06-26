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

namespace BloodForLifeProject
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

            

        private void tbUserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            DBConection con = new DBConection();
            try
            {


                if (tbuser.Text == string.Empty)
                {
                    MessageBox.Show("Please enter Username", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    tbuser.Focus();
                    return;
                }
                else if (tbpass.Text == string.Empty)
                {
                    MessageBox.Show("Please enter Password", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    tbpass.Text = string.Empty;
                    tbpass.Focus();
                    return;
                }
                else
                {
                    try
                    {
                        if (con.getconnection.State == ConnectionState.Closed)
                        {
                            con.openConnection();

                            SqlCommand com = new SqlCommand("select username,password from NewUserReg where username='" + tbuser.Text + "' and password='" + tbpass.Text + "'", con.getconnection);
                            DataSet ds = new DataSet();
                            SqlDataAdapter da = new SqlDataAdapter(com);
                            da.Fill(ds);
                            if (tbuser.Text != ds.Tables[0].Rows[0][0].ToString())
                            {
                                MessageBox.Show("Invalid username");
                                tbuser.Text = string.Empty;
                                tbuser.Focus();
                            }
                            else if (tbpass.Text != ds.Tables[0].Rows[0][1].ToString())
                            {
                                MessageBox.Show("Invalid Password", "Passord", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                tbpass.Text = string.Empty;
                                tbpass.Focus();
                            }

                            else
                            {
                                Home frm = new Home();
                                frm.Show();
                                this.Hide();

                            }
                        }




                    }
                    catch (Exception)
                    {

                        MessageBox.Show("Invalid User or Password", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        tbuser.Text = "";
                        tbpass.Text = "";
                        tbuser.Focus();


                    }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnnew_Click(object sender, EventArgs e)
        {
            CreateNewUser n = new CreateNewUser();
            this.Hide();
            n.Show();
        }

        private void btnExitMe_Click(object sender, EventArgs e)
        {
            
            Application.Exit();
        }
    }
    }


