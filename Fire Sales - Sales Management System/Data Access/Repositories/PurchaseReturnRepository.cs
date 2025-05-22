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
    public class PurchaseReturnRepository : IPurchaseReturnRepository
    {
        private readonly DatabaseManager _db;

        public PurchaseReturnRepository(DatabaseManager db)
        {
            _db = db;
        }

        public List<PurchaseReturn> GetAll()
        {
            string query = "SELECT * FROM PurchaseReturn";
            return _db.ExecuteToList<PurchaseReturn>(query);
        }

        public PurchaseReturn GetById(int id)
        {
            string query = "SELECT * FROM PurchaseReturn WHERE PurchaseReturnID = @ID";
            var parameters = new Dictionary<string, object> { { "@ID", id } };
            var result = _db.ExecuteToList<PurchaseReturn>(query, parameters);
            return result.Count > 0 ? result[0] : null;
        }

        public int Add(PurchaseReturn item)
        {
            string query = @"
                INSERT INTO PurchaseReturn (PurchaseInvoiceID, Date, TotalReturnAmount, CreatedBy)
                VALUES (@InvoiceID, @Date, @Amount, @UserID)";

            var parameters = new Dictionary<string, object>
            {
                { "@InvoiceID", item.PurchaseInvoiceID },
                { "@Date", item.Date },
                { "@Amount", item.TotalReturnAmount },
                { "@UserID", item.CreatedBy }
            };

            return _db.ExecuteNonQuery(query, parameters);
        }

        public int Update(PurchaseReturn item)
        {
            string query = @"
                UPDATE PurchaseReturn SET
                    PurchaseInvoiceID = @InvoiceID,
                    Date = @Date,
                    TotalReturnAmount = @Amount,
                    CreatedBy = @UserID
                WHERE PurchaseReturnID = @ID";

            var parameters = new Dictionary<string, object>
            {
                { "@ID", item.PurchaseReturnID },
                { "@InvoiceID", item.PurchaseInvoiceID },
                { "@Date", item.Date },
                { "@Amount", item.TotalReturnAmount },
                { "@UserID", item.CreatedBy }
            };

            return _db.ExecuteNonQuery(query, parameters);
        }

        public int Delete(int id)
        {
            string query = "DELETE FROM PurchaseReturn WHERE PurchaseReturnID = @ID";
            var parameters = new Dictionary<string, object> { { "@ID", id } };
            return _db.ExecuteNonQuery(query, parameters);
        }

        //---

        public List<PurchaseReturn> GetByInvoiceId(int invoiceId)
        {
            string query = "SELECT * FROM PurchaseReturn WHERE PurchaseInvoiceID = @InvoiceID";
            var parameters = new Dictionary<string, object>
    {
        { "@InvoiceID", invoiceId }
    };
            return _db.ExecuteToList<PurchaseReturn>(query, parameters);
        }


        public List<PurchaseReturn> GetBySupplierId(int supplierId)
        {
            string query = @"
                SELECT pr.*
                FROM PurchaseReturn pr
                JOIN PurchaseInvoice pi ON pr.PurchaseInvoiceID = pi.PurchaseInvoiceID
                WHERE pi.SupplierID = @SupplierID";

            var parameters = new Dictionary<string, object> { { "@SupplierID", supplierId } };
            return _db.ExecuteToList<PurchaseReturn>(query, parameters);
        }

        public List<PurchaseReturn> GetByUserId(int userId)
        {
            string query = "SELECT * FROM PurchaseReturn WHERE CreatedBy = @UserID";
            var parameters = new Dictionary<string, object> { { "@UserID", userId } };
            return _db.ExecuteToList<PurchaseReturn>(query, parameters);
        }

        public List<PurchaseReturn> GetByDateRange(DateTime start, DateTime end)
        {
            string query = "SELECT * FROM PurchaseReturn WHERE Date BETWEEN @Start AND @End";
            var parameters = new Dictionary<string, object>
            {
                { "@Start", start },
                { "@End", end }
            };
            return _db.ExecuteToList<PurchaseReturn>(query, parameters);
        }
    }
}
