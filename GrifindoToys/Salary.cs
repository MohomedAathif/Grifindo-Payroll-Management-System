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
using System.Globalization;
using Microsoft.VisualBasic.ApplicationServices;

namespace GrifindoToys
{

    public partial class Salary : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-RTT32SQ\\SQLEXPRESS;Initial Catalog=Grifindo_Toys;Integrated Security=True;Encrypt=False");
        SqlCommand cmd = new SqlCommand();
        string query;
        float tax;

        public Salary()
        {
            InitializeComponent();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void Salary_Load(object sender, EventArgs e)
        {

        }

        private void Clear()
        {
            dtestart.Value = DateTime.Today;
            dteend.Value = DateTime.Today;

            noleave.Value = 0;
            textdaterange.Clear();
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {

        }

        public void btncal_OnClick(object sender, EventArgs e)
        {

        }
        private void dteend_ValueChanged(object sender, EventArgs e)
        {
            DateTime stdate, enddate;
            TimeSpan gap;
            int daterange;
            stdate = DateTime.Parse(dtestart.Text);
            enddate = DateTime.Parse(dteend.Text);
            gap = enddate - stdate;
            daterange = gap.Days;
            textdaterange.Text = daterange.ToString();
        }

        private void txtdaysabsent_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnback_Click(object sender, EventArgs e)
        {

        }

        private void btnviewreport_Click(object sender, EventArgs e)
        {

        }

        private void txtgrosspay_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtattendance_TextChanged(object sender, EventArgs e)
        {

        }


        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void btnconfirmsalary_Click(object sender, EventArgs e)
        {

        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainMenu m = new MainMenu();
            m.ShowDialog();
        }

        private void btncal_Click(object sender, EventArgs e)
        {
            try
            {
                float overtime, NoPay, monthlysalary, overallattendance, cycledaterange, absentdays, BasePay, Allowance, otrate, othours, GrossPay, tax;

                monthlysalary = float.Parse(textmsalary.Text);
                overallattendance = float.Parse(textattendance.Text);
                cycledaterange = float.Parse(textdaterange.Text);
                absentdays = float.Parse(textdaysabsent.Text);
                Allowance = float.Parse(textallowance.Text);
                otrate = float.Parse(textotrate.Text);
                othours = float.Parse(textothours.Text);
                tax = float.Parse(textpercentage.Text);

                //NoPay calculation
                if (overallattendance < cycledaterange)
                {
                    NoPay = (monthlysalary / cycledaterange) * absentdays;
                    textnopay.Text = NoPay.ToString();

                }
                else
                {
                    NoPay = 0;
                }

                //BasePay Calculation
                overtime = othours * otrate;
                BasePay = monthlysalary + Allowance + overtime;
                textbasepay.Text = BasePay.ToString();
                textovertime.Text = overtime.ToString();

                //GrossPay Calculation
                tax = BasePay * tax / 100;
                GrossPay = BasePay - (NoPay + tax);
                textgrosspay.Text = GrossPay.ToString();
            }
            catch
            {
                MessageBox.Show("Please enter a valid numeric values", "Input error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void butnsearch_Click(object sender, EventArgs e)
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
                    if (dr["Gender"].ToString() == "M")
                    {
                        rabm.Checked = true;
                        rabf.Checked = false;
                    }
                    else
                    {
                        rbfemale.Checked = true;
                        rbmale.Checked = false;
                    }
                    textmsalary.Text = dr["Monthly_salary"].ToString();
                    textotrate.Text = dr["OT_rate"].ToString();
                    textallowance.Text = dr["Allowance"].ToString();
                    textpercentage.Text = dr["Tax"].ToString();

                    //calculate TAX Percentage automatically
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
        private void butncalattendance_Click(object sender, EventArgs e)
        {
            try
            {
                // Parse the input values from the textboxes
                int absentdays = int.Parse(textdaysabsent.Text);
                int cycledaterange = int.Parse(textdaterange.Text);
                //int Holidaystaken = int.Parse(txtholidaystaken.Text);
                //int leavestaken = int.Parse(txtleavestaken.Text);

                // Calculate the overall attendance
                int overallattendance = cycledaterange - absentdays;

                // Display the overall attendance in the txtattendance textbox
                textattendance.Text = overallattendance.ToString();
            }
            catch (FormatException)
            {
                // Show an error message if the input values are not valid numeric values
                MessageBox.Show("Please enter valid numeric values for absent days and cycle date range.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                // Show a general error message if any other exception occurs
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnconfirmsalary_Click_1(object sender, EventArgs e)
        {
            try
            {
                con.Open();

                String sqlInsert = "INSERT INTO PayRoll (PR_id,E_id,E_f_name,E_l_name,Monthly_salary,Allowance,othours,NoPay,BasePay,GrossPay,PaymentDate) values ('" + textsalaryid.Text + "','" + textpayrollid.Text + "','" + textfname.Text + "','" + textlname.Text + "','" + textmsalary.Text + "','" + textallowance.Text + "','" + textothours.Text + "','" + textnopay.Text + "','" + textbasepay.Text + "','" + textgrosspay.Text + "','" + dtepaydate.Value + "')";
                SqlCommand cmdInsert = new SqlCommand(sqlInsert, con);
                cmdInsert.ExecuteNonQuery();
                MessageBox.Show("PayRoll Added Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);


                String sqlsalary = "INSERT INTO Salary (Salary_id,E_id,StartDate,EndDate,Basepay,Tax,GrossPay) values ('" + textsalaryid.Text + "','" + texteid.Text + "','" + dtestart.Value + "','" + dteend.Value + "','" + textbasepay.Text + "','" + textpercentage.Text + "','" + textgrosspay.Text + "')";
                SqlCommand cmdsalary = new SqlCommand(sqlsalary, con);
                cmdsalary.ExecuteNonQuery();
                MessageBox.Show("Salary Added Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void btnviewreport_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            PayRollReport pr = new PayRollReport();
            pr.ShowDialog();
        }
    }
}
