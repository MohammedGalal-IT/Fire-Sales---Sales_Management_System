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
    public class ExpenseRepository : IExpenseRepository
    {
        private readonly DatabaseManager _db;

        public ExpenseRepository(DatabaseManager db)
        {
            _db = db;
        }

        public List<Expense> GetAll()
        {
            string query = "SELECT * FROM Expense";
            return _db.ExecuteToList<Expense>(query);
        }

        public Expense GetById(int id)
        {
            string query = "SELECT * FROM Expense WHERE ExpenseID = @ID";
            var parameters = new Dictionary<string, object> { { "@ID", id } };
            var result = _db.ExecuteToList<Expense>(query, parameters);
            return result.Count > 0 ? result[0] : null;
        }

        public int Add(Expense item)
        {
            string query = @"
                INSERT INTO Expense (Description, Amount, Date, ExpenseType, CreatedBy)
                VALUES (@Description, @Amount, @Date, @Type, @UserID)";

            var parameters = new Dictionary<string, object>
            {
                { "@Description", item.Description },
                { "@Amount", item.Amount },
                { "@Date", item.Date },
                { "@Type", item.ExpenseType },
                { "@UserID", item.CreatedBy }
            };

            return _db.ExecuteNonQuery(query, parameters);
        }

        public int Update(Expense item)
        {
            string query = @"
                UPDATE Expense SET
                    Description = @Description,
                    Amount = @Amount,
                    Date = @Date,
                    ExpenseType = @Type,
                    CreatedBy = @UserID
                WHERE ExpenseID = @ID";

            var parameters = new Dictionary<string, object>
            {
                { "@ID", item.ExpenseID },
                { "@Description", item.Description },
                { "@Amount", item.Amount },
                { "@Date", item.Date },
                { "@Type", item.ExpenseType },
                { "@UserID", item.CreatedBy }
            };

            return _db.ExecuteNonQuery(query, parameters);
        }

        public int Delete(int id)
        {
            string query = "DELETE FROM Expense WHERE ExpenseID = @ID";
            var parameters = new Dictionary<string, object> { { "@ID", id } };
            return _db.ExecuteNonQuery(query, parameters);
        }


        //-------------

        public List<Expense> GetByUserId(int userId)
        {
            string query = "SELECT * FROM Expense WHERE CreatedBy = @UserID";
            var parameters = new Dictionary<string, object> { { "@UserID", userId } };
            return _db.ExecuteToList<Expense>(query, parameters);
        }

        public List<Expense> GetByDateRange(DateTime start, DateTime end)
        {
            string query = "SELECT * FROM Expense WHERE Date BETWEEN @Start AND @End";
            var parameters = new Dictionary<string, object>
            {
                { "@Start", start },
                { "@End", end }
            };
            return _db.ExecuteToList<Expense>(query, parameters);
        }

        public List<Expense> GetByType(string type)
        {
            string query = "SELECT * FROM Expense WHERE ExpenseType = @Type";
            var parameters = new Dictionary<string, object> { { "@Type", type } };
            return _db.ExecuteToList<Expense>(query, parameters);
        }
    }
}
