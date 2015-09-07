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
    public partial class DeleteMemberForm : Form
    {
        public DeleteMemberForm()
        {
            InitializeComponent();
            LoadCustGrid();
        }

        public void LoadCustGrid()
        {
            customerDataGridView.Rows.Clear();

            for (int i = 0; i < Program.customerList.Count(); i++)
            {
                customerDataGridView.Rows.Add();
                customerDataGridView.Rows[i].Cells[0].Value = Program.customerList[i].CustID;
                customerDataGridView.Rows[i].Cells[1].Value = Program.customerList[i].FirstName;
                customerDataGridView.Rows[i].Cells[2].Value = Program.customerList[i].Surname;
                customerDataGridView.Rows[i].Cells[3].Value = Program.customerList[i].Address;
                customerDataGridView.Rows[i].Cells[4].Value = Program.customerList[i].Mobile;
                customerDataGridView.Rows[i].Cells[5].Value = Program.customerList[i].Age;

            }
        }

        private void deleteMemberButton_Click(object sender, EventArgs e)
        {
            bool custDeleted = false;
            if (customerDataGridView.SelectedCells.Count > 0)
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to pernamentally delete the selected customer(s) ?", "Delete Selected Customer(s) ?", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    for (int i = 0; i < customerDataGridView.SelectedCells.Count; i++)
                    {
                        int selectedrowindex = customerDataGridView.SelectedCells[i].RowIndex;

                        DataGridViewRow selectedRow = customerDataGridView.Rows[selectedrowindex];

                        int custID = (int)selectedRow.Cells[0].Value;

                        int deleteCustIndex = Program.customerList.FindIndex(c => c.HasID(custID));

                        //Check if customer is currently renting
                        if (Program.customerList[deleteCustIndex].IsRenting == true)
                        {
                            DialogResult cantDeleteMsg = MessageBox.Show(String.Format("Customer with ID: {0} cannot be deleted because he is currently renting a game", custID), "Game Cannot Be Deleted", MessageBoxButtons.OK);
                        }

                        else
                        {
                            Program.accountList.RemoveAt(Program.accountList.FindIndex(a => a.HasCustomerID(custID)));
                            Program.customerList.RemoveAt(deleteCustIndex);
                            custDeleted = true;
                        }
                    }
                    LoadCustGrid();
                    if (custDeleted)
                    {
                        DialogResult deleteResult = MessageBox.Show("Customer(s) successfully deleted", "Customer(s) Deleted", MessageBoxButtons.OK);

                    }
                }
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
