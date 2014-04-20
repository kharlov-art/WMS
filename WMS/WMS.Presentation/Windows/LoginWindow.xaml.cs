﻿using System;
using System.Windows;
using WMS.BusinessLogic.Services;
using WMS.CustomControls.Controls.BaseWindow;

namespace WMS.Presentation.Windows
{
    /// <summary>
    /// Interaction logic for LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : BaseWindow
    {
        public LoginWindow()
        {
            InitializeComponent();
            BlueButton.Click = Click; 
        }

        private void Click(object sender, RoutedEventArgs routedEventArgs)
        {
            var uS = new UserService(Context);
            if (!uS.IsUserExists(txtLogin.Text, txtPassword.Text))
            {
                MessageBox.Show("No such user");
                return;
            }
            var window = new MainMenuWindow();
            window.Show();
        }
    }
}