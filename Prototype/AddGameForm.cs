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
using System.IO;

namespace Prototype
{
    public partial class AddGameForm : Form
    {
        public AddGameForm()
        {
            InitializeComponent();
            gameIDTextBox.Text = Program.GetNextGameID().ToString();
        }

       

        

        private void addGameButton_Click(object sender, EventArgs e)
        {
            titleCheck.Visible = false;
            categoryCheck.Visible = false;
            releaseCheck.Visible = false;
            ageCheck.Visible = false;
            numCopiesCheck.Visible = false;

            int copies;
            bool isNumeric = Int32.TryParse(numCopiesTextBox.Text, out copies);
           
            
            if (titleTextBox.Text.Length == 0 || titleTextBox.Text == "Title")
            {
                titleCheck.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.x));
                titleCheck.Visible = true;
            }

            else if (categoryComboBox.Text == "Category")
            {
                categoryCheck.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.x));
                categoryCheck.Visible = true;
            }

            else if (releaseComboBox.Text == "Release Year")
            {
                releaseCheck.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.x));
                releaseCheck.Visible = true;
            }

            else if (ageComboBox.Text == "Age Category")
            {
                ageCheck.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.x));
                ageCheck.Visible = true;
            }

            else if(numCopiesTextBox.Text == "Number of Copies")
            {
                numCopiesCheck.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.x));
                numCopiesCheck.Visible = true;
            }

            else if(!isNumeric)
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

                try
                {
                    string title, category, releaseYear;
                    int gameID, ageCategory, numCopies;


                    gameID = Int32.Parse(gameIDTextBox.Text);
                    ageCategory = Int32.Parse(ageComboBox.Text);
                    numCopies = Int32.Parse(numCopiesTextBox.Text);
                    title = titleTextBox.Text;
                    category = categoryComboBox.Text;
                    releaseYear = releaseComboBox.Text;

                    Game newGame = new Game(gameID, title, category, releaseYear, ageCategory, numCopies);
                    Program.gameList.Add(newGame);

                    //Create fake customer
                    Customer cust = new Customer(0, " ", " ", " ", 0, " ");
                    //Add Stock Items
                    for (int i = 0; i < numCopies; i++)
                    {
                        int nextID = Program.GetNextStockID();
                        StockItem newStockItem = new StockItem(nextID, newGame, cust);
                        Program.stockList.Add(newStockItem);
                    }

                    DialogResult dialogResult = MessageBox.Show("Game was successfully added. Add another one ?", "Success!", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        AddGameForm anotherGame = new AddGameForm();
                        anotherGame.Show();
                        this.Close();
                    }
                    else
                    {
                        this.Close();
                    }
                   
                }

                catch (Exception ex)
                {

                }
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are You sure?", "", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void titleTextBox_Enter(object sender, EventArgs e)
        {
            if (titleTextBox.Text == "Title")
            {
                titleTextBox.Text = "";
                titleTextBox.ForeColor = Color.Black;
            }
        }

        private void titleTextBox_Leave(object sender, EventArgs e)
        {
            if (titleTextBox.Text.Length == 0)
            {
                titleTextBox.Text = "Title";
                titleTextBox.ForeColor = Color.Silver;
            }
        }

        private void categoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(categoryComboBox.SelectedText != "Category")
            {
                categoryComboBox.ForeColor = Color.Black;
            }
        }

        private void categoryComboBox_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
        }

        private void releaseComboBox_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
        }

        private void releaseComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (releaseComboBox.SelectedText != "Release Year")
            {
                releaseComboBox.ForeColor = Color.Black;
            }
        }

        private void ageComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ageComboBox.SelectedText != "Age Category")
            {
                ageComboBox.ForeColor = Color.Black;
            }
        }

        private void ageComboBox_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
        }

        private void numCopiesTextBox_Enter(object sender, EventArgs e)
        {
            if (numCopiesTextBox.Text == "Number of Copies")
            {
                numCopiesTextBox.Text = "";
                numCopiesTextBox.ForeColor = Color.Black;
            }
        }

        private void numCopiesTextBox_Leave(object sender, EventArgs e)
        {
            if (numCopiesTextBox.Text.Length == 0)
            {
                numCopiesTextBox.Text = "Number of Copies";
                numCopiesTextBox.ForeColor = Color.Silver;
            }
        }
    }
}
