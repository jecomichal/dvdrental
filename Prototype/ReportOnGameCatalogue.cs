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
    public partial class ReportOnGameCatalogue : Form
    {
        public ReportOnGameCatalogue()
        {
            InitializeComponent();
            LoadDataGrid();
        }
        public void LoadDataGrid()
        {
            for (int i = 0; i < Program.gameList.Count(); i++)
                {
                    reportDataGridView.Rows.Add();
                    reportDataGridView.Rows[i].Cells[0].Value = Program.gameList[i].GameID;
                    reportDataGridView.Rows[i].Cells[1].Value = Program.gameList[i].Title;
                    reportDataGridView.Rows[i].Cells[2].Value = Program.gameList[i].Category;
                    reportDataGridView.Rows[i].Cells[3].Value = Program.gameList[i].ReleaseYear;
                    reportDataGridView.Rows[i].Cells[4].Value = Program.gameList[i].AgeCategory;
                    reportDataGridView.Rows[i].Cells[5].Value = Program.gameList[i].NumCopies;
                }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
