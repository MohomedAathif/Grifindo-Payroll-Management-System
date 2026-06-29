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
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace GrifindoToys
{
    public partial class Employee : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-RTT32SQ\\SQLEXPRESS;Initial Catalog=Grifindo_Toys;Integrated Security=True;Encrypt=False");
        SqlCommand cmd;
        string gender, qurey;

        public Employee()
        {
            InitializeComponent();
            this.Load += new EventHandler(Employee_Load);
        }

        private void Employee_Load(object sender, EventArgs e)
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
                string query = "SELECT E_id AS 'Employee ID', E_f_name AS 'First Name', E_l_name AS 'Last Name', Gender, Address, DOB AS 'Date of Birth', Monthly_salary AS 'Salary',OT_rate AS 'OT RATE', Allowance, TAX  FROM Employee";
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

        private void txtpercentage_TextChanged(object sender, EventArgs e)
        {

        }
        private void rabm_CheckedChanged(object sender, EventArgs e)
        {
            gender = "M";
        }

        private void rabf_CheckedChanged(object sender, EventArgs e)
        {
            gender = "F";
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txteid_TextChanged(object sender, EventArgs e)
        {

        }
        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            try
            {
                string SqlSearch = "SELECT * FROM Employee where E_id='" + texteid.Text + "'";
                SqlCommand cmd = new SqlCommand(SqlSearch, con);
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    textfname.Text = dr["E_f_name"].ToString();
                    textlname.Text = dr["E_l_name"].ToString();
                    textaddress.Text = dr["Address"].ToString();
                    if (dr["Gender"].ToString() == "M")
                    {
                        rabm.Checked = true;
                        rabf.Checked = false;
                    }
                    else
                    {
                        rabf.Checked = true;
                        rabm.Checked = false;
                    }
                    dtedob.Text = dr["DOB"].ToString();
                    textmsalary.Text = dr["Monthly_salary"].ToString();
                    textotrate.Text = dr["OT_rate"].ToString();
                    textallowance.Text = dr["Allowance"].ToString();
                    textpercentage.Text = dr["Tax"].ToString();
                }
                else
                {
                    MessageBox.Show("Employee not found", "Not found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btninsert_Click(object sender, EventArgs e)
        {
            try
            {
                if (rabm.Checked)
                {
                    gender = "M";
                }
                else if (rabf.Checked)
                {
                    gender = "F";
                }

                con.Open();
                String sqlInsert = "INSERT INTO Employee (E_id,E_f_name,E_l_name,Gender,Address,DOB,Monthly_salary,OT_rate,Allowance,Tax) values ('" + texteid.Text + "','" + textfname.Text + "','" + textlname.Text + "','" + gender + "','" + textaddress.Text + "','" + dtedob.Value + "','" + textmsalary.Text + "','" + textotrate.Text + "','" + textallowance.Text + "','" + textpercentage.Text + "')";
                SqlCommand cmd = new SqlCommand(sqlInsert, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Successfully inserted employee", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clear();
                con.Close();
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (rabm.Checked)
                {
                    gender = "M";
                }
                else if (rabf.Checked)
                {
                    gender = "F";
                }

                String SqlUpdate = "UPDATE Employee SET E_f_name='" + textfname.Text + "',E_l_name='" + textlname.Text + "',Address='" + textaddress.Text + "',Gender='" + gender + "',DOB='" + dtedob.Value + "',Monthly_salary='" + textmsalary.Text + "',OT_rate='" + textotrate.Text + "' ,Allowance='" + textallowance.Text + "',Tax='" + textpercentage.Text + "' WHERE E_id = '" + texteid.Text + "'";
                cmd = new SqlCommand(SqlUpdate, con);
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Record updated successfully", "Update success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            try
            {

                if (MessageBox.Show("Are you sure you want to delete this employee record?", "Confirm delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                {
                    con.Open();
                    qurey = "delete from Employee where E_id='" + texteid.Text + "'";     //Assigns the delete query to the variable
                    cmd = new SqlCommand(qurey, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Record deleted successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information); //Displays the success message
                    clear();
                    con.Close();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void calctax_Click(object sender, EventArgs e)
        {
            {
                int tax;
                float sal = float.Parse(textmsalary.Text);
                if (sal >= 200000)
                {
                    tax = 3;
                }
                else if (sal >= 100000)
                {
                    tax = 2;
                }
                else if (sal >= 75000)
                {
                    tax = 1;
                }
                else
                {
                    tax = 0;
                }
                textpercentage.Text = tax.ToString();
            }
        }
        private void btnclear_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void clear()
        {
            texteid.Clear();
            textfname.Clear();
            textlname.Clear();
            textaddress.Clear();
            rabm.Checked = false;
            rabf.Checked = false;
            dtedob.Value = DateTime.Today;
            textmsalary.Clear();
            textotrate.Clear();
            textallowance.Clear();
            textpercentage.Clear();
        }

        private void textaddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainMenu m = new MainMenu();
            m.ShowDialog();
        }
    }
}
