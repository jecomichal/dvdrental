using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prototype
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            Program.LoadStaff();
            loginUserTextBox.Select();
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            bool found = false;
            for (int i = 0; i < Program.staffList.Count(); i++)
            {
                if (Program.staffList[i].HasUsernameAndPassword(loginUserTextBox.Text, loginPasswordTextBox.Text))
                {
                    found = true;
                    if (Program.staffList[i].UserType == 'M')
                    {
                        loginWarningLabel.Visible = false;
                        this.Hide();
                        ManagerMenuForm managerMenu = new ManagerMenuForm();
                        managerMenu.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        loginWarningLabel.Visible = false;
                        this.Hide();
                        StaffMenuForm staffMenu = new StaffMenuForm();
                        staffMenu.ShowDialog();
                        this.Close();
                    }
                }

            }

            if (!found)
            {
                loginWarningLabel.Visible = true;
            }
        }

        private void loginUserTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Return))
            {
                 button1_Click(sender, e);
            }
        }

        private void loginPasswordTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Return))
            {
                button1_Click(sender, e);
            }
        }
    }
}
