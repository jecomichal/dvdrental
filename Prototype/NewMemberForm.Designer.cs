namespace Prototype
{
    partial class NewMemberForm
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
            this.addMemberButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.custIDTextBox = new System.Windows.Forms.TextBox();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.surnameTextBox = new System.Windows.Forms.TextBox();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.mobileTextBox = new System.Windows.Forms.TextBox();
            this.ageTextBox = new System.Windows.Forms.TextBox();
            this.firstNameCheck = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.surnameCheck = new System.Windows.Forms.Panel();
            this.addressCheck = new System.Windows.Forms.Panel();
            this.mobileCheck = new System.Windows.Forms.Panel();
            this.ageCheck = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // addMemberButton
            // 
            this.addMemberButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.addMemberButton.FlatAppearance.BorderSize = 0;
            this.addMemberButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addMemberButton.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addMemberButton.ForeColor = System.Drawing.Color.White;
            this.addMemberButton.Location = new System.Drawing.Point(77, 389);
            this.addMemberButton.Name = "addMemberButton";
            this.addMemberButton.Size = new System.Drawing.Size(125, 40);
            this.addMemberButton.TabIndex = 1;
            this.addMemberButton.Text = "Add";
            this.addMemberButton.UseVisualStyleBackColor = false;
            this.addMemberButton.Click += new System.EventHandler(this.addMemberButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.cancelButton.FlatAppearance.BorderSize = 0;
            this.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelButton.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButton.ForeColor = System.Drawing.Color.White;
            this.cancelButton.Location = new System.Drawing.Point(77, 435);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(125, 40);
            this.cancelButton.TabIndex = 2;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = false;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // custIDTextBox
            // 
            this.custIDTextBox.BackColor = System.Drawing.Color.White;
            this.custIDTextBox.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.custIDTextBox.ForeColor = System.Drawing.Color.DarkGray;
            this.custIDTextBox.Location = new System.Drawing.Point(56, 138);
            this.custIDTextBox.Name = "custIDTextBox";
            this.custIDTextBox.ReadOnly = true;
            this.custIDTextBox.Size = new System.Drawing.Size(175, 22);
            this.custIDTextBox.TabIndex = 3;
            this.custIDTextBox.Text = "10021";
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.firstNameTextBox.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNameTextBox.ForeColor = System.Drawing.Color.DarkGray;
            this.firstNameTextBox.Location = new System.Drawing.Point(56, 174);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(175, 22);
            this.firstNameTextBox.TabIndex = 4;
            this.firstNameTextBox.Text = "First Name";
            this.firstNameTextBox.Enter += new System.EventHandler(this.firstNameTextBox_Enter);
            this.firstNameTextBox.Leave += new System.EventHandler(this.firstNameTextBox_Leave);
            // 
            // surnameTextBox
            // 
            this.surnameTextBox.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.surnameTextBox.ForeColor = System.Drawing.Color.DarkGray;
            this.surnameTextBox.Location = new System.Drawing.Point(56, 210);
            this.surnameTextBox.Name = "surnameTextBox";
            this.surnameTextBox.Size = new System.Drawing.Size(175, 22);
            this.surnameTextBox.TabIndex = 5;
            this.surnameTextBox.Text = "Surname";
            this.surnameTextBox.Enter += new System.EventHandler(this.surnameTextBox_Enter);
            this.surnameTextBox.Leave += new System.EventHandler(this.surnameTextBox_Leave);
            // 
            // addressTextBox
            // 
            this.addressTextBox.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressTextBox.ForeColor = System.Drawing.Color.DarkGray;
            this.addressTextBox.Location = new System.Drawing.Point(56, 249);
            this.addressTextBox.Multiline = true;
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(175, 41);
            this.addressTextBox.TabIndex = 6;
            this.addressTextBox.Text = "Address";
            this.addressTextBox.Enter += new System.EventHandler(this.addressTextBox_Enter);
            this.addressTextBox.Leave += new System.EventHandler(this.addressTextBox_Leave);
            // 
            // mobileTextBox
            // 
            this.mobileTextBox.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mobileTextBox.ForeColor = System.Drawing.Color.DarkGray;
            this.mobileTextBox.Location = new System.Drawing.Point(56, 308);
            this.mobileTextBox.Name = "mobileTextBox";
            this.mobileTextBox.Size = new System.Drawing.Size(175, 22);
            this.mobileTextBox.TabIndex = 7;
            this.mobileTextBox.Text = "Mobile";
            this.mobileTextBox.Enter += new System.EventHandler(this.mobileTextBox_Enter);
            this.mobileTextBox.Leave += new System.EventHandler(this.mobileTextBox_Leave);
            // 
            // ageTextBox
            // 
            this.ageTextBox.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ageTextBox.ForeColor = System.Drawing.Color.DarkGray;
            this.ageTextBox.Location = new System.Drawing.Point(56, 343);
            this.ageTextBox.MaxLength = 3;
            this.ageTextBox.Name = "ageTextBox";
            this.ageTextBox.Size = new System.Drawing.Size(175, 22);
            this.ageTextBox.TabIndex = 8;
            this.ageTextBox.Text = "Age";
            this.ageTextBox.Enter += new System.EventHandler(this.ageTextBox_Enter);
            this.ageTextBox.Leave += new System.EventHandler(this.ageTextBox_Leave);
            // 
            // firstNameCheck
            // 
            this.firstNameCheck.BackgroundImage = global::Prototype.Properties.Resources.tick;
            this.firstNameCheck.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.firstNameCheck.Location = new System.Drawing.Point(237, 180);
            this.firstNameCheck.Name = "firstNameCheck";
            this.firstNameCheck.Size = new System.Drawing.Size(16, 16);
            this.firstNameCheck.TabIndex = 10;
            this.firstNameCheck.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = global::Prototype.Properties.Resources.add_user_dark;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel1.Location = new System.Drawing.Point(82, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(120, 120);
            this.panel1.TabIndex = 0;
            // 
            // surnameCheck
            // 
            this.surnameCheck.BackgroundImage = global::Prototype.Properties.Resources.tick;
            this.surnameCheck.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.surnameCheck.Location = new System.Drawing.Point(237, 216);
            this.surnameCheck.Name = "surnameCheck";
            this.surnameCheck.Size = new System.Drawing.Size(16, 16);
            this.surnameCheck.TabIndex = 11;
            this.surnameCheck.Visible = false;
            // 
            // addressCheck
            // 
            this.addressCheck.BackgroundImage = global::Prototype.Properties.Resources.tick;
            this.addressCheck.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.addressCheck.Location = new System.Drawing.Point(237, 274);
            this.addressCheck.Name = "addressCheck";
            this.addressCheck.Size = new System.Drawing.Size(16, 16);
            this.addressCheck.TabIndex = 11;
            this.addressCheck.Visible = false;
            // 
            // mobileCheck
            // 
            this.mobileCheck.BackgroundImage = global::Prototype.Properties.Resources.tick;
            this.mobileCheck.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.mobileCheck.Location = new System.Drawing.Point(237, 314);
            this.mobileCheck.Name = "mobileCheck";
            this.mobileCheck.Size = new System.Drawing.Size(16, 16);
            this.mobileCheck.TabIndex = 11;
            this.mobileCheck.Visible = false;
            // 
            // ageCheck
            // 
            this.ageCheck.BackgroundImage = global::Prototype.Properties.Resources.tick;
            this.ageCheck.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ageCheck.Location = new System.Drawing.Point(237, 349);
            this.ageCheck.Name = "ageCheck";
            this.ageCheck.Size = new System.Drawing.Size(16, 16);
            this.ageCheck.TabIndex = 11;
            this.ageCheck.Visible = false;
            // 
            // NewMemberForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(284, 483);
            this.Controls.Add(this.ageCheck);
            this.Controls.Add(this.mobileCheck);
            this.Controls.Add(this.addressCheck);
            this.Controls.Add(this.surnameCheck);
            this.Controls.Add(this.firstNameCheck);
            this.Controls.Add(this.ageTextBox);
            this.Controls.Add(this.mobileTextBox);
            this.Controls.Add(this.addressTextBox);
            this.Controls.Add(this.surnameTextBox);
            this.Controls.Add(this.firstNameTextBox);
            this.Controls.Add(this.custIDTextBox);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.addMemberButton);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "NewMemberForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Member Registration";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button addMemberButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.TextBox custIDTextBox;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.TextBox surnameTextBox;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.TextBox mobileTextBox;
        private System.Windows.Forms.TextBox ageTextBox;
        private System.Windows.Forms.Panel firstNameCheck;
        private System.Windows.Forms.Panel surnameCheck;
        private System.Windows.Forms.Panel addressCheck;
        private System.Windows.Forms.Panel mobileCheck;
        private System.Windows.Forms.Panel ageCheck;
    }
}