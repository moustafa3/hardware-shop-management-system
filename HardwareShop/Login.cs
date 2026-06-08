using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HardwareShop
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            if (UNameTb.Text == "" || PasswordTb.Text == "")
            {
                MessageBox.Show("Missing Data!");
            }
            else if(UNameTb.Text == "Admin" && PasswordTb.Text == "Admin")
            {
                Items Obj = new Items();
                Obj.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Wrong UserName or Password");
            }
        }

        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            PasswordTb.PasswordChar = chkShowPassword.Checked ? '\0' : '*';
        }
    }
}
