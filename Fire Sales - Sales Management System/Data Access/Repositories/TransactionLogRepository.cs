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
    public class TransactionLogRepository : ITransactionLogRepository
    {
        private readonly DatabaseManager _db;

        public TransactionLogRepository(DatabaseManager db)
        {
            _db = db;
        }

        public List<TransactionLog> GetAll()
        {
            string query = "SELECT * FROM TransactionLog";
            return _db.ExecuteToList<TransactionLog>(query);
        }

        public TransactionLog GetById(int id)
        {
            string query = "SELECT * FROM TransactionLog WHERE TransactionLogID = @ID";
            var parameters = new Dictionary<string, object> { { "@ID", id } };
            var result = _db.ExecuteToList<TransactionLog>(query, parameters);
            return result.Count > 0 ? result[0] : null;
        }

        public int Add(TransactionLog item)
        {
            string query = @"
                INSERT INTO TransactionLog (TransactionType, ReferenceID, Amount, Date, CreatedBy, Note)
                VALUES (@Type, @ReferenceID, @Amount, @Date, @UserID, @Note)";

            var parameters = new Dictionary<string, object>
            {
                { "@Type", item.TransactionType },
                { "@ReferenceID", item.ReferenceID },
                { "@Amount", item.Amount },
                { "@Date", item.Date },
                { "@UserID", item.CreatedBy },
                { "@Note", item.Note }
            };

            return _db.ExecuteNonQuery(query, parameters);
        }

        public int Update(TransactionLog item)
        {
            string query = @"
                UPDATE TransactionLog SET
                    TransactionType = @Type,
                    ReferenceID = @ReferenceID,
                    Amount = @Amount,
                    Date = @Date,
                    CreatedBy = @UserID,
                    Note = @Note
                WHERE TransactionLogID = @ID";

            var parameters = new Dictionary<string, object>
            {
                { "@ID", item.TransactionLogID },
                { "@Type", item.TransactionType },
                { "@ReferenceID", item.ReferenceID },
                { "@Amount", item.Amount },
                { "@Date", item.Date },
                { "@UserID", item.CreatedBy },
                { "@Note", item.Note }
            };

            return _db.ExecuteNonQuery(query, parameters);
        }

        public int Delete(int id)
        {
            string query = "DELETE FROM TransactionLog WHERE TransactionLogID = @ID";
            var parameters = new Dictionary<string, object> { { "@ID", id } };
            return _db.ExecuteNonQuery(query, parameters);
        }

        //------

        public List<TransactionLog> GetByUserId(int userId)
        {
            string query = "SELECT * FROM TransactionLog WHERE CreatedBy = @UserID";
            var parameters = new Dictionary<string, object> { { "@UserID", userId } };
            return _db.ExecuteToList<TransactionLog>(query, parameters);
        }

        public List<TransactionLog> GetByDateRange(DateTime start, DateTime end)
        {
            string query = "SELECT * FROM TransactionLog WHERE Date BETWEEN @Start AND @End";
            var parameters = new Dictionary<string, object>
            {
                { "@Start", start },
                { "@End", end }
            };
            return _db.ExecuteToList<TransactionLog>(query, parameters);
        }

        public List<TransactionLog> GetByType(string type)
        {
            string query = "SELECT * FROM TransactionLog WHERE TransactionType = @Type";
            var parameters = new Dictionary<string, object> { { "@Type", type } };
            return _db.ExecuteToList<TransactionLog>(query, parameters);
        }
    }
}
