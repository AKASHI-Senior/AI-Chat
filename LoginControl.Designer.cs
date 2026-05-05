namespace WinFormsApp4
{
    partial class LoginControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tableLayoutPanel1 = new TableLayoutPanel();
            TableLayoutPanel = new TableLayoutPanel();
            emailLabel = new Label();
            emailTextBox = new TextBox();
            passworldLabel = new Label();
            passwordTextBox = new TextBox();
            signinButton = new Button();
            tableLayoutPanelLeft = new TableLayoutPanel();
            showPassword = new CheckBox();
            tableLayoutPanelUp = new TableLayoutPanel();
            label1 = new Label();
            siginLabel = new Label();
            registerLink = new LinkLabel();
            tableLayoutPanel1.SuspendLayout();
            TableLayoutPanel.SuspendLayout();
            tableLayoutPanelLeft.SuspendLayout();
            tableLayoutPanelUp.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.Controls.Add(TableLayoutPanel, 1, 1);
            tableLayoutPanel1.Controls.Add(tableLayoutPanelLeft, 2, 1);
            tableLayoutPanel1.Controls.Add(tableLayoutPanelUp, 1, 0);
            tableLayoutPanel1.Controls.Add(registerLink, 1, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.Size = new Size(1065, 621);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // TableLayoutPanel
            // 
            TableLayoutPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            TableLayoutPanel.ColumnCount = 2;
            TableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            TableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            TableLayoutPanel.Controls.Add(emailLabel, 0, 0);
            TableLayoutPanel.Controls.Add(emailTextBox, 1, 0);
            TableLayoutPanel.Controls.Add(passworldLabel, 0, 1);
            TableLayoutPanel.Controls.Add(passwordTextBox, 1, 1);
            TableLayoutPanel.Controls.Add(signinButton, 0, 3);
            TableLayoutPanel.Location = new Point(358, 210);
            TableLayoutPanel.Name = "TableLayoutPanel";
            TableLayoutPanel.RowCount = 4;
            TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            TableLayoutPanel.Size = new Size(349, 201);
            TableLayoutPanel.TabIndex = 0;
            // 
            // emailLabel
            // 
            emailLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            emailLabel.AutoSize = true;
            emailLabel.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            emailLabel.Location = new Point(6, 0);
            emailLabel.Margin = new Padding(6, 0, 6, 0);
            emailLabel.Name = "emailLabel";
            emailLabel.RightToLeft = RightToLeft.No;
            emailLabel.Size = new Size(162, 50);
            emailLabel.TabIndex = 2;
            emailLabel.Text = "E-mail:";
            emailLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // emailTextBox
            // 
            emailTextBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            emailTextBox.Location = new Point(180, 7);
            emailTextBox.Margin = new Padding(6, 5, 6, 5);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.Size = new Size(163, 35);
            emailTextBox.TabIndex = 3;
            // 
            // passworldLabel
            // 
            passworldLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            passworldLabel.AutoSize = true;
            passworldLabel.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            passworldLabel.Location = new Point(6, 50);
            passworldLabel.Margin = new Padding(6, 0, 6, 0);
            passworldLabel.Name = "passworldLabel";
            passworldLabel.RightToLeft = RightToLeft.No;
            passworldLabel.Size = new Size(162, 50);
            passworldLabel.TabIndex = 6;
            passworldLabel.Text = "Password:";
            passworldLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // passwordTextBox
            // 
            passwordTextBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            passwordTextBox.Location = new Point(180, 57);
            passwordTextBox.Margin = new Padding(6, 5, 6, 5);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.PasswordChar = '*';
            passwordTextBox.Size = new Size(163, 35);
            passwordTextBox.TabIndex = 7;
            // 
            // signinButton
            // 
            signinButton.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            TableLayoutPanel.SetColumnSpan(signinButton, 2);
            signinButton.FlatAppearance.BorderColor = Color.Black;
            signinButton.Location = new Point(3, 153);
            signinButton.Name = "signinButton";
            signinButton.Size = new Size(343, 44);
            signinButton.TabIndex = 8;
            signinButton.Text = "Sign In";
            signinButton.UseVisualStyleBackColor = true;
            signinButton.Click += signinButton_Click;
            // 
            // tableLayoutPanelLeft
            // 
            tableLayoutPanelLeft.AutoSize = true;
            tableLayoutPanelLeft.ColumnCount = 1;
            tableLayoutPanelLeft.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanelLeft.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanelLeft.Controls.Add(showPassword, 0, 1);
            tableLayoutPanelLeft.Dock = DockStyle.Left;
            tableLayoutPanelLeft.Location = new Point(713, 210);
            tableLayoutPanelLeft.Name = "tableLayoutPanelLeft";
            tableLayoutPanelLeft.RowCount = 4;
            tableLayoutPanelLeft.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanelLeft.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanelLeft.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanelLeft.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanelLeft.Size = new Size(122, 201);
            tableLayoutPanelLeft.TabIndex = 1;
            // 
            // showPassword
            // 
            showPassword.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            showPassword.AutoSize = true;
            showPassword.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            showPassword.Location = new Point(3, 53);
            showPassword.Name = "showPassword";
            showPassword.Size = new Size(116, 44);
            showPassword.TabIndex = 3;
            showPassword.Text = "Show Password";
            showPassword.UseVisualStyleBackColor = true;
            showPassword.CheckedChanged += showPassword_CheckedChanged;
            // 
            // tableLayoutPanelUp
            // 
            tableLayoutPanelUp.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanelUp.ColumnCount = 1;
            tableLayoutPanelUp.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanelUp.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanelUp.Controls.Add(label1, 0, 0);
            tableLayoutPanelUp.Controls.Add(siginLabel, 0, 1);
            tableLayoutPanelUp.Location = new Point(358, 3);
            tableLayoutPanelUp.Name = "tableLayoutPanelUp";
            tableLayoutPanelUp.RowCount = 3;
            tableLayoutPanelUp.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanelUp.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanelUp.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanelUp.Size = new Size(349, 201);
            tableLayoutPanelUp.TabIndex = 2;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Location = new Point(174, 19);
            label1.Name = "label1";
            label1.Size = new Size(0, 27);
            label1.TabIndex = 1;
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // siginLabel
            // 
            siginLabel.Dock = DockStyle.Fill;
            siginLabel.FlatStyle = FlatStyle.Popup;
            siginLabel.Font = new Font("Arial", 32F, FontStyle.Bold);
            siginLabel.ForeColor = Color.Teal;
            siginLabel.Location = new Point(3, 66);
            siginLabel.Name = "siginLabel";
            siginLabel.Size = new Size(343, 66);
            siginLabel.TabIndex = 2;
            siginLabel.Text = "Sign In";
            siginLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // registerLink
            // 
            registerLink.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            registerLink.AutoSize = true;
            registerLink.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            registerLink.Location = new Point(358, 414);
            registerLink.Name = "registerLink";
            registerLink.Size = new Size(349, 18);
            registerLink.TabIndex = 3;
            registerLink.TabStop = true;
            registerLink.Text = "Don't have account ? Register";
            registerLink.TextAlign = ContentAlignment.TopCenter;
            registerLink.LinkClicked += registerLink_LinkClicked;
            // 
            // LoginControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Name = "LoginControl";
            Size = new Size(1065, 621);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            TableLayoutPanel.ResumeLayout(false);
            TableLayoutPanel.PerformLayout();
            tableLayoutPanelLeft.ResumeLayout(false);
            tableLayoutPanelLeft.PerformLayout();
            tableLayoutPanelUp.ResumeLayout(false);
            tableLayoutPanelUp.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel TableLayoutPanel;
        private Button signinButton;
        private Label passworldLabel;
        private TextBox passwordTextBox;
        private Label emailLabel;
        private TextBox emailTextBox;
        private TableLayoutPanel tableLayoutPanelLeft;
        private CheckBox showPassword;
        private TableLayoutPanel tableLayoutPanelUp;
        private Label label1;
        private Label siginLabel;
        private LinkLabel registerLink;
    }
}
