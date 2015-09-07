namespace Prototype
{
    partial class ReturnGameForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.returnDataGridView = new System.Windows.Forms.DataGridView();
            this.stockID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.custID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.issue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.due = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.returnButton = new System.Windows.Forms.Button();
            this.imagePanel = new System.Windows.Forms.Panel();
            this.helpBox = new System.Windows.Forms.TextBox();
            this.helpPanel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.returnDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // returnDataGridView
            // 
            this.returnDataGridView.AllowUserToAddRows = false;
            this.returnDataGridView.AllowUserToDeleteRows = false;
            this.returnDataGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.returnDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.returnDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.returnDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.returnDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stockID,
            this.title,
            this.custID,
            this.fname,
            this.sname,
            this.issue,
            this.due});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.returnDataGridView.DefaultCellStyle = dataGridViewCellStyle4;
            this.returnDataGridView.Location = new System.Drawing.Point(12, 150);
            this.returnDataGridView.MultiSelect = false;
            this.returnDataGridView.Name = "returnDataGridView";
            this.returnDataGridView.ReadOnly = true;
            this.returnDataGridView.RowHeadersVisible = false;
            this.returnDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.returnDataGridView.Size = new System.Drawing.Size(820, 360);
            this.returnDataGridView.TabIndex = 0;
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
            this.title.Width = 155;
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
            // 
            // issue
            // 
            this.issue.HeaderText = "Issue Date";
            this.issue.Name = "issue";
            this.issue.ReadOnly = true;
            this.issue.Width = 125;
            // 
            // due
            // 
            this.due.HeaderText = "Due Date";
            this.due.Name = "due";
            this.due.ReadOnly = true;
            // 
            // returnButton
            // 
            this.returnButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.returnButton.FlatAppearance.BorderSize = 0;
            this.returnButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.returnButton.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnButton.ForeColor = System.Drawing.Color.White;
            this.returnButton.Location = new System.Drawing.Point(348, 525);
            this.returnButton.Name = "returnButton";
            this.returnButton.Size = new System.Drawing.Size(125, 40);
            this.returnButton.TabIndex = 81;
            this.returnButton.Text = "Return";
            this.returnButton.UseVisualStyleBackColor = false;
            this.returnButton.Click += new System.EventHandler(this.returnButton_Click);
            // 
            // imagePanel
            // 
            this.imagePanel.BackColor = System.Drawing.Color.Transparent;
            this.imagePanel.BackgroundImage = global::Prototype.Properties.Resources.return_game_dark;
            this.imagePanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.imagePanel.Location = new System.Drawing.Point(348, 12);
            this.imagePanel.Name = "imagePanel";
            this.imagePanel.Size = new System.Drawing.Size(120, 120);
            this.imagePanel.TabIndex = 82;
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
            this.helpBox.Size = new System.Drawing.Size(270, 79);
            this.helpBox.TabIndex = 84;
            this.helpBox.Text = "Select the game that you want to return by clicking on the \'Stock ID\' of that gam" +
    "e.\r\nPress the \'Return\' button to return the game";
            this.helpBox.Visible = false;
            // 
            // helpPanel
            // 
            this.helpPanel.BackgroundImage = global::Prototype.Properties.Resources.help_icon;
            this.helpPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.helpPanel.Location = new System.Drawing.Point(12, 12);
            this.helpPanel.Name = "helpPanel";
            this.helpPanel.Size = new System.Drawing.Size(24, 24);
            this.helpPanel.TabIndex = 83;
            this.helpPanel.MouseLeave += new System.EventHandler(this.helpPanel_MouseLeave);
            this.helpPanel.MouseHover += new System.EventHandler(this.helpPanel_MouseHover);
            // 
            // ReturnGameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 577);
            this.Controls.Add(this.helpBox);
            this.Controls.Add(this.helpPanel);
            this.Controls.Add(this.imagePanel);
            this.Controls.Add(this.returnButton);
            this.Controls.Add(this.returnDataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ReturnGameForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Return Game";
            ((System.ComponentModel.ISupportInitialize)(this.returnDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView returnDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockID;
        private System.Windows.Forms.DataGridViewTextBoxColumn title;
        private System.Windows.Forms.DataGridViewTextBoxColumn custID;
        private System.Windows.Forms.DataGridViewTextBoxColumn fname;
        private System.Windows.Forms.DataGridViewTextBoxColumn sname;
        private System.Windows.Forms.DataGridViewTextBoxColumn issue;
        private System.Windows.Forms.DataGridViewTextBoxColumn due;
        private System.Windows.Forms.Button returnButton;
        private System.Windows.Forms.Panel imagePanel;
        private System.Windows.Forms.TextBox helpBox;
        private System.Windows.Forms.Panel helpPanel;
    }
}