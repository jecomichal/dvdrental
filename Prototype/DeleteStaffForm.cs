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
    public partial class DeleteStaffForm : Form
    {
        public DeleteStaffForm()
        {
            
            InitializeComponent();
            filterComboBox.SelectedItem = "All Employees";
            LoadDeleteGrid();
        }
        public void LoadDeleteGrid()
        {
            deleteDataGridView.Rows.Clear();
            int pos = 0;

            if (filterComboBox.SelectedItem == "All Employees")
            {
                for (int i = 0; i < Program.staffList.Count(); i++)
                {
                    deleteDataGridView.Rows.Add();
                    deleteDataGridView.Rows[i].Cells[0].Value = Program.staffList[i].EmpID;
                    deleteDataGridView.Rows[i].Cells[1].Value = Program.staffList[i].UserType == 'S' ? "Staff" : "Manager";
                    deleteDataGridView.Rows[i].Cells[2].Value = Program.staffList[i].FirstName;
                    deleteDataGridView.Rows[i].Cells[3].Value = Program.staffList[i].Surname;
                    deleteDataGridView.Rows[i].Cells[4].Value = Program.staffList[i].Age;
                    deleteDataGridView.Rows[i].Cells[5].Value = Program.staffList[i].Email;
                    deleteDataGridView.Rows[i].Cells[6].Value = Program.staffList[i].Address;
                    deleteDataGridView.Rows[i].Cells[7].Value = Program.staffList[i].Pps;

                }
            }

            else if(filterComboBox.SelectedItem == "Staff")
            {
                for (int i = 0; i < Program.staffList.Count(); i++)
                {

                    if (Program.staffList[i].UserType == 'S')
                    {
                        deleteDataGridView.Rows.Add();
                        deleteDataGridView.Rows[pos].Cells[0].Value = Program.staffList[i].EmpID;
                        deleteDataGridView.Rows[pos].Cells[1].Value = "Staff";
                        deleteDataGridView.Rows[pos].Cells[2].Value = Program.staffList[i].FirstName;
                        deleteDataGridView.Rows[pos].Cells[3].Value = Program.staffList[i].Surname;
                        deleteDataGridView.Rows[pos].Cells[4].Value = Program.staffList[i].Age;
                        deleteDataGridView.Rows[pos].Cells[5].Value = Program.staffList[i].Email;
                        deleteDataGridView.Rows[pos].Cells[6].Value = Program.staffList[i].Address;
                        deleteDataGridView.Rows[pos].Cells[7].Value = Program.staffList[i].Pps;

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
                        deleteDataGridView.Rows.Add();
                        deleteDataGridView.Rows[pos].Cells[0].Value = Program.staffList[i].EmpID;
                        deleteDataGridView.Rows[pos].Cells[1].Value = "Manager";
                        deleteDataGridView.Rows[pos].Cells[2].Value = Program.staffList[i].FirstName;
                        deleteDataGridView.Rows[pos].Cells[3].Value = Program.staffList[i].Surname;
                        deleteDataGridView.Rows[pos].Cells[4].Value = Program.staffList[i].Age;
                        deleteDataGridView.Rows[pos].Cells[5].Value = Program.staffList[i].Email;
                        deleteDataGridView.Rows[pos].Cells[6].Value = Program.staffList[i].Address;
                        deleteDataGridView.Rows[pos].Cells[7].Value = Program.staffList[i].Pps;

                        pos++;
                    }
                }
            }
        }

        private void deleteStaffButton_Click(object sender, EventArgs e)
        {
            if (deleteDataGridView.SelectedCells.Count > 0)
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to pernamentally delete the selected Staff Member(s) ?", "Delete Selected Staff ?", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    for (int i = 0; i < deleteDataGridView.SelectedCells.Count; i++)
                    {
                        int selectedrowindex = deleteDataGridView.SelectedCells[i].RowIndex;

                        DataGridViewRow selectedRow = deleteDataGridView.Rows[selectedrowindex];

                        int employeeID = (int)selectedRow.Cells[0].Value;
                        int deleteStaffIndex = Program.staffList.FindIndex(staff => staff.HasEmpID(employeeID));

                        Program.staffList.RemoveAt(deleteStaffIndex);

                    }
                    LoadDeleteGrid();
                    DialogResult deleteResult = MessageBox.Show("Staff memeber(s) successfully deleted", "Staff Deleted", MessageBoxButtons.OK);
                   
                }  
            }
            
        }

        private void filterComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadDeleteGrid();
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
