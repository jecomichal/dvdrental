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
    public partial class EditGameForm : Form
    {
        public EditGameForm()
        {
            InitializeComponent();
            searchIDRadio.Checked = true;
        }

        private void searchIDRadio_CheckedChanged(object sender, EventArgs e)
        {
            searchTitleTextBox.Visible = false;
            searchTitleCheck.Visible = false;
            searchIDTextBox.Visible = true;

            searchIDTextBox.Text = "Search By GameID";
            searchIDTextBox.ForeColor = Color.DarkGray;
            gameDetailsPanel.Visible = false;
            updateGameButton.Visible = false;
            searchGameButton.Visible = true;
        }

        private void searchTitleRadio_CheckedChanged(object sender, EventArgs e)
        {
            searchIDTextBox.Visible = false;
            searchIDCheck.Visible = false;
            searchTitleTextBox.Visible = true;

            searchTitleTextBox.Text = "Search By Title";
            searchTitleTextBox.ForeColor = Color.DarkGray;
            gameDetailsPanel.Visible = false;
            updateGameButton.Visible = false;
            searchGameButton.Visible = true;
        }

        private void updateGameButton_Click(object sender, EventArgs e)
        {
            int copies;
            bool isNumeric = Int32.TryParse(numCopiesTextBox.Text, out copies);

            if (titleTextBox.Text.Trim().Length == 0)
            {
                titleCheck.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.x));
                titleCheck.Visible = true;
            }

            else if (!isNumeric)
            {
                numCopiesCheck.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.x));
                numCopiesCheck.Visible = true;
            }

            else
            {
                titleCheck.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.tick));
                titleCheck.Visible = true;
                categoryCheck.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.tick));
                categoryCheck.Visible = true;
                releaseCheck.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.tick));
                releaseCheck.Visible = true;
                ageCheck.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.tick));
                ageCheck.Visible = true;
                numCopiesCheck.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.tick));
                numCopiesCheck.Visible = true;

                
               
                string newTitle, newCategory, newReleaseYear;
                int newAgeCategory, newNumCopies, currentNumCopies = 0, addToStock = 0, location = 0;
                Game newGame = new Game(0,"","","",0,0);

                newAgeCategory = Int32.Parse(ageComboBox.Text);
                newNumCopies = (int)numCopiesTextBox.Value;
                newTitle = titleTextBox.Text;
                newCategory = categoryComboBox.Text;
                newReleaseYear = releaseComboBox.Text;


                if (searchIDRadio.Checked == true)
                    location = Program.gameList.FindIndex(game => game.HasID(Int32.Parse(searchIDTextBox.Text)));


                else
                    location = Program.gameList.FindIndex(game => game.HasTitle(searchTitleTextBox.Text));
                   
                currentNumCopies = Program.gameList[location].NumCopies;
                if (newNumCopies != currentNumCopies)
                {
                    addToStock = (newNumCopies - currentNumCopies);
                }
               
                Program.gameList[location].Title = newTitle;
                Program.gameList[location].Category = newCategory;
                Program.gameList[location].ReleaseYear = newReleaseYear;
                Program.gameList[location].AgeCategory = newAgeCategory;
                Program.gameList[location].NumCopies = newNumCopies;
                newGame = Program.gameList[location];

                //Update current stock

                if (searchIDRadio.Checked == true)
                {
                    for (int i = 0; i < Program.stockList.Count(); i++)
                    {
                        if (Program.stockList[i].Game.HasID(Int32.Parse(searchIDTextBox.Text)))
                        {
                            Program.stockList[i].Game.Title = newTitle;
                            Program.stockList[i].Game.Category = newCategory;
                            Program.stockList[i].Game.ReleaseYear = newReleaseYear;
                            Program.stockList[i].Game.AgeCategory = newAgeCategory;
                            Program.stockList[i].Game.NumCopies = newNumCopies;
                        }
                    }
                }

                else
                {
                    for (int i = 0; i < Program.stockList.Count(); i++)
                    {
                        if (Program.stockList[i].Game.HasTitle(searchTitleTextBox.Text))
                        {
                            Program.stockList[i].Game.Title = newTitle;
                            Program.stockList[i].Game.Category = newCategory;
                            Program.stockList[i].Game.ReleaseYear = newReleaseYear;
                            Program.stockList[i].Game.AgeCategory = newAgeCategory;
                            Program.stockList[i].Game.NumCopies = newNumCopies;
                        }
                    }
                }

                //Create fake customer
                Customer cust = new Customer(0, " ", " ", " ", 0, " ");

                //Add Stock Items
                for (int i = 0; i < addToStock; i++)
                {
                    int nextID = Program.GetNextStockID();
                    StockItem newStockItem = new StockItem(nextID, newGame, cust);
                    Program.stockList.Add(newStockItem);
                }

                DialogResult dialogResult = MessageBox.Show("Game was successfully Updated.", "Success!", MessageBoxButtons.OK);
                if (dialogResult == DialogResult.OK)
                {  
                    this.Close();
                }
                                
            }
        }

        private void searchGameButton_Click(object sender, EventArgs e)
        {
            //Hide Labels
            searchIDCheck.Visible = false;
            searchTitleCheck.Visible = false;
            notFoundLabel.Visible = false;
            Game editGame = new Game(0, "", "", "", 0, 0);

            if (searchIDRadio.Checked == true)
            {
                int gameID;
                bool isNumeric = Int32.TryParse(searchIDTextBox.Text, out gameID);
               
                //Find the game with corresponding GameID
                editGame = Program.gameList.Find(game => game.HasID(gameID));

                if (searchIDTextBox.Text == "Search By GameID")
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

                else if (editGame == null)
                {
                    notFoundLabel.Visible = true;
                }

                else
                {

                    gameDetailsPanel.Visible = true;
                    titleTextBox.Text = editGame.Title;
                    categoryComboBox.SelectedItem = editGame.Category;
                    releaseComboBox.SelectedItem = editGame.ReleaseYear;
                    ageComboBox.SelectedItem = editGame.AgeCategory.ToString();
                    numCopiesTextBox.Minimum = editGame.NumCopies;
                    numCopiesTextBox.Value = editGame.NumCopies;

                    searchGameButton.Visible = false;
                    updateGameButton.Visible = true;
                }
            }

            else
            {
                //Find the game with corresponding Title
                editGame = Program.gameList.Find(game => game.HasTitle(searchTitleTextBox.Text));

                if (searchTitleTextBox.Text == "Search By Title")
                {
                    searchTitleCheck.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.x));
                    searchTitleCheck.Visible = true;
                }

                else if (searchTitleTextBox.Text.Trim().Length == 0)
                {
                    searchTitleCheck.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.x));
                    searchTitleCheck.Visible = true;
                }

                else if (editGame == null)
                {
                    notFoundLabel.Visible = true;
                }

                else
                {

                    gameDetailsPanel.Visible = true;
                    titleTextBox.Text = editGame.Title;
                    categoryComboBox.SelectedItem = editGame.Category;
                    releaseComboBox.SelectedItem = editGame.ReleaseYear;
                    ageComboBox.SelectedItem = editGame.AgeCategory.ToString();
                    numCopiesTextBox.Minimum = editGame.NumCopies;

                    searchGameButton.Visible = false;
                    updateGameButton.Visible = true;
                }
            }
        }

        private void searchIDTextBox_Enter(object sender, EventArgs e)
        {
            if (searchIDTextBox.Text == "Search By GameID")
            {
                searchIDTextBox.Text = "";
                searchIDTextBox.ForeColor = Color.Black;
            }
            else
            {
                gameDetailsPanel.Visible = false;
                updateGameButton.Visible = false;
                searchGameButton.Visible = true;
            }          
        }

        private void searchTitleTextBox_Enter(object sender, EventArgs e)
        {
            if (searchTitleTextBox.Text == "Search By Title")
            {
                searchTitleTextBox.Text = "";
                searchTitleTextBox.ForeColor = Color.Black;
            }
            else
            {
                gameDetailsPanel.Visible = false;
                updateGameButton.Visible = false;
                searchGameButton.Visible = true;
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            if (updateGameButton.Visible == true)
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
