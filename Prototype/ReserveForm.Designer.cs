namespace Prototype
{
    partial class ReserveForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReserveForm));
            this.stockDataGridView = new System.Windows.Forms.DataGridView();
            this.stockID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.agecat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerDataGridView = new System.Windows.Forms.DataGridView();
            this.custID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.age = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.issueGameButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.imagePanel = new System.Windows.Forms.Panel();
            this.helpBox = new System.Windows.Forms.TextBox();
            this.helpPanel = new System.Windows.Forms.Panel();
            this.searchStockIDButton = new System.Windows.Forms.Button();
            this.searchStockIDTextBox = new System.Windows.Forms.TextBox();
            this.searchCustIDButton = new System.Windows.Forms.Button();
            this.searchCustIDTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.stockDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // stockDataGridView
            // 
            this.stockDataGridView.AllowUserToAddRows = false;
            this.stockDataGridView.AllowUserToDeleteRows = false;
            this.stockDataGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.stockDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle21.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle21.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle21.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle21.Padding = new System.Windows.Forms.Padding(3);
            dataGridViewCellStyle21.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle21.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle21.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.stockDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle21;
            this.stockDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.stockDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stockID,
            this.title,
            this.category,
            this.agecat});
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle22.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle22.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle22.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle22.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle22.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle22.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.stockDataGridView.DefaultCellStyle = dataGridViewCellStyle22;
            this.stockDataGridView.Location = new System.Drawing.Point(12, 164);
            this.stockDataGridView.MultiSelect = false;
            this.stockDataGridView.Name = "stockDataGridView";
            this.stockDataGridView.ReadOnly = true;
            this.stockDataGridView.RowHeadersVisible = false;
            this.stockDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.stockDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.stockDataGridView.Size = new System.Drawing.Size(461, 320);
            this.stockDataGridView.TabIndex = 0;
            // 
            // stockID
            // 
            this.stockID.HeaderText = "Stock ID";
            this.stockID.Name = "stockID";
            this.stockID.ReadOnly = true;
            // 
            // title
            // 
            this.title.HeaderText = "Game Title";
            this.title.Name = "title";
            this.title.ReadOnly = true;
            this.title.Width = 150;
            // 
            // category
            // 
            this.category.HeaderText = "Cateogry";
            this.category.Name = "category";
            this.category.ReadOnly = true;
            this.category.Width = 115;
            // 
            // agecat
            // 
            this.agecat.HeaderText = "Min. Age";
            this.agecat.Name = "agecat";
            this.agecat.ReadOnly = true;
            this.agecat.Width = 90;
            // 
            // customerDataGridView
            // 
            this.customerDataGridView.AllowUserToAddRows = false;
            this.customerDataGridView.AllowUserToDeleteRows = false;
            this.customerDataGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.customerDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle23.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle23.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle23.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle23.Padding = new System.Windows.Forms.Padding(3);
            dataGridViewCellStyle23.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle23.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.customerDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle23;
            this.customerDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customerDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.custID,
            this.fname,
            this.sname,
            this.age});
            dataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle24.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle24.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle24.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle24.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle24.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle24.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.customerDataGridView.DefaultCellStyle = dataGridViewCellStyle24;
            this.customerDataGridView.Location = new System.Drawing.Point(495, 164);
            this.customerDataGridView.MultiSelect = false;
            this.customerDataGridView.Name = "customerDataGridView";
            this.customerDataGridView.ReadOnly = true;
            this.customerDataGridView.RowHeadersVisible = false;
            this.customerDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.customerDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.customerDataGridView.Size = new System.Drawing.Size(461, 320);
            this.customerDataGridView.TabIndex = 1;
            // 
            // custID
            // 
            this.custID.HeaderText = "Customer ID";
            this.custID.Name = "custID";
            this.custID.ReadOnly = true;
            this.custID.Width = 115;
            // 
            // fname
            // 
            this.fname.HeaderText = "First Name";
            this.fname.Name = "fname";
            this.fname.ReadOnly = true;
            this.fname.Width = 120;
            // 
            // sname
            // 
            this.sname.HeaderText = "Surname";
            this.sname.Name = "sname";
            this.sname.ReadOnly = true;
            this.sname.Width = 120;
            // 
            // age
            // 
            this.age.HeaderText = "Age";
            this.age.Name = "age";
            this.age.ReadOnly = true;
            // 
            // issueGameButton
            // 
            this.issueGameButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.issueGameButton.FlatAppearance.BorderSize = 0;
            this.issueGameButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.issueGameButton.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.issueGameButton.ForeColor = System.Drawing.Color.White;
            this.issueGameButton.Location = new System.Drawing.Point(402, 499);
            this.issueGameButton.Name = "issueGameButton";
            this.issueGameButton.Size = new System.Drawing.Size(156, 40);
            this.issueGameButton.TabIndex = 49;
            this.issueGameButton.Text = "Reserve Game";
            this.issueGameButton.UseVisualStyleBackColor = false;
            this.issueGameButton.Click += new System.EventHandler(this.reserveGameButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.label1.Location = new System.Drawing.Point(8, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(468, 23);
            this.label1.TabIndex = 50;
            this.label1.Text = "LIST OF GAMES AVAILABLE FOR RESERVATION\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.label2.Location = new System.Drawing.Point(622, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(215, 23);
            this.label2.TabIndex = 51;
            this.label2.Text = "LIST OF CUSTOMERS";
            // 
            // imagePanel
            // 
            this.imagePanel.BackColor = System.Drawing.Color.Transparent;
            this.imagePanel.BackgroundImage = global::Prototype.Properties.Resources.reserve_dark;
            this.imagePanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.imagePanel.Location = new System.Drawing.Point(402, 12);
            this.imagePanel.Name = "imagePanel";
            this.imagePanel.Size = new System.Drawing.Size(120, 120);
            this.imagePanel.TabIndex = 61;
            // 
            // helpBox
            // 
            this.helpBox.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.helpBox.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helpBox.ForeColor = System.Drawing.SystemColors.InfoText;
            this.helpBox.Location = new System.Drawing.Point(42, 12);
            this.helpBox.Multiline = true;
            this.helpBox.Name = "helpBox";
            this.helpBox.ReadOnly = true;
            this.helpBox.Size = new System.Drawing.Size(307, 136);
            this.helpBox.TabIndex = 66;
            this.helpBox.Text = resources.GetString("helpBox.Text");
            this.helpBox.Visible = false;
            // 
            // helpPanel
            // 
            this.helpPanel.BackgroundImage = global::Prototype.Properties.Resources.help_icon;
            this.helpPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.helpPanel.Location = new System.Drawing.Point(12, 12);
            this.helpPanel.Name = "helpPanel";
            this.helpPanel.Size = new System.Drawing.Size(24, 24);
            this.helpPanel.TabIndex = 65;
            this.helpPanel.MouseLeave += new System.EventHandler(this.helpPanel_MouseLeave);
            this.helpPanel.MouseHover += new System.EventHandler(this.helpPanel_MouseHover);
            // 
            // searchStockIDButton
            // 
            this.searchStockIDButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.searchStockIDButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchStockIDButton.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchStockIDButton.ForeColor = System.Drawing.Color.White;
            this.searchStockIDButton.Location = new System.Drawing.Point(149, 511);
            this.searchStockIDButton.Name = "searchStockIDButton";
            this.searchStockIDButton.Size = new System.Drawing.Size(37, 21);
            this.searchStockIDButton.TabIndex = 68;
            this.searchStockIDButton.Text = "Go";
            this.searchStockIDButton.UseVisualStyleBackColor = false;
            this.searchStockIDButton.Click += new System.EventHandler(this.searchStockIDButton_Click);
            // 
            // searchStockIDTextBox
            // 
            this.searchStockIDTextBox.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchStockIDTextBox.ForeColor = System.Drawing.Color.Silver;
            this.searchStockIDTextBox.Location = new System.Drawing.Point(12, 511);
            this.searchStockIDTextBox.Name = "searchStockIDTextBox";
            this.searchStockIDTextBox.Size = new System.Drawing.Size(131, 21);
            this.searchStockIDTextBox.TabIndex = 67;
            this.searchStockIDTextBox.Text = "Search By Stock ID";
            this.searchStockIDTextBox.Enter += new System.EventHandler(this.searchStockIDTextBox_Enter);
            this.searchStockIDTextBox.Leave += new System.EventHandler(this.searchStockIDTextBox_Leave);
            // 
            // searchCustIDButton
            // 
            this.searchCustIDButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.searchCustIDButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchCustIDButton.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchCustIDButton.ForeColor = System.Drawing.Color.White;
            this.searchCustIDButton.Location = new System.Drawing.Point(918, 512);
            this.searchCustIDButton.Name = "searchCustIDButton";
            this.searchCustIDButton.Size = new System.Drawing.Size(37, 21);
            this.searchCustIDButton.TabIndex = 70;
            this.searchCustIDButton.Text = "Go";
            this.searchCustIDButton.UseVisualStyleBackColor = false;
            this.searchCustIDButton.Click += new System.EventHandler(this.searchCustIDButton_Click);
            // 
            // searchCustIDTextBox
            // 
            this.searchCustIDTextBox.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchCustIDTextBox.ForeColor = System.Drawing.Color.Silver;
            this.searchCustIDTextBox.Location = new System.Drawing.Point(763, 512);
            this.searchCustIDTextBox.Name = "searchCustIDTextBox";
            this.searchCustIDTextBox.Size = new System.Drawing.Size(149, 21);
            this.searchCustIDTextBox.TabIndex = 69;
            this.searchCustIDTextBox.Text = "Search By Customer ID";
            this.searchCustIDTextBox.Enter += new System.EventHandler(this.searchCustIDTextBox_Enter);
            this.searchCustIDTextBox.Leave += new System.EventHandler(this.searchCustIDTextBox_Leave);
            // 
            // ReserveForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(969, 551);
            this.Controls.Add(this.searchCustIDButton);
            this.Controls.Add(this.searchCustIDTextBox);
            this.Controls.Add(this.searchStockIDButton);
            this.Controls.Add(this.searchStockIDTextBox);
            this.Controls.Add(this.helpBox);
            this.Controls.Add(this.helpPanel);
            this.Controls.Add(this.imagePanel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.issueGameButton);
            this.Controls.Add(this.customerDataGridView);
            this.Controls.Add(this.stockDataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ReserveForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reserve Game";
            ((System.ComponentModel.ISupportInitialize)(this.stockDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView stockDataGridView;
        private System.Windows.Forms.DataGridView customerDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn custID;
        private System.Windows.Forms.DataGridViewTextBoxColumn fname;
        private System.Windows.Forms.DataGridViewTextBoxColumn sname;
        private System.Windows.Forms.DataGridViewTextBoxColumn age;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockID;
        private System.Windows.Forms.DataGridViewTextBoxColumn title;
        private System.Windows.Forms.DataGridViewTextBoxColumn category;
        private System.Windows.Forms.DataGridViewTextBoxColumn agecat;
        private System.Windows.Forms.Button issueGameButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel imagePanel;
        private System.Windows.Forms.TextBox helpBox;
        private System.Windows.Forms.Panel helpPanel;
        private System.Windows.Forms.Button searchStockIDButton;
        private System.Windows.Forms.TextBox searchStockIDTextBox;
        private System.Windows.Forms.Button searchCustIDButton;
        private System.Windows.Forms.TextBox searchCustIDTextBox;
    }
}