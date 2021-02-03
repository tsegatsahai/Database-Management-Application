using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace database
{
    public partial class shipmentCompanyForm : Form
    {
        string con_string;
        SqlConnection con;
        
        public shipmentCompanyForm()
        {
            InitializeComponent();
            con_string = ConfigurationManager.ConnectionStrings["database.Properties.Settings.supplier_part_shipmentConnectionString"].ConnectionString;
        }

       

        private void shipmentCompanyForm_Load(object sender, EventArgs e)
        {
            load_supplier_data();
        }

        private void load_supplier_data()
        {
            using (con = new SqlConnection(con_string))
            using (SqlDataAdapter sql_adapter = new SqlDataAdapter("SELECT * FROM SUPPLIER",con_string))
            {
                DataTable suppliers = new DataTable();
                sql_adapter.Fill(suppliers);
                dataGridView1.DataSource = suppliers;
            }
        }
        private void load_part_data()
        {
            using (con = new SqlConnection(con_string))
            using (SqlDataAdapter sql_adapter = new SqlDataAdapter("SELECT * FROM PART", con_string))
            {
                DataTable parts = new DataTable();
                sql_adapter.Fill(parts);
                dataGridView1.DataSource = parts;
            }
        }
        private void load_shipment_data()
        {
            using (con = new SqlConnection(con_string))
            using (SqlDataAdapter sql_adapter = new SqlDataAdapter("SELECT * FROM SHIPMENT", con_string))
            {
                DataTable shipments = new DataTable();
                sql_adapter.Fill(shipments);
                dataGridView1.DataSource = shipments;
            }
        }

        private void supplier_button_Click(object sender, EventArgs e)
        {
            load_supplier_data();
        }

        private void part_button_Click(object sender, EventArgs e)
        {
            load_part_data();
        }

        private void shipment_button_Click(object sender, EventArgs e)
        {
            load_shipment_data();
        }
        private void pno_to_display_supplier_TextChanged(object sender, EventArgs e)
        {

        }

        private void Sno_text_TextChanged(object sender, EventArgs e)
        {
                      
        }

        private void insert_supplier_Click(object sender, EventArgs e)
        {
            string qry = "INSERT INTO SUPPLIER (Sno, Sname, [Status], City) VALUES (@sno, @sname, @status, @city)";
            using (con = new SqlConnection(con_string))
            {
                SqlCommand command = new SqlCommand(qry, con);
                SqlDataAdapter sql_adapter = new SqlDataAdapter(command);
                try
                {
                    command.Parameters.Add("@sno", System.Data.SqlDbType.NVarChar, 3);
                    command.Parameters.Add("@sname", System.Data.SqlDbType.NVarChar, 15);
                    command.Parameters.Add("@status", System.Data.SqlDbType.Int, 3);
                    command.Parameters.Add("@city", System.Data.SqlDbType.NVarChar, 15);
                    command.Parameters["@sno"].Value = Sno_text.Text;
                    command.Parameters["@sname"].Value = Sname_text.Text;
                    command.Parameters["@status"].Value = Status_text.Text;
                    command.Parameters["@city"].Value = City_text.Text;
                    DataTable query_result = new DataTable();
                    sql_adapter.Fill(query_result);
                    dataGridView1.DataSource = query_result;
                    load_supplier_data();
                    MessageBox.Show("Inserted Successfully!");
                    City_text.Text = "";
                    Status_text.Text = "";
                    Sname_text.Text = "";
                    Sno_text.Text = "";

                }
                catch (SqlException err)
                {
                    string error = err.Message;
                    MessageBox.Show("Failed to insert!\n Reason:\n"+ error);
                }
                catch (FormatException ex)
                {
                    string er = ex.Message;
                    MessageBox.Show("Failed to insert!\n Reason:\n" + er);
                }

            }
        }

        private void display_supplier_from_pno_Click(object sender, EventArgs e)
        {
            string qry = "SELECT * FROM SUPPLIER WHERE Sno in (SELECT DISTINCT Sno FROM SHIPMENT WHERE Pno = @pno)";
            using (con = new SqlConnection(con_string))
           {
                SqlCommand command = new SqlCommand(qry, con);
                SqlDataAdapter sql_adapter = new SqlDataAdapter(command);
                try
                {
                    command.Parameters.Add("@pno", System.Data.SqlDbType.NVarChar, 2);
                    command.Parameters["@pno"].Value = pno_to_display_supplier.Text;
                    DataTable query_result = new DataTable();
                    sql_adapter.Fill(query_result);
                    if (query_result.Rows.Count < 1)
                    {
                        dataGridView1.DataSource = query_result;
                        MessageBox.Show("No suppliers available");
                    }
                    dataGridView1.DataSource = query_result;
                }
                catch (SqlException)
                {
                    MessageBox.Show("ERROR!");
                }
                catch (FormatException ex)
                {
                    string er = ex.Message;
                    MessageBox.Show("Failed!\n Reason:\n" + er);
                }

            }
        }

        private void yes_button_Click(object sender, EventArgs e)
        {
            string qry = "UPDATE SUPPLIER SET Status = Status * 1.1;";
            using (con = new SqlConnection(con_string))
            using (SqlDataAdapter sql_adapter = new SqlDataAdapter(qry, con_string))
            {
                DataTable supplier = new DataTable();
                sql_adapter.Fill(supplier);
                dataGridView1.DataSource = supplier;
                load_supplier_data();
            }
        }

        private void insert_part_Click(object sender, EventArgs e)
        {
            string qry = "INSERT INTO PART (Pno, Pname, Color, [Weight], City) VALUES (@pno, @pname, @color, @weight, @city)";
            using (con = new SqlConnection(con_string))
            {
                SqlCommand command = new SqlCommand(qry, con);
                SqlDataAdapter sql_adapter = new SqlDataAdapter(command);
                try
                {
                    command.Parameters.Add("@pno", System.Data.SqlDbType.NVarChar, 3);
                    command.Parameters.Add("@pname", System.Data.SqlDbType.NVarChar, 15);
                    command.Parameters.Add("@color", System.Data.SqlDbType.NVarChar, 10);
                    command.Parameters.Add("@weight", System.Data.SqlDbType.Int, 3);
                    command.Parameters.Add("@city", System.Data.SqlDbType.NVarChar, 15);
                    command.Parameters["@pno"].Value = part_pno_text.Text;
                    command.Parameters["@pname"].Value = pname_text.Text;
                    command.Parameters["@color"].Value = color_text.Text;
                    command.Parameters["@weight"].Value = weight_text.Text;
                    command.Parameters["@city"].Value =part_city_text.Text;
                    DataTable query_result = new DataTable();
                    sql_adapter.Fill(query_result);
                    dataGridView1.DataSource = query_result;
                    load_part_data();
                    MessageBox.Show("Inserted Successfully!");
                    part_pno_text.Text = "";
                    pname_text.Text = "";
                    color_text.Text = "";
                    weight_text.Text = "";
                    part_city_text.Text = "";

                }
                catch (SqlException err)
                {
                    string error = err.Message;
                    MessageBox.Show("Failed to insert!\n Reason:\n" + error);
                }
                catch (FormatException ex)
                {
                    string er = ex.Message;
                    MessageBox.Show("Failed to insert!\n Reason:\n" + er);
                }

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string qry = "INSERT INTO SHIPMENT (Sno, Pno, Qty, Price) VALUES (@sno, @pno, @qty, @price)";
            using (con = new SqlConnection(con_string))
            {
                SqlCommand command = new SqlCommand(qry, con);
                SqlDataAdapter sql_adapter = new SqlDataAdapter(command);
                try
                {
                    command.Parameters.Add("@pno", System.Data.SqlDbType.NVarChar, 3);
                    command.Parameters.Add("@sno", System.Data.SqlDbType.NVarChar, 3);
                    command.Parameters.Add("@qty", System.Data.SqlDbType.Int, 4);
                    command.Parameters.Add("@price", System.Data.SqlDbType.Decimal, 5);
                    command.Parameters["@pno"].Value = ship_pno_text.Text;
                    command.Parameters["@sno"].Value = ship_sno_text.Text;
                    command.Parameters["@qty"].Value = qty_text.Text;
                    command.Parameters["@price"].Value = price_text.Text;
                    DataTable query_result = new DataTable();
                    sql_adapter.Fill(query_result);
                    dataGridView1.DataSource = query_result;
                    load_shipment_data();
                    MessageBox.Show("Inserted Successfully!");
                    ship_pno_text.Text = "";
                    ship_sno_text.Text = "";
                    qty_text.Text = "";
                    price_text.Text = "";
                 }
                catch (SqlException err)
                {
                    string error = err.Message;
                    MessageBox.Show("Failed to insert!\n Reason:\n" + error);
                }
                catch (FormatException ex)
                {
                    string er = ex.Message;
                    MessageBox.Show("Failed to insert!\n Reason:\n" + er );
                }

            }
        }
    }
}
