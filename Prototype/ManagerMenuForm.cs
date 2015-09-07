using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prototype
{
    public partial class ManagerMenuForm : Form
    {
        public ManagerMenuForm()
        {
            InitializeComponent();
            Program.LoadGames();
            Program.LoadStock();
            Program.LoadCustomers();
            Program.LoadStaff();
            Program.LoadAcc();
        }

        private void viewStaffButton_MouseEnter(object sender, EventArgs e)
        {
            viewStaffButton.BackgroundImage = null;
            viewStaffButton.Text = "View Staff";
        }

        private void viewStaffButton_MouseLeave(object sender, EventArgs e)
        {
            viewStaffButton.Text = "";
            viewStaffButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.view_emp));
        }

        private void addStaffButton_MouseEnter(object sender, EventArgs e)
        {
            addStaffButton.BackgroundImage = null;
            addStaffButton.Text = "Add Staff";
        }

        private void addStaffButton_MouseLeave(object sender, EventArgs e)
        {
            addStaffButton.Text = "";
            addStaffButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.add_emp));
        }

        private void deleteStaffButton_MouseEnter(object sender, EventArgs e)
        {
            deleteStaffButton.BackgroundImage = null;
            deleteStaffButton.Text = "Delete Staff";
        }

        private void deleteStaffButton_MouseLeave(object sender, EventArgs e)
        {
            deleteStaffButton.Text = "";
            deleteStaffButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.delete_emp));
        }

        private void editStaffButton_MouseEnter(object sender, EventArgs e)
        {
            editStaffButton.BackgroundImage = null;
            editStaffButton.Text = "Edit Staff";
        }

        private void editStaffButton_MouseLeave(object sender, EventArgs e)
        {
            editStaffButton.Text = "";
            editStaffButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.edit_emp));
        }

        private void viewGameButton_MouseEnter(object sender, EventArgs e)
        {
           viewGameButton.BackgroundImage = null;
            viewGameButton.Text = "View Game";
        }

        private void viewGameButton_MouseLeave(object sender, EventArgs e)
        {
            viewGameButton.Text = "";
            viewGameButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.view_game));
        }

        private void addGameButton_MouseEnter(object sender, EventArgs e)
        {
            addGameButton.BackgroundImage = null;
            addGameButton.Text = "Add New Game";
        }

        private void addGameButton_MouseLeave(object sender, EventArgs e)
        {
            addGameButton.Text = "";
            addGameButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.add_game));
        }

        private void deleteGameButton_MouseEnter(object sender, EventArgs e)
        {
            deleteGameButton.BackgroundImage = null;
            deleteGameButton.Text = "Delete Game";
        }

        private void deleteGameButton_MouseLeave(object sender, EventArgs e)
        {
            deleteGameButton.Text = "";
            deleteGameButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.delete_game));
        }

        private void editGameButton_MouseEnter(object sender, EventArgs e)
        {
            editGameButton.BackgroundImage = null;
            editGameButton.Text = "Edit Game";
        }

        private void editGameButton_MouseLeave(object sender, EventArgs e)
        {
            editGameButton.Text = "";
            editGameButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.edit_game));
        }

        private void viewMemberButton_MouseEnter(object sender, EventArgs e)
        {
            viewMemberButton.BackgroundImage = null;
            viewMemberButton.Text = "View Member";
        }

        private void viewMemberButton_MouseLeave(object sender, EventArgs e)
        {
            viewMemberButton.Text = "";
            viewMemberButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.view_user));
        }

        private void addMemberButton_MouseEnter(object sender, EventArgs e)
        {
            addMemberButton.BackgroundImage = null;
            addMemberButton.Text = "Add New Member";
        }

        private void addMemberButton_MouseLeave(object sender, EventArgs e)
        {
            addMemberButton.Text = "";
            addMemberButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.add_user));
        }

        private void deleteMemberButton_MouseEnter(object sender, EventArgs e)
        {
            deleteMemberButton.BackgroundImage = null;
            deleteMemberButton.Text = "Delete Member";
        }

        private void deleteMemberButton_MouseLeave(object sender, EventArgs e)
        {
            deleteMemberButton.Text = "";
            deleteMemberButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.delete_user));
        }

        private void editMemberButton_MouseEnter(object sender, EventArgs e)
        {
            editMemberButton.BackgroundImage = null;
            editMemberButton.Text = "Edit Member";
        }

        private void editMemberButton_MouseLeave(object sender, EventArgs e)
        {
            editMemberButton.Text = "";
            editMemberButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.edit_user));
        }

        private void catalogueButton_MouseEnter(object sender, EventArgs e)
        {
            catalogueButton.BackgroundImage = null;
            catalogueButton.Text = "View Game Catalogue";
        }

        private void catalogueButton_MouseLeave(object sender, EventArgs e)
        {
            catalogueButton.Text = "";
            catalogueButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.catalogue));
        }

        private void transactionButton_MouseEnter(object sender, EventArgs e)
        {
            transactionButton.BackgroundImage = null;
            transactionButton.Text = "View Account Transactions";
        }

        private void transactionButton_MouseLeave(object sender, EventArgs e)
        {
            transactionButton.Text = "";
            transactionButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.money));
        }

        //Button Clicks
        private void addMemberButton_Click(object sender, EventArgs e)
        {
            NewMemberForm newMember = new NewMemberForm();
            newMember.Show();
        }

        private void overdueButton_Click(object sender, EventArgs e)
        {
            OverdueGamesForm overdueGames = new OverdueGamesForm();
            overdueGames.Show();
        }

        private void addGameButton_Click(object sender, EventArgs e)
        {
            AddGameForm addGameForm = new AddGameForm();
            addGameForm.Show();
        }

        private void editGameButton_Click(object sender, EventArgs e)
        {
            EditGameForm editGameForm = new EditGameForm();
            editGameForm.Show();
        }

        private void viewGameButton_Click(object sender, EventArgs e)
        {
            ViewGameForm viewGameForm = new ViewGameForm();
            viewGameForm.Show();
        }

        private void ManagerMenuForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Program.SaveGames();
            Program.SaveStock();
            Program.SaveCustomer();
            Program.SaveStaff();
            Program.SaveAcc();
        }

        private void deleteGameButton_Click(object sender, EventArgs e)
        {
            DeleteGameForm deleteGameForm = new DeleteGameForm();
            deleteGameForm.Show();
        }

        private void editMemberButton_Click(object sender, EventArgs e)
        {
            EditMemberForm editMemberForm = new EditMemberForm();
            editMemberForm.Show();
        }

        private void addStaffButton_Click(object sender, EventArgs e)
        {
            AddStaffForm addstaff = new AddStaffForm();
            addstaff.Show();
        }

        private void viewStaffButton_Click(object sender, EventArgs e)
        {
            ViewStaffForm viewStaff = new ViewStaffForm();
            viewStaff.Show();
        }

        private void editStaffButton_Click(object sender, EventArgs e)
        {
            EditStaffForm editStaff = new EditStaffForm();
            editStaff.Show();
        }

        private void deleteStaffButton_Click(object sender, EventArgs e)
        {
            DeleteStaffForm deleteStaff = new DeleteStaffForm();
            deleteStaff.Show();
        }

        private void transactionButton_Click(object sender, EventArgs e)
        {
            AccountForm accForm = new AccountForm();
            accForm.Show();
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            Program.SaveGames();
            Program.SaveStock();
            Program.SaveCustomer();
            Program.SaveStaff();
            Program.SaveAcc();

            this.Hide();

            LoginForm login = new LoginForm();
            login.ShowDialog();

            this.Close();
        }

        private void viewMemberButton_Click(object sender, EventArgs e)
        {
            ViewMemberForm viewMember = new ViewMemberForm();
            viewMember.Show();
        }

        private void deleteMemberButton_Click(object sender, EventArgs e)
        {
            DeleteMemberForm deletemember = new DeleteMemberForm();
            deletemember.Show();
        }

        private void catalogueButton_Click(object sender, EventArgs e)
        {
            ReportOnGameCatalogue report = new ReportOnGameCatalogue();
            report.Show();
        }

        private void overdueButton_MouseEnter(object sender, EventArgs e)
        {
            overdueButton.BackgroundImage = null;
            overdueButton.Text = "View Overdue Games";
        }

        private void overdueButton_MouseLeave(object sender, EventArgs e)
        {
            overdueButton.Text = "";
            overdueButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.overdue));
        }
    }
}
