using Fire_Sales___Sales_Management_System.Business_Logic.Interfaces;
using Fire_Sales___Sales_Management_System.Data_Access.Interfaces;
using Fire_Sales___Sales_Management_System.Data_Access.Repositories;
using Fire_Sales___Sales_Management_System.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fire_Sales___Sales_Management_System.Business_Logic.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public List<User> GetAllUsers()
        {
            return _userRepository.GetAll();
        }

        public User GetUserById(int id)
        {
            return _userRepository.GetById(id);
        }

        public bool CreateUser(User user)
        {
            return _userRepository.Add(user) > 0;
        }

        public bool UpdateUser(User user)
        {
            return _userRepository.Update(user) > 0;
        }

        public bool DeleteUser(int id)
        {
            return _userRepository.Delete(id) > 0;
        }

        public User Authenticate(string username, string password)
        {
            return _userRepository.Authenticate(username, password);
        }

        public List<User> GetActiveUsers()
        {
            return _userRepository.GetActiveUsers();
        }

        
        public User GetByUsername(string username)
        {
            return _userRepository.GetByUsername(username);
        }
    }
}
