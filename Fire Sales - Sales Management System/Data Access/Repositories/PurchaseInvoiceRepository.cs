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
    public class PurchaseInvoiceRepository : IPurchaseInvoiceRepository
    {
        private readonly DatabaseManager _db;

        public PurchaseInvoiceRepository(DatabaseManager db)
        {
            _db = db;
        }

        public List<PurchaseInvoice> GetAll()
        {
            string query = "SELECT * FROM PurchaseInvoice";
            return _db.ExecuteToList<PurchaseInvoice>(query);
        }

        public PurchaseInvoice GetById(int id)
        {
            string query = "SELECT * FROM PurchaseInvoice WHERE PurchaseInvoiceID = @ID";
            var parameters = new Dictionary<string, object> { { "@ID", id } };
            var result = _db.ExecuteToList<PurchaseInvoice>(query, parameters);
            return result.Count > 0 ? result[0] : null;
        }

        public int Add(PurchaseInvoice invoice)
        {
            string query = @"
                INSERT INTO PurchaseInvoice (InvoiceNumber, SupplierID, Date, TotalAmount, CreatedBy)
                VALUES (@InvoiceNumber, @SupplierID, @Date, @TotalAmount, @CreatedBy)";

            var parameters = new Dictionary<string, object>
            {
                { "@InvoiceNumber", invoice.InvoiceNumber },
                { "@SupplierID", invoice.SupplierID },
                { "@Date", invoice.Date },
                { "@TotalAmount", invoice.TotalAmount },
                { "@CreatedBy", invoice.CreatedBy }
            };

            return _db.ExecuteNonQuery(query, parameters);
        }

        public int Update(PurchaseInvoice invoice)
        {
            string query = @"
                UPDATE PurchaseInvoice SET 
                    InvoiceNumber = @InvoiceNumber,
                    SupplierID = @SupplierID,
                    Date = @Date,
                    TotalAmount = @TotalAmount,
                    CreatedBy = @CreatedBy
                WHERE PurchaseInvoiceID = @ID";

            var parameters = new Dictionary<string, object>
            {
                { "@ID", invoice.PurchaseInvoiceID },
                { "@InvoiceNumber", invoice.InvoiceNumber },
                { "@SupplierID", invoice.SupplierID },
                { "@Date", invoice.Date },
                { "@TotalAmount", invoice.TotalAmount },
                { "@CreatedBy", invoice.CreatedBy }
            };

            return _db.ExecuteNonQuery(query, parameters);
        }

        public int Delete(int id)
        {
            string query = "DELETE FROM PurchaseInvoice WHERE PurchaseInvoiceID = @ID";
            var parameters = new Dictionary<string, object> { { "@ID", id } };
            return _db.ExecuteNonQuery(query, parameters);
        }
         

        //-----------------
        public PurchaseInvoice GetByInvoiceNumber(string invoiceNumber)
        {
            string query = "SELECT * FROM PurchaseInvoice WHERE InvoiceNumber = @InvoiceNumber";
            var parameters = new Dictionary<string, object> { { "@InvoiceNumber", invoiceNumber } };
            var result = _db.ExecuteToList<PurchaseInvoice>(query, parameters);
            return result.Count > 0 ? result[0] : null;
        }

        public List<PurchaseInvoice> GetBySupplierId(int supplierId)
        {
            string query = "SELECT * FROM PurchaseInvoice WHERE SupplierID = @SupplierID";
            var parameters = new Dictionary<string, object> { { "@SupplierID", supplierId } };
            return _db.ExecuteToList<PurchaseInvoice>(query, parameters);
        }

        public List<PurchaseInvoice> GetByDateRange(DateTime startDate, DateTime endDate)
        {
            string query = @"
                SELECT * FROM PurchaseInvoice 
                WHERE Date BETWEEN @StartDate AND @EndDate";

            var parameters = new Dictionary<string, object>
            {
                { "@StartDate", startDate },
                { "@EndDate", endDate }
            };

            return _db.ExecuteToList<PurchaseInvoice>(query, parameters);
        }
    }
}
