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
    public partial class DeleteGameForm : Form
    {
        public DeleteGameForm()
        {
            
            InitializeComponent();
            filterComboBox.SelectedItem = "All Games";
            LoadDeleteGrid();
        }

        public void LoadDeleteGrid()
        {
            deleteDataGridView.Rows.Clear();
            int pos = 0;

            if (filterComboBox.SelectedItem == "All Games")
            {
                for (int i = 0; i < Program.stockList.Count(); i++)
                {
                    deleteDataGridView.Rows.Add();
                    deleteDataGridView.Rows[i].Cells[0].Value = Program.stockList[i].StockID;
                    deleteDataGridView.Rows[i].Cells[1].Value = Program.stockList[i].Game.GameID;
                    deleteDataGridView.Rows[i].Cells[2].Value = Program.stockList[i].Game.Title;
                    deleteDataGridView.Rows[i].Cells[3].Value = Program.stockList[i].Game.Category;

                    if (Program.stockList[i].IsRented == true)
                        deleteDataGridView.Rows[i].Cells[4].Value = "Yes";
                    else
                        deleteDataGridView.Rows[i].Cells[4].Value = "No";
                }
            }

            else
            {
                for (int i = 0; i < Program.stockList.Count(); i++)
                {
                    if (Program.stockList[i].IsRented == false)
                    {
                        deleteDataGridView.Rows.Add();
                        deleteDataGridView.Rows[pos].Cells[0].Value = Program.stockList[i].StockID;
                        deleteDataGridView.Rows[pos].Cells[1].Value = Program.stockList[i].Game.GameID;
                        deleteDataGridView.Rows[pos].Cells[2].Value = Program.stockList[i].Game.Title;
                        deleteDataGridView.Rows[pos].Cells[3].Value = Program.stockList[i].Game.Category;
                        deleteDataGridView.Rows[pos].Cells[4].Value = "No";

                        pos++;
                    }
                }
            }

        }

        private void deleteGameButton_Click(object sender, EventArgs e)
        {
            bool gameDeleted = false;
            if (deleteDataGridView.SelectedCells.Count > 0)
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to pernamentally delete the selected game(s) ?", "Delete Selected Game(s) ?", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    for (int i = 0; i < deleteDataGridView.SelectedRows.Count; i++)
                    {
                        //int selectedrowindex = deleteDataGridView.SelectedCells[i].RowIndex;
                        int selectedrowindex = deleteDataGridView.SelectedRows[i].Index;

                        DataGridViewRow selectedRow = deleteDataGridView.Rows[selectedrowindex];

                        int stockID = (int)selectedRow.Cells[0].Value;
                        int gameID = (int)selectedRow.Cells[1].Value;

                        int deleteStockIndex = Program.stockList.FindIndex(stock => stock.HasStockID(stockID));

                        //Check if game is currently rented
                        if (Program.stockList[deleteStockIndex].IsRented == true)
                        {
                            DialogResult cantDeleteMsg = MessageBox.Show(String.Format("Game with Stock ID: {0} cannot be deleted because it is currently being rented", stockID), "Game Cannot Be Deleted", MessageBoxButtons.OK);
                        }

                        else
                        {
                            int updateGameIndex = Program.gameList.FindIndex(game => game.HasID(gameID));
                            int currentNumCopies = Program.gameList[updateGameIndex].NumCopies;
                            int newNumCopies = currentNumCopies - 1;
                            Program.gameList[updateGameIndex].NumCopies = newNumCopies;

                            if (Program.gameList[updateGameIndex].NumCopies < 1)
                                Program.gameList.RemoveAt(updateGameIndex);

                            Program.stockList.RemoveAt(deleteStockIndex);
                            gameDeleted = true;
                        }
                    }
                    LoadDeleteGrid();
                    if (gameDeleted)
                    {
                        DialogResult deleteResult = MessageBox.Show("Game(s) successfully deleted", "Game(s) Deleted", MessageBoxButtons.OK);

                    }
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

        private void searchByIDButton_Click(object sender, EventArgs e)
        {
            string searchValue = searchTextBox.Text;

            deleteDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            try
            {
                deleteDataGridView.ClearSelection();
                foreach (DataGridViewRow row in deleteDataGridView.Rows)
                {
                    if (row.Cells[0].Value.ToString().Equals(searchValue))
                    {
                        row.Selected = true;
                        deleteDataGridView.FirstDisplayedScrollingRowIndex = deleteDataGridView.SelectedRows[0].Index;
                        break;
                    }
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void searchTextBox_Enter(object sender, EventArgs e)
        {
           
            if (searchTextBox.Text == "Search By Stock ID")
            {
                searchTextBox.Text = "";
                searchTextBox.ForeColor = Color.Black;
            }
        }
    }
}
