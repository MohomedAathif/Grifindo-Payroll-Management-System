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
    public partial class Login : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-RTT32SQ\\SQLEXPRESS;Initial Catalog=Grifindo_Toys;Integrated Security=True;Encrypt=False");
        string query;
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnlogin_Click(object sender, EventArgs e)
        {

        }

        private void Btnlogin_Click_1(object sender, EventArgs e)
        {
            con.Open();
            string Login = "SELECT username, password FROM Login WHERE username='" + txtusername.Text + "' AND password='" + txtpassword.Text + "'";
            SqlCommand cmd = new SqlCommand(Login, con);
            SqlDataReader dr = cmd.ExecuteReader();

            cmd.Parameters.AddWithValue("username", txtusername.Text);
            cmd.Parameters.AddWithValue("password", txtpassword.Text);

            if (dr.Read() == true)
            {

                this.Hide();
                MainMenu m = new MainMenu();
                m.ShowDialog();

            }
            else
            {
                MessageBox.Show("Invalid Login");
            }
            con.Close();
        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textpassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void hide_Click(object sender, EventArgs e)
        {
            txtpassword.UseSystemPasswordChar = true;
            txtpassword.PasswordChar = '●';    // or '*'

            hide.Visible = false;
            view.Visible = true;
        }

        private void view_Click(object sender, EventArgs e)
        {
            txtpassword.UseSystemPasswordChar = false;
            txtpassword.PasswordChar = '\0';   // 🔑 THIS LINE FIXES IT

            view.Visible = false;
            hide.Visible = true;
        }

        private void guna2HtmlLabel3_Click(object sender, EventArgs e)
        {

        }

        private void txtusername_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtpassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
