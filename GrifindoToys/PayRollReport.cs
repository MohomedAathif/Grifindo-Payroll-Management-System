using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace GrifindoToys
{
    public partial class PayRollReport : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-RTT32SQ\\SQLEXPRESS;Initial Catalog=Grifindo_Toys;Integrated Security=True;Encrypt=False");
        SqlCommand cmd = new SqlCommand();
        public PayRollReport()
        {
            InitializeComponent();
            this.Load += new EventHandler(PayRollReport_Load);

        }

        private void PayRollReport_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                // Open the connection
                con.Open();

                // SQL query to fetch data from your PayRoll table
                string query = "SELECT PR_id AS 'Payroll ID', E_id AS 'Employee ID', E_f_name AS 'First Name', E_l_name AS 'Last Name', Monthly_salary AS 'Monthly Salary', Allowance, othours AS 'OT Hours', NoPay AS 'NO PAY',BasePay AS 'BASE PAY',GrossPay AS 'Gross Salary', PaymentDate as 'Salary Date'  FROM PayRoll";
                SqlDataAdapter adapter = new SqlDataAdapter(query, con);

                // Use SqlDataAdapter to fill DataTable
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                // Check if the DataTable has rows
                if (dataTable.Rows.Count > 0)
                {
                    // Bind the DataTable to DataGridView
                    dataGridView1.DataSource = dataTable;
                }
                else
                {
                    MessageBox.Show("No data found in the PayRoll table.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                // Ensure the connection is closed
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}
