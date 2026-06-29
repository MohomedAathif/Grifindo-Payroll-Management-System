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
    public partial class Settings : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-RTT32SQ\\SQLEXPRESS;Initial Catalog=Grifindo_Toys;Integrated Security=True;");
        SqlCommand cmd;
        string query;
        public Settings()
        {
            InitializeComponent();
        }

        private void clear()
        {
            dtstart.Value = DateTime.Today;
            dtend.Value = DateTime.Today;
            noleave.Value = 0;
            textdaterange.Clear();
        }


        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Settings_Load(object sender, EventArgs e)
        {

        }
        private void back_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainMenu m = new MainMenu();
            m.ShowDialog();
        }

        private void dtend_ValueChanged_1(object sender, EventArgs e)
        {
            DateTime stdate, enddate;
            TimeSpan gap;
            int daterange;
            stdate = DateTime.Parse(dtstart.Text);
            enddate = DateTime.Parse(dtend.Text);
            gap = enddate - stdate;
            daterange = gap.Days;
            textdaterange.Text = daterange.ToString();
        }
        private void dateend_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void btninsert_Click_1(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                query = "INSERT INTO Settings (StartDate,EndDate,No_of_leaves,RangeCycle) VALUES ('" + dtstart.Value + "', '" + dtend.Value + "', '" + noleave.Value + "','" + textdaterange.Text + "')";
                cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Settings Inserted Successfully!!", "Insert Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clear();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }

        private void textdaterange_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dtstart_ValueChanged_1(object sender, EventArgs e)
        {

        }

    }
}
