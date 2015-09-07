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
    public partial class GameAvailabilityForm : Form
    {
        public GameAvailabilityForm()
        {
            InitializeComponent();
            LoadAvailGrid();
        }

        public void LoadAvailGrid()
        {
            stockDataGridView.Rows.Clear();
            for (int i = 0; i < Program.stockList.Count(); i++)
            {
                stockDataGridView.Rows.Add();
                stockDataGridView.Rows[i].Cells[0].Value = Program.stockList[i].StockID;
                stockDataGridView.Rows[i].Cells[1].Value = Program.stockList[i].Game.Title;
                stockDataGridView.Rows[i].Cells[2].Value = Program.stockList[i].IsRented == true ? "Yes" : "No";
                stockDataGridView.Rows[i].Cells[3].Value = Program.stockList[i].IsReserved == true ? "Yes" : "No";
            }
        }
    }
}
