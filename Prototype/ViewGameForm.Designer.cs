namespace Prototype
{
    partial class ViewGameForm
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
            this.backButton = new System.Windows.Forms.Panel();
            this.imagePanel = new System.Windows.Forms.Panel();
            this.searchPanel = new System.Windows.Forms.Panel();
            this.notFound = new System.Windows.Forms.Label();
            this.searchGameButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.viewGamePanel = new System.Windows.Forms.Panel();
            this.closeButton = new System.Windows.Forms.Button();
            this.reserved = new System.Windows.Forms.Label();
            this.rented = new System.Windows.Forms.Label();
            this.due = new System.Windows.Forms.Label();
            this.issue = new System.Windows.Forms.Label();
            this.mobile = new System.Windows.Forms.Label();
            this.age = new System.Windows.Forms.Label();
            this.address = new System.Windows.Forms.Label();
            this.sname = new System.Windows.Forms.Label();
            this.fname = new System.Windows.Forms.Label();
            this.custID = new System.Windows.Forms.Label();
            this.agecat = new System.Windows.Forms.Label();
            this.released = new System.Windows.Forms.Label();
            this.category = new System.Windows.Forms.Label();
            this.title = new System.Windows.Forms.Label();
            this.gameID = new System.Windows.Forms.Label();
            this.stockID = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.searchPanel.SuspendLayout();
            this.viewGamePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // backButton
            // 
            this.backButton.BackgroundImage = global::Prototype.Properties.Resources.back_button;
            this.backButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.backButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backButton.Location = new System.Drawing.Point(12, 12);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(45, 45);
            this.backButton.TabIndex = 52;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // imagePanel
            // 
            this.imagePanel.BackColor = System.Drawing.Color.Transparent;
            this.imagePanel.BackgroundImage = global::Prototype.Properties.Resources.view_game_dark;
            this.imagePanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.imagePanel.Location = new System.Drawing.Point(220, 12);
            this.imagePanel.Name = "imagePanel";
            this.imagePanel.Size = new System.Drawing.Size(120, 120);
            this.imagePanel.TabIndex = 11;
            // 
            // searchPanel
            // 
            this.searchPanel.Controls.Add(this.notFound);
            this.searchPanel.Controls.Add(this.searchGameButton);
            this.searchPanel.Controls.Add(this.label1);
            this.searchPanel.Controls.Add(this.searchTextBox);
            this.searchPanel.Location = new System.Drawing.Point(47, 149);
            this.searchPanel.Name = "searchPanel";
            this.searchPanel.Size = new System.Drawing.Size(514, 251);
            this.searchPanel.TabIndex = 53;
            // 
            // notFound
            // 
            this.notFound.AutoSize = true;
            this.notFound.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notFound.ForeColor = System.Drawing.Color.Crimson;
            this.notFound.Location = new System.Drawing.Point(194, 141);
            this.notFound.Name = "notFound";
            this.notFound.Size = new System.Drawing.Size(112, 14);
            this.notFound.TabIndex = 55;
            this.notFound.Text = "Game Not Found";
            this.notFound.Visible = false;
            // 
            // searchGameButton
            // 
            this.searchGameButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.searchGameButton.FlatAppearance.BorderSize = 0;
            this.searchGameButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchGameButton.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchGameButton.ForeColor = System.Drawing.Color.White;
            this.searchGameButton.Location = new System.Drawing.Point(188, 183);
            this.searchGameButton.Name = "searchGameButton";
            this.searchGameButton.Size = new System.Drawing.Size(125, 40);
            this.searchGameButton.TabIndex = 54;
            this.searchGameButton.Text = "Search";
            this.searchGameButton.UseVisualStyleBackColor = false;
            this.searchGameButton.Click += new System.EventHandler(this.searchGameButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(101, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(290, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Search for a game to view";
            // 
            // searchTextBox
            // 
            this.searchTextBox.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchTextBox.ForeColor = System.Drawing.Color.Silver;
            this.searchTextBox.Location = new System.Drawing.Point(133, 111);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(237, 21);
            this.searchTextBox.TabIndex = 1;
            this.searchTextBox.Text = "Enter Stock ID";
            this.searchTextBox.Enter += new System.EventHandler(this.searchTextBox_Enter);
            this.searchTextBox.Leave += new System.EventHandler(this.searchTextBox_Leave);
            // 
            // viewGamePanel
            // 
            this.viewGamePanel.Controls.Add(this.closeButton);
            this.viewGamePanel.Controls.Add(this.reserved);
            this.viewGamePanel.Controls.Add(this.rented);
            this.viewGamePanel.Controls.Add(this.due);
            this.viewGamePanel.Controls.Add(this.issue);
            this.viewGamePanel.Controls.Add(this.mobile);
            this.viewGamePanel.Controls.Add(this.age);
            this.viewGamePanel.Controls.Add(this.address);
            this.viewGamePanel.Controls.Add(this.sname);
            this.viewGamePanel.Controls.Add(this.fname);
            this.viewGamePanel.Controls.Add(this.custID);
            this.viewGamePanel.Controls.Add(this.agecat);
            this.viewGamePanel.Controls.Add(this.released);
            this.viewGamePanel.Controls.Add(this.category);
            this.viewGamePanel.Controls.Add(this.title);
            this.viewGamePanel.Controls.Add(this.gameID);
            this.viewGamePanel.Controls.Add(this.stockID);
            this.viewGamePanel.Controls.Add(this.label22);
            this.viewGamePanel.Controls.Add(this.label21);
            this.viewGamePanel.Controls.Add(this.label20);
            this.viewGamePanel.Controls.Add(this.label19);
            this.viewGamePanel.Controls.Add(this.label18);
            this.viewGamePanel.Controls.Add(this.label17);
            this.viewGamePanel.Controls.Add(this.label10);
            this.viewGamePanel.Controls.Add(this.label16);
            this.viewGamePanel.Controls.Add(this.label9);
            this.viewGamePanel.Controls.Add(this.label15);
            this.viewGamePanel.Controls.Add(this.label8);
            this.viewGamePanel.Controls.Add(this.label14);
            this.viewGamePanel.Controls.Add(this.label7);
            this.viewGamePanel.Controls.Add(this.label13);
            this.viewGamePanel.Controls.Add(this.label6);
            this.viewGamePanel.Controls.Add(this.label12);
            this.viewGamePanel.Controls.Add(this.label11);
            this.viewGamePanel.Controls.Add(this.label5);
            this.viewGamePanel.Controls.Add(this.label4);
            this.viewGamePanel.Controls.Add(this.label3);
            this.viewGamePanel.Controls.Add(this.label2);
            this.viewGamePanel.Location = new System.Drawing.Point(68, 138);
            this.viewGamePanel.Name = "viewGamePanel";
            this.viewGamePanel.Size = new System.Drawing.Size(475, 563);
            this.viewGamePanel.TabIndex = 55;
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.closeButton.FlatAppearance.BorderSize = 0;
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeButton.ForeColor = System.Drawing.Color.White;
            this.closeButton.Location = new System.Drawing.Point(160, 520);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(125, 40);
            this.closeButton.TabIndex = 80;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // reserved
            // 
            this.reserved.AutoSize = true;
            this.reserved.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reserved.Location = new System.Drawing.Point(149, 470);
            this.reserved.Name = "reserved";
            this.reserved.Size = new System.Drawing.Size(54, 16);
            this.reserved.TabIndex = 79;
            this.reserved.Text = "label39";
            // 
            // rented
            // 
            this.rented.AutoSize = true;
            this.rented.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rented.Location = new System.Drawing.Point(149, 445);
            this.rented.Name = "rented";
            this.rented.Size = new System.Drawing.Size(54, 16);
            this.rented.TabIndex = 78;
            this.rented.Text = "label38";
            // 
            // due
            // 
            this.due.AutoSize = true;
            this.due.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.due.Location = new System.Drawing.Point(149, 405);
            this.due.Name = "due";
            this.due.Size = new System.Drawing.Size(54, 16);
            this.due.TabIndex = 77;
            this.due.Text = "label37";
            // 
            // issue
            // 
            this.issue.AutoSize = true;
            this.issue.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.issue.Location = new System.Drawing.Point(149, 380);
            this.issue.Name = "issue";
            this.issue.Size = new System.Drawing.Size(54, 16);
            this.issue.TabIndex = 76;
            this.issue.Text = "label36";
            // 
            // mobile
            // 
            this.mobile.AutoSize = true;
            this.mobile.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mobile.Location = new System.Drawing.Point(149, 340);
            this.mobile.Name = "mobile";
            this.mobile.Size = new System.Drawing.Size(54, 16);
            this.mobile.TabIndex = 75;
            this.mobile.Text = "label35";
            // 
            // age
            // 
            this.age.AutoSize = true;
            this.age.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.age.Location = new System.Drawing.Point(149, 315);
            this.age.Name = "age";
            this.age.Size = new System.Drawing.Size(54, 16);
            this.age.TabIndex = 74;
            this.age.Text = "label34";
            // 
            // address
            // 
            this.address.AutoSize = true;
            this.address.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.address.Location = new System.Drawing.Point(149, 290);
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(54, 16);
            this.address.TabIndex = 73;
            this.address.Text = "label33";
            // 
            // sname
            // 
            this.sname.AutoSize = true;
            this.sname.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sname.Location = new System.Drawing.Point(149, 265);
            this.sname.Name = "sname";
            this.sname.Size = new System.Drawing.Size(54, 16);
            this.sname.TabIndex = 72;
            this.sname.Text = "label32";
            // 
            // fname
            // 
            this.fname.AutoSize = true;
            this.fname.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fname.Location = new System.Drawing.Point(149, 240);
            this.fname.Name = "fname";
            this.fname.Size = new System.Drawing.Size(54, 16);
            this.fname.TabIndex = 71;
            this.fname.Text = "label31";
            // 
            // custID
            // 
            this.custID.AutoSize = true;
            this.custID.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.custID.Location = new System.Drawing.Point(149, 215);
            this.custID.Name = "custID";
            this.custID.Size = new System.Drawing.Size(54, 16);
            this.custID.TabIndex = 70;
            this.custID.Text = "label30";
            // 
            // agecat
            // 
            this.agecat.AutoSize = true;
            this.agecat.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.agecat.Location = new System.Drawing.Point(149, 175);
            this.agecat.Name = "agecat";
            this.agecat.Size = new System.Drawing.Size(54, 16);
            this.agecat.TabIndex = 69;
            this.agecat.Text = "label29";
            // 
            // released
            // 
            this.released.AutoSize = true;
            this.released.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.released.Location = new System.Drawing.Point(149, 150);
            this.released.Name = "released";
            this.released.Size = new System.Drawing.Size(54, 16);
            this.released.TabIndex = 68;
            this.released.Text = "label28";
            // 
            // category
            // 
            this.category.AutoSize = true;
            this.category.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.category.Location = new System.Drawing.Point(149, 120);
            this.category.Name = "category";
            this.category.Size = new System.Drawing.Size(54, 16);
            this.category.TabIndex = 67;
            this.category.Text = "label27";
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(149, 95);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(54, 16);
            this.title.TabIndex = 66;
            this.title.Text = "label26";
            // 
            // gameID
            // 
            this.gameID.AutoSize = true;
            this.gameID.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameID.Location = new System.Drawing.Point(149, 70);
            this.gameID.Name = "gameID";
            this.gameID.Size = new System.Drawing.Size(54, 16);
            this.gameID.TabIndex = 65;
            this.gameID.Text = "label25";
            // 
            // stockID
            // 
            this.stockID.AutoSize = true;
            this.stockID.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stockID.Location = new System.Drawing.Point(149, 31);
            this.stockID.Name = "stockID";
            this.stockID.Size = new System.Drawing.Size(54, 16);
            this.stockID.TabIndex = 64;
            this.stockID.Text = "label24";
            // 
            // label22
            // 
            this.label22.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label22.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.label22.Location = new System.Drawing.Point(131, 34);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(2, 450);
            this.label22.TabIndex = 62;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.label21.Location = new System.Drawing.Point(42, 470);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(81, 16);
            this.label21.TabIndex = 61;
            this.label21.Text = "Reserved:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.label20.Location = new System.Drawing.Point(59, 445);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(64, 16);
            this.label20.TabIndex = 60;
            this.label20.Text = "Rented:";
            // 
            // label19
            // 
            this.label19.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label19.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.label19.Location = new System.Drawing.Point(16, 434);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(454, 2);
            this.label19.TabIndex = 59;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.label18.Location = new System.Drawing.Point(44, 405);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(79, 16);
            this.label18.TabIndex = 58;
            this.label18.Text = "Due Date:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.label17.Location = new System.Drawing.Point(32, 380);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(91, 16);
            this.label17.TabIndex = 57;
            this.label17.Text = "Issue Date:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.label10.Location = new System.Drawing.Point(19, 215);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(104, 16);
            this.label10.TabIndex = 8;
            this.label10.Text = "Customer ID:";
            // 
            // label16
            // 
            this.label16.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label16.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.label16.Location = new System.Drawing.Point(16, 368);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(454, 2);
            this.label16.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label9.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.label9.Location = new System.Drawing.Point(16, 205);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(454, 2);
            this.label9.TabIndex = 7;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.label15.Location = new System.Drawing.Point(65, 340);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(60, 16);
            this.label15.TabIndex = 56;
            this.label15.Text = "Mobile:";
            // 
            // label8
            // 
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label8.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.label8.Location = new System.Drawing.Point(16, 58);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(454, 2);
            this.label8.TabIndex = 6;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.label14.Location = new System.Drawing.Point(84, 315);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(41, 16);
            this.label14.TabIndex = 55;
            this.label14.Text = "Age:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.label7.Location = new System.Drawing.Point(13, 175);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 16);
            this.label7.TabIndex = 5;
            this.label7.Text = "Age Category:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.label13.Location = new System.Drawing.Point(51, 290);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(72, 16);
            this.label13.TabIndex = 9;
            this.label13.Text = "Address:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.label6.Location = new System.Drawing.Point(44, 150);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 16);
            this.label6.TabIndex = 4;
            this.label6.Text = "Released:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.label12.Location = new System.Drawing.Point(45, 265);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(78, 16);
            this.label12.TabIndex = 54;
            this.label12.Text = "Surname:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.label11.Location = new System.Drawing.Point(33, 240);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(92, 16);
            this.label11.TabIndex = 9;
            this.label11.Text = "First Name:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.label5.Location = new System.Drawing.Point(43, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 16);
            this.label5.TabIndex = 3;
            this.label5.Text = "Category:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.label4.Location = new System.Drawing.Point(79, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Title:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.label3.Location = new System.Drawing.Point(50, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Game ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.label2.Location = new System.Drawing.Point(50, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Stock ID:";
            // 
            // ViewGameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 724);
            this.Controls.Add(this.viewGamePanel);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.imagePanel);
            this.Controls.Add(this.searchPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Location = new System.Drawing.Point(60, 40);
            this.MaximizeBox = false;
            this.Name = "ViewGameForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "View Games";
            this.searchPanel.ResumeLayout(false);
            this.searchPanel.PerformLayout();
            this.viewGamePanel.ResumeLayout(false);
            this.viewGamePanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel imagePanel;
        private System.Windows.Forms.Panel backButton;
        private System.Windows.Forms.Panel searchPanel;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button searchGameButton;
        private System.Windows.Forms.Panel viewGamePanel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label agecat;
        private System.Windows.Forms.Label released;
        private System.Windows.Forms.Label category;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label gameID;
        private System.Windows.Forms.Label stockID;
        private System.Windows.Forms.Label reserved;
        private System.Windows.Forms.Label rented;
        private System.Windows.Forms.Label due;
        private System.Windows.Forms.Label issue;
        private System.Windows.Forms.Label mobile;
        private System.Windows.Forms.Label age;
        private System.Windows.Forms.Label address;
        private System.Windows.Forms.Label sname;
        private System.Windows.Forms.Label fname;
        private System.Windows.Forms.Label custID;
        private System.Windows.Forms.Label notFound;
        private System.Windows.Forms.Button closeButton;
    }
}