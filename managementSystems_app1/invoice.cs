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

namespace managementSystems_app1
{
    public partial class invoice : Form
    {
        public invoice()
        {
            InitializeComponent();
        }

        private void btninvoice_Click(object sender, EventArgs e)
        {
            string ConnectionString = "Server=DESKTOP-DPDLQMP; Database=ManagementSystems_test; User ID =mvc; Password= mvc;";

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {

                //query to be completed
                string query = "select * from TBL_CUSTOMER join TBL_INVOICE on TBL_CUSTOMER.CUST_ID = TBL_INVOICE.CUST_ID  join TBL_INVOICE_DETAILS on TBL_INVOICE.INVO_NO =  TBL_INVOICE_DETAILS.INVO_NO  join TBL_ITEMS on TBL_INVOICE_DETAILS.ITEM_CODE = TBL_ITEMS.ITEM_CODE ";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                DataSet dataSet = new DataSet();

                try
                {
                    connection.Open();
                    dataAdapter.Fill(dataSet, "StudentDataTable");


                    CrystalReport1 report = new CrystalReport1();
                    report.SetDataSource(dataSet.Tables["StudentDataTable"]);

                    crystalReportViewer1.ReportSource = report;
                    crystalReportViewer1.Refresh();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }



        }
    }
}
