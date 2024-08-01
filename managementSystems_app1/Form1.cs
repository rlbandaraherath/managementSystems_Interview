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
    public partial class Form1 : Form
    {


        string ConnectionString = "Server=DESKTOP-DPDLQMP; Database=ManagementSystems_test; User ID =mvc; Password= mvc;";


        public Form1()
        {
            InitializeComponent();
          
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.txtnic.Validating += new CancelEventHandler(this.txtnic_Validating);
            this.FormClosing += new FormClosingEventHandler(this.Form1_FormClosing);
        }

        //private void btnsearch_Click(object sender, EventArgs e)
        //{
        //    string customerid = txtcustomerid.Text;

        //    string ConnectionString = "Server=DESKTOP-DPDLQMP; Database=ManagementSystems_test; User ID =mvc; Password= mvc;";

        //    string query = "Select * from TBL_CUSTOMER where CUST_ID= '" + customerid + "'";

        //    SqlConnection connection = new SqlConnection(ConnectionString);

        //    SqlCommand cmd = new SqlCommand(query, connection);

        //    connection.Open();

        //    SqlDataReader reader = cmd.ExecuteReader();

        //    if (reader.Read()) {
            
            
            
            
            
        //    }
        //    connection.Close();
        //}

    

        private void txtinsert_Click(object sender, EventArgs e)
        {
            
            string nic = txtnic.Text;
      

            NicCheck(nic);


            //string ConnectionString = "Server=DESKTOP-DPDLQMP; Database=ManagementSystems_test; User ID =mvc; Password= mvc;";

            //string query = " INSERT INTO TBL_CUSTOMER (CUST_ID,CUST_NAME,CUST_MOBILE,CUST_FIXLINE,CUST_ADDRESS,JOINED_DATE) VALUES ('" + customerid + "','" + customername + "','" + mobile + "','" + fixline + "','" + address + "','" + date + "')";

            //using (SqlConnection connection = new SqlConnection(ConnectionString))
            //{
            //    SqlCommand command = new SqlCommand(query, connection);
            //    command.Parameters.AddWithValue("@CUST_ID", customerid);
            //    command.Parameters.AddWithValue("@CUST_NAME", customername);
            //    command.Parameters.AddWithValue("@CUST_NIC", nic);
            //    command.Parameters.AddWithValue("@CUST_MOBILE", mobile);
            //    command.Parameters.AddWithValue("@CUST_FIXLINE", fixline);
            //    command.Parameters.AddWithValue("@CUST_ADDRESS", address);
            //    command.Parameters.AddWithValue("@JOINED_DATE", date);

            //    try
            //    {
            //        connection.Open();
            //        command.ExecuteNonQuery();
            //        MessageBox.Show("Data inserted successfully!");
            //        ClearAllFields();
            //    }
            //    catch (Exception ex)
            //    {
            //        MessageBox.Show("An error occurred: " + ex.Message);
            //    }
            // }


        }

        private void txtedit_Click(object sender, EventArgs e)
        {
            string customerid = txtcustomerid.Text;
            string customername = txtname.Text;
            string nic = txtnic.Text;
            string mobile = txtmobile.Text;
            string fixline = txtfixedline.Text;
            string address = txtaddress.Text;
            DateTime date = DateTime.Parse(txtdatetime.Text);


          

            string ConnectionString = "Server=DESKTOP-DPDLQMP; Database=ManagementSystems_test; User ID =mvc; Password= mvc;";

            string query = "  UPDATE  TBL_CUSTOMER SET  CUST_ID=@CUST_ID,CUST_NAME=@CUST_NAME,CUST_NIC = @CUST_NIC,CUST_MOBILE = @CUST_MOBILE,CUST_FIXLINE = @CUST_FIXLINE,CUST_ADDRESS = @CUST_ADDRESS ,JOINED_DATE = @JOINED_DATE ";

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@CUST_ID", customerid);
                command.Parameters.AddWithValue("@CUST_NAME", customername);
                command.Parameters.AddWithValue("@CUST_NIC", nic);
                command.Parameters.AddWithValue("@CUST_MOBILE", mobile);
                command.Parameters.AddWithValue("@CUST_FIXLINE", fixline);
                command.Parameters.AddWithValue("@CUST_ADDRESS", address);
                command.Parameters.AddWithValue("@JOINED_DATE", date);

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Data updated successfully!");
                    ClearAllFields();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }

        private void txtdelete_Click(object sender, EventArgs e)
        {
            string customerid = txtcustomerid.Text;

            string ConnectionString = "Server=DESKTOP-DPDLQMP; Database=ManagementSystems_test; User ID =mvc; Password= mvc;";

            String query = " Delete * from TBL_CUSTOMER where   CUST_ID = @CUST_ID";

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@CUST_ID", customerid);
             

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Data Deleted successfully!");
                    ClearAllFields();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }

        }
        protected void ClearAllFields() {

          txtcustomerid.Text="";
             txtname.Text="";
             txtnic.Text="";
             txtmobile.Text="";
             txtfixedline.Text="";
             txtaddress.Text="";
             txtdatetime.Text="";


        }
        private bool _isValidating = true;
        private void txtnic_Validating(object sender, CancelEventArgs e)
        {
            if (!_isValidating)
                return;

            string nic = txtnic.Text;
            if (nic.Length != 9 && nic.Length != 12)
            {
                e.Cancel = true; // Prevents the control from losing focus
                MessageBox.Show("NIC must be either 9 or 12 characters long.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            _isValidating = false; // Disable validation
            this.txtnic.CausesValidation = false; // This will not trigger validation on form closing
        }






        protected void NicCheck(string nic) {


           

            if (IsNicExists(nic))
            {
                MessageBox.Show("NIC number already exists. Please enter a different NIC number.", "Duplicate NIC", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                // Code to insert the new NIC number into the database
              
                InsertAll();
            }


        }

        private bool IsNicExists(string nic)
        {
           
            bool exists = false;
            string query = "SELECT COUNT(*) FROM TBL_CUSTOMER  WHERE CUST_NIC = @nic";

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@nic", nic);
                    connection.Open();
                    int count = (int)command.ExecuteScalar();
                    exists = count > 0;
                }
            }

            return exists;
        }


      


        protected void InsertAll() {

            string customerid = txtcustomerid.Text;
            string customername = txtname.Text;
            string nic = txtnic.Text;
            string mobile = txtmobile.Text;
            string fixline = txtfixedline.Text;
            string address = txtaddress.Text;
            DateTime date = DateTime.Parse(txtdatetime.Text);




            string ConnectionString = "Server=DESKTOP-DPDLQMP; Database=ManagementSystems_test; User ID =mvc; Password= mvc;";

            string query = " INSERT INTO TBL_CUSTOMER (CUST_ID,CUST_NAME,CUST_NIC,CUST_MOBILE,CUST_FIXLINE,CUST_ADDRESS,JOINED_DATE) VALUES ('" + customerid + "','" + customername + "','" + nic + "','" + mobile + "','" + fixline + "','" + address + "','" + date + "')";

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@CUST_ID", customerid);
                command.Parameters.AddWithValue("@CUST_NAME", customername);
                command.Parameters.AddWithValue("@CUST_NIC", nic);
                command.Parameters.AddWithValue("@CUST_MOBILE", mobile);
                command.Parameters.AddWithValue("@CUST_FIXLINE", fixline);
                command.Parameters.AddWithValue("@CUST_ADDRESS", address);
                command.Parameters.AddWithValue("@JOINED_DATE", date);

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Data inserted successfully!");
                    ClearAllFields();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }





        }


    }
}

