namespace Prototype
{
    partial class EditMemberForm
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
            this.searchMemberButton = new System.Windows.Forms.Button();
            this.notFoundLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.memberDetailsPanel = new System.Windows.Forms.Panel();
            this.ageTextBox = new System.Windows.Forms.TextBox();
            this.mobileTextBox = new System.Windows.Forms.TextBox();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.surnameTextBox = new System.Windows.Forms.TextBox();
            this.ageCheck = new System.Windows.Forms.Panel();
            this.mobileCheck = new System.Windows.Forms.Panel();
            this.addressCheck = new System.Windows.Forms.Panel();
            this.surnameCheck = new System.Windows.Forms.Panel();
            this.firstNameCheck = new System.Windows.Forms.Panel();
            this.searchIDTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.updateMemberButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.searchIDCheck = new System.Windows.Forms.Panel();
            this.imagePanel = new System.Windows.Forms.Panel();
            this.memberDetailsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // searchMemberButton
            // 
            this.searchMemberButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.searchMemberButton.FlatAppearance.BorderSize = 0;
            this.searchMemberButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchMemberButton.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchMemberButton.ForeColor = System.Drawing.Color.White;
            this.searchMemberButton.Location = new System.Drawing.Point(159, 461);
            this.searchMemberButton.Name = "searchMemberButton";
            this.searchMemberButton.Size = new System.Drawing.Size(125, 40);
            this.searchMemberButton.TabIndex = 60;
            this.searchMemberButton.Text = "Search";
            this.searchMemberButton.UseVisualStyleBackColor = false;
            this.searchMemberButton.Click += new System.EventHandler(this.searchMemberButton_Click_1);
            // 
            // notFoundLabel
            // 
            this.notFoundLabel.AutoSize = true;
            this.notFoundLabel.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notFoundLabel.ForeColor = System.Drawing.Color.Crimson;
            this.notFoundLabel.Location = new System.Drawing.Point(157, 210);
            this.notFoundLabel.Name = "notFoundLabel";
            this.notFoundLabel.Size = new System.Drawing.Size(128, 16);
            this.notFoundLabel.TabIndex = 59;
            this.notFoundLabel.Text = "Member not found";
            this.notFoundLabel.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.label6.Location = new System.Drawing.Point(93, 170);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 52;
            this.label6.Text = "Age";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.label5.Location = new System.Drawing.Point(76, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 51;
            this.label5.Text = "Mobile";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.label4.Location = new System.Drawing.Point(65, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 50;
            this.label4.Text = "Address";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.label3.Location = new System.Drawing.Point(60, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 49;
            this.label3.Text = "Surname";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.label2.Location = new System.Drawing.Point(47, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 48;
            this.label2.Text = "First Name";
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.firstNameTextBox.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNameTextBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.firstNameTextBox.Location = new System.Drawing.Point(131, 8);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(175, 21);
            this.firstNameTextBox.TabIndex = 37;
            // 
            // memberDetailsPanel
            // 
            this.memberDetailsPanel.Controls.Add(this.ageTextBox);
            this.memberDetailsPanel.Controls.Add(this.mobileTextBox);
            this.memberDetailsPanel.Controls.Add(this.addressTextBox);
            this.memberDetailsPanel.Controls.Add(this.surnameTextBox);
            this.memberDetailsPanel.Controls.Add(this.label6);
            this.memberDetailsPanel.Controls.Add(this.label5);
            this.memberDetailsPanel.Controls.Add(this.label4);
            this.memberDetailsPanel.Controls.Add(this.label3);
            this.memberDetailsPanel.Controls.Add(this.label2);
            this.memberDetailsPanel.Controls.Add(this.ageCheck);
            this.memberDetailsPanel.Controls.Add(this.mobileCheck);
            this.memberDetailsPanel.Controls.Add(this.addressCheck);
            this.memberDetailsPanel.Controls.Add(this.surnameCheck);
            this.memberDetailsPanel.Controls.Add(this.firstNameCheck);
            this.memberDetailsPanel.Controls.Add(this.firstNameTextBox);
            this.memberDetailsPanel.Location = new System.Drawing.Point(2, 238);
            this.memberDetailsPanel.Name = "memberDetailsPanel";
            this.memberDetailsPanel.Size = new System.Drawing.Size(353, 196);
            this.memberDetailsPanel.TabIndex = 54;
            this.memberDetailsPanel.Visible = false;
            // 
            // ageTextBox
            // 
            this.ageTextBox.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ageTextBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ageTextBox.Location = new System.Drawing.Point(131, 163);
            this.ageTextBox.Name = "ageTextBox";
            this.ageTextBox.Size = new System.Drawing.Size(175, 21);
            this.ageTextBox.TabIndex = 57;
            // 
            // mobileTextBox
            // 
            this.mobileTextBox.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mobileTextBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.mobileTextBox.Location = new System.Drawing.Point(131, 124);
            this.mobileTextBox.Name = "mobileTextBox";
            this.mobileTextBox.Size = new System.Drawing.Size(175, 21);
            this.mobileTextBox.TabIndex = 56;
            // 
            // addressTextBox
            // 
            this.addressTextBox.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressTextBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.addressTextBox.Location = new System.Drawing.Point(131, 85);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(175, 21);
            this.addressTextBox.TabIndex = 55;
            // 
            // surnameTextBox
            // 
            this.surnameTextBox.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.surnameTextBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.surnameTextBox.Location = new System.Drawing.Point(131, 47);
            this.surnameTextBox.Name = "surnameTextBox";
            this.surnameTextBox.Size = new System.Drawing.Size(175, 21);
            this.surnameTextBox.TabIndex = 54;
            // 
            // ageCheck
            // 
            this.ageCheck.BackgroundImage = global::Prototype.Properties.Resources.tick;
            this.ageCheck.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ageCheck.Location = new System.Drawing.Point(312, 167);
            this.ageCheck.Name = "ageCheck";
            this.ageCheck.Size = new System.Drawing.Size(16, 16);
            this.ageCheck.TabIndex = 43;
            this.ageCheck.Visible = false;
            // 
            // mobileCheck
            // 
            this.mobileCheck.BackgroundImage = global::Prototype.Properties.Resources.tick;
            this.mobileCheck.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.mobileCheck.Location = new System.Drawing.Point(312, 128);
            this.mobileCheck.Name = "mobileCheck";
            this.mobileCheck.Size = new System.Drawing.Size(16, 16);
            this.mobileCheck.TabIndex = 44;
            this.mobileCheck.Visible = false;
            // 
            // addressCheck
            // 
            this.addressCheck.BackgroundImage = global::Prototype.Properties.Resources.tick;
            this.addressCheck.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.addressCheck.Location = new System.Drawing.Point(312, 89);
            this.addressCheck.Name = "addressCheck";
            this.addressCheck.Size = new System.Drawing.Size(16, 16);
            this.addressCheck.TabIndex = 45;
            this.addressCheck.Visible = false;
            // 
            // surnameCheck
            // 
            this.surnameCheck.BackgroundImage = global::Prototype.Properties.Resources.tick;
            this.surnameCheck.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.surnameCheck.Location = new System.Drawing.Point(312, 52);
            this.surnameCheck.Name = "surnameCheck";
            this.surnameCheck.Size = new System.Drawing.Size(16, 16);
            this.surnameCheck.TabIndex = 46;
            this.surnameCheck.Visible = false;
            // 
            // firstNameCheck
            // 
            this.firstNameCheck.BackgroundImage = global::Prototype.Properties.Resources.tick;
            this.firstNameCheck.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.firstNameCheck.Location = new System.Drawing.Point(312, 14);
            this.firstNameCheck.Name = "firstNameCheck";
            this.firstNameCheck.Size = new System.Drawing.Size(16, 16);
            this.firstNameCheck.TabIndex = 42;
            this.firstNameCheck.Visible = false;
            // 
            // searchIDTextBox
            // 
            this.searchIDTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.searchIDTextBox.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchIDTextBox.ForeColor = System.Drawing.Color.DarkGray;
            this.searchIDTextBox.Location = new System.Drawing.Point(133, 175);
            this.searchIDTextBox.Name = "searchIDTextBox";
            this.searchIDTextBox.Size = new System.Drawing.Size(175, 22);
            this.searchIDTextBox.TabIndex = 52;
            this.searchIDTextBox.Text = "Enter Customer ID";
            this.searchIDTextBox.Enter += new System.EventHandler(this.searchIDTextBox_Enter_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.label1.Location = new System.Drawing.Point(121, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 16);
            this.label1.TabIndex = 51;
            this.label1.Text = "Search for customer to edit";
            // 
            // updateMemberButton
            // 
            this.updateMemberButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.updateMemberButton.FlatAppearance.BorderSize = 0;
            this.updateMemberButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateMemberButton.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateMemberButton.ForeColor = System.Drawing.Color.White;
            this.updateMemberButton.Location = new System.Drawing.Point(159, 461);
            this.updateMemberButton.Name = "updateMemberButton";
            this.updateMemberButton.Size = new System.Drawing.Size(125, 40);
            this.updateMemberButton.TabIndex = 49;
            this.updateMemberButton.Text = "Update";
            this.updateMemberButton.UseVisualStyleBackColor = false;
            this.updateMemberButton.Visible = false;
            this.updateMemberButton.Click += new System.EventHandler(this.updateMemberButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.cancelButton.FlatAppearance.BorderSize = 0;
            this.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelButton.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButton.ForeColor = System.Drawing.Color.White;
            this.cancelButton.Location = new System.Drawing.Point(159, 507);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(125, 40);
            this.cancelButton.TabIndex = 50;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = false;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click_1);
            // 
            // searchIDCheck
            // 
            this.searchIDCheck.BackgroundImage = global::Prototype.Properties.Resources.tick;
            this.searchIDCheck.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.searchIDCheck.Location = new System.Drawing.Point(314, 181);
            this.searchIDCheck.Name = "searchIDCheck";
            this.searchIDCheck.Size = new System.Drawing.Size(16, 16);
            this.searchIDCheck.TabIndex = 55;
            this.searchIDCheck.Visible = false;
            // 
            // imagePanel
            // 
            this.imagePanel.BackColor = System.Drawing.Color.Transparent;
            this.imagePanel.BackgroundImage = global::Prototype.Properties.Resources.edit_user_dark;
            this.imagePanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.imagePanel.Location = new System.Drawing.Point(162, 12);
            this.imagePanel.Name = "imagePanel";
            this.imagePanel.Size = new System.Drawing.Size(120, 120);
            this.imagePanel.TabIndex = 48;
            // 
            // EditMemberForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(442, 559);
            this.Controls.Add(this.notFoundLabel);
            this.Controls.Add(this.searchIDCheck);
            this.Controls.Add(this.imagePanel);
            this.Controls.Add(this.memberDetailsPanel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.updateMemberButton);
            this.Controls.Add(this.searchIDTextBox);
            this.Controls.Add(this.searchMemberButton);
            this.Name = "EditMemberForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit Member";
            this.memberDetailsPanel.ResumeLayout(false);
            this.memberDetailsPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button searchMemberButton;
        private System.Windows.Forms.Label notFoundLabel;
        private System.Windows.Forms.Panel searchIDCheck;
        private System.Windows.Forms.Panel imagePanel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel ageCheck;
        private System.Windows.Forms.Panel mobileCheck;
        private System.Windows.Forms.Panel addressCheck;
        private System.Windows.Forms.Panel surnameCheck;
        private System.Windows.Forms.Panel firstNameCheck;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.Panel memberDetailsPanel;
        private System.Windows.Forms.TextBox searchIDTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button updateMemberButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.TextBox ageTextBox;
        private System.Windows.Forms.TextBox mobileTextBox;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.TextBox surnameTextBox;
    }
}