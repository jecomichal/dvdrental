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
    public partial class ViewStaffForm : Form
    {
        public ViewStaffForm()
        {
            InitializeComponent();
            filterComboBox.SelectedItem = "All Employees";
            LoadStaffGrid();
        }

        public void LoadStaffGrid()
        {

            staffDataGridView.Rows.Clear();
            int pos = 0;

            if (filterComboBox.SelectedItem == "All Employees")
            {
                for (int i = 0; i < Program.staffList.Count(); i++)
                {
                    staffDataGridView.Rows.Add();
                    staffDataGridView.Rows[i].Cells[0].Value = Program.staffList[i].EmpID;
                    staffDataGridView.Rows[i].Cells[1].Value = Program.staffList[i].UserType == 'S' ? "Staff" : "Manager";
                    staffDataGridView.Rows[i].Cells[2].Value = Program.staffList[i].DateHired.ToString("dd/M/yyyy");
                    staffDataGridView.Rows[i].Cells[3].Value = Program.staffList[i].FirstName;
                    staffDataGridView.Rows[i].Cells[4].Value = Program.staffList[i].Surname;
                    staffDataGridView.Rows[i].Cells[5].Value = Program.staffList[i].Age;
                    staffDataGridView.Rows[i].Cells[6].Value = Program.staffList[i].Mobile;
                    staffDataGridView.Rows[i].Cells[7].Value = Program.staffList[i].Username;
                    staffDataGridView.Rows[i].Cells[8].Value = Program.staffList[i].Password;
                    staffDataGridView.Rows[i].Cells[9].Value = Program.staffList[i].Email;
                    staffDataGridView.Rows[i].Cells[10].Value = Program.staffList[i].Pps;
                    staffDataGridView.Rows[i].Cells[11].Value = Program.staffList[i].Address;
                }
            }

            else if(filterComboBox.SelectedItem == "Staff")
            {
                for (int i = 0; i < Program.staffList.Count(); i++)
                {

                    if (Program.staffList[i].UserType == 'S')
                    {
                        staffDataGridView.Rows.Add();
                        staffDataGridView.Rows[pos].Cells[0].Value = Program.staffList[i].EmpID;
                        staffDataGridView.Rows[pos].Cells[1].Value = "Staff";
                        staffDataGridView.Rows[pos].Cells[2].Value = Program.staffList[i].DateHired.ToString("dd/M/yyyy");
                        staffDataGridView.Rows[pos].Cells[3].Value = Program.staffList[i].FirstName;
                        staffDataGridView.Rows[pos].Cells[4].Value = Program.staffList[i].Surname;
                        staffDataGridView.Rows[pos].Cells[5].Value = Program.staffList[i].Age;
                        staffDataGridView.Rows[pos].Cells[6].Value = Program.staffList[i].Mobile;
                        staffDataGridView.Rows[pos].Cells[7].Value = Program.staffList[i].Username;
                        staffDataGridView.Rows[pos].Cells[8].Value = Program.staffList[i].Password;
                        staffDataGridView.Rows[pos].Cells[9].Value = Program.staffList[i].Email;
                        staffDataGridView.Rows[pos].Cells[10].Value = Program.staffList[i].Pps;
                        staffDataGridView.Rows[pos].Cells[11].Value = Program.staffList[i].Address;

                        pos++;
                    }
                }
            }

            else
            {
                for (int i = 0; i < Program.staffList.Count(); i++)
                {

                    if (Program.staffList[i].UserType == 'M')
                    {
                        staffDataGridView.Rows.Add();
                        staffDataGridView.Rows[pos].Cells[0].Value = Program.staffList[i].EmpID;
                        staffDataGridView.Rows[pos].Cells[1].Value = "Manager";
                        staffDataGridView.Rows[pos].Cells[2].Value = Program.staffList[i].DateHired.ToString("dd/M/yyyy");
                        staffDataGridView.Rows[pos].Cells[3].Value = Program.staffList[i].FirstName;
                        staffDataGridView.Rows[pos].Cells[4].Value = Program.staffList[i].Surname;
                        staffDataGridView.Rows[pos].Cells[5].Value = Program.staffList[i].Age;
                        staffDataGridView.Rows[pos].Cells[6].Value = Program.staffList[i].Mobile;
                        staffDataGridView.Rows[pos].Cells[7].Value = Program.staffList[i].Username;
                        staffDataGridView.Rows[pos].Cells[8].Value = Program.staffList[i].Password;
                        staffDataGridView.Rows[pos].Cells[9].Value = Program.staffList[i].Email;
                        staffDataGridView.Rows[pos].Cells[10].Value = Program.staffList[i].Pps;
                        staffDataGridView.Rows[pos].Cells[11].Value = Program.staffList[i].Address;

                        pos++;
                    }
                }
            }
        }

        private void ViewStaffForm_Load(object sender, EventArgs e)
        {

        }

        private void filterComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadStaffGrid();
        }
    }
}
