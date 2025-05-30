﻿using Fire_Sales___Sales_Management_System.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fire_Sales___Sales_Management_System.Data_Access.Interfaces
{
    public interface IUserRepository : IRepository<User>
    {
        User GetByUsername(string username);
        List<User> GetActiveUsers();
        List<User> GetByRole(string role);
        User Authenticate(string username, string password);

        //bool ValidateLogin(string username, string password);


    }
}
