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
    public class SalesReturnRepository : ISalesReturnRepository
    {
        private readonly DatabaseManager _db;

        public SalesReturnRepository(DatabaseManager db)
        {
            _db = db;
        }

        public List<SalesReturn> GetAll()
        {
            string query = "SELECT * FROM SalesReturn";
            return _db.ExecuteToList<SalesReturn>(query);
        }

        public SalesReturn GetById(int id)
        {
            string query = "SELECT * FROM SalesReturn WHERE SalesReturnID = @ID";
            var parameters = new Dictionary<string, object> { { "@ID", id } };
            var result = _db.ExecuteToList<SalesReturn>(query, parameters);
            return result.Count > 0 ? result[0] : null;
        }

        public int Add(SalesReturn item)
        {
            string query = @"
                INSERT INTO SalesReturn (SalesInvoiceID, Date, TotalRefundAmount, CreatedBy)
                VALUES (@InvoiceID, @Date, @RefundAmount, @CreatedBy)";

            var parameters = new Dictionary<string, object>
            {
                { "@InvoiceID", item.SalesInvoiceID },
                { "@Date", item.Date },
                { "@RefundAmount", item.TotalRefundAmount },
                { "@CreatedBy", item.CreatedBy }
            };

            return _db.ExecuteNonQuery(query, parameters);
        }

        public int Update(SalesReturn item)
        {
            string query = @"
                UPDATE SalesReturn SET
                    SalesInvoiceID = @InvoiceID,
                    Date = @Date,
                    TotalRefundAmount = @RefundAmount,
                    CreatedBy = @CreatedBy
                WHERE SalesReturnID = @ID";

            var parameters = new Dictionary<string, object>
            {
                { "@ID", item.SalesReturnID },
                { "@InvoiceID", item.SalesInvoiceID },
                { "@Date", item.Date },
                { "@RefundAmount", item.TotalRefundAmount },
                { "@CreatedBy", item.CreatedBy }
            };

            return _db.ExecuteNonQuery(query, parameters);
        }

        public int Delete(int id)
        {
            string query = "DELETE FROM SalesReturn WHERE SalesReturnID = @ID";
            var parameters = new Dictionary<string, object> { { "@ID", id } };
            return _db.ExecuteNonQuery(query, parameters);
        }

        //-----

        public List<SalesReturn> GetByInvoiceId(int salesInvoiceId)
        {
            string query = "SELECT * FROM SalesReturn WHERE SalesInvoiceID = @salesInvoiceId";
            var parameters = new Dictionary<string, object> { { "@salesInvoiceId", salesInvoiceId } };
            return _db.ExecuteToList<SalesReturn>(query, parameters);
        }

        public List<SalesReturn> GetByUserId(int userId)
        {
            string query = "SELECT * FROM SalesReturn WHERE CreatedBy = @UserID";
            var parameters = new Dictionary<string, object> { { "@UserID", userId } };
            return _db.ExecuteToList<SalesReturn>(query, parameters);
        }
    }
}
