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
    public partial class EditStaffForm : Form
    {
        public EditStaffForm()
        {
            InitializeComponent();
            searchIDRadio.Select();
            searchIDRadio.Checked = true;
        }

        private void searchIDRadio_CheckedChanged(object sender, EventArgs e)
        {
            searchPPSTextBox.Visible = false;
            searchPPSCheck.Visible = false;
            searchIDTextBox.Visible = true;

            searchIDTextBox.Text = "Search By EmployeeID";
            searchIDTextBox.ForeColor = Color.DarkGray;
            staffDetailsPanel.Visible = false;
            updateStaffButton.Visible = false;
            searchStaffButton.Visible = true;
        }

        private void searchPPSRadio_CheckedChanged(object sender, EventArgs e)
        {
            searchIDTextBox.Visible = false;
            searchIDCheck.Visible = false;
            searchPPSTextBox.Visible = true;

            searchPPSTextBox.Text = "Search By PPS";
            searchPPSTextBox.ForeColor = Color.DarkGray;
            staffDetailsPanel.Visible = false;
            updateStaffButton.Visible = false;
            searchStaffButton.Visible = true;
        }

        private void updateStaffButton_Click(object sender, EventArgs e)
        {
            firstCheck.Visible = false;
            lastCheck.Visible = false;
            ageCheck.Visible = false;
            mobileCheck.Visible = false;
            usernameCheck.Visible = false;
            passwordCheck.Visible = false;
            emailCheck.Visible = false;
            addressCheck.Visible = false;

            int x,b;
            bool isNum = Int32.TryParse(ageTextBox.Text, out x);
            bool realPhone = Int32.TryParse(mobileTextBox.Text, out b);

            if (firstNameTextBox.Text.Trim().Length == 0)
            {
                firstCheck.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.x));
                firstCheck.Visible = true;
            }

            else if (lastNameTextBox.Text.Trim().Length == 0)
            {
                lastCheck.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.x));
                lastCheck.Visible = true;
            }

            else if (ageTextBox.Text.Trim().Length == 0 || !isNum)
            {
                ageCheck.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.x));
                ageCheck.Visible = true;
            }

            else if (mobileTextBox.Text.Trim().Length == 0 || !realPhone)
            {
                mobileCheck.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.x));
                mobileCheck.Visible = true;
            }

            else if (usernameTextBox.Text.Trim().Length == 0)
            {
                usernameCheck.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.x));
                usernameCheck.Visible = true;
            }

            else if (passwordTextBox.Text.Trim().Length == 0)
            {
                passwordCheck.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.x));
                passwordCheck.Visible = true;
            }

            else if (emailTextBox.Text.Trim().Length == 0)
            {
                emailCheck.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.x));
                emailCheck.Visible = true;
            }

            else if (addressTextBox.Text.Trim().Length == 0)
            {
                addressCheck.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.x));
                addressCheck.Visible = true;
            }

            else
            {
                firstCheck.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.tick));
                firstCheck.Visible = true;
                lastCheck.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.tick));
                lastCheck.Visible = true;
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
                addressCheck.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.tick));
                addressCheck.Visible = true;



                string newFname, newUserN, newPass, newLname, newMobile, newEmail, newAddress;
                int  newAge, location = 0;
                Employee newStaff = new Employee(0, "", "", "", 0, "", "", "", 'S', "", "");
                
                newFname = firstNameTextBox.Text;
                newLname = lastNameTextBox.Text;
                newAge = Int32.Parse(ageTextBox.Text);
                newMobile = mobileTextBox.Text;
                newUserN = usernameTextBox.Text;
                newPass = passwordTextBox.Text;
                newEmail = emailTextBox.Text;
                newAddress = addressTextBox.Text;
                
                if (searchIDRadio.Checked == true)
                    location = Program.staffList.FindIndex(staff => staff.HasEmpID(Int32.Parse(searchIDTextBox.Text)));


                else
                    location = Program.staffList.FindIndex(staff => staff.HasPPS(searchPPSTextBox.Text));
               
                Program.staffList[location].FirstName = newFname;
                Program.staffList[location].Surname = newLname;
                Program.staffList[location].Age = newAge;
                Program.staffList[location].Mobile = newMobile;
                Program.staffList[location].Username = newUserN;
                Program.staffList[location].Password = newPass;
                Program.staffList[location].Email = newEmail;
                Program.staffList[location].Address = newAddress;
                newStaff = Program.staffList[location];

                DialogResult dialogResult = MessageBox.Show("Staff Memeber was successfully Updated.", "Success!", MessageBoxButtons.OK);
                if (dialogResult == DialogResult.OK)
                {  
                    this.Close();
                }
                                
            }
        }

        private void searchStaffButton_Click(object sender, EventArgs e)
        {
            searchIDCheck.Visible = false;
            searchPPSCheck.Visible = false;
            notFoundLabel.Visible = false;
            Employee editStaff = new Employee(0, "", "", "", 0, "", "", "", 'S', "", "");

            if (searchIDRadio.Checked == true)
            {
                int empID;
                bool isNumeric = Int32.TryParse(searchIDTextBox.Text, out empID);
               
                editStaff = Program.staffList.Find(staff => staff.HasEmpID(empID));

                if (searchIDTextBox.Text == "Search By EmployeeID")
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

                else if (editStaff == null)
                {
                    notFoundLabel.Visible = true;
                }

                else
                {

                    staffDetailsPanel.Visible = true;
                    firstNameTextBox.Text = editStaff.FirstName;
                    lastNameTextBox.Text = editStaff.Surname;
                    ageTextBox.Text = editStaff.Age.ToString();
                    mobileTextBox.Text = editStaff.Mobile;
                    usernameTextBox.Text = editStaff.Username;
                    passwordTextBox.Text = editStaff.Password;
                    emailTextBox.Text = editStaff.Email;
                    addressTextBox.Text = editStaff.Address;

                    searchStaffButton.Visible = false;
                    updateStaffButton.Visible = true;
                }
            }

            else
            {
                editStaff = Program.staffList.Find(staff => staff.HasPPS(searchPPSTextBox.Text));

                if (searchPPSTextBox.Text == "Search By PPS")
                {
                    searchPPSCheck.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.x));
                    searchPPSCheck.Visible = true;
                }

                else if (searchPPSTextBox.Text.Trim().Length == 0)
                {
                    searchPPSCheck.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.x));
                    searchPPSCheck.Visible = true;
                }

                else if (editStaff == null)
                {
                    notFoundLabel.Visible = true;
                }

                else
                {

                    staffDetailsPanel.Visible = true;
                    firstNameTextBox.Text = editStaff.FirstName;
                    lastNameTextBox.Text = editStaff.Surname;
                    ageTextBox.Text = editStaff.Age.ToString();
                    mobileTextBox.Text = editStaff.Mobile;
                    usernameTextBox.Text = editStaff.Username;
                    passwordTextBox.Text = editStaff.Password;
                    emailTextBox.Text = editStaff.Email;
                    addressTextBox.Text = editStaff.Address;

                    searchStaffButton.Visible = false;
                    updateStaffButton.Visible = true;
                }
            }
        }

        private void searchIDTextBox_Enter(object sender, EventArgs e)
        {
            if (searchIDTextBox.Text == "Search By EmployeeID")
            {
                searchIDTextBox.Text = "";
                searchIDTextBox.ForeColor = Color.Black;
            }
            else
            {
                staffDetailsPanel.Visible = false;
                updateStaffButton.Visible = false;
                searchStaffButton.Visible = true;
            }          
        }

        private void searchPPSTextBox_Enter(object sender, EventArgs e)
        {
            if (searchPPSTextBox.Text == "Search By PPS")
            {
                searchPPSTextBox.Text = "";
                searchPPSTextBox.ForeColor = Color.Black;
            }
            else
            {
                staffDetailsPanel.Visible = false;
                updateStaffButton.Visible = false;
                searchStaffButton.Visible = true;
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            if (updateStaffButton.Visible == true)
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
    }
}
