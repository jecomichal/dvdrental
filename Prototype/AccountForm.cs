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
    public partial class AccountForm : Form
    {
        public AccountForm()
        {
            InitializeComponent();
            LoadAccountGrid();

        }

        public void LoadAccountGrid()
        {
            accountDataGridView.Rows.Clear();
           
            for (int i = 0; i < Program.accountList.Count(); i++)
            {
                accountDataGridView.Rows.Add();
                accountDataGridView.Rows[i].Cells[0].Value = Program.accountList[i].AccID;
                accountDataGridView.Rows[i].Cells[1].Value = Program.accountList[i].Customer.CustID;
                accountDataGridView.Rows[i].Cells[2].Value = Program.accountList[i].Customer.FirstName;
                accountDataGridView.Rows[i].Cells[3].Value = Program.accountList[i].Customer.Surname;
                accountDataGridView.Rows[i].Cells[4].Value = Program.accountList[i].JoinFee;
                accountDataGridView.Rows[i].Cells[5].Value = Program.accountList[i].RentFee;
                accountDataGridView.Rows[i].Cells[6].Value = Program.accountList[i].LateFee;
                accountDataGridView.Rows[i].Cells[7].Value = Program.accountList[i].JoinFee + Program.accountList[i].RentFee + Program.accountList[i].LateFee;
            }
            
        }
    }

   
}
