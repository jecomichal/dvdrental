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
    public partial class AddStaffForm : Form
    {
        public AddStaffForm()
        {
            InitializeComponent();
            staffIDTextBox.Text = Program.GetNextStaffID().ToString();
            this.ActiveControl = imagePanel;
        }

        private void addStaffButton_Click(object sender, EventArgs e)
        {
            typeCheck.Visible = false;
            IdCheck.Visible = false;
            firstnameCheck.Visible = false;
            lastnameCheck.Visible = false;
            ageCheck.Visible = false;
            mobileCheck.Visible = false;
            usernameCheck.Visible = false;
            passwordCheck.Visible = false;
            emailCheck.Visible = false;
            ppsCheck.Visible = false;
            addressCheck.Visible = false;

            int x,b;
            bool isNumeric = Int32.TryParse(ageTextBox.Text, out x);
            char userTypeX;
            bool isChar = Char.TryParse(typeTextBox.Text, out userTypeX);
            bool realPhone = Int32.TryParse(mobileTextBox.Text, out b);

            if (typeTextBox.Text.Length == 0 || typeTextBox.Text == "Usertype (M/S)")
            {
                typeCheck.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.x));
                typeCheck.Visible = true;
            }

            else if(!isChar)
            {
                typeCheck.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.x));
                typeCheck.Visible = true;
            }

            else if (userTypeX != 'S' && userTypeX != 's' && userTypeX != 'M' && userTypeX != 'm')
            {
                typeCheck.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.x));
                typeCheck.Visible = true;
            }

            else if (firstNameTextBox.Text == "First Name" || firstNameTextBox.Text.Length == 0)
            {
                firstnameCheck.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.x));
                firstnameCheck.Visible = true;
            }

            else if (lastNameTextBox.Text == "Surname" || lastNameTextBox.Text.Length == 0)
            {
                lastnameCheck.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.x));
                lastnameCheck.Visible = true;
            }

            else if (ageTextBox.Text == "Age" || ageTextBox.Text.Length == 0)
            {
                ageCheck.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.x));
                ageCheck.Visible = true;
            }

            else if(!isNumeric)
            {
                ageCheck.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.x));
                ageCheck.Visible = true;
            }

            else if(mobileTextBox.Text == "Mobile" || mobileTextBox.Text.Length == 0 || !realPhone)
            {
                mobileCheck.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.x));
                mobileCheck.Visible = true;
            }
            else if (userNameTextBox.Text == "Username" || userNameTextBox.Text.Length == 0)
            {
                usernameCheck.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.x));
                usernameCheck.Visible = true;
            }

            else if (passwordTextBox.Text == "Password" || passwordTextBox.Text.Length == 0)
            {
                passwordCheck.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.x));
                passwordCheck.Visible = true;
            }
            else if (emailTextBox.Text == "Email" || emailTextBox.Text.Length == 0)
            {
                emailCheck.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.x));
                emailCheck.Visible = true;
            }

            else if (ppsTextBox.Text == "PPS" || ppsTextBox.Text.Length ==0)
            {
                ppsCheck.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.x));
                ppsCheck.Visible = true;
            }

            else if (addressTextBox.Text == "Address" || addressTextBox.Text.Length == 0)
            {
                addressCheck.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.x));
                addressCheck.Visible = true;
            }
           

            else
            {
                typeCheck.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.tick));
                typeCheck.Visible = true;
                IdCheck.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.tick));
                IdCheck.Visible = true;
                firstnameCheck.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.tick));
                firstnameCheck.Visible = true;
                lastnameCheck.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.tick));
                lastnameCheck.Visible = true;
                ageCheck.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.tick));
                ageCheck.Visible = true;
                mobileCheck.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.tick));
                mobileCheck.Visible = true;
                usernameCheck.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.tick));
                usernameCheck.Visible = true;
                passwordCheck.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.tick));
                passwordCheck.Visible = true;
                emailCheck.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.tick));
                emailCheck.Visible = true;
                ppsCheck.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.tick));
                ppsCheck.Visible = true;
                addressCheck.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.tick));
                addressCheck.Visible = true;
               
                try
                {
                    string firstName, lastName, address, phoneNO, userName, password, pps, email;
                    int ID, age;
                    char userType;


                    age = Int32.Parse(ageTextBox.Text);
                    phoneNO = mobileTextBox.Text;
                    ID = Int32.Parse(staffIDTextBox.Text);
                    firstName = firstNameTextBox.Text;
                    lastName = lastNameTextBox.Text;
                    address = addressTextBox.Text;
                    userName = userNameTextBox.Text;
                    password = passwordTextBox.Text;
                    pps = ppsTextBox.Text;
                    email = emailTextBox.Text;
                    userType = char.Parse(typeTextBox.Text);

                    userType = Char.ToUpper(userType);

                    Employee newStaff = new Employee(ID, firstName, lastName, address, age, phoneNO,
                                            userName, password, userType, pps, email);
                    Program.staffList.Add(newStaff);

                    DialogResult dialogResult = MessageBox.Show("Employee was successfully added. Add another one ?", "Success!", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        AddStaffForm anotherStaff = new AddStaffForm();
                        anotherStaff.Show();
                        this.Close();
                    }
                    else
                    {
                        this.Close();
                    }
                   
                }

                catch (Exception ex)
                {

                }
            }
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

        private void mobileTextBox_Enter(object sender, EventArgs e)
        {
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

        private void addressTextBox_Enter(object sender, EventArgs e)
        {
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

        private void ppsTextBox_Enter(object sender, EventArgs e)
        {
            if (ppsTextBox.Text == "PPS")
            {
                ppsTextBox.Text = "";
                ppsTextBox.ForeColor = Color.Black;
            }
        }
        private void ppsTextBox_Leave(object sender, EventArgs e)
        {
            if (ppsTextBox.Text.Length == 0)
            {
                ppsTextBox.Text = "PPS";
                ppsTextBox.ForeColor = Color.Silver;
            }
        }

        private void emailTextBox_Enter(object sender, EventArgs e)
        {
            if (emailTextBox.Text == "Email")
            {
                emailTextBox.Text = "";
                emailTextBox.ForeColor = Color.Black;
            }
        }
        private void emailTextBox_Leave(object sender, EventArgs e)
        {
            if (emailTextBox.Text.Length == 0)
            {
                emailTextBox.Text = "Email";
                emailTextBox.ForeColor = Color.Silver;
            }
        }

        private void passwordTextBox_Enter(object sender, EventArgs e)
        {
            if (passwordTextBox.Text == "Password")
            {
                passwordTextBox.Text = "";
                passwordTextBox.ForeColor = Color.Black;
                passwordTextBox.UseSystemPasswordChar = true;
            }
        }
        private void passwordTextBox_Leave(object sender, EventArgs e)
        {
            if (passwordTextBox.Text.Length == 0)
            {
                passwordTextBox.Text = "Password";
                passwordTextBox.ForeColor = Color.Silver;
                passwordTextBox.UseSystemPasswordChar = false;
            }
        }

        private void usernameTextBox_Enter(object sender, EventArgs e)
        {
            if (userNameTextBox.Text == "Username")
            {
                userNameTextBox.Text = "";
                userNameTextBox.ForeColor = Color.Black;
            }
        }
        private void usernameTextBox_Leave(object sender, EventArgs e)
        {
            if (userNameTextBox.Text.Length == 0)
            {
                userNameTextBox.Text = "Username";
                userNameTextBox.ForeColor = Color.Silver;
            }
        }

        private void ageTextBox_Enter(object sender, EventArgs e)
        {
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


        private void lastNameTextBox_Enter(object sender, EventArgs e)
        {
            if (lastNameTextBox.Text == "Surname")
            {
                lastNameTextBox.Text = "";
                lastNameTextBox.ForeColor = Color.Black;
            }
        }
        private void lastNameTextBox_Leave(object sender, EventArgs e)
        {
            if (lastNameTextBox.Text.Length == 0)
            {
                lastNameTextBox.Text = "Surname";
                lastNameTextBox.ForeColor = Color.Silver;
            }
        }

        
        private void typeTextBox_Enter(object sender, EventArgs e)
        {
            if (typeTextBox.Text == "Usertype (M/S)")
            {
                typeTextBox.Text = "";
                typeTextBox.ForeColor = Color.Black;
            }
        }

        private void typeTextBox_Leave(object sender, EventArgs e)
        {
            if (typeTextBox.Text.Length == 0)
            {
                typeTextBox.Text = "Usertype (M/S)";
                typeTextBox.ForeColor = Color.Silver;
            }
        }

        private void helpPanel_MouseHover(object sender, EventArgs e)
        {
            
             helpBox.Visible = true;
           
        }

        private void helpPanel_MouseLeave(object sender, EventArgs e)
        {
            helpBox.Visible = false;
        }
    }
}
