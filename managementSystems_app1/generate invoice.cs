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
    public partial class generate_invoice : Form
    {
        public generate_invoice()
        {
            InitializeComponent();

        }

        private void btncave_Click(object sender, EventArgs e)
        {
            //string customercode = txtcustomercode.Text.ToString();
            //string customername = txtcustomername.Text.ToString();
            //string customeraddress = txtcustomeraddress.Text.ToString();
            ////string @invoicenumber = txtinvoicenumber.Text;
            //DateTime invoicedate = DateTime.Parse(txtinvoicedate.Text);
            //string itemname = ddlitems.SelectedIndex.ToString();
            //string reportdetails = txtreportdetails.Text.ToString();
            //string itemcode = txtitemcode.Text.ToString();
            //string noofitemse = txtnoofitems.Text.ToString();
            //string itemprice = txtitemprice.Text.ToString();
            //string quantity = txtquantity.Text.ToString();
            //int itemprice1 = int.Parse(txtitemprice.Text.ToString());
            //int quantity1 = int.Parse(txtquantity.Text.ToString());
            //int amount1 = itemprice1 * quantity1;
            //string amount = amount1.ToString();
            //string invoiceamount = txtinvoiceamount.Text.ToString();

            string ConnectionString = "Server=DESKTOP-DPDLQMP; Database=ManagementSystems_test; User ID =mvc; Password= mvc;";

            string storedProcedureName = "invoicecreation";

            
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                try
                {

                    conn.Open();


                    using (SqlCommand cmd = new SqlCommand(storedProcedureName, conn))
                    {

                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@customercode", txtcustomercode.Text);
                        cmd.Parameters.AddWithValue("@customername", txtcustomername.Text);
                        cmd.Parameters.AddWithValue("@customeraddress", txtcustomeraddress.Text);
                        cmd.Parameters.AddWithValue("@itemcode", txtitemcode.Text);
                        cmd.Parameters.AddWithValue("@itemname", ddlitems.SelectedItem.ToString());
                        cmd.Parameters.AddWithValue("@itemprice", txtitemprice.Text);
                        cmd.Parameters.AddWithValue("@invoicedate", DateTime.Parse(txtinvoicedate.Text));
                        cmd.Parameters.AddWithValue("@noofitemse", txtnoofitems.Text);
                        cmd.Parameters.AddWithValue("@invoiceamount", txtinvoiceamount.Text);
                        cmd.Parameters.AddWithValue("@quantity", txtquantity.Text);

                      
                        int itemprice1 = int.Parse(txtitemprice.Text);
                        int quantity1 = int.Parse(txtquantity.Text);
                        int amount1 = itemprice1 * quantity1;
                        cmd.Parameters.AddWithValue("@amount", amount1.ToString());

                      
                        cmd.ExecuteNonQuery();


                        MessageBox.Show("Stored procedure executed successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearFields();
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }
        protected void Dropdownitems()
        {

            string ConnectionString = "Server=DESKTOP-DPDLQMP; Database=ManagementSystems_test; User ID =mvc; Password= mvc;";

            string Query = "Select ITEM_NAME from TBL_ITEMS";

            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {

                try
                {


                    SqlDataAdapter adapter = new SqlDataAdapter(Query, conn);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    ddlitems.DataSource = dataTable;
                    ddlitems.DisplayMember = "ITEM_NAME";
                    ddlitems.ValueMember = "ITEM_NAME";

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading data: " + ex.Message);
                }

            }





        }

        private void generate_invoice_Load(object sender, EventArgs e)
        {
            Dropdownitems();
        }

        protected void ClearFields()
        {
            txtcustomercode.Text = "";
            txtcustomername.Text = "";
            txtcustomeraddress.Text = "";
//txtinvoicenumber.Text = "";
            txtreportdetails.Text = "";
            txtitemcode.Text = "";
            txtnoofitems.Text = "";
            txtitemprice.Text = "";
            txtquantity.Text = "";
            txtinvoiceamount.Text = "";


        }


    }
}
