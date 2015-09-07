using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjectClasses;

namespace Prototype
{
    public partial class ViewMemberForm : Form
    {
        public ViewMemberForm()
        {
            InitializeComponent();
            imagePanel.Select();
            backButton.Visible = false;
            viewMemberPanel.Visible = false;
            searchPanel.Visible = true;
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            viewMemberPanel.Visible = false;
            searchPanel.Visible = true;
            backButton.Visible = false;
        }

        private void searchMemberButton_Click(object sender, EventArgs e)
        {
            idCheck.Visible = false;
            int searchID;
            bool isNum = Int32.TryParse(searchTextBox.Text, out searchID);

            if(!isNum)
            {
                idCheck.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.x));
                idCheck.Visible = true;
            }

            else
            {
                Customer viewItem = Program.customerList.Find(CustID => CustID.HasID(searchID));

                if (viewItem == null)
                {
                    notFound.Visible = true;
                }
                else
                {
                    idCheck.Visible = false;
                    searchPanel.Visible = false;
                    backButton.Visible = true;

                    LoadViewGrid(viewItem);
                }
            }

            
        }
        public void LoadViewGrid(Customer item)
        {
            viewMemberPanel.Visible = true;
            custID.Text = item.CustID == 0 ? "N/A" : item.CustID.ToString();
            firstName.Text = item.FirstName == " " ? "N/A" : item.FirstName;
            surname.Text = item.Surname == " " ? "N/A" : item.Surname;
            address.Text = item.Address == " " ? "N/A" : item.Address;
            age.Text = item.Age == 0 ? "N/A" : item.Age.ToString();
            mobile.Text = item.Mobile == " " ? "N/A" : item.Mobile;
        }

        private void searchTextBox_Enter(object sender, EventArgs e)
        {
            notFound.Visible = false;
            if (searchTextBox.Text == "Enter Customer ID")
            {
                searchTextBox.Text = "";
                searchTextBox.ForeColor = Color.Black;
            }
        }

        private void searchTextBox_Leave(object sender, EventArgs e)
        {
            if (searchTextBox.Text.Length == 0)
            {
                searchTextBox.Text = "Enter Customer ID";
                searchTextBox.ForeColor = Color.Silver;
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
