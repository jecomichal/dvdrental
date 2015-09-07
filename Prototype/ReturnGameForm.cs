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
    public partial class ReturnGameForm : Form
    {
        public ReturnGameForm()
        {
            InitializeComponent();
            LoadReturnGrid();
        }

        public void LoadReturnGrid()
        {
            returnDataGridView.Rows.Clear();
            int pos = 0;

            for (int i = 0; i < Program.stockList.Count(); i++)
            {
                if (Program.stockList[i].IsRented == true)
                {
                    returnDataGridView.Rows.Add();
                    returnDataGridView.Rows[pos].Cells[0].Value = Program.stockList[i].StockID;
                    returnDataGridView.Rows[pos].Cells[1].Value = Program.stockList[i].Game.Title;
                    returnDataGridView.Rows[pos].Cells[2].Value = Program.stockList[i].Customer.CustID;
                    returnDataGridView.Rows[pos].Cells[3].Value = Program.stockList[i].Customer.FirstName;
                    returnDataGridView.Rows[pos].Cells[4].Value = Program.stockList[i].Customer.Surname;
                    returnDataGridView.Rows[pos].Cells[5].Value = Program.stockList[i].IssueDate.ToString("dd/MM/yyyy");
                    returnDataGridView.Rows[pos].Cells[6].Value = Program.stockList[i].DueDate.ToString("dd/MM/yyyy");
                    pos++;
                }  
            }
        }

        private void returnButton_Click(object sender, EventArgs e)
        {
            if (returnDataGridView.SelectedCells.Count > 0)
            {
                    
                int selectedrowindex = returnDataGridView.SelectedCells[0].RowIndex;

                DataGridViewRow selectedRow = returnDataGridView.Rows[selectedrowindex];

                int stockID = (int)selectedRow.Cells[0].Value;
                int custID = (int)selectedRow.Cells[2].Value;

                int returnStockIndex = Program.stockList.FindIndex(stock => stock.HasStockID(stockID));

                int custIndex = Program.customerList.FindIndex(c => c.HasID(custID));

                int accIndex = Program.accountList.FindIndex(a => a.HasCustomerID(custID));

                //Check if game is overdue
                string strDueDate = selectedRow.Cells[6].Value.ToString();
                string strToday = DateTime.Today.ToString("dd/MM/yyyy");

                DateTime dueDate = DateTime.ParseExact(strDueDate, "dd/MM/yyyy", null);
                DateTime today = DateTime.ParseExact(strToday, "dd/MM/yyyy", null);


                int result = DateTime.Compare(today, dueDate);

                if (result > 0) //game is overdue
                {
                    //calculate overdue days
                    int overdueDays = (int)(DateTime.Today - dueDate).TotalDays;
                    int lateFee = overdueDays;

                    //Update account late fees
                    Program.accountList[accIndex].UpdateLateFee(lateFee);

                    // return the game
                    Customer cust = new Customer(0, " ", " ", " ", 0, " ");

                    Program.stockList[returnStockIndex].Customer = cust;
                    Program.stockList[returnStockIndex].IsRented = false;
                    Program.stockList[returnStockIndex].IssueDate = new DateTime();
                    Program.stockList[returnStockIndex].DueDate = new DateTime();

                    Program.customerList[custIndex].IsRenting = false;

                    DialogResult lateResult = MessageBox.Show(String.Format("Customer was charged extra €{0} for being {1} days late", lateFee, overdueDays), "Late Fee Charged", MessageBoxButtons.OK);

                }

                else
                {                  
                    Customer cust = new Customer(0, " ", " ", " ", 0, " ");

                    Program.stockList[returnStockIndex].Customer = cust;
                    Program.stockList[returnStockIndex].IsRented = false;
                    Program.stockList[returnStockIndex].IssueDate = new DateTime();
                    Program.stockList[returnStockIndex].DueDate = new DateTime();

                    Program.customerList[custIndex].IsRenting = false;
                }

                LoadReturnGrid();
                    
                DialogResult deleteResult = MessageBox.Show("Game successfully returned", "Game Returned", MessageBoxButtons.OK);       
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
