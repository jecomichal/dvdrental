namespace Prototype
{
    partial class AddGameForm
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
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.gameIDTextBox = new System.Windows.Forms.TextBox();
            this.cancelButton = new System.Windows.Forms.Button();
            this.addGameButton = new System.Windows.Forms.Button();
            this.categoryComboBox = new System.Windows.Forms.ComboBox();
            this.releaseComboBox = new System.Windows.Forms.ComboBox();
            this.ageComboBox = new System.Windows.Forms.ComboBox();
            this.numCopiesCheck = new System.Windows.Forms.Panel();
            this.ageCheck = new System.Windows.Forms.Panel();
            this.releaseCheck = new System.Windows.Forms.Panel();
            this.categoryCheck = new System.Windows.Forms.Panel();
            this.titleCheck = new System.Windows.Forms.Panel();
            this.imagePanel = new System.Windows.Forms.Panel();
            this.numCopiesTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // titleTextBox
            // 
            this.titleTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.titleTextBox.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleTextBox.ForeColor = System.Drawing.Color.DarkGray;
            this.titleTextBox.Location = new System.Drawing.Point(55, 185);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(175, 22);
            this.titleTextBox.TabIndex = 13;
            this.titleTextBox.Text = "Title";
            this.titleTextBox.Enter += new System.EventHandler(this.titleTextBox_Enter);
            this.titleTextBox.Leave += new System.EventHandler(this.titleTextBox_Leave);
            // 
            // gameIDTextBox
            // 
            this.gameIDTextBox.BackColor = System.Drawing.Color.White;
            this.gameIDTextBox.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameIDTextBox.ForeColor = System.Drawing.Color.DarkGray;
            this.gameIDTextBox.Location = new System.Drawing.Point(55, 149);
            this.gameIDTextBox.Name = "gameIDTextBox";
            this.gameIDTextBox.ReadOnly = true;
            this.gameIDTextBox.Size = new System.Drawing.Size(175, 22);
            this.gameIDTextBox.TabIndex = 12;
            // 
            // cancelButton
            // 
            this.cancelButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.cancelButton.FlatAppearance.BorderSize = 0;
            this.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelButton.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButton.ForeColor = System.Drawing.Color.White;
            this.cancelButton.Location = new System.Drawing.Point(76, 433);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(125, 40);
            this.cancelButton.TabIndex = 11;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = false;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // addGameButton
            // 
            this.addGameButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.addGameButton.FlatAppearance.BorderSize = 0;
            this.addGameButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addGameButton.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addGameButton.ForeColor = System.Drawing.Color.White;
            this.addGameButton.Location = new System.Drawing.Point(76, 387);
            this.addGameButton.Name = "addGameButton";
            this.addGameButton.Size = new System.Drawing.Size(125, 40);
            this.addGameButton.TabIndex = 10;
            this.addGameButton.Text = "Add";
            this.addGameButton.UseVisualStyleBackColor = false;
            this.addGameButton.Click += new System.EventHandler(this.addGameButton_Click);
            // 
            // categoryComboBox
            // 
            this.categoryComboBox.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryComboBox.ForeColor = System.Drawing.Color.DarkGray;
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
            this.categoryComboBox.Location = new System.Drawing.Point(55, 223);
            this.categoryComboBox.MaxDropDownItems = 10;
            this.categoryComboBox.Name = "categoryComboBox";
            this.categoryComboBox.Size = new System.Drawing.Size(175, 22);
            this.categoryComboBox.Sorted = true;
            this.categoryComboBox.TabIndex = 18;
            this.categoryComboBox.Text = "Category";
            this.categoryComboBox.SelectedIndexChanged += new System.EventHandler(this.categoryComboBox_SelectedIndexChanged);
            this.categoryComboBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.categoryComboBox_KeyDown);
            // 
            // releaseComboBox
            // 
            this.releaseComboBox.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.releaseComboBox.ForeColor = System.Drawing.Color.DarkGray;
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
            this.releaseComboBox.Location = new System.Drawing.Point(55, 260);
            this.releaseComboBox.MaxDropDownItems = 10;
            this.releaseComboBox.Name = "releaseComboBox";
            this.releaseComboBox.Size = new System.Drawing.Size(175, 22);
            this.releaseComboBox.Sorted = true;
            this.releaseComboBox.TabIndex = 19;
            this.releaseComboBox.Text = "Release Year";
            this.releaseComboBox.SelectedIndexChanged += new System.EventHandler(this.releaseComboBox_SelectedIndexChanged);
            this.releaseComboBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.releaseComboBox_KeyDown);
            // 
            // ageComboBox
            // 
            this.ageComboBox.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ageComboBox.ForeColor = System.Drawing.Color.DarkGray;
            this.ageComboBox.FormattingEnabled = true;
            this.ageComboBox.Items.AddRange(new object[] {
            "7",
            "12",
            "16",
            "18"});
            this.ageComboBox.Location = new System.Drawing.Point(55, 299);
            this.ageComboBox.MaxDropDownItems = 10;
            this.ageComboBox.Name = "ageComboBox";
            this.ageComboBox.Size = new System.Drawing.Size(175, 22);
            this.ageComboBox.TabIndex = 20;
            this.ageComboBox.Text = "Age Category";
            this.ageComboBox.SelectedIndexChanged += new System.EventHandler(this.ageComboBox_SelectedIndexChanged);
            this.ageComboBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ageComboBox_KeyDown);
            // 
            // numCopiesCheck
            // 
            this.numCopiesCheck.BackgroundImage = global::Prototype.Properties.Resources.tick;
            this.numCopiesCheck.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.numCopiesCheck.Location = new System.Drawing.Point(236, 344);
            this.numCopiesCheck.Name = "numCopiesCheck";
            this.numCopiesCheck.Size = new System.Drawing.Size(16, 16);
            this.numCopiesCheck.TabIndex = 23;
            this.numCopiesCheck.Visible = false;
            // 
            // ageCheck
            // 
            this.ageCheck.BackgroundImage = global::Prototype.Properties.Resources.tick;
            this.ageCheck.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ageCheck.Location = new System.Drawing.Point(236, 305);
            this.ageCheck.Name = "ageCheck";
            this.ageCheck.Size = new System.Drawing.Size(16, 16);
            this.ageCheck.TabIndex = 23;
            this.ageCheck.Visible = false;
            // 
            // releaseCheck
            // 
            this.releaseCheck.BackgroundImage = global::Prototype.Properties.Resources.tick;
            this.releaseCheck.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.releaseCheck.Location = new System.Drawing.Point(236, 266);
            this.releaseCheck.Name = "releaseCheck";
            this.releaseCheck.Size = new System.Drawing.Size(16, 16);
            this.releaseCheck.TabIndex = 23;
            this.releaseCheck.Visible = false;
            // 
            // categoryCheck
            // 
            this.categoryCheck.BackgroundImage = global::Prototype.Properties.Resources.tick;
            this.categoryCheck.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.categoryCheck.Location = new System.Drawing.Point(236, 229);
            this.categoryCheck.Name = "categoryCheck";
            this.categoryCheck.Size = new System.Drawing.Size(16, 16);
            this.categoryCheck.TabIndex = 23;
            this.categoryCheck.Visible = false;
            // 
            // titleCheck
            // 
            this.titleCheck.BackgroundImage = global::Prototype.Properties.Resources.tick;
            this.titleCheck.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.titleCheck.Location = new System.Drawing.Point(236, 191);
            this.titleCheck.Name = "titleCheck";
            this.titleCheck.Size = new System.Drawing.Size(16, 16);
            this.titleCheck.TabIndex = 22;
            this.titleCheck.Visible = false;
            // 
            // imagePanel
            // 
            this.imagePanel.BackColor = System.Drawing.Color.Transparent;
            this.imagePanel.BackgroundImage = global::Prototype.Properties.Resources.add_game_dark;
            this.imagePanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.imagePanel.Location = new System.Drawing.Point(81, 10);
            this.imagePanel.Name = "imagePanel";
            this.imagePanel.Size = new System.Drawing.Size(120, 120);
            this.imagePanel.TabIndex = 9;
            // 
            // numCopiesTextBox
            // 
            this.numCopiesTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.numCopiesTextBox.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numCopiesTextBox.ForeColor = System.Drawing.Color.DarkGray;
            this.numCopiesTextBox.Location = new System.Drawing.Point(55, 338);
            this.numCopiesTextBox.Name = "numCopiesTextBox";
            this.numCopiesTextBox.Size = new System.Drawing.Size(175, 22);
            this.numCopiesTextBox.TabIndex = 24;
            this.numCopiesTextBox.Text = "Number of Copies";
            this.numCopiesTextBox.Enter += new System.EventHandler(this.numCopiesTextBox_Enter);
            this.numCopiesTextBox.Leave += new System.EventHandler(this.numCopiesTextBox_Leave);
            // 
            // AddGameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 483);
            this.Controls.Add(this.numCopiesTextBox);
            this.Controls.Add(this.numCopiesCheck);
            this.Controls.Add(this.ageCheck);
            this.Controls.Add(this.releaseCheck);
            this.Controls.Add(this.categoryCheck);
            this.Controls.Add(this.titleCheck);
            this.Controls.Add(this.ageComboBox);
            this.Controls.Add(this.releaseComboBox);
            this.Controls.Add(this.categoryComboBox);
            this.Controls.Add(this.titleTextBox);
            this.Controls.Add(this.gameIDTextBox);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.addGameButton);
            this.Controls.Add(this.imagePanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "AddGameForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add New Game";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.TextBox gameIDTextBox;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button addGameButton;
        private System.Windows.Forms.Panel imagePanel;
        private System.Windows.Forms.ComboBox categoryComboBox;
        private System.Windows.Forms.ComboBox releaseComboBox;
        private System.Windows.Forms.ComboBox ageComboBox;
        private System.Windows.Forms.Panel titleCheck;
        private System.Windows.Forms.Panel categoryCheck;
        private System.Windows.Forms.Panel releaseCheck;
        private System.Windows.Forms.Panel ageCheck;
        private System.Windows.Forms.Panel numCopiesCheck;
        private System.Windows.Forms.TextBox numCopiesTextBox;
    }
}