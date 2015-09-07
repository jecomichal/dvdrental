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
    public partial class EditMemberForm : Form
    {
        public EditMemberForm()
        {
            InitializeComponent();
            
        }
       

        private void updateMemberButton_Click(object sender, EventArgs e)
        {
            
            firstNameCheck.Visible = false;
            surnameCheck.Visible = false;
            addressCheck.Visible = false;
            mobileCheck.Visible = false;
            mobileCheck.Visible = false;
            ageCheck.Visible = false;

            int a, b;
            bool realAge = Int32.TryParse(ageTextBox.Text, out a);
            bool realPhone = Int32.TryParse(mobileTextBox.Text, out b);

            if (firstNameTextBox.Text.Length == 0 || firstNameTextBox.Text == "First Name")
            {
                firstNameCheck.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.x));
                firstNameCheck.Visible = true;
            }

            else if (surnameTextBox.Text.Length == 0 || surnameTextBox.Text == "Surname")
            {
                surnameCheck.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.x));
                surnameCheck.Visible = true;
            }

            else if (addressTextBox.Text.Length == 0 || addressTextBox.Text == "Address")
            {
                addressCheck.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.x));
                addressCheck.Visible = true;
            }

            else if (mobileTextBox.Text.Length == 0 || mobileTextBox.Text == "Mobile" || !realPhone)
            {
                mobileCheck.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.x));
                mobileCheck.Visible = true;
            }

            else if (ageTextBox.Text.Length == 0 || ageTextBox.Text == "Age" || !realAge)
            {
                ageCheck.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.x));
                ageCheck.Visible = true;
            }

            else
            {
                firstNameCheck.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.tick));
                firstNameCheck.Visible = true;
                surnameCheck.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.tick));
                surnameCheck.Visible = true;
                addressCheck.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.tick));
                addressCheck.Visible = true;
                mobileCheck.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.tick));
                mobileCheck.Visible = true;
                mobileCheck.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.tick));
                mobileCheck.Visible = true;
                ageCheck.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.tick));
                ageCheck.Visible = true;

                string newFirstName, newSurname, newAddress, newMobile;
                int newAge;
                Customer newCustomer = new Customer(0, "", "", "", 0, "");

                newFirstName = firstNameTextBox.Text;
                newSurname = surnameTextBox.Text;
                newAddress = addressTextBox.Text;
                newAge = Int32.Parse(ageTextBox.Text);
                newMobile = mobileTextBox.Text;

                for (int i = 0; i < Program.customerList.Count(); i++)
                {
                    if (Program.customerList[i].HasID(Int32.Parse(searchIDTextBox.Text)))
                    {
                        Program.customerList[i].FirstName = newFirstName;
                        Program.customerList[i].Surname = newSurname;
                        Program.customerList[i].Address = newAddress;
                        Program.customerList[i].Mobile = newMobile;
                        Program.customerList[i].Age = newAge;
                    }
                }

                DialogResult dialogResult = MessageBox.Show("Member was successfully Updated.", "Success!", MessageBoxButtons.OK);
                if (dialogResult == DialogResult.OK)
                {
                    this.Close();
                }
            }
        }

        private void searchMemberButton_Click_1(object sender, EventArgs e)
        {
            searchIDCheck.Visible = false;
            notFoundLabel.Visible = false;

            int custID;
            bool foundCust = false;
            bool isNumeric = Int32.TryParse(searchIDTextBox.Text, out custID);
            Customer editCustomer = new Customer(0, " ", " ", " ", 0, " ");

            for (int i = 0; i < Program.customerList.Count(); i++)
            {
                if (Program.customerList[i].HasID(custID))
                {
                    foundCust = true;
                    editCustomer = Program.customerList[i];
                }
            }

            if (searchIDTextBox.Text == "Enter Customer ID")
            {
                searchIDCheck.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.x));
                searchIDCheck.Visible = true;
            }

            else if (searchIDTextBox.Text.Trim().Length == 0)
            {
                searchIDCheck.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.x));
                searchIDCheck.Visible = true;
            }

            else if (!isNumeric)
            {
                searchIDCheck.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.x));
                searchIDCheck.Visible = true;
            }

            else if (!foundCust)
            {
                notFoundLabel.Visible = true;
            }

            else
            {

                memberDetailsPanel.Visible = true;
                firstNameTextBox.Text = editCustomer.FirstName;
                surnameTextBox.Text = editCustomer.Surname;
                addressTextBox.Text = editCustomer.Address;
                ageTextBox.Text = editCustomer.Age.ToString();
                mobileTextBox.Text = editCustomer.Mobile;

                searchMemberButton.Visible = false;
                updateMemberButton.Visible = true;
            }
            
            
        }

        private void cancelButton_Click_1(object sender, EventArgs e)
        {
            if (updateMemberButton.Visible == true)
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to cancel? Any unsaved changes will be lost", "Cancel", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    this.Close();
                }
            }

            else
            {
                this.Close();
            }
        }

        private void searchIDTextBox_Enter_1(object sender, EventArgs e)
        {
            if (searchIDTextBox.Text == "Enter Customer ID")
            {
                searchIDTextBox.Text = "";
                searchIDTextBox.ForeColor = Color.Black;
                
            }
            memberDetailsPanel.Visible = false;
            updateMemberButton.Visible = false;
            searchMemberButton.Visible = true;
        }
    }
}
