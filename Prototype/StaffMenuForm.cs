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
    public partial class StaffMenuForm : Form
    {
        public StaffMenuForm()
        {
            InitializeComponent();
            logoutButton.Select();
            Program.LoadGames();
            Program.LoadStock();
            Program.LoadCustomers();
            Program.LoadAcc();
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

        private void rentGameButton_MouseEnter(object sender, EventArgs e)
        {
            rentGameButton.BackgroundImage = null;
            rentGameButton.Text = "Rent Game";
        }

        private void rentGameButton_MouseLeave(object sender, EventArgs e)
        {
            rentGameButton.Text = "";
            rentGameButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.rent_game));
        }

        private void returnGameButton_MouseEnter(object sender, EventArgs e)
        {
            returnGameButton.BackgroundImage = null;
            returnGameButton.Text = "Return Game";
        }

        private void returnGameButton_MouseLeave(object sender, EventArgs e)
        {
            returnGameButton.Text = "";
            returnGameButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.return_game));
        }

        private void reserveGameButton_MouseEnter(object sender, EventArgs e)
        {
            reserveGameButton.BackgroundImage = null;
            reserveGameButton.Text = "Reserve Game";
        }

        private void reserveGameButton_MouseLeave(object sender, EventArgs e)
        {
            reserveGameButton.Text = "";
            reserveGameButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.reserve));
        }

        private void catalogueButton_MouseEnter(object sender, EventArgs e)
        {
            catalogueButton.BackgroundImage = null;
            catalogueButton.Text = "View Game";
        }

        private void catalogueButton_MouseLeave(object sender, EventArgs e)
        {
            catalogueButton.Text = "";
            catalogueButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.catalogue));
        }

        private void searchGameButton_MouseEnter(object sender, EventArgs e)
        {
            searchGameButton.BackgroundImage = null;
            searchGameButton.Text = "Game Availibility";
        }

        private void searchGameButton_MouseLeave(object sender, EventArgs e)
        {
            searchGameButton.Text = "";
            searchGameButton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.search));
        }

        private void addMemberButton_Click(object sender, EventArgs e)
        {
            NewMemberForm newMember = new NewMemberForm();
            newMember.Show();
        }

        private void StaffMenuForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Program.SaveStock();
            Program.SaveCustomer();
            Program.SaveAcc();
            Program.SaveGames();
        }

        private void returnGameButton_Click(object sender, EventArgs e)
        {
            ReturnGameForm returnGame = new ReturnGameForm();
            returnGame.Show();
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            Program.SaveStock();
            Program.SaveCustomer();
            Program.SaveAcc();
            Program.SaveGames();

            this.Hide();

            LoginForm login = new LoginForm();
            login.ShowDialog();

            this.Close();
        }

        private void rentGameButton_Click(object sender, EventArgs e)
        {
            RentGameForm rentGame = new RentGameForm();
            rentGame.Show();
        }

        private void viewMemberButton_Click(object sender, EventArgs e)
        {
            ViewMemberForm viewMember = new ViewMemberForm();
            viewMember.Show();
        }

        private void deleteMemberButton_Click(object sender, EventArgs e)
        {
            DeleteMemberForm deleteMem = new DeleteMemberForm();
            deleteMem.Show();
        }

        private void editMemberButton_Click(object sender, EventArgs e)
        {
            EditMemberForm editMem = new EditMemberForm();
            editMem.Show();
        }

        private void catalogueButton_Click(object sender, EventArgs e)
        {
            ViewGameForm view = new ViewGameForm();
            view.Show();
        }

        private void searchGameButton_Click(object sender, EventArgs e)
        {
            GameAvailabilityForm avail = new GameAvailabilityForm();
            avail.Show();
        }

        private void reserveGameButton_Click(object sender, EventArgs e)
        {
            ReserveForm reserve = new ReserveForm();
            reserve.Show();
        }
    }
}
