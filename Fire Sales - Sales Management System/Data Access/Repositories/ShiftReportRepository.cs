using Fire_Sales___Sales_Management_System.Data_Access.Interfaces;
using Fire_Sales___Sales_Management_System.Model;
using Fire_Sales___Sales_Management_System.Helpers.Database_Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fire_Sales___Sales_Management_System.Data_Access.Repositories
{
    public class ShiftReportRepository : IShiftReportRepository
    {
        private readonly DatabaseManager _db;

        public ShiftReportRepository(DatabaseManager db)
        {
            _db = db;
        }

        public List<ShiftReport> GetAll()
        {
            string query = "SELECT * FROM ShiftReport";
            return _db.ExecuteToList<ShiftReport>(query);
        }

        public ShiftReport GetById(int id)
        {
            string query = "SELECT * FROM ShiftReport WHERE ReportID = @ID";
            var parameters = new Dictionary<string, object> { { "@ID", id } };
            var result = _db.ExecuteToList<ShiftReport>(query, parameters);
            return result.Count > 0 ? result[0] : null;
        }

        public bool Add(ShiftReport item)
        {
            string query = @"
                INSERT INTO ShiftReport (Date, TotalSales, TotalReturns, TotalExpenses, NetTotal, Note, CreatedBy)
                VALUES (@Date, @Sales, @Returns, @Expenses, @Net, @Note, @UserID)";

            var parameters = new Dictionary<string, object>
            {
                { "@Date", item.Date },
                { "@Sales", item.TotalSales },
                { "@Returns", item.TotalReturns },
                { "@Expenses", item.TotalExpenses },
                { "@Net", item.NetTotal },
                { "@Note", item.Note },
                { "@UserID", item.CreatedBy }
            };

            return _db.ExecuteNonQuery(query, parameters) > 0;
        }

        public bool Update(ShiftReport item)
        {
            string query = @"
                UPDATE ShiftReport SET
                    Date = @Date,
                    TotalSales = @Sales,
                    TotalReturns = @Returns,
                    TotalExpenses = @Expenses,
                    NetTotal = @Net,
                    Note = @Note,
                    CreatedBy = @UserID
                WHERE ReportID = @ID";

            var parameters = new Dictionary<string, object>
            {
                { "@ID", item.ReportID },
                { "@Date", item.Date },
                { "@Sales", item.TotalSales },
                { "@Returns", item.TotalReturns },
                { "@Expenses", item.TotalExpenses },
                { "@Net", item.NetTotal },
                { "@Note", item.Note },
                { "@UserID", item.CreatedBy }
            };

            return _db.ExecuteNonQuery(query, parameters) > 0;
        }

        public bool Delete(int id)
        {
            string query = "DELETE FROM ShiftReport WHERE ReportID = @ID";
            var parameters = new Dictionary<string, object> { { "@ID", id } };
            return _db.ExecuteNonQuery(query, parameters) > 0;
        }

        public List<ShiftReport> GetByUserId(int userId)
        {
            string query = "SELECT * FROM ShiftReport WHERE CreatedBy = @UserID";
            var parameters = new Dictionary<string, object> { { "@UserID", userId } };
            return _db.ExecuteToList<ShiftReport>(query, parameters);
        }

        public ShiftReport GetByDate(DateTime date)
        {
            string query = "SELECT * FROM ShiftReport WHERE DATE(Date) = DATE(@Date)";
            var parameters = new Dictionary<string, object> { { "@Date", date } };
            var result = _db.ExecuteToList<ShiftReport>(query, parameters);
            return result.Count > 0 ? result[0] : null;
        }

        public List<ShiftReport> GetByDateRange(DateTime start, DateTime end)
        {
            string query = "SELECT * FROM ShiftReport WHERE Date BETWEEN @Start AND @End";
            var parameters = new Dictionary<string, object>
            {
                { "@Start", start },
                { "@End", end }
            };
            return _db.ExecuteToList<ShiftReport>(query, parameters);
        }
    }
}
