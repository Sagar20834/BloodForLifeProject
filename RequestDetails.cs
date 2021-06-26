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
using System.IO;
using iTextSharp.text.pdf;
using iTextSharp.text;
using System.Data.Linq;
using System.Windows.Documents;
using DGVPrinterHelper;
using Microsoft.Graph;
using NHibernate.Impl;

namespace BloodForLifeProject
{
    public partial class RequestDetails : Form
    {
        DGVPrinter printer = new DGVPrinter();
        public RequestDetails()
        {
            InitializeComponent();
        }

       
        private void RequestDetails_Load(object sender, EventArgs e)
        {
            DBConection con = new DBConection();
            con.openConnection();
            try
            {

                SqlCommand c = new SqlCommand("select id,Fname,Lname,Phone,Address,dateofbirth,gender,bloodgroup,bloodunit from RequestDetail  ;", con.getconnection);
                SqlDataAdapter dap = new SqlDataAdapter(c);
                DataTable dt = new DataTable();
                dap.Fill(dt);
                gridrequestdetails.DataSource = dt;
                c.ExecuteNonQuery();
                con.closeConnection();
                gridrequestdetails.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btngoback_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home h = new Home();
            h.Show();
        }

        private void btnprintit_Click(object sender, EventArgs e)
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
            printer.PrintDataGridView(gridrequestdetails);

        }
    }
}

