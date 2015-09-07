namespace Prototype
{
    partial class LoginForm
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
            this.loginUserTextBox = new System.Windows.Forms.TextBox();
            this.loginPasswordTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.loginWarningLabel = new System.Windows.Forms.Label();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.passLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // loginUserTextBox
            // 
            this.loginUserTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.loginUserTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.loginUserTextBox.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginUserTextBox.ForeColor = System.Drawing.Color.Black;
            this.loginUserTextBox.Location = new System.Drawing.Point(51, 323);
            this.loginUserTextBox.MinimumSize = new System.Drawing.Size(150, 25);
            this.loginUserTextBox.Name = "loginUserTextBox";
            this.loginUserTextBox.Size = new System.Drawing.Size(188, 27);
            this.loginUserTextBox.TabIndex = 1;
            this.loginUserTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.loginUserTextBox_KeyPress);
            // 
            // loginPasswordTextBox
            // 
            this.loginPasswordTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.loginPasswordTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.loginPasswordTextBox.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginPasswordTextBox.ForeColor = System.Drawing.Color.Black;
            this.loginPasswordTextBox.Location = new System.Drawing.Point(51, 353);
            this.loginPasswordTextBox.MinimumSize = new System.Drawing.Size(150, 25);
            this.loginPasswordTextBox.Name = "loginPasswordTextBox";
            this.loginPasswordTextBox.Size = new System.Drawing.Size(188, 27);
            this.loginPasswordTextBox.TabIndex = 2;
            this.loginPasswordTextBox.UseSystemPasswordChar = true;
            this.loginPasswordTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.loginPasswordTextBox_KeyPress);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(169)))), ((int)(((byte)(221)))));
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(51, 386);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(188, 30);
            this.button1.TabIndex = 3;
            this.button1.Text = "Login";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // loginWarningLabel
            // 
            this.loginWarningLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.loginWarningLabel.AutoSize = true;
            this.loginWarningLabel.BackColor = System.Drawing.Color.Transparent;
            this.loginWarningLabel.Font = new System.Drawing.Font("Verdana", 20F);
            this.loginWarningLabel.ForeColor = System.Drawing.Color.Red;
            this.loginWarningLabel.Location = new System.Drawing.Point(-50, 450);
            this.loginWarningLabel.Name = "loginWarningLabel";
            this.loginWarningLabel.Size = new System.Drawing.Size(412, 32);
            this.loginWarningLabel.TabIndex = 4;
            this.loginWarningLabel.Text = "Login information is incorrect";
            this.loginWarningLabel.Visible = false;
            // 
            // usernameLabel
            // 
            this.usernameLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.BackColor = System.Drawing.Color.Transparent;
            this.usernameLabel.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLabel.ForeColor = System.Drawing.Color.Snow;
            this.usernameLabel.Location = new System.Drawing.Point(-60, 327);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(105, 23);
            this.usernameLabel.TabIndex = 6;
            this.usernameLabel.Text = "Username";
            // 
            // passLabel
            // 
            this.passLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.passLabel.AutoSize = true;
            this.passLabel.BackColor = System.Drawing.Color.Transparent;
            this.passLabel.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passLabel.ForeColor = System.Drawing.Color.Snow;
            this.passLabel.Location = new System.Drawing.Point(-60, 357);
            this.passLabel.Name = "passLabel";
            this.passLabel.Size = new System.Drawing.Size(100, 23);
            this.passLabel.TabIndex = 7;
            this.passLabel.Text = "Password";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.BackgroundImage = global::Prototype.Properties.Resources.LimerickGamersGameLibrary;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(923, 603);
            this.Controls.Add(this.passLabel);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.loginWarningLabel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.loginPasswordTextBox);
            this.Controls.Add(this.loginUserTextBox);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Silver;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoginForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox loginUserTextBox;
        private System.Windows.Forms.TextBox loginPasswordTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label loginWarningLabel;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Label passLabel;
    }
}

