using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GrifindoToys
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {

        }
        private void btnemployee_Click(object sender, EventArgs e)
        {
            this.Hide();
            Employee em = new Employee();
            em.ShowDialog();
        }
        private void btnsettings_Click(object sender, EventArgs e)
        {
            this.Hide();
            Settings st = new Settings();
            st.ShowDialog();
        }
        private void btnsalary_Click(object sender, EventArgs e)
        {
            this.Hide();
            Salary salary = new Salary();
            salary.ShowDialog();
        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
