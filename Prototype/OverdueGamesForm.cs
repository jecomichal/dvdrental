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
    public partial class OverdueGamesForm : Form
    {
        public OverdueGamesForm()
        {
            InitializeComponent();
            LoadList();
        }

        public void LoadList()
        {
             dataGridView1.Rows.Clear();
            int pos = 0;

            for (int i = 0; i < Program.stockList.Count(); i++)
            {
                string strDueDate = Program.stockList[i].DueDate.ToString("dd/MM/yyyy");
                string strToday = DateTime.Today.ToString("dd/MM/yyyy");

                DateTime dueDate = DateTime.ParseExact(strDueDate, "dd/MM/yyyy", null);
                DateTime today = DateTime.ParseExact(strToday, "dd/MM/yyyy", null);


                int result = DateTime.Compare(today, dueDate);

                if (Program.stockList[i].IsRented == true && result > 0)
                {
                    dataGridView1.Rows.Add();
                    dataGridView1.Rows[pos].Cells[0].Value = Program.stockList[i].StockID;
                    dataGridView1.Rows[pos].Cells[1].Value = Program.stockList[i].Game.Title;
                    dataGridView1.Rows[pos].Cells[2].Value = Program.stockList[i].Customer.CustID;
                    dataGridView1.Rows[pos].Cells[3].Value = Program.stockList[i].Customer.FirstName;
                    dataGridView1.Rows[pos].Cells[4].Value = Program.stockList[i].Customer.Surname;
                    dataGridView1.Rows[pos].Cells[5].Value = Program.stockList[i].IssueDate.ToString("dd/MM/yyyy");
                    dataGridView1.Rows[pos].Cells[6].Value = Program.stockList[i].DueDate.ToString("dd/MM/yyyy");
                    pos++;
                }  
            }
        }

       
    }
}
