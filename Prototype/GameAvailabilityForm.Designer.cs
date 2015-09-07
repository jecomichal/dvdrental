namespace Prototype
{
    partial class GameAvailabilityForm
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
            this.stockDataGridView = new System.Windows.Forms.DataGridView();
            this.stockID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rented = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reserved = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imagePanel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.stockDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // stockDataGridView
            // 
            this.stockDataGridView.AllowUserToAddRows = false;
            this.stockDataGridView.AllowUserToDeleteRows = false;
            this.stockDataGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.stockDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(3);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.stockDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.stockDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.stockDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stockID,
            this.title,
            this.rented,
            this.reserved});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.stockDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.stockDataGridView.Location = new System.Drawing.Point(12, 166);
            this.stockDataGridView.Name = "stockDataGridView";
            this.stockDataGridView.ReadOnly = true;
            this.stockDataGridView.RowHeadersVisible = false;
            this.stockDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.stockDataGridView.Size = new System.Drawing.Size(476, 373);
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
            this.title.Width = 170;
            // 
            // rented
            // 
            this.rented.HeaderText = "Rented";
            this.rented.Name = "rented";
            this.rented.ReadOnly = true;
            this.rented.Width = 115;
            // 
            // reserved
            // 
            this.reserved.HeaderText = "Reserved";
            this.reserved.Name = "reserved";
            this.reserved.ReadOnly = true;
            this.reserved.Width = 90;
            // 
            // imagePanel
            // 
            this.imagePanel.BackColor = System.Drawing.Color.Transparent;
            this.imagePanel.BackgroundImage = global::Prototype.Properties.Resources.search_dark;
            this.imagePanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.imagePanel.Location = new System.Drawing.Point(179, 12);
            this.imagePanel.Name = "imagePanel";
            this.imagePanel.Size = new System.Drawing.Size(120, 120);
            this.imagePanel.TabIndex = 10;
            // 
            // GameAvailabilityForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 551);
            this.Controls.Add(this.imagePanel);
            this.Controls.Add(this.stockDataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "GameAvailabilityForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Available Games";
            ((System.ComponentModel.ISupportInitialize)(this.stockDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView stockDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockID;
        private System.Windows.Forms.DataGridViewTextBoxColumn title;
        private System.Windows.Forms.DataGridViewTextBoxColumn rented;
        private System.Windows.Forms.DataGridViewTextBoxColumn reserved;
        private System.Windows.Forms.Panel imagePanel;
    }
}