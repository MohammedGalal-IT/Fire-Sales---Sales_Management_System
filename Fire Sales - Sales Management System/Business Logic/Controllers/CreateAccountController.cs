using Fire_Sales___Sales_Management_System.Business_Logic.Interfaces;
using Fire_Sales___Sales_Management_System.Business_Logic.Services;
using Fire_Sales___Sales_Management_System.Data_Access.Interfaces;
using Fire_Sales___Sales_Management_System.Data_Access.Repositories;
using Fire_Sales___Sales_Management_System.Helpers.Database_Helpers;
using Fire_Sales___Sales_Management_System.Model;
using Fire_Sales___Sales_Management_System.Presentation.TempViews;
using Fire_Sales___Sales_Management_System.Presentation.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fire_Sales___Sales_Management_System.Business_Logic.Controllers
{
 

    public class CreateAccountController
    {
        public readonly signupForm _view;
        private readonly IUserService _userService;
        private readonly IUserRepository _userRepository;
        private readonly DatabaseManager _db;

        public CreateAccountController(signupForm view)
        {
            _view = view;
            _db = new DatabaseManager(@"Data Source=DESKTOP-KL322NI\MOHAMMEDGALAL; DataBase=db_FireSales;integrated Security=true;");
            _userRepository = new UserRepository(_db);
            _userService = new UserService(_userRepository);

            _view.OnCreateAccountAttempt = HandleCreateAccount;
        }

        private void HandleCreateAccount(string username, string password, string confirmPassword, bool isActive, UserRole role)
        {
            username = username.Trim();
            password = password.Trim();
            confirmPassword = confirmPassword.Trim();

            // Validation
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password) ||
                string.IsNullOrWhiteSpace(confirmPassword))
            {
                _view.ShowError("All fields are required.");
                return;
            }

            if (password != confirmPassword)
            {
                _view.ShowError("Passwords do not match.");
                return;
            }

            if (username.Length < 3 || username.Length > 20 || password.Length < 3 || password.Length > 20)
            {
                _view.ShowError("Username and password must be 3–20 characters long.");
                return;
            }

            var user = new User
            {
                Username = username,
                Password = password,
                IsActive = isActive,
                Role = role 
            };

            bool created = _userService.CreateUser(user);
            if (created)
            {
                _view.ShowSuccess("User account created successfully.");
            }
            else
            {
                _view.ShowError("Failed to create account. Try again or choose another username.");
            }
        }
    }

}
