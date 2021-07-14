
namespace CS_Webhook_Sender
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.topBarPanel = new System.Windows.Forms.Panel();
            this.minimiseButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.titleLabel = new System.Windows.Forms.Label();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.settingsLabel = new System.Windows.Forms.Label();
            this.menuLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.showMessage = new System.Windows.Forms.Button();
            this.showSettings = new System.Windows.Forms.Button();
            this.settingsPanel = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.loadButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.applyName = new System.Windows.Forms.Button();
            this.PFPTextBox = new System.Windows.Forms.TextBox();
            this.PFPLabel = new System.Windows.Forms.Label();
            this.applyPFP = new System.Windows.Forms.Button();
            this.linkTextBox = new System.Windows.Forms.TextBox();
            this.linkLabel = new System.Windows.Forms.Label();
            this.applyLink = new System.Windows.Forms.Button();
            this.messageLabel = new System.Windows.Forms.Label();
            this.messagePanel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.outputTextBox = new System.Windows.Forms.TextBox();
            this.sendMessageButton = new System.Windows.Forms.Button();
            this.panel8 = new System.Windows.Forms.Panel();
            this.webhookPFPLabel = new System.Windows.Forms.Label();
            this.webhookNameLabel = new System.Windows.Forms.Label();
            this.webhookLinkLabel = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.messageLengthLabel = new System.Windows.Forms.TextBox();
            this.messageLength = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.topBarPanel.SuspendLayout();
            this.mainPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.settingsPanel.SuspendLayout();
            this.panel3.SuspendLayout();
            this.messagePanel.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // topBarPanel
            // 
            this.topBarPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.topBarPanel.Controls.Add(this.minimiseButton);
            this.topBarPanel.Controls.Add(this.closeButton);
            this.topBarPanel.Controls.Add(this.titleLabel);
            this.topBarPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topBarPanel.Location = new System.Drawing.Point(0, 0);
            this.topBarPanel.Name = "topBarPanel";
            this.topBarPanel.Size = new System.Drawing.Size(884, 26);
            this.topBarPanel.TabIndex = 0;
            this.topBarPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.topBarPanel_MouseDown);
            // 
            // minimiseButton
            // 
            this.minimiseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.minimiseButton.FlatAppearance.BorderSize = 0;
            this.minimiseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimiseButton.ForeColor = System.Drawing.Color.White;
            this.minimiseButton.Location = new System.Drawing.Point(830, 0);
            this.minimiseButton.Name = "minimiseButton";
            this.minimiseButton.Size = new System.Drawing.Size(24, 23);
            this.minimiseButton.TabIndex = 2;
            this.minimiseButton.Text = "_";
            this.minimiseButton.UseVisualStyleBackColor = false;
            this.minimiseButton.Click += new System.EventHandler(this.minimiseButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(50)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.closeButton.FlatAppearance.BorderSize = 0;
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.ForeColor = System.Drawing.Color.White;
            this.closeButton.Location = new System.Drawing.Point(860, 0);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(24, 23);
            this.closeButton.TabIndex = 1;
            this.closeButton.Text = "x";
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.titleLabel.ForeColor = System.Drawing.Color.White;
            this.titleLabel.Location = new System.Drawing.Point(3, 4);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(134, 17);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "CJ\'s Webhook Sender";
            // 
            // mainPanel
            // 
            this.mainPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("mainPanel.BackgroundImage")));
            this.mainPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.mainPanel.Controls.Add(this.settingsLabel);
            this.mainPanel.Controls.Add(this.menuLabel);
            this.mainPanel.Controls.Add(this.panel1);
            this.mainPanel.Controls.Add(this.settingsPanel);
            this.mainPanel.Controls.Add(this.messageLabel);
            this.mainPanel.Controls.Add(this.messagePanel);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 26);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(884, 435);
            this.mainPanel.TabIndex = 1;
            // 
            // settingsLabel
            // 
            this.settingsLabel.AutoSize = true;
            this.settingsLabel.BackColor = System.Drawing.Color.Transparent;
            this.settingsLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.settingsLabel.ForeColor = System.Drawing.Color.White;
            this.settingsLabel.Location = new System.Drawing.Point(245, 0);
            this.settingsLabel.Name = "settingsLabel";
            this.settingsLabel.Size = new System.Drawing.Size(103, 15);
            this.settingsLabel.TabIndex = 2;
            this.settingsLabel.Text = "Webhook Settings";
            // 
            // menuLabel
            // 
            this.menuLabel.AutoSize = true;
            this.menuLabel.BackColor = System.Drawing.Color.Transparent;
            this.menuLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.menuLabel.ForeColor = System.Drawing.Color.White;
            this.menuLabel.Location = new System.Drawing.Point(24, 0);
            this.menuLabel.Name = "menuLabel";
            this.menuLabel.Size = new System.Drawing.Size(38, 15);
            this.menuLabel.TabIndex = 1;
            this.menuLabel.Text = "Menu";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.showMessage);
            this.panel1.Controls.Add(this.showSettings);
            this.panel1.Location = new System.Drawing.Point(12, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 417);
            this.panel1.TabIndex = 0;
            // 
            // showMessage
            // 
            this.showMessage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.showMessage.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.showMessage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.showMessage.ForeColor = System.Drawing.Color.White;
            this.showMessage.Location = new System.Drawing.Point(11, 56);
            this.showMessage.Name = "showMessage";
            this.showMessage.Size = new System.Drawing.Size(177, 23);
            this.showMessage.TabIndex = 1;
            this.showMessage.Text = "Message";
            this.showMessage.UseVisualStyleBackColor = false;
            this.showMessage.Click += new System.EventHandler(this.showMessage_Click);
            // 
            // showSettings
            // 
            this.showSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.showSettings.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.showSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.showSettings.ForeColor = System.Drawing.Color.White;
            this.showSettings.Location = new System.Drawing.Point(11, 23);
            this.showSettings.Name = "showSettings";
            this.showSettings.Size = new System.Drawing.Size(177, 23);
            this.showSettings.TabIndex = 0;
            this.showSettings.Text = "Settings";
            this.showSettings.UseVisualStyleBackColor = false;
            this.showSettings.Click += new System.EventHandler(this.showSettings_Click);
            // 
            // settingsPanel
            // 
            this.settingsPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.settingsPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.settingsPanel.Controls.Add(this.label4);
            this.settingsPanel.Controls.Add(this.panel4);
            this.settingsPanel.Controls.Add(this.panel3);
            this.settingsPanel.Location = new System.Drawing.Point(229, 6);
            this.settingsPanel.Name = "settingsPanel";
            this.settingsPanel.Size = new System.Drawing.Size(643, 417);
            this.settingsPanel.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(26, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 15);
            this.label4.TabIndex = 2;
            this.label4.Text = "Preview";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Location = new System.Drawing.Point(15, 191);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(609, 211);
            this.panel4.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.loadButton);
            this.panel3.Controls.Add(this.saveButton);
            this.panel3.Controls.Add(this.nameTextBox);
            this.panel3.Controls.Add(this.nameLabel);
            this.panel3.Controls.Add(this.applyName);
            this.panel3.Controls.Add(this.PFPTextBox);
            this.panel3.Controls.Add(this.PFPLabel);
            this.panel3.Controls.Add(this.applyPFP);
            this.panel3.Controls.Add(this.linkTextBox);
            this.panel3.Controls.Add(this.linkLabel);
            this.panel3.Controls.Add(this.applyLink);
            this.panel3.Location = new System.Drawing.Point(15, 23);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(609, 152);
            this.panel3.TabIndex = 0;
            // 
            // loadButton
            // 
            this.loadButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.loadButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.loadButton.FlatAppearance.BorderSize = 0;
            this.loadButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loadButton.ForeColor = System.Drawing.Color.White;
            this.loadButton.Location = new System.Drawing.Point(404, 5);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(93, 23);
            this.loadButton.TabIndex = 10;
            this.loadButton.Text = "Load";
            this.loadButton.UseVisualStyleBackColor = false;
            this.loadButton.Click += new System.EventHandler(this.loadButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.saveButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.saveButton.FlatAppearance.BorderSize = 0;
            this.saveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveButton.ForeColor = System.Drawing.Color.White;
            this.saveButton.Location = new System.Drawing.Point(503, 5);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(93, 23);
            this.saveButton.TabIndex = 9;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // nameTextBox
            // 
            this.nameTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.nameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nameTextBox.ForeColor = System.Drawing.Color.White;
            this.nameTextBox.Location = new System.Drawing.Point(109, 119);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(487, 23);
            this.nameTextBox.TabIndex = 8;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.BackColor = System.Drawing.Color.Transparent;
            this.nameLabel.ForeColor = System.Drawing.Color.White;
            this.nameLabel.Location = new System.Drawing.Point(10, 100);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(96, 15);
            this.nameLabel.TabIndex = 7;
            this.nameLabel.Text = "Webhook Name:";
            // 
            // applyName
            // 
            this.applyName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.applyName.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.applyName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.applyName.ForeColor = System.Drawing.Color.White;
            this.applyName.Location = new System.Drawing.Point(10, 118);
            this.applyName.Name = "applyName";
            this.applyName.Size = new System.Drawing.Size(93, 23);
            this.applyName.TabIndex = 6;
            this.applyName.Text = "Apply";
            this.applyName.UseVisualStyleBackColor = false;
            this.applyName.Click += new System.EventHandler(this.applyName_Click);
            // 
            // PFPTextBox
            // 
            this.PFPTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.PFPTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PFPTextBox.ForeColor = System.Drawing.Color.White;
            this.PFPTextBox.Location = new System.Drawing.Point(112, 75);
            this.PFPTextBox.Name = "PFPTextBox";
            this.PFPTextBox.Size = new System.Drawing.Size(487, 23);
            this.PFPTextBox.TabIndex = 5;
            // 
            // PFPLabel
            // 
            this.PFPLabel.AutoSize = true;
            this.PFPLabel.BackColor = System.Drawing.Color.Transparent;
            this.PFPLabel.ForeColor = System.Drawing.Color.White;
            this.PFPLabel.Location = new System.Drawing.Point(11, 55);
            this.PFPLabel.Name = "PFPLabel";
            this.PFPLabel.Size = new System.Drawing.Size(138, 15);
            this.PFPLabel.TabIndex = 4;
            this.PFPLabel.Text = "Webhook Profile picture:";
            // 
            // applyPFP
            // 
            this.applyPFP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.applyPFP.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.applyPFP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.applyPFP.ForeColor = System.Drawing.Color.White;
            this.applyPFP.Location = new System.Drawing.Point(11, 73);
            this.applyPFP.Name = "applyPFP";
            this.applyPFP.Size = new System.Drawing.Size(93, 23);
            this.applyPFP.TabIndex = 3;
            this.applyPFP.Text = "Apply";
            this.applyPFP.UseVisualStyleBackColor = false;
            this.applyPFP.Click += new System.EventHandler(this.applyPFP_Click);
            // 
            // linkTextBox
            // 
            this.linkTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.linkTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.linkTextBox.ForeColor = System.Drawing.Color.White;
            this.linkTextBox.Location = new System.Drawing.Point(109, 32);
            this.linkTextBox.Name = "linkTextBox";
            this.linkTextBox.Size = new System.Drawing.Size(487, 23);
            this.linkTextBox.TabIndex = 2;
            // 
            // linkLabel
            // 
            this.linkLabel.AutoSize = true;
            this.linkLabel.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel.ForeColor = System.Drawing.Color.White;
            this.linkLabel.Location = new System.Drawing.Point(10, 13);
            this.linkLabel.Name = "linkLabel";
            this.linkLabel.Size = new System.Drawing.Size(86, 15);
            this.linkLabel.TabIndex = 1;
            this.linkLabel.Text = "Webhook Link:";
            // 
            // applyLink
            // 
            this.applyLink.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.applyLink.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.applyLink.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.applyLink.ForeColor = System.Drawing.Color.White;
            this.applyLink.Location = new System.Drawing.Point(10, 31);
            this.applyLink.Name = "applyLink";
            this.applyLink.Size = new System.Drawing.Size(93, 23);
            this.applyLink.TabIndex = 0;
            this.applyLink.Text = "Apply";
            this.applyLink.UseVisualStyleBackColor = false;
            this.applyLink.Click += new System.EventHandler(this.applyLink_Click);
            // 
            // messageLabel
            // 
            this.messageLabel.AutoSize = true;
            this.messageLabel.BackColor = System.Drawing.Color.Transparent;
            this.messageLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.messageLabel.ForeColor = System.Drawing.Color.White;
            this.messageLabel.Location = new System.Drawing.Point(245, 0);
            this.messageLabel.Name = "messageLabel";
            this.messageLabel.Size = new System.Drawing.Size(53, 15);
            this.messageLabel.TabIndex = 4;
            this.messageLabel.Text = "Message";
            // 
            // messagePanel
            // 
            this.messagePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.messagePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.messagePanel.Controls.Add(this.label2);
            this.messagePanel.Controls.Add(this.label1);
            this.messagePanel.Controls.Add(this.panel7);
            this.messagePanel.Controls.Add(this.panel6);
            this.messagePanel.Location = new System.Drawing.Point(229, 6);
            this.messagePanel.Name = "messagePanel";
            this.messagePanel.Size = new System.Drawing.Size(643, 417);
            this.messagePanel.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(30, 305);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Send message";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(30, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Message content";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel7.Controls.Add(this.outputTextBox);
            this.panel7.Controls.Add(this.sendMessageButton);
            this.panel7.Controls.Add(this.panel8);
            this.panel7.Location = new System.Drawing.Point(10, 311);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(625, 98);
            this.panel7.TabIndex = 1;
            // 
            // outputTextBox
            // 
            this.outputTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.outputTextBox.Location = new System.Drawing.Point(486, 35);
            this.outputTextBox.Name = "outputTextBox";
            this.outputTextBox.ReadOnly = true;
            this.outputTextBox.Size = new System.Drawing.Size(128, 23);
            this.outputTextBox.TabIndex = 2;
            // 
            // sendMessageButton
            // 
            this.sendMessageButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.sendMessageButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.sendMessageButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sendMessageButton.ForeColor = System.Drawing.Color.White;
            this.sendMessageButton.Location = new System.Drawing.Point(486, 64);
            this.sendMessageButton.Name = "sendMessageButton";
            this.sendMessageButton.Size = new System.Drawing.Size(128, 27);
            this.sendMessageButton.TabIndex = 1;
            this.sendMessageButton.Text = "Send";
            this.sendMessageButton.UseVisualStyleBackColor = false;
            this.sendMessageButton.Click += new System.EventHandler(this.sendMessageButton_Click);
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.webhookPFPLabel);
            this.panel8.Controls.Add(this.webhookNameLabel);
            this.panel8.Controls.Add(this.webhookLinkLabel);
            this.panel8.Location = new System.Drawing.Point(5, 5);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(450, 86);
            this.panel8.TabIndex = 0;
            // 
            // webhookPFPLabel
            // 
            this.webhookPFPLabel.AutoSize = true;
            this.webhookPFPLabel.ForeColor = System.Drawing.Color.White;
            this.webhookPFPLabel.Location = new System.Drawing.Point(9, 54);
            this.webhookPFPLabel.Name = "webhookPFPLabel";
            this.webhookPFPLabel.Size = new System.Drawing.Size(141, 15);
            this.webhookPFPLabel.TabIndex = 2;
            this.webhookPFPLabel.Text = "Webhook Profile Picture: ";
            // 
            // webhookNameLabel
            // 
            this.webhookNameLabel.AutoSize = true;
            this.webhookNameLabel.ForeColor = System.Drawing.Color.White;
            this.webhookNameLabel.Location = new System.Drawing.Point(9, 34);
            this.webhookNameLabel.Name = "webhookNameLabel";
            this.webhookNameLabel.Size = new System.Drawing.Size(97, 15);
            this.webhookNameLabel.TabIndex = 1;
            this.webhookNameLabel.Text = "Webhook name: ";
            // 
            // webhookLinkLabel
            // 
            this.webhookLinkLabel.AutoSize = true;
            this.webhookLinkLabel.ForeColor = System.Drawing.Color.White;
            this.webhookLinkLabel.Location = new System.Drawing.Point(9, 14);
            this.webhookLinkLabel.Name = "webhookLinkLabel";
            this.webhookLinkLabel.Size = new System.Drawing.Size(86, 15);
            this.webhookLinkLabel.TabIndex = 0;
            this.webhookLinkLabel.Text = "Webhook link: ";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.panel6.Controls.Add(this.messageLengthLabel);
            this.panel6.Controls.Add(this.messageLength);
            this.panel6.Controls.Add(this.textBox1);
            this.panel6.Location = new System.Drawing.Point(10, 22);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(625, 283);
            this.panel6.TabIndex = 0;
            // 
            // messageLengthLabel
            // 
            this.messageLengthLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.messageLengthLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.messageLengthLabel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.messageLengthLabel.ForeColor = System.Drawing.Color.White;
            this.messageLengthLabel.Location = new System.Drawing.Point(18, 249);
            this.messageLengthLabel.Multiline = true;
            this.messageLengthLabel.Name = "messageLengthLabel";
            this.messageLengthLabel.ReadOnly = true;
            this.messageLengthLabel.Size = new System.Drawing.Size(156, 27);
            this.messageLengthLabel.TabIndex = 2;
            this.messageLengthLabel.Text = "Message length:";
            // 
            // messageLength
            // 
            this.messageLength.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.messageLength.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.messageLength.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.messageLength.ForeColor = System.Drawing.Color.White;
            this.messageLength.Location = new System.Drawing.Point(180, 249);
            this.messageLength.Multiline = true;
            this.messageLength.Name = "messageLength";
            this.messageLength.ReadOnly = true;
            this.messageLength.Size = new System.Drawing.Size(423, 27);
            this.messageLength.TabIndex = 1;
            this.messageLength.Text = "0";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(17, 13);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(586, 219);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(884, 461);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.topBarPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.topBarPanel.ResumeLayout(false);
            this.topBarPanel.PerformLayout();
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.settingsPanel.ResumeLayout(false);
            this.settingsPanel.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.messagePanel.ResumeLayout(false);
            this.messagePanel.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel topBarPanel;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label menuLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button minimiseButton;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Label settingsLabel;
        private System.Windows.Forms.Panel settingsPanel;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Button applyName;
        private System.Windows.Forms.TextBox PFPTextBox;
        private System.Windows.Forms.Label PFPLabel;
        private System.Windows.Forms.Button applyPFP;
        private System.Windows.Forms.TextBox linkTextBox;
        private System.Windows.Forms.Label linkLabel;
        private System.Windows.Forms.Button applyLink;
        private System.Windows.Forms.Button showSettings;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label messageLabel;
        private System.Windows.Forms.Panel messagePanel;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox messageLengthLabel;
        private System.Windows.Forms.TextBox messageLength;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button showMessage;
        private System.Windows.Forms.Button sendMessageButton;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label webhookLinkLabel;
        private System.Windows.Forms.TextBox outputTextBox;
        private System.Windows.Forms.Label webhookPFPLabel;
        private System.Windows.Forms.Label webhookNameLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button loadButton;
    }
}

