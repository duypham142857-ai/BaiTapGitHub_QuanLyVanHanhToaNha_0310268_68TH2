using System;
using System.Collections.Generic;
using System.Text;

namespace App_Do_An.Model
{
    internal class Users
    {
        public enum UserRole { Admin, Manager, Maintenance }

        public class User
        {
            public string Username { get; set; }
            public string FullName { get; set; }
            public UserRole Role { get; set; }
            public string AuthToken { get; set; } // Dùng để gọi API sau này
        }
    }
}
