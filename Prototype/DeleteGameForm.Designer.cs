namespace Prototype
{
    partial class DeleteGameForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeleteGameForm));
            this.imagePanel = new System.Windows.Forms.Panel();
            this.deleteDataGridView = new System.Windows.Forms.DataGridView();
            this.stockID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gameID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gameTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isRented = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deleteGameButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.filterComboBox = new System.Windows.Forms.ComboBox();
            this.filterLabel = new System.Windows.Forms.Label();
            this.helpBox = new System.Windows.Forms.TextBox();
            this.helpPanel = new System.Windows.Forms.Panel();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.searchByIDButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.deleteDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // imagePanel
            // 
            this.imagePanel.BackColor = System.Drawing.Color.Transparent;
            this.imagePanel.BackgroundImage = global::Prototype.Properties.Resources.delete_game_dark;
            this.imagePanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.imagePanel.Location = new System.Drawing.Point(280, 12);
            this.imagePanel.Name = "imagePanel";
            this.imagePanel.Size = new System.Drawing.Size(120, 120);
            this.imagePanel.TabIndex = 12;
            // 
            // deleteDataGridView
            // 
            this.deleteDataGridView.AllowUserToAddRows = false;
            this.deleteDataGridView.AllowUserToDeleteRows = false;
            this.deleteDataGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.deleteDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(3);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.deleteDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.deleteDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.deleteDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stockID,
            this.gameID,
            this.gameTitle,
            this.category,
            this.isRented});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.deleteDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.deleteDataGridView.Location = new System.Drawing.Point(12, 165);
            this.deleteDataGridView.Name = "deleteDataGridView";
            this.deleteDataGridView.ReadOnly = true;
            this.deleteDataGridView.RowHeadersVisible = false;
            this.deleteDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.deleteDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.deleteDataGridView.Size = new System.Drawing.Size(649, 276);
            this.deleteDataGridView.TabIndex = 13;
            // 
            // stockID
            // 
            this.stockID.HeaderText = "Stock ID";
            this.stockID.Name = "stockID";
            this.stockID.ReadOnly = true;
            // 
            // gameID
            // 
            this.gameID.HeaderText = "Game ID";
            this.gameID.Name = "gameID";
            this.gameID.ReadOnly = true;
            this.gameID.Width = 95;
            // 
            // gameTitle
            // 
            this.gameTitle.HeaderText = "Game Title";
            this.gameTitle.Name = "gameTitle";
            this.gameTitle.ReadOnly = true;
            this.gameTitle.Width = 270;
            // 
            // category
            // 
            this.category.HeaderText = "Category";
            this.category.Name = "category";
            this.category.ReadOnly = true;
            this.category.Width = 110;
            // 
            // isRented
            // 
            this.isRented.HeaderText = "Rented";
            this.isRented.Name = "isRented";
            this.isRented.ReadOnly = true;
            this.isRented.Width = 70;
            // 
            // deleteGameButton
            // 
            this.deleteGameButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.deleteGameButton.FlatAppearance.BorderSize = 0;
            this.deleteGameButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteGameButton.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteGameButton.ForeColor = System.Drawing.Color.White;
            this.deleteGameButton.Location = new System.Drawing.Point(264, 460);
            this.deleteGameButton.Name = "deleteGameButton";
            this.deleteGameButton.Size = new System.Drawing.Size(156, 40);
            this.deleteGameButton.TabIndex = 48;
            this.deleteGameButton.Text = "Delete Selected";
            this.deleteGameButton.UseVisualStyleBackColor = false;
            this.deleteGameButton.Click += new System.EventHandler(this.deleteGameButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(173, 475);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 49;
            // 
            // filterComboBox
            // 
            this.filterComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.filterComboBox.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filterComboBox.FormattingEnabled = true;
            this.filterComboBox.Items.AddRange(new object[] {
            "All Games",
            "Only NOT Rented Games"});
            this.filterComboBox.Location = new System.Drawing.Point(492, 37);
            this.filterComboBox.Name = "filterComboBox";
            this.filterComboBox.Size = new System.Drawing.Size(169, 21);
            this.filterComboBox.TabIndex = 50;
            this.filterComboBox.SelectedIndexChanged += new System.EventHandler(this.filterComboBox_SelectedIndexChanged);
            // 
            // filterLabel
            // 
            this.filterLabel.AutoSize = true;
            this.filterLabel.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filterLabel.Location = new System.Drawing.Point(489, 21);
            this.filterLabel.Name = "filterLabel";
            this.filterLabel.Size = new System.Drawing.Size(66, 13);
            this.filterLabel.TabIndex = 51;
            this.filterLabel.Text = "View Filter";
            // 
            // helpBox
            // 
            this.helpBox.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.helpBox.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helpBox.ForeColor = System.Drawing.SystemColors.InfoText;
            this.helpBox.Location = new System.Drawing.Point(42, 10);
            this.helpBox.Multiline = true;
            this.helpBox.Name = "helpBox";
            this.helpBox.ReadOnly = true;
            this.helpBox.Size = new System.Drawing.Size(198, 160);
            this.helpBox.TabIndex = 53;
            this.helpBox.Text = resources.GetString("helpBox.Text");
            this.helpBox.Visible = false;
            // 
            // helpPanel
            // 
            this.helpPanel.BackgroundImage = global::Prototype.Properties.Resources.help_icon;
            this.helpPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.helpPanel.Location = new System.Drawing.Point(12, 10);
            this.helpPanel.Name = "helpPanel";
            this.helpPanel.Size = new System.Drawing.Size(24, 24);
            this.helpPanel.TabIndex = 52;
            this.helpPanel.MouseLeave += new System.EventHandler(this.helpPanel_MouseLeave);
            this.helpPanel.MouseHover += new System.EventHandler(this.helpPanel_MouseHover);
            // 
            // searchTextBox
            // 
            this.searchTextBox.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchTextBox.ForeColor = System.Drawing.Color.Silver;
            this.searchTextBox.Location = new System.Drawing.Point(455, 126);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(131, 21);
            this.searchTextBox.TabIndex = 54;
            this.searchTextBox.Text = "Search By Stock ID";
            this.searchTextBox.Enter += new System.EventHandler(this.searchTextBox_Enter);
            // 
            // searchByIDButton
            // 
            this.searchByIDButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.searchByIDButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchByIDButton.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchByIDButton.ForeColor = System.Drawing.Color.White;
            this.searchByIDButton.Location = new System.Drawing.Point(592, 126);
            this.searchByIDButton.Name = "searchByIDButton";
            this.searchByIDButton.Size = new System.Drawing.Size(37, 22);
            this.searchByIDButton.TabIndex = 55;
            this.searchByIDButton.Text = "Go";
            this.searchByIDButton.UseVisualStyleBackColor = false;
            this.searchByIDButton.Click += new System.EventHandler(this.searchByIDButton_Click);
            // 
            // DeleteGameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 514);
            this.Controls.Add(this.searchByIDButton);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.helpBox);
            this.Controls.Add(this.helpPanel);
            this.Controls.Add(this.filterLabel);
            this.Controls.Add(this.filterComboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.deleteGameButton);
            this.Controls.Add(this.deleteDataGridView);
            this.Controls.Add(this.imagePanel);
            this.MaximizeBox = false;
            this.Name = "DeleteGameForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Delete Game";
            ((System.ComponentModel.ISupportInitialize)(this.deleteDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel imagePanel;
        private System.Windows.Forms.DataGridView deleteDataGridView;
        private System.Windows.Forms.Button deleteGameButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox filterComboBox;
        private System.Windows.Forms.Label filterLabel;
        private System.Windows.Forms.TextBox helpBox;
        private System.Windows.Forms.Panel helpPanel;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockID;
        private System.Windows.Forms.DataGridViewTextBoxColumn gameID;
        private System.Windows.Forms.DataGridViewTextBoxColumn gameTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn category;
        private System.Windows.Forms.DataGridViewTextBoxColumn isRented;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Button searchByIDButton;
    }
}