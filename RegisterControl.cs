using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp4
{
    public partial class RegisterControl : UserControl
    {
        public event Action? OpenLogin;
        public event Action<string,string,string>? OnSignupRequested;
        public RegisterControl()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (showPassword.Checked)
            {
                passwordTextBox.PasswordChar = default;
            }
            else passwordTextBox.PasswordChar = '*';
        }
        private void signupButton_Click(object sender, EventArgs e)
        {
            string email = emailTextBox.Text.Trim().ToLower();
            string username = usernametextBox.Text.Trim();
            string password = passwordTextBox.Text.Trim();
            OnSignupRequested?.Invoke(email, username, password);
        }


        private void loginLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenLogin?.Invoke();
        }

    }
}
