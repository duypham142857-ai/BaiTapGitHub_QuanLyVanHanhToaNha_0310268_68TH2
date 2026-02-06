using App_Do_An.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Input;
using System.Windows.Navigation;
using static App_Do_An.Model.Users;

namespace App_Do_An.View_Model
{
    internal class LoginViewModel
    {
        private AuthService _authService = new AuthService();

        public string Username { get; set; }
        public string Password { get; set; }

        public void ExecuteLogin()
        {
            
            var user = _authService.Login(Username, Password);

            if (user != null)
            {
                
                MessageBox.Show("Chào mừng {user.FullName}!");
            }
            else
            {
                MessageBox.Show("Sai tài khoản hoặc mật khẩu!");
            }
        }
    }
}
