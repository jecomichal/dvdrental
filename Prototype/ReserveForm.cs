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
    public partial class ReserveForm : Form
    {
        public ReserveForm()
        {
            InitializeComponent();
            LoadStockGrid();
            LoadCustGrid();
        }

        public void LoadStockGrid()
        {
            stockDataGridView.Rows.Clear();
            int pos = 0;

            for (int i = 0; i < Program.stockList.Count(); i++)
            {
                if (Program.stockList[i].IsRented == false && Program.stockList[i].IsReserved == false)
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

        private void reserveGameButton_Click(object sender, EventArgs e)
        {
            if (stockDataGridView.SelectedRows.Count > 0 && customerDataGridView.SelectedRows.Count > 0)
            {
                int selectedrowindexStock = stockDataGridView.SelectedRows[0].Index;
                int selectedrowindexCust = customerDataGridView.SelectedRows[0].Index;

                DataGridViewRow selectedRowStock = stockDataGridView.Rows[selectedrowindexStock];
                DataGridViewRow selectedRowCust = customerDataGridView.Rows[selectedrowindexCust];

                int stockID = (int)selectedRowStock.Cells[0].Value;
                int custID = (int)selectedRowCust.Cells[0].Value;

                //Find stockitem and customer in list
                int stockItemIndex = Program.stockList.FindIndex(s => s.HasStockID(stockID));
                int custIndex = Program.customerList.FindIndex(c => c.HasID(custID));

                if (Program.stockList[stockItemIndex].IsReserved == true)
                {
                    DialogResult reserved = MessageBox.Show("This game is reserved for another customer", "Game Is Reserved", MessageBoxButtons.OK);
                }

                else
                {
                    if (Program.stockList[stockItemIndex].Game.AgeCategory > Program.customerList[custIndex].Age)
                    {
                        DialogResult age = MessageBox.Show(String.Format("This game is {0}+ , customers age is {1}. Cannot rent the game", Program.stockList[stockItemIndex].Game.AgeCategory, Program.customerList[custIndex].Age), "Age Restriction", MessageBoxButtons.OK);

                    }
                    else
                    {
                        //update stock item
                        Program.stockList[stockItemIndex].IsReserved = true;
                        Program.stockList[stockItemIndex].Customer = Program.customerList[custIndex];

                        LoadStockGrid();
                        DialogResult reserved = MessageBox.Show(String.Format("Game successfully reserved for {0} {1}", Program.customerList[custIndex].FirstName, Program.customerList[custIndex].Surname), "Game reserved", MessageBoxButtons.OK);
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

        private void searchStockIDButton_Click(object sender, EventArgs e)
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
    }
}
