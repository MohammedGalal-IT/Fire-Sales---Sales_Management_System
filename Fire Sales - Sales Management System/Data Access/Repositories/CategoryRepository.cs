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
    public class CategoryRepository : ICategoryRepository
    {
        private readonly DatabaseManager _db;

        public CategoryRepository(DatabaseManager db)
        {
            _db = db;
        }

        public int Add(Category entity)
        {
            string query = @"INSERT INTO Category (Name, Description)
                             VALUES (@Name, @Description)";
            var parameters = new Dictionary<string, object>
            {
                { "@Name", entity.Name },
                { "@Description", entity.Description ?? (object)DBNull.Value }
            };

            return _db.ExecuteNonQuery(query, parameters);
        }

        public int Update(Category entity)
        {
            string query = @"UPDATE Category 
                             SET Name = @Name, Description = @Description 
                             WHERE CategoryID = @CategoryID";
            var parameters = new Dictionary<string, object>
            {
                { "@Name", entity.Name },
                { "@Description", entity.Description ?? (object)DBNull.Value },
                { "@CategoryID", entity.CategoryID }
            };

            return _db.ExecuteNonQuery(query, parameters);
        }

        public int Delete(int id)
        {
            string query = "DELETE FROM Category WHERE CategoryID = @CategoryID";
            var parameters = new Dictionary<string, object>
            {
                { "@CategoryID", id }
            };

            return _db.ExecuteNonQuery(query, parameters);
        }

        public Category GetById(int id)
        {
            string query = "SELECT * FROM Category WHERE CategoryID = @CategoryID";
            var parameters = new Dictionary<string, object>
            {
                { "@CategoryID", id }
            };

            var result = _db.ExecuteToList<Category>(query, parameters);
            return result.Count > 0 ? result[0] : null;
        }

        public List<Category> GetAll()
        {
            string query = "SELECT * FROM Category";
            return _db.ExecuteToList<Category>(query);
        }

        public List<Category> SearchByName(string name)
        {
            string query = "SELECT * FROM Category WHERE Name LIKE @Name";
            var parameters = new Dictionary<string, object>
            {
                { "@Name", "%" + name + "%" }
            };

            return _db.ExecuteToList<Category>(query, parameters);
        }

        
        public Category GetByName(string name)
        {
            string query = "SELECT * FROM Category WHERE Name = @Name";
            var parameters = new Dictionary<string, object>
            {
                { "@Name", name }
            };
            var result = _db.ExecuteToList<Category>(query, parameters);
            return result.Count > 0 ? result[0] : null;
        }
}
          }
