using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fire_Sales___Sales_Management_System.Business_Logic.Interfaces;
using Fire_Sales___Sales_Management_System.Business_Logic.Services;
using System.Web.UI.WebControls;
using Fire_Sales___Sales_Management_System.Presentation.Views;
using Fire_Sales___Sales_Management_System.Helpers.Database_Helpers;
using Fire_Sales___Sales_Management_System.Data_Access.Interfaces;
using Fire_Sales___Sales_Management_System.Data_Access.Repositories;
using Fire_Sales___Sales_Management_System.Model;   
using System.Threading;
using Fire_Sales___Sales_Management_System.Presentation.Views;
using Fire_Sales___Sales_Management_System.Presentation.Views;

namespace Fire_Sales___Sales_Management_System.Business_Logic.Controllers
{
    public class LoginController
    {
        private DatabaseManager _databaseManager;
        private readonly IUserService _userService;
        private readonly IUserRepository _userRepository;
        private readonly signinForm _view;

        

        public LoginController(signinForm view)
        {
            _view = view;
            _databaseManager = new DatabaseManager(@"Data Source=DESKTOP-KL322NI\MOHAMMEDGALAL; DataBase=db_FireSales;integrated Security=true;");
            _userRepository = new UserRepository(_databaseManager);
            _userService = new UserService(_userRepository);

            _view.OnLoginAttempt = HandleLogin;
        }

        private void HandleLogin(string username, string password)
        {
            username = username.Trim();
            password = password.Trim();

            // Validate inputs
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                _view.ShowError("Please enter both username and password");
                return;
            }

            if (username.Length < 3 || password.Length < 3)
            {
                _view.ShowError("Username and password must be at least 3 characters long.");
                return;
            }

            if (username.Length > 20 || password.Length > 20)
            {
                _view.ShowError("Username and password must be less than 20 characters long.");
                return;
            }

            var user = _userService.Authenticate(username, password);
            if (user != null)
            {
                if (!user.IsActive)
                {
                    _view.ShowError("This account is inactive.");
                    return;
                }

                _view.LoginSuccess($"Welcome {user.Username}, login Successfully");
                //this._view.user = user;
                new MainView2(user).Show();
                this._view.Hide(); 
            }
            else
            {
                _view.ShowError("Invalid username or password.");
            }
        }
    }
}
