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
    public partial class ViewGameForm : Form
    {
        public ViewGameForm()
        {
            
            InitializeComponent();
            backButton.Visible = false;
            viewGamePanel.Visible = false;
            searchPanel.Visible = true;
            imagePanel.Select();
        }

        public void LoadViewGrid(StockItem item)
        {
            viewGamePanel.Visible = true;

            stockID.Text = item.StockID.ToString();
            gameID.Text = item.Game.GameID.ToString();
            title.Text = item.Game.Title;
            category.Text = item.Game.Category;
            released.Text = item.Game.ReleaseYear;
            agecat.Text = item.Game.AgeCategory.ToString();

            custID.Text = item.Customer.CustID == 0 ? "N/A" : item.Customer.CustID.ToString();
            fname.Text = item.Customer.FirstName == " " ? "N/A" : item.Customer.FirstName;
            sname.Text = item.Customer.Surname == " " ? "N/A" : item.Customer.Surname;
            address.Text = item.Customer.Address == " " ? "N/A" : item.Customer.Address;
            age.Text = item.Customer.Age == 0 ? "N/A" : item.Customer.Age.ToString();
            mobile.Text = item.Customer.Mobile == " " ? "N/A" : item.Customer.Mobile;

            issue.Text = item.IssueDate.ToShortDateString() == "1/1/0001" ? "N/A" : item.IssueDate.ToString("dd/M/yyyy");
            due.Text = item.DueDate.ToShortDateString() == "1/1/0001" ? "N/A" : item.DueDate.ToString("dd/M/yyyy");
            rented.Text = item.IsRented.ToString();
            reserved.Text = item.IsReserved.ToString();
        }

        private void searchTextBox_Enter(object sender, EventArgs e)
        {
            notFound.Visible = false;
            if (searchTextBox.Text == "Enter Stock ID")
            {
                searchTextBox.Text = "";
                searchTextBox.ForeColor = Color.Black;
            }
        }

        private void searchTextBox_Leave(object sender, EventArgs e)
        {
            if (searchTextBox.Text.Length == 0)
            {
                searchTextBox.Text = "Enter Stock ID";
                searchTextBox.ForeColor = Color.Silver;
            }
        }

        private void searchGameButton_Click(object sender, EventArgs e)
        {
            int x;
            bool isNum = Int32.TryParse(searchTextBox.Text, out x);

            if (searchTextBox.Text == "" || searchTextBox.Text.Length == 0)
            {
                notFound.Visible = true;
            }

            else if(!isNum)
            {
                notFound.Visible = true;
            }

            else
            {
                int searchID = Int32.Parse(searchTextBox.Text);

                StockItem viewItem = Program.stockList.Find(stock => stock.HasStockID(searchID));

                if (viewItem == null)
                {
                    notFound.Visible = true;
                }
                else
                {
                    searchPanel.Visible = false;
                    backButton.Visible = true;

                    LoadViewGrid(viewItem);
                }
            }  
        }


        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            viewGamePanel.Visible = false;
            searchPanel.Visible = true;
            backButton.Visible = false;
        }
    }
}
