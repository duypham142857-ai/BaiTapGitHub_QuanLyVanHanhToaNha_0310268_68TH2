using System;
using System.Collections.Generic;
using System.Text;
using static App_Do_An.Model.Users;

namespace App_Do_An.Model
{
    internal class AuthService
    {
        
        
            // Giả lập cơ sở dữ liệu người dùng
            public User Login(string username, string password)
            {
        
                if (username == "manager" && password == "123")
                {
                    return new User
                    {
                        Username = "manager01",
                        FullName = "Nguyễn Quản Lý",
                        Role = UserRole.Manager
                    };
                }
                else if (username == "admin" && password == "123")
                {
                    return new User
                    {
                        Username = "admin01",
                        FullName = "Hệ Thống Admin",
                        Role = UserRole.Admin
                    };
                }

                return null; // Đăng nhập thất bại
            }
        
    }
}
