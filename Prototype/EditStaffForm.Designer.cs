namespace Prototype
{
    partial class EditStaffForm
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
            this.updateStaffButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.searchIDTextBox = new System.Windows.Forms.TextBox();
            this.searchPPSTextBox = new System.Windows.Forms.TextBox();
            this.staffDetailsPanel = new System.Windows.Forms.Panel();
            this.addressCheck = new System.Windows.Forms.Panel();
            this.emailCheck = new System.Windows.Forms.Panel();
            this.passwordCheck = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.mobileTextBox = new System.Windows.Forms.TextBox();
            this.ageTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.usernameCheck = new System.Windows.Forms.Panel();
            this.mobileCheck = new System.Windows.Forms.Panel();
            this.ageCheck = new System.Windows.Forms.Panel();
            this.lastCheck = new System.Windows.Forms.Panel();
            this.firstCheck = new System.Windows.Forms.Panel();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.searchIDRadio = new System.Windows.Forms.RadioButton();
            this.searchTitleRadio = new System.Windows.Forms.RadioButton();
            this.notFoundLabel = new System.Windows.Forms.Label();
            this.searchStaffButton = new System.Windows.Forms.Button();
            this.searchIDCheck = new System.Windows.Forms.Panel();
            this.searchPPSCheck = new System.Windows.Forms.Panel();
            this.imagePanel = new System.Windows.Forms.Panel();
            this.staffDetailsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // cancelButton
            // 
            this.cancelButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.cancelButton.FlatAppearance.BorderSize = 0;
            this.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelButton.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButton.ForeColor = System.Drawing.Color.White;
            this.cancelButton.Location = new System.Drawing.Point(149, 613);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(125, 40);
            this.cancelButton.TabIndex = 13;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = false;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // updateStaffButton
            // 
            this.updateStaffButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.updateStaffButton.FlatAppearance.BorderSize = 0;
            this.updateStaffButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateStaffButton.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateStaffButton.ForeColor = System.Drawing.Color.White;
            this.updateStaffButton.Location = new System.Drawing.Point(149, 567);
            this.updateStaffButton.Name = "updateStaffButton";
            this.updateStaffButton.Size = new System.Drawing.Size(125, 40);
            this.updateStaffButton.TabIndex = 24;
            this.updateStaffButton.Text = "Update";
            this.updateStaffButton.UseVisualStyleBackColor = false;
            this.updateStaffButton.Visible = false;
            this.updateStaffButton.Click += new System.EventHandler(this.updateStaffButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.label1.Location = new System.Drawing.Point(133, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Search for Staff to edit";
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
            this.searchIDTextBox.Text = "Search by EmployeeID";
            this.searchIDTextBox.Visible = false;
            this.searchIDTextBox.Enter += new System.EventHandler(this.searchIDTextBox_Enter);
            // 
            // searchPPSTextBox
            // 
            this.searchPPSTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.searchPPSTextBox.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchPPSTextBox.ForeColor = System.Drawing.Color.DarkGray;
            this.searchPPSTextBox.Location = new System.Drawing.Point(133, 217);
            this.searchPPSTextBox.Name = "searchPPSTextBox";
            this.searchPPSTextBox.Size = new System.Drawing.Size(175, 22);
            this.searchPPSTextBox.TabIndex = 3;
            this.searchPPSTextBox.Text = "Search By PPS";
            this.searchPPSTextBox.Visible = false;
            this.searchPPSTextBox.Enter += new System.EventHandler(this.searchPPSTextBox_Enter);
            // 
            // staffDetailsPanel
            // 
            this.staffDetailsPanel.Controls.Add(this.addressCheck);
            this.staffDetailsPanel.Controls.Add(this.emailCheck);
            this.staffDetailsPanel.Controls.Add(this.passwordCheck);
            this.staffDetailsPanel.Controls.Add(this.label9);
            this.staffDetailsPanel.Controls.Add(this.label8);
            this.staffDetailsPanel.Controls.Add(this.label7);
            this.staffDetailsPanel.Controls.Add(this.addressTextBox);
            this.staffDetailsPanel.Controls.Add(this.emailTextBox);
            this.staffDetailsPanel.Controls.Add(this.passwordTextBox);
            this.staffDetailsPanel.Controls.Add(this.usernameTextBox);
            this.staffDetailsPanel.Controls.Add(this.mobileTextBox);
            this.staffDetailsPanel.Controls.Add(this.ageTextBox);
            this.staffDetailsPanel.Controls.Add(this.lastNameTextBox);
            this.staffDetailsPanel.Controls.Add(this.label6);
            this.staffDetailsPanel.Controls.Add(this.label5);
            this.staffDetailsPanel.Controls.Add(this.label4);
            this.staffDetailsPanel.Controls.Add(this.label3);
            this.staffDetailsPanel.Controls.Add(this.label2);
            this.staffDetailsPanel.Controls.Add(this.usernameCheck);
            this.staffDetailsPanel.Controls.Add(this.mobileCheck);
            this.staffDetailsPanel.Controls.Add(this.ageCheck);
            this.staffDetailsPanel.Controls.Add(this.lastCheck);
            this.staffDetailsPanel.Controls.Add(this.firstCheck);
            this.staffDetailsPanel.Controls.Add(this.firstNameTextBox);
            this.staffDetailsPanel.Location = new System.Drawing.Point(2, 258);
            this.staffDetailsPanel.Name = "staffDetailsPanel";
            this.staffDetailsPanel.Size = new System.Drawing.Size(439, 303);
            this.staffDetailsPanel.TabIndex = 41;
            this.staffDetailsPanel.Visible = false;
            // 
            // addressCheck
            // 
            this.addressCheck.BackgroundImage = global::Prototype.Properties.Resources.tick;
            this.addressCheck.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.addressCheck.Location = new System.Drawing.Point(312, 271);
            this.addressCheck.Name = "addressCheck";
            this.addressCheck.Size = new System.Drawing.Size(16, 16);
            this.addressCheck.TabIndex = 44;
            this.addressCheck.Visible = false;
            // 
            // emailCheck
            // 
            this.emailCheck.BackgroundImage = global::Prototype.Properties.Resources.tick;
            this.emailCheck.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.emailCheck.Location = new System.Drawing.Point(312, 235);
            this.emailCheck.Name = "emailCheck";
            this.emailCheck.Size = new System.Drawing.Size(16, 16);
            this.emailCheck.TabIndex = 44;
            this.emailCheck.Visible = false;
            // 
            // passwordCheck
            // 
            this.passwordCheck.BackgroundImage = global::Prototype.Properties.Resources.tick;
            this.passwordCheck.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.passwordCheck.Location = new System.Drawing.Point(312, 199);
            this.passwordCheck.Name = "passwordCheck";
            this.passwordCheck.Size = new System.Drawing.Size(16, 16);
            this.passwordCheck.TabIndex = 44;
            this.passwordCheck.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.label9.Location = new System.Drawing.Point(65, 274);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 13);
            this.label9.TabIndex = 63;
            this.label9.Text = "Address";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.label8.Location = new System.Drawing.Point(82, 238);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 13);
            this.label8.TabIndex = 62;
            this.label8.Text = "Email";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.label7.Location = new System.Drawing.Point(56, 202);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 13);
            this.label7.TabIndex = 61;
            this.label7.Text = "Password";
            // 
            // addressTextBox
            // 
            this.addressTextBox.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.addressTextBox.Location = new System.Drawing.Point(131, 271);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(175, 21);
            this.addressTextBox.TabIndex = 11;
            // 
            // emailTextBox
            // 
            this.emailTextBox.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.emailTextBox.Location = new System.Drawing.Point(131, 235);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(175, 21);
            this.emailTextBox.TabIndex = 10;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.passwordTextBox.Location = new System.Drawing.Point(131, 199);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(175, 21);
            this.passwordTextBox.TabIndex = 9;
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.usernameTextBox.Location = new System.Drawing.Point(131, 163);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(175, 21);
            this.usernameTextBox.TabIndex = 8;
            // 
            // mobileTextBox
            // 
            this.mobileTextBox.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mobileTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.mobileTextBox.Location = new System.Drawing.Point(131, 121);
            this.mobileTextBox.Name = "mobileTextBox";
            this.mobileTextBox.Size = new System.Drawing.Size(175, 21);
            this.mobileTextBox.TabIndex = 7;
            // 
            // ageTextBox
            // 
            this.ageTextBox.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ageTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.ageTextBox.Location = new System.Drawing.Point(131, 85);
            this.ageTextBox.Name = "ageTextBox";
            this.ageTextBox.Size = new System.Drawing.Size(175, 21);
            this.ageTextBox.TabIndex = 6;
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastNameTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.lastNameTextBox.Location = new System.Drawing.Point(131, 47);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(175, 21);
            this.lastNameTextBox.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.label6.Location = new System.Drawing.Point(52, 166);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 13);
            this.label6.TabIndex = 52;
            this.label6.Text = "Username";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.label5.Location = new System.Drawing.Point(76, 124);
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
            this.label4.Location = new System.Drawing.Point(93, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 50;
            this.label4.Text = "Age";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.label3.Location = new System.Drawing.Point(54, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 49;
            this.label3.Text = "LastName";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.label2.Location = new System.Drawing.Point(51, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 48;
            this.label2.Text = "FirstName";
            // 
            // usernameCheck
            // 
            this.usernameCheck.BackgroundImage = global::Prototype.Properties.Resources.tick;
            this.usernameCheck.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.usernameCheck.Location = new System.Drawing.Point(312, 167);
            this.usernameCheck.Name = "usernameCheck";
            this.usernameCheck.Size = new System.Drawing.Size(16, 16);
            this.usernameCheck.TabIndex = 43;
            this.usernameCheck.Visible = false;
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
            // ageCheck
            // 
            this.ageCheck.BackgroundImage = global::Prototype.Properties.Resources.tick;
            this.ageCheck.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ageCheck.Location = new System.Drawing.Point(312, 89);
            this.ageCheck.Name = "ageCheck";
            this.ageCheck.Size = new System.Drawing.Size(16, 16);
            this.ageCheck.TabIndex = 45;
            this.ageCheck.Visible = false;
            // 
            // lastCheck
            // 
            this.lastCheck.BackgroundImage = global::Prototype.Properties.Resources.tick;
            this.lastCheck.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.lastCheck.Location = new System.Drawing.Point(312, 52);
            this.lastCheck.Name = "lastCheck";
            this.lastCheck.Size = new System.Drawing.Size(16, 16);
            this.lastCheck.TabIndex = 46;
            this.lastCheck.Visible = false;
            // 
            // firstCheck
            // 
            this.firstCheck.BackgroundImage = global::Prototype.Properties.Resources.tick;
            this.firstCheck.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.firstCheck.Location = new System.Drawing.Point(312, 14);
            this.firstCheck.Name = "firstCheck";
            this.firstCheck.Size = new System.Drawing.Size(16, 16);
            this.firstCheck.TabIndex = 42;
            this.firstCheck.Visible = false;
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.firstNameTextBox.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNameTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.firstNameTextBox.Location = new System.Drawing.Point(131, 8);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(175, 21);
            this.firstNameTextBox.TabIndex = 4;
            // 
            // searchIDRadio
            // 
            this.searchIDRadio.AutoSize = true;
            this.searchIDRadio.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchIDRadio.Location = new System.Drawing.Point(167, 167);
            this.searchIDRadio.Name = "searchIDRadio";
            this.searchIDRadio.Size = new System.Drawing.Size(158, 17);
            this.searchIDRadio.TabIndex = 1;
            this.searchIDRadio.TabStop = true;
            this.searchIDRadio.Text = "Search By EmployeeID";
            this.searchIDRadio.UseVisualStyleBackColor = true;
            this.searchIDRadio.CheckedChanged += new System.EventHandler(this.searchIDRadio_CheckedChanged);
            // 
            // searchTitleRadio
            // 
            this.searchTitleRadio.AutoSize = true;
            this.searchTitleRadio.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchTitleRadio.Location = new System.Drawing.Point(167, 190);
            this.searchTitleRadio.Name = "searchTitleRadio";
            this.searchTitleRadio.Size = new System.Drawing.Size(110, 17);
            this.searchTitleRadio.TabIndex = 2;
            this.searchTitleRadio.TabStop = true;
            this.searchTitleRadio.Text = "Search By PPS";
            this.searchTitleRadio.UseVisualStyleBackColor = true;
            this.searchTitleRadio.CheckedChanged += new System.EventHandler(this.searchPPSRadio_CheckedChanged);
            // 
            // notFoundLabel
            // 
            this.notFoundLabel.AutoSize = true;
            this.notFoundLabel.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notFoundLabel.ForeColor = System.Drawing.Color.Crimson;
            this.notFoundLabel.Location = new System.Drawing.Point(161, 243);
            this.notFoundLabel.Name = "notFoundLabel";
            this.notFoundLabel.Size = new System.Drawing.Size(121, 16);
            this.notFoundLabel.TabIndex = 46;
            this.notFoundLabel.Text = "Person not found";
            this.notFoundLabel.Visible = false;
            // 
            // searchStaffButton
            // 
            this.searchStaffButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.searchStaffButton.FlatAppearance.BorderSize = 0;
            this.searchStaffButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchStaffButton.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchStaffButton.ForeColor = System.Drawing.Color.White;
            this.searchStaffButton.Location = new System.Drawing.Point(149, 567);
            this.searchStaffButton.Name = "searchStaffButton";
            this.searchStaffButton.Size = new System.Drawing.Size(125, 40);
            this.searchStaffButton.TabIndex = 12;
            this.searchStaffButton.Text = "Search";
            this.searchStaffButton.UseVisualStyleBackColor = false;
            this.searchStaffButton.Click += new System.EventHandler(this.searchStaffButton_Click);
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
            // searchPPSCheck
            // 
            this.searchPPSCheck.BackgroundImage = global::Prototype.Properties.Resources.tick;
            this.searchPPSCheck.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.searchPPSCheck.Location = new System.Drawing.Point(314, 224);
            this.searchPPSCheck.Name = "searchPPSCheck";
            this.searchPPSCheck.Size = new System.Drawing.Size(16, 16);
            this.searchPPSCheck.TabIndex = 43;
            this.searchPPSCheck.Visible = false;
            // 
            // imagePanel
            // 
            this.imagePanel.BackColor = System.Drawing.Color.Transparent;
            this.imagePanel.BackgroundImage = global::Prototype.Properties.Resources.edit_emp_dark;
            this.imagePanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.imagePanel.Location = new System.Drawing.Point(163, 10);
            this.imagePanel.Name = "imagePanel";
            this.imagePanel.Size = new System.Drawing.Size(120, 120);
            this.imagePanel.TabIndex = 0;
            // 
            // EditStaffForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 669);
            this.Controls.Add(this.searchStaffButton);
            this.Controls.Add(this.notFoundLabel);
            this.Controls.Add(this.searchTitleRadio);
            this.Controls.Add(this.searchIDRadio);
            this.Controls.Add(this.searchIDCheck);
            this.Controls.Add(this.searchPPSCheck);
            this.Controls.Add(this.staffDetailsPanel);
            this.Controls.Add(this.searchPPSTextBox);
            this.Controls.Add(this.searchIDTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.imagePanel);
            this.Controls.Add(this.updateStaffButton);
            this.Controls.Add(this.cancelButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "EditStaffForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit Staff Details";
            this.staffDetailsPanel.ResumeLayout(false);
            this.staffDetailsPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel imagePanel;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button updateStaffButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox searchIDTextBox;
        private System.Windows.Forms.TextBox searchPPSTextBox;
        private System.Windows.Forms.Panel staffDetailsPanel;
        private System.Windows.Forms.Panel usernameCheck;
        private System.Windows.Forms.Panel mobileCheck;
        private System.Windows.Forms.Panel ageCheck;
        private System.Windows.Forms.Panel lastCheck;
        private System.Windows.Forms.Panel firstCheck;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.Panel searchPPSCheck;
        private System.Windows.Forms.Panel searchIDCheck;
        private System.Windows.Forms.RadioButton searchIDRadio;
        private System.Windows.Forms.RadioButton searchTitleRadio;
        private System.Windows.Forms.Label notFoundLabel;
        private System.Windows.Forms.Button searchStaffButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.TextBox mobileTextBox;
        private System.Windows.Forms.TextBox ageTextBox;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Panel addressCheck;
        private System.Windows.Forms.Panel emailCheck;
        private System.Windows.Forms.Panel passwordCheck;
    }
}