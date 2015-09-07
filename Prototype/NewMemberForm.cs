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
using System.IO;

namespace Prototype
{
    public partial class NewMemberForm : Form
    {
        public NewMemberForm()
        {
            InitializeComponent();
            custIDTextBox.Text = Program.GetNextCustomerID().ToString();
            custIDTextBox.ReadOnly = true;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are You sure?", "", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
            }
            
        }

        private void firstNameTextBox_Enter(object sender, EventArgs e)
        {
            firstNameCheck.Visible = false;
            if (firstNameTextBox.Text == "First Name")
            {
                firstNameTextBox.Text = "";
                firstNameTextBox.ForeColor = Color.Black;
            }
        }

        private void firstNameTextBox_Leave(object sender, EventArgs e)
        {
            if (firstNameTextBox.Text.Length == 0)
            {
                firstNameTextBox.Text = "First Name";
                firstNameTextBox.ForeColor = Color.Silver;
            }
        }

        private void surnameTextBox_Enter(object sender, EventArgs e)
        {
            surnameCheck.Visible = false;
            surnameTextBox.BackColor = Color.White;
            if (surnameTextBox.Text == "Surname")
            {
                surnameTextBox.Text = "";
                surnameTextBox.ForeColor = Color.Black;
            }
        }

        private void surnameTextBox_Leave(object sender, EventArgs e)
        {
            if (surnameTextBox.Text.Length == 0)
            {
                surnameTextBox.Text = "Surname";
                surnameTextBox.ForeColor = Color.Silver;
            }
        }

        private void addressTextBox_Enter(object sender, EventArgs e)
        {
            addressCheck.Visible = false;
            addressTextBox.BackColor = Color.White;
            if (addressTextBox.Text == "Address")
            {
                addressTextBox.Text = "";
                addressTextBox.ForeColor = Color.Black;
            }
        }

        private void addressTextBox_Leave(object sender, EventArgs e)
        {
            if (addressTextBox.Text.Length == 0)
            {
                addressTextBox.Text = "Address";
                addressTextBox.ForeColor = Color.Silver;
            }
        }

        private void mobileTextBox_Enter(object sender, EventArgs e)
        {
            mobileCheck.Visible = false;
            mobileTextBox.BackColor = Color.White;
            if (mobileTextBox.Text == "Mobile")
            {
                mobileTextBox.Text = "";
                mobileTextBox.ForeColor = Color.Black;
            }
        }

        private void mobileTextBox_Leave(object sender, EventArgs e)
        {
            if (mobileTextBox.Text.Length == 0)
            {
                mobileTextBox.Text = "Mobile";
                mobileTextBox.ForeColor = Color.Silver;
            }
        }

        private void ageTextBox_Enter(object sender, EventArgs e)
        {
            ageCheck.Visible = false;
            ageTextBox.BackColor = Color.White;
            if (ageTextBox.Text == "Age")
            {
                ageTextBox.Text = "";
                ageTextBox.ForeColor = Color.Black;
            }
        }

        private void ageTextBox_Leave(object sender, EventArgs e)
        {
            if (ageTextBox.Text.Length == 0)
            {
                ageTextBox.Text = "Age";
                ageTextBox.ForeColor = Color.Silver;
            }

        }

        private void addMemberButton_Click(object sender, EventArgs e)
        {
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
                ageCheck.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.tick));
                ageCheck.Visible = true;
               
              
                    int custID, age;
                    string firstName, surname, address, mobile;


                    custID = Int32.Parse(custIDTextBox.Text);
                    firstName = firstNameTextBox.Text;
                    surname = surnameTextBox.Text;
                    address = addressTextBox.Text;
                    mobile = mobileTextBox.Text;
                    age = Int32.Parse(ageTextBox.Text);

                    Customer newCustomer = new Customer(custID, firstName, surname, address, age, mobile);
                    Program.customerList.Add(newCustomer);

                    Account newAccount = new Account(Program.GetNextAccID(), newCustomer);
                    Program.accountList.Add(newAccount);

                    DialogResult dialogResult = MessageBox.Show("Customer was registered. Add another one?", "Success!", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                       
                        NewMemberForm anotherCustomer = new NewMemberForm();
                        anotherCustomer.Show();
                        this.Close();

                    }
                    else
                    {
                        this.Close();
                    }
                    
            }
        }

        
    }
}
