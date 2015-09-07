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
    public partial class RentGameForm : Form
    {
        public RentGameForm()
        {
            InitializeComponent();
            filterComboBox.SelectedItem = "All Games";
            LoadStockGrid();
            LoadCustGrid();

            for (int i = 0; i < Program.stockList.Count(); i++)
            {
                if (Program.stockList[i].HasStockID(57))
                {
                    Customer cust = Program.customerList.Find(c => c.HasID(1000));
                    Program.stockList[i].Customer = cust;
                    Program.stockList[i].IsReserved = true;
                }
            }
        }

        public void LoadStockGrid()
        {
            stockDataGridView.Rows.Clear();
          
            int pos = 0;

            if (filterComboBox.SelectedItem == "All Games")
            {
                reservedDataGridView.Visible = false;
                stockDataGridView.Visible = true;
                for (int i = 0; i < Program.stockList.Count(); i++)
                {
                    if (Program.stockList[i].IsRented == false)
                    {
                        stockDataGridView.Rows.Add();
                        stockDataGridView.Rows[pos].Cells[0].Value = Program.stockList[i].StockID;
                        stockDataGridView.Rows[pos].Cells[1].Value = Program.stockList[i].Game.Title;
                        stockDataGridView.Rows[pos].Cells[2].Value = Program.stockList[i].Game.Category;
                        stockDataGridView.Rows[pos].Cells[3].Value = Program.stockList[i].Game.AgeCategory;
                        pos++;
                    }
                }
            }
            else
                LoadReservedGrid();
        }

        public void LoadReservedGrid()
        {
            reservedDataGridView.Rows.Clear();

            int pos = 0;

            if (filterComboBox.SelectedItem == "Reserved Games")
            {
                stockDataGridView.Visible = false;
                reservedDataGridView.Visible = true;
                for (int i = 0; i < Program.stockList.Count(); i++)
                {
                    if (Program.stockList[i].IsReserved == true)
                    {
                        reservedDataGridView.Rows.Add();
                        reservedDataGridView.Rows[pos].Cells[0].Value = Program.stockList[i].StockID;
                        reservedDataGridView.Rows[pos].Cells[1].Value = Program.stockList[i].Customer.CustID;
                        reservedDataGridView.Rows[pos].Cells[2].Value = Program.stockList[i].Game.Title;
                        reservedDataGridView.Rows[pos].Cells[3].Value = Program.stockList[i].Game.AgeCategory;
                        pos++;
                    }
                }
            }
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
                customerDataGridView.Rows[i].Cells[3].Value = Program.customerList[i].Age;
            }
          
        }

        private void issueGameButton_Click(object sender, EventArgs e)
        {
            if ((stockDataGridView.SelectedRows.Count > 0 && customerDataGridView.SelectedRows.Count > 0) || (reservedDataGridView.SelectedRows.Count > 0 && customerDataGridView.SelectedRows.Count > 0))
            {
                DataGridViewRow selectedRowStock;
                DataGridViewRow selectedRowCust;
                DataGridViewRow selectedRowReserved;
                int stockID = 0;
                int custID = 0;

                if(stockDataGridView.Visible == true)
                {
                    int selectedrowindexStock = stockDataGridView.SelectedRows[0].Index;
                    int selectedrowindexCust = customerDataGridView.SelectedRows[0].Index;

                    selectedRowStock = stockDataGridView.Rows[selectedrowindexStock];
                    selectedRowCust = customerDataGridView.Rows[selectedrowindexCust];

                    stockID = (int)selectedRowStock.Cells[0].Value;
                    custID = (int)selectedRowCust.Cells[0].Value;
                }
                else
                {
                    int selectedrowindexReserved = reservedDataGridView.SelectedRows[0].Index;
                    int selectedrowindexCust = customerDataGridView.SelectedRows[0].Index;

                    selectedRowReserved = reservedDataGridView.Rows[selectedrowindexReserved];
                    selectedRowCust = customerDataGridView.Rows[selectedrowindexCust];

                    stockID = (int)selectedRowReserved.Cells[0].Value;
                    custID = (int)selectedRowCust.Cells[0].Value;
                }


                //Find stockitem and customer in list
                int stockItemIndex = Program.stockList.FindIndex(s => s.HasStockID(stockID));
                int custIndex = Program.customerList.FindIndex(c => c.HasID(custID));

                //check if customer is already renting
                if (Program.customerList[custIndex].IsRenting == true)
                {
                    DialogResult renting = MessageBox.Show(String.Format("Customer with id: {0} is already renting a game", custID), "Customer Is Already Renting", MessageBoxButtons.OK);
                }

                else if (Program.stockList[stockItemIndex].IsReserved == true) // if game is reserved
                {
                    Customer reservedFor = Program.stockList[stockItemIndex].Customer;

                    if (custID != reservedFor.CustID)
                    {
                        DialogResult reserved = MessageBox.Show("This game is reserved for another customer", "Game Is Reserved", MessageBoxButtons.OK);
                    }
                    else
                    {
                        if(Program.stockList[stockItemIndex].Game.AgeCategory > Program.customerList[custIndex].Age)
                        {
                            DialogResult age = MessageBox.Show(String.Format("This game is {0}+ , customers age is {1}. Cannot rent the game", Program.stockList[stockItemIndex].Game.AgeCategory, Program.customerList[custIndex].Age), "Age Restriction", MessageBoxButtons.OK);

                        }
                        else
                        {
                            DateTime issueDate = DateTime.Today;
                            DateTime dueDate = issueDate.AddDays(3);

                            //Set customer to stockItem
                            Program.stockList[stockItemIndex].IssueDate = issueDate;
                            Program.stockList[stockItemIndex].DueDate = dueDate;
                            Program.stockList[stockItemIndex].IsRented = true;
                            Program.stockList[stockItemIndex].IsReserved = false;

                            //update Customer
                            Program.customerList[custIndex].IsRenting = true;

                            //update account;
                            int accIndex = Program.accountList.FindIndex(a => a.HasCustomerID(custID));
                            Program.accountList[accIndex].UpdateRentFee(3);

                            LoadStockGrid();
                            DialogResult reservedRented = MessageBox.Show("Game successfully rented", "Game Rented", MessageBoxButtons.OK);
                        }
                        

                    }

                }

                else
                {
                    if (Program.stockList[stockItemIndex].Game.AgeCategory > Program.customerList[custIndex].Age)
                    {
                        DialogResult age = MessageBox.Show(String.Format("This game is {0}+ , customers age is {1}. Cannot rent the game", Program.stockList[stockItemIndex].Game.AgeCategory, Program.customerList[custIndex].Age), "Age Restriction", MessageBoxButtons.OK);

                    }
                    else
                    {
                        DateTime issueDate = DateTime.Today;
                        DateTime dueDate = issueDate.AddDays(3);

                        //Set customer to stockItem
                        Program.stockList[stockItemIndex].Customer = Program.customerList[custIndex];
                        Program.stockList[stockItemIndex].IssueDate = issueDate;
                        Program.stockList[stockItemIndex].DueDate = dueDate;
                        Program.stockList[stockItemIndex].IsRented = true;

                        //update Customer
                        Program.customerList[custIndex].IsRenting = true;

                        //update account;
                        int accIndex = Program.accountList.FindIndex(a => a.HasCustomerID(custID));
                        Program.accountList[accIndex].UpdateRentFee(3);


                        LoadStockGrid();
                        DialogResult reserved = MessageBox.Show("Game successfully rented", "Game Rented", MessageBoxButtons.OK);
                    }
                    
                }

            }
        }

        private void searchStockIDButton_Click(object sender, EventArgs e)
        {
            if (stockDataGridView.Visible == true)
            {
                string searchValue = searchStockIDTextBox.Text;

                stockDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                try
                {
                    stockDataGridView.ClearSelection();
                    foreach (DataGridViewRow row in stockDataGridView.Rows)
                    {
                        if (row.Cells[0].Value.ToString().Equals(searchValue))
                        {
                            row.Selected = true;
                            stockDataGridView.FirstDisplayedScrollingRowIndex = stockDataGridView.SelectedRows[0].Index;
                            break;
                        }
                    }
                }
                catch (Exception exc)
                {
                    MessageBox.Show(exc.Message);
                }
            }
            else
            {
                string searchValue = searchStockIDTextBox.Text;

                reservedDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                try
                {
                    reservedDataGridView.ClearSelection();
                    foreach (DataGridViewRow row in reservedDataGridView.Rows)
                    {
                        if (row.Cells[0].Value.ToString().Equals(searchValue))
                        {
                            row.Selected = true;
                            reservedDataGridView.FirstDisplayedScrollingRowIndex = reservedDataGridView.SelectedRows[0].Index;
                            break;
                        }
                    }
                }
                catch (Exception exc)
                {
                    MessageBox.Show(exc.Message);
                }
            }
        }

        private void searchCustIDButton_Click(object sender, EventArgs e)
        {
            string searchValue = searchCustIDTextBox.Text;

            customerDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            try
            {
                customerDataGridView.ClearSelection();
                foreach (DataGridViewRow row in customerDataGridView.Rows)
                {
                    if (row.Cells[0].Value.ToString().Equals(searchValue))
                    {
                        row.Selected = true;
                        customerDataGridView.FirstDisplayedScrollingRowIndex = customerDataGridView.SelectedRows[0].Index;
                        break;
                    }
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void searchStockIDTextBox_Enter(object sender, EventArgs e)
        {
            if (searchStockIDTextBox.Text == "Search By Stock ID")
            {
                searchStockIDTextBox.Text = "";
                searchStockIDTextBox.ForeColor = Color.Black;
            }
        }

        private void searchCustIDTextBox_Enter(object sender, EventArgs e)
        {
            if (searchCustIDTextBox.Text == "Search By Customer ID")
            {
                searchCustIDTextBox.Text = "";
                searchCustIDTextBox.ForeColor = Color.Black;
            }
        }

        private void searchStockIDTextBox_Leave(object sender, EventArgs e)
        {
            if (searchStockIDTextBox.Text.Length == 0)
            {
                searchStockIDTextBox.Text = "Search By Stock ID";
                searchStockIDTextBox.ForeColor = Color.Silver;
            }
        }

        private void searchCustIDTextBox_Leave(object sender, EventArgs e)
        {
            if (searchCustIDTextBox.Text.Length == 0)
            {
                searchCustIDTextBox.Text = "Search By Customer ID";
                searchCustIDTextBox.ForeColor = Color.Silver;
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

        private void filterComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (filterComboBox.SelectedItem == "All Games")
                LoadStockGrid();
            else
                LoadReservedGrid();
        }
    }
}
