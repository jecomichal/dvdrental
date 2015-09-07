namespace Prototype
{
    partial class EditGameForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cancelButton = new System.Windows.Forms.Button();
            this.updateGameButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.searchIDTextBox = new System.Windows.Forms.TextBox();
            this.searchTitleTextBox = new System.Windows.Forms.TextBox();
            this.gameDetailsPanel = new System.Windows.Forms.Panel();
            this.numCopiesTextBox = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numCopiesCheck = new System.Windows.Forms.Panel();
            this.ageCheck = new System.Windows.Forms.Panel();
            this.ageComboBox = new System.Windows.Forms.ComboBox();
            this.releaseCheck = new System.Windows.Forms.Panel();
            this.categoryCheck = new System.Windows.Forms.Panel();
            this.titleCheck = new System.Windows.Forms.Panel();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.categoryComboBox = new System.Windows.Forms.ComboBox();
            this.releaseComboBox = new System.Windows.Forms.ComboBox();
            this.searchIDRadio = new System.Windows.Forms.RadioButton();
            this.searchTitleRadio = new System.Windows.Forms.RadioButton();
            this.notFoundLabel = new System.Windows.Forms.Label();
            this.searchGameButton = new System.Windows.Forms.Button();
            this.searchIDCheck = new System.Windows.Forms.Panel();
            this.searchTitleCheck = new System.Windows.Forms.Panel();
            this.imagePanel = new System.Windows.Forms.Panel();
            this.gameDetailsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCopiesTextBox)).BeginInit();
            this.SuspendLayout();
            // 
            // cancelButton
            // 
            this.cancelButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.cancelButton.FlatAppearance.BorderSize = 0;
            this.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelButton.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButton.ForeColor = System.Drawing.Color.White;
            this.cancelButton.Location = new System.Drawing.Point(154, 506);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(125, 40);
            this.cancelButton.TabIndex = 25;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = false;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // updateGameButton
            // 
            this.updateGameButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.updateGameButton.FlatAppearance.BorderSize = 0;
            this.updateGameButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateGameButton.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateGameButton.ForeColor = System.Drawing.Color.White;
            this.updateGameButton.Location = new System.Drawing.Point(154, 460);
            this.updateGameButton.Name = "updateGameButton";
            this.updateGameButton.Size = new System.Drawing.Size(125, 40);
            this.updateGameButton.TabIndex = 24;
            this.updateGameButton.Text = "Update";
            this.updateGameButton.UseVisualStyleBackColor = false;
            this.updateGameButton.Visible = false;
            this.updateGameButton.Click += new System.EventHandler(this.updateGameButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.label1.Location = new System.Drawing.Point(133, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 16);
            this.label1.TabIndex = 37;
            this.label1.Text = "Search for game to edit";
            // 
            // searchIDTextBox
            // 
            this.searchIDTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.searchIDTextBox.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchIDTextBox.ForeColor = System.Drawing.Color.DarkGray;
            this.searchIDTextBox.Location = new System.Drawing.Point(133, 217);
            this.searchIDTextBox.Name = "searchIDTextBox";
            this.searchIDTextBox.Size = new System.Drawing.Size(175, 22);
            this.searchIDTextBox.TabIndex = 38;
            this.searchIDTextBox.Text = "Search by GameID";
            this.searchIDTextBox.Visible = false;
            this.searchIDTextBox.Enter += new System.EventHandler(this.searchIDTextBox_Enter);
            // 
            // searchTitleTextBox
            // 
            this.searchTitleTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.searchTitleTextBox.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchTitleTextBox.ForeColor = System.Drawing.Color.DarkGray;
            this.searchTitleTextBox.Location = new System.Drawing.Point(133, 217);
            this.searchTitleTextBox.Name = "searchTitleTextBox";
            this.searchTitleTextBox.Size = new System.Drawing.Size(175, 22);
            this.searchTitleTextBox.TabIndex = 39;
            this.searchTitleTextBox.Text = "Search By Title";
            this.searchTitleTextBox.Visible = false;
            this.searchTitleTextBox.Enter += new System.EventHandler(this.searchTitleTextBox_Enter);
            // 
            // gameDetailsPanel
            // 
            this.gameDetailsPanel.Controls.Add(this.numCopiesTextBox);
            this.gameDetailsPanel.Controls.Add(this.label6);
            this.gameDetailsPanel.Controls.Add(this.label5);
            this.gameDetailsPanel.Controls.Add(this.label4);
            this.gameDetailsPanel.Controls.Add(this.label3);
            this.gameDetailsPanel.Controls.Add(this.label2);
            this.gameDetailsPanel.Controls.Add(this.numCopiesCheck);
            this.gameDetailsPanel.Controls.Add(this.ageCheck);
            this.gameDetailsPanel.Controls.Add(this.ageComboBox);
            this.gameDetailsPanel.Controls.Add(this.releaseCheck);
            this.gameDetailsPanel.Controls.Add(this.categoryCheck);
            this.gameDetailsPanel.Controls.Add(this.titleCheck);
            this.gameDetailsPanel.Controls.Add(this.titleTextBox);
            this.gameDetailsPanel.Controls.Add(this.categoryComboBox);
            this.gameDetailsPanel.Controls.Add(this.releaseComboBox);
            this.gameDetailsPanel.Location = new System.Drawing.Point(2, 258);
            this.gameDetailsPanel.Name = "gameDetailsPanel";
            this.gameDetailsPanel.Size = new System.Drawing.Size(401, 196);
            this.gameDetailsPanel.TabIndex = 41;
            this.gameDetailsPanel.Visible = false;
            // 
            // numCopiesTextBox
            // 
            this.numCopiesTextBox.Location = new System.Drawing.Point(131, 163);
            this.numCopiesTextBox.Name = "numCopiesTextBox";
            this.numCopiesTextBox.Size = new System.Drawing.Size(175, 20);
            this.numCopiesTextBox.TabIndex = 53;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.label6.Location = new System.Drawing.Point(3, 170);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 13);
            this.label6.TabIndex = 52;
            this.label6.Text = "Number of Copies";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.label5.Location = new System.Drawing.Point(30, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 13);
            this.label5.TabIndex = 51;
            this.label5.Text = "Age Category";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.label4.Location = new System.Drawing.Point(33, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 50;
            this.label4.Text = "Release Year";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.label3.Location = new System.Drawing.Point(59, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 49;
            this.label3.Text = "Category";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.label2.Location = new System.Drawing.Point(89, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 48;
            this.label2.Text = "Title";
            // 
            // numCopiesCheck
            // 
            this.numCopiesCheck.BackgroundImage = global::Prototype.Properties.Resources.tick;
            this.numCopiesCheck.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.numCopiesCheck.Location = new System.Drawing.Point(312, 167);
            this.numCopiesCheck.Name = "numCopiesCheck";
            this.numCopiesCheck.Size = new System.Drawing.Size(16, 16);
            this.numCopiesCheck.TabIndex = 43;
            this.numCopiesCheck.Visible = false;
            // 
            // ageCheck
            // 
            this.ageCheck.BackgroundImage = global::Prototype.Properties.Resources.tick;
            this.ageCheck.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ageCheck.Location = new System.Drawing.Point(312, 128);
            this.ageCheck.Name = "ageCheck";
            this.ageCheck.Size = new System.Drawing.Size(16, 16);
            this.ageCheck.TabIndex = 44;
            this.ageCheck.Visible = false;
            // 
            // ageComboBox
            // 
            this.ageComboBox.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ageComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.ageComboBox.FormattingEnabled = true;
            this.ageComboBox.Items.AddRange(new object[] {
            "7",
            "12",
            "16",
            "18"});
            this.ageComboBox.Location = new System.Drawing.Point(131, 122);
            this.ageComboBox.MaxDropDownItems = 10;
            this.ageComboBox.Name = "ageComboBox";
            this.ageComboBox.Size = new System.Drawing.Size(175, 22);
            this.ageComboBox.TabIndex = 40;
            // 
            // releaseCheck
            // 
            this.releaseCheck.BackgroundImage = global::Prototype.Properties.Resources.tick;
            this.releaseCheck.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.releaseCheck.Location = new System.Drawing.Point(312, 89);
            this.releaseCheck.Name = "releaseCheck";
            this.releaseCheck.Size = new System.Drawing.Size(16, 16);
            this.releaseCheck.TabIndex = 45;
            this.releaseCheck.Visible = false;
            // 
            // categoryCheck
            // 
            this.categoryCheck.BackgroundImage = global::Prototype.Properties.Resources.tick;
            this.categoryCheck.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.categoryCheck.Location = new System.Drawing.Point(312, 52);
            this.categoryCheck.Name = "categoryCheck";
            this.categoryCheck.Size = new System.Drawing.Size(16, 16);
            this.categoryCheck.TabIndex = 46;
            this.categoryCheck.Visible = false;
            // 
            // titleCheck
            // 
            this.titleCheck.BackgroundImage = global::Prototype.Properties.Resources.tick;
            this.titleCheck.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.titleCheck.Location = new System.Drawing.Point(312, 14);
            this.titleCheck.Name = "titleCheck";
            this.titleCheck.Size = new System.Drawing.Size(16, 16);
            this.titleCheck.TabIndex = 42;
            this.titleCheck.Visible = false;
            // 
            // titleTextBox
            // 
            this.titleTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.titleTextBox.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.titleTextBox.Location = new System.Drawing.Point(131, 8);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(175, 22);
            this.titleTextBox.TabIndex = 37;
            // 
            // categoryComboBox
            // 
            this.categoryComboBox.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.categoryComboBox.FormattingEnabled = true;
            this.categoryComboBox.Items.AddRange(new object[] {
            "Action",
            "Adventure",
            "Classics",
            "Fighting",
            "Puzzle",
            "Racing",
            "RPG",
            "Shooter",
            "Sports",
            "Strategy"});
            this.categoryComboBox.Location = new System.Drawing.Point(131, 46);
            this.categoryComboBox.MaxDropDownItems = 10;
            this.categoryComboBox.Name = "categoryComboBox";
            this.categoryComboBox.Size = new System.Drawing.Size(175, 22);
            this.categoryComboBox.Sorted = true;
            this.categoryComboBox.TabIndex = 38;
            // 
            // releaseComboBox
            // 
            this.releaseComboBox.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.releaseComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.releaseComboBox.FormattingEnabled = true;
            this.releaseComboBox.Items.AddRange(new object[] {
            "2000",
            "2001",
            "2002",
            "2003",
            "2004",
            "2005",
            "2006",
            "2007",
            "2008",
            "2009",
            "2010",
            "2011",
            "2012",
            "2013",
            "2014",
            "2015"});
            this.releaseComboBox.Location = new System.Drawing.Point(131, 83);
            this.releaseComboBox.MaxDropDownItems = 10;
            this.releaseComboBox.Name = "releaseComboBox";
            this.releaseComboBox.Size = new System.Drawing.Size(175, 22);
            this.releaseComboBox.Sorted = true;
            this.releaseComboBox.TabIndex = 39;
            // 
            // searchIDRadio
            // 
            this.searchIDRadio.AutoSize = true;
            this.searchIDRadio.Location = new System.Drawing.Point(167, 167);
            this.searchIDRadio.Name = "searchIDRadio";
            this.searchIDRadio.Size = new System.Drawing.Size(116, 17);
            this.searchIDRadio.TabIndex = 44;
            this.searchIDRadio.TabStop = true;
            this.searchIDRadio.Text = "Search By GameID";
            this.searchIDRadio.UseVisualStyleBackColor = true;
            this.searchIDRadio.CheckedChanged += new System.EventHandler(this.searchIDRadio_CheckedChanged);
            // 
            // searchTitleRadio
            // 
            this.searchTitleRadio.AutoSize = true;
            this.searchTitleRadio.Location = new System.Drawing.Point(167, 190);
            this.searchTitleRadio.Name = "searchTitleRadio";
            this.searchTitleRadio.Size = new System.Drawing.Size(97, 17);
            this.searchTitleRadio.TabIndex = 45;
            this.searchTitleRadio.TabStop = true;
            this.searchTitleRadio.Text = "Search By Title";
            this.searchTitleRadio.UseVisualStyleBackColor = true;
            this.searchTitleRadio.CheckedChanged += new System.EventHandler(this.searchTitleRadio_CheckedChanged);
            // 
            // notFoundLabel
            // 
            this.notFoundLabel.AutoSize = true;
            this.notFoundLabel.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notFoundLabel.ForeColor = System.Drawing.Color.Crimson;
            this.notFoundLabel.Location = new System.Drawing.Point(161, 243);
            this.notFoundLabel.Name = "notFoundLabel";
            this.notFoundLabel.Size = new System.Drawing.Size(113, 16);
            this.notFoundLabel.TabIndex = 46;
            this.notFoundLabel.Text = "Game not found";
            this.notFoundLabel.Visible = false;
            // 
            // searchGameButton
            // 
            this.searchGameButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.searchGameButton.FlatAppearance.BorderSize = 0;
            this.searchGameButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchGameButton.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchGameButton.ForeColor = System.Drawing.Color.White;
            this.searchGameButton.Location = new System.Drawing.Point(154, 460);
            this.searchGameButton.Name = "searchGameButton";
            this.searchGameButton.Size = new System.Drawing.Size(125, 40);
            this.searchGameButton.TabIndex = 47;
            this.searchGameButton.Text = "Search";
            this.searchGameButton.UseVisualStyleBackColor = false;
            this.searchGameButton.Click += new System.EventHandler(this.searchGameButton_Click);
            // 
            // searchIDCheck
            // 
            this.searchIDCheck.BackgroundImage = global::Prototype.Properties.Resources.tick;
            this.searchIDCheck.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.searchIDCheck.Location = new System.Drawing.Point(314, 223);
            this.searchIDCheck.Name = "searchIDCheck";
            this.searchIDCheck.Size = new System.Drawing.Size(16, 16);
            this.searchIDCheck.TabIndex = 43;
            this.searchIDCheck.Visible = false;
            // 
            // searchTitleCheck
            // 
            this.searchTitleCheck.BackgroundImage = global::Prototype.Properties.Resources.tick;
            this.searchTitleCheck.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.searchTitleCheck.Location = new System.Drawing.Point(314, 224);
            this.searchTitleCheck.Name = "searchTitleCheck";
            this.searchTitleCheck.Size = new System.Drawing.Size(16, 16);
            this.searchTitleCheck.TabIndex = 43;
            this.searchTitleCheck.Visible = false;
            // 
            // imagePanel
            // 
            this.imagePanel.BackColor = System.Drawing.Color.Transparent;
            this.imagePanel.BackgroundImage = global::Prototype.Properties.Resources.edit_game_dark;
            this.imagePanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.imagePanel.Location = new System.Drawing.Point(163, 10);
            this.imagePanel.Name = "imagePanel";
            this.imagePanel.Size = new System.Drawing.Size(120, 120);
            this.imagePanel.TabIndex = 10;
            // 
            // EditGameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 559);
            this.Controls.Add(this.searchGameButton);
            this.Controls.Add(this.notFoundLabel);
            this.Controls.Add(this.searchTitleRadio);
            this.Controls.Add(this.searchIDRadio);
            this.Controls.Add(this.searchIDCheck);
            this.Controls.Add(this.searchTitleCheck);
            this.Controls.Add(this.gameDetailsPanel);
            this.Controls.Add(this.searchTitleTextBox);
            this.Controls.Add(this.searchIDTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.imagePanel);
            this.Controls.Add(this.updateGameButton);
            this.Controls.Add(this.cancelButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "EditGameForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit Game Details";
            this.gameDetailsPanel.ResumeLayout(false);
            this.gameDetailsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCopiesTextBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel imagePanel;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button updateGameButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox searchIDTextBox;
        private System.Windows.Forms.TextBox searchTitleTextBox;
        private System.Windows.Forms.Panel gameDetailsPanel;
        private System.Windows.Forms.Panel numCopiesCheck;
        private System.Windows.Forms.Panel ageCheck;
        private System.Windows.Forms.ComboBox ageComboBox;
        private System.Windows.Forms.Panel releaseCheck;
        private System.Windows.Forms.Panel categoryCheck;
        private System.Windows.Forms.Panel titleCheck;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.ComboBox categoryComboBox;
        private System.Windows.Forms.ComboBox releaseComboBox;
        private System.Windows.Forms.Panel searchTitleCheck;
        private System.Windows.Forms.Panel searchIDCheck;
        private System.Windows.Forms.RadioButton searchIDRadio;
        private System.Windows.Forms.RadioButton searchTitleRadio;
        private System.Windows.Forms.Label notFoundLabel;
        private System.Windows.Forms.Button searchGameButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numCopiesTextBox;
    }
}