using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevComponents.DotNetBar;

namespace McGamer_Moderation
{
    public partial class Login : DevComponents.DotNetBar.Metro.MetroForm
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void textBoxX1_TextChanged(object sender, EventArgs e)
        {

        }

        private void questionButton_Click(object sender, EventArgs e)
        {
            MessageBoxEx.Show("Your Login Info was given to you by a Senior Staff Member!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            Login login = new Login();
            main.Show();
            login.Hide();
        }
    }
}
