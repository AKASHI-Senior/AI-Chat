using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp4
{
    public partial class LoginControl : UserControl
    {
        public event Action? OpenRegister;
        public event Action<string, string>? OnLoginRequested;
        public LoginControl()
        {
            InitializeComponent();
        }


        private void registerLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenRegister?.Invoke();
        }

        private void showPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (showPassword.Checked)
            {
                passwordTextBox.PasswordChar = default;
            }
            else passwordTextBox.PasswordChar = '*';
        }

        private void signinButton_Click(object sender, EventArgs e)
        {
            string email = emailTextBox.Text;
            string password = passwordTextBox.Text;
            OnLoginRequested?.Invoke(email,password);
        }
    }
}
