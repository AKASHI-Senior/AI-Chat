namespace WinFormsApp4
{
    partial class RegisterControl
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
            signupButton = new Button();
            passworldLabel = new Label();
            passwordTextBox = new TextBox();
            labeluser = new Label();
            usernametextBox = new TextBox();
            emailLabel = new Label();
            emailTextBox = new TextBox();
            tableLayoutPanelLeft = new TableLayoutPanel();
            showPassword = new CheckBox();
            tableLayoutPanelUp = new TableLayoutPanel();
            label1 = new Label();
            sigupLabel = new Label();
            loginLink = new LinkLabel();
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
            tableLayoutPanel1.Controls.Add(loginLink, 1, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.Size = new Size(1136, 650);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // TableLayoutPanel
            // 
            TableLayoutPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            TableLayoutPanel.ColumnCount = 2;
            TableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            TableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            TableLayoutPanel.Controls.Add(signupButton, 0, 3);
            TableLayoutPanel.Controls.Add(passworldLabel, 0, 2);
            TableLayoutPanel.Controls.Add(passwordTextBox, 1, 2);
            TableLayoutPanel.Controls.Add(labeluser, 0, 1);
            TableLayoutPanel.Controls.Add(usernametextBox, 1, 1);
            TableLayoutPanel.Controls.Add(emailLabel, 0, 0);
            TableLayoutPanel.Controls.Add(emailTextBox, 1, 0);
            TableLayoutPanel.Location = new Point(381, 219);
            TableLayoutPanel.Name = "TableLayoutPanel";
            TableLayoutPanel.RowCount = 4;
            TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            TableLayoutPanel.Size = new Size(372, 210);
            TableLayoutPanel.TabIndex = 0;
            // 
            // signupButton
            // 
            signupButton.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            TableLayoutPanel.SetColumnSpan(signupButton, 2);
            signupButton.FlatAppearance.BorderColor = Color.Black;
            signupButton.Location = new Point(3, 159);
            signupButton.Name = "signupButton";
            signupButton.Size = new Size(366, 48);
            signupButton.TabIndex = 8;
            signupButton.Text = "Sign Up";
            signupButton.UseVisualStyleBackColor = true;
            signupButton.Click += signupButton_Click;
            // 
            // passworldLabel
            // 
            passworldLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            passworldLabel.AutoSize = true;
            passworldLabel.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            passworldLabel.Location = new Point(6, 104);
            passworldLabel.Margin = new Padding(6, 0, 6, 0);
            passworldLabel.Name = "passworldLabel";
            passworldLabel.RightToLeft = RightToLeft.No;
            passworldLabel.Size = new Size(174, 52);
            passworldLabel.TabIndex = 6;
            passworldLabel.Text = "Password:";
            passworldLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // passwordTextBox
            // 
            passwordTextBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            passwordTextBox.Location = new Point(192, 112);
            passwordTextBox.Margin = new Padding(6, 5, 6, 5);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.PasswordChar = '*';
            passwordTextBox.Size = new Size(174, 35);
            passwordTextBox.TabIndex = 7;
            // 
            // labeluser
            // 
            labeluser.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labeluser.AutoSize = true;
            labeluser.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labeluser.Location = new Point(6, 52);
            labeluser.Margin = new Padding(6, 0, 6, 0);
            labeluser.Name = "labeluser";
            labeluser.RightToLeft = RightToLeft.No;
            labeluser.Size = new Size(174, 52);
            labeluser.TabIndex = 4;
            labeluser.Text = "Username:";
            labeluser.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // usernametextBox
            // 
            usernametextBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            usernametextBox.Location = new Point(192, 60);
            usernametextBox.Margin = new Padding(6, 5, 6, 5);
            usernametextBox.Name = "usernametextBox";
            usernametextBox.Size = new Size(174, 35);
            usernametextBox.TabIndex = 5;
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
            emailLabel.Size = new Size(174, 52);
            emailLabel.TabIndex = 2;
            emailLabel.Text = "E-mail:";
            emailLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // emailTextBox
            // 
            emailTextBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            emailTextBox.Location = new Point(192, 8);
            emailTextBox.Margin = new Padding(6, 5, 6, 5);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.Size = new Size(174, 35);
            emailTextBox.TabIndex = 3;
            // 
            // tableLayoutPanelLeft
            // 
            tableLayoutPanelLeft.AutoSize = true;
            tableLayoutPanelLeft.ColumnCount = 1;
            tableLayoutPanelLeft.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanelLeft.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanelLeft.Controls.Add(showPassword, 0, 2);
            tableLayoutPanelLeft.Dock = DockStyle.Left;
            tableLayoutPanelLeft.Location = new Point(759, 219);
            tableLayoutPanelLeft.Name = "tableLayoutPanelLeft";
            tableLayoutPanelLeft.RowCount = 4;
            tableLayoutPanelLeft.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanelLeft.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanelLeft.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanelLeft.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanelLeft.Size = new Size(122, 210);
            tableLayoutPanelLeft.TabIndex = 1;
            // 
            // showPassword
            // 
            showPassword.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            showPassword.AutoSize = true;
            showPassword.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            showPassword.Location = new Point(3, 107);
            showPassword.Name = "showPassword";
            showPassword.Size = new Size(116, 46);
            showPassword.TabIndex = 3;
            showPassword.Text = "Show Password";
            showPassword.UseVisualStyleBackColor = true;
            showPassword.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // tableLayoutPanelUp
            // 
            tableLayoutPanelUp.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanelUp.ColumnCount = 1;
            tableLayoutPanelUp.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanelUp.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanelUp.Controls.Add(label1, 0, 0);
            tableLayoutPanelUp.Controls.Add(sigupLabel, 0, 1);
            tableLayoutPanelUp.Location = new Point(381, 3);
            tableLayoutPanelUp.Name = "tableLayoutPanelUp";
            tableLayoutPanelUp.RowCount = 3;
            tableLayoutPanelUp.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanelUp.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanelUp.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanelUp.Size = new Size(372, 210);
            tableLayoutPanelUp.TabIndex = 2;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Location = new Point(186, 21);
            label1.Name = "label1";
            label1.Size = new Size(0, 27);
            label1.TabIndex = 1;
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // sigupLabel
            // 
            sigupLabel.Dock = DockStyle.Fill;
            sigupLabel.FlatStyle = FlatStyle.Popup;
            sigupLabel.Font = new Font("Arial", 32F, FontStyle.Bold);
            sigupLabel.ForeColor = Color.Teal;
            sigupLabel.Location = new Point(3, 69);
            sigupLabel.Name = "sigupLabel";
            sigupLabel.Size = new Size(366, 69);
            sigupLabel.TabIndex = 2;
            sigupLabel.Text = "Sign Up";
            sigupLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // loginLink
            // 
            loginLink.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            loginLink.AutoSize = true;
            loginLink.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            loginLink.Location = new Point(381, 432);
            loginLink.Name = "loginLink";
            loginLink.Size = new Size(372, 18);
            loginLink.TabIndex = 3;
            loginLink.TabStop = true;
            loginLink.Text = "Already have a account? Login";
            loginLink.TextAlign = ContentAlignment.TopCenter;
            loginLink.LinkClicked += loginLink_LinkClicked;
            // 
            // RegisterControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Name = "RegisterControl";
            Size = new Size(1136, 650);
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
        private TableLayoutPanel tableLayoutPanelLeft;
        private TableLayoutPanel tableLayoutPanelUp;
        private Label label1;
        private Label emailLabel;
        private TextBox emailTextBox;
        private Label labeluser;
        private TextBox usernametextBox;
        private Label passworldLabel;
        private TextBox passwordTextBox;
        private Button signupButton;
        private CheckBox showPassword;
        private Label sigupLabel;
        private LinkLabel loginLink;
    }
}
