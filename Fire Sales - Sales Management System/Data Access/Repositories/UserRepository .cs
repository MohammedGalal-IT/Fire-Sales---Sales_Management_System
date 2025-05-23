using Fire_Sales___Sales_Management_System.Data_Access.Interfaces;
using Fire_Sales___Sales_Management_System.Helpers.Database_Helpers;
using Fire_Sales___Sales_Management_System.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fire_Sales___Sales_Management_System.Data_Access.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly DatabaseManager _db;

        public UserRepository(DatabaseManager db)
        {
            _db = db;
        }

        public List<User> GetAll()
        {
            string query = "SELECT * FROM [User]";
            return _db.ExecuteToList<User>(query);
        }

        public User GetById(int id)
        {
            string query = "SELECT * FROM [User] WHERE UserID = @UserID";
            var parameters = new Dictionary<string, object> { { "@UserID", id } };
            var result = _db.ExecuteToList<User>(query, parameters);
            return result.Count > 0 ? result[0] : null;
        }

        public int Add(User user)
        {
            string query = @"
                INSERT INTO [User] (Username, Password, Role, IsActive)
                VALUES (@Username, @Password, @Role, @IsActive)";

            var parameters = new Dictionary<string, object>
            {
                { "@Username", user.Username },
                { "@Password", user.Password },
                { "@Role", user.Role },
                { "@IsActive", user.IsActive }
            };

            return _db.ExecuteNonQuery(query, parameters);
        }

        public int Update(User user)
        {
            string query = @"
                UPDATE [User] SET 
                    Username = @Username,
                    Password = @Password,
                    Role = @Role,
                    IsActive = @IsActive
                WHERE UserID = @UserID";

            var parameters = new Dictionary<string, object>
            {
                { "@UserID", user.UserID },
                { "@Username", user.Username },
                { "@Password", user.Password },
                { "@Role", user.Role },
                { "@IsActive", user.IsActive }
            };

            return _db.ExecuteNonQuery(query, parameters);
        }

        public int Delete(int id)
        {
            string query = "UPDATE [User] SET IsActive = 0 WHERE UserID = @UserID";
            var parameters = new Dictionary<string, object> { { "@UserID", id } };
            return _db.ExecuteNonQuery(query, parameters);
        }


        //-----
        public User GetByUsername(string username)
        {
            string query = "SELECT * FROM [User] WHERE Username = @Username";
            var parameters = new Dictionary<string, object> { { "@Username", username } };
            var result = _db.ExecuteToList<User>(query, parameters);
            return result.Count > 0 ? result[0] : null;
        }

        public List<User> GetActiveUsers()
        {
            string query = "SELECT * FROM [User] WHERE IsActive = 1";
            return _db.ExecuteToList<User>(query);
        }

        public List<User> GetByRole(string role)
        {
            string query = "SELECT * FROM [User] WHERE Role = @Role";
            var parameters = new Dictionary<string, object> { { "@Role", role } };
            return _db.ExecuteToList<User>(query, parameters);
        }

        public User Authenticate(string username, string password)
        {
            string query = "SELECT * FROM User WHERE Username = @Username AND Password = @Password AND IsActive = TRUE";
            var parameters = new Dictionary<string, object>
    {
        { "@Username", username },
        { "@Password", password }
    };
            var result = _db.ExecuteToList<User>(query, parameters);
            return result.Count > 0 ? result[0] : null;
        }
    }
}
