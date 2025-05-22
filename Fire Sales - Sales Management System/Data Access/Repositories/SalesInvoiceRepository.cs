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
    public class SalesInvoiceRepository : ISalesInvoiceRepository
    {
        private readonly DatabaseManager _db;

        public SalesInvoiceRepository(DatabaseManager db)
        {
            _db = db;
        }

        public List<SalesInvoice> GetAll()
        {
            string query = "SELECT * FROM SalesInvoice";
            return _db.ExecuteToList<SalesInvoice>(query);
        }

        public SalesInvoice GetById(int id)
        {
            string query = "SELECT * FROM SalesInvoice WHERE SalesInvoiceID = @ID";
            var parameters = new Dictionary<string, object> { { "@ID", id } };
            var result = _db.ExecuteToList<SalesInvoice>(query, parameters);
            return result.Count > 0 ? result[0] : null;
        }

        public int Add(SalesInvoice invoice)
        {
            string query = @"
                INSERT INTO SalesInvoice (InvoiceNumber, Date, TotalAmount, CreatedBy)
                VALUES (@InvoiceNumber, @Date, @TotalAmount, @CreatedBy)";

            var parameters = new Dictionary<string, object>
            {
                { "@InvoiceNumber", invoice.InvoiceNumber },
                { "@Date", invoice.Date },
                { "@TotalAmount", invoice.TotalAmount },
                { "@CreatedBy", invoice.CreatedBy }
            };

            return _db.ExecuteNonQuery(query, parameters);
        }

        public int Update(SalesInvoice invoice)
        {
            string query = @"
                UPDATE SalesInvoice SET 
                    InvoiceNumber = @InvoiceNumber,
                    Date = @Date,
                    TotalAmount = @TotalAmount,
                    CreatedBy = @CreatedBy
                WHERE SalesInvoiceID = @ID";

            var parameters = new Dictionary<string, object>
            {
                { "@ID", invoice.SalesInvoiceID },
                { "@InvoiceNumber", invoice.InvoiceNumber },
                { "@Date", invoice.Date },
                { "@TotalAmount", invoice.TotalAmount },
                { "@CreatedBy", invoice.CreatedBy }
            };

            return _db.ExecuteNonQuery(query, parameters);
        }

        public int Delete(int id)
        {
            string query = "DELETE FROM SalesInvoice WHERE SalesInvoiceID = @ID";
            var parameters = new Dictionary<string, object> { { "@ID", id } };
            return _db.ExecuteNonQuery(query, parameters);
        }


        //---
        public SalesInvoice GetByInvoiceNumber(string invoiceNumber)
        {
            string query = "SELECT * FROM SalesInvoice WHERE InvoiceNumber = @InvoiceNumber";
            var parameters = new Dictionary<string, object> { { "@InvoiceNumber", invoiceNumber } };
            var result = _db.ExecuteToList<SalesInvoice>(query, parameters);
            return result.Count > 0 ? result[0] : null;
        }

        public List<SalesInvoice> GetByDateRange(DateTime fromDate, DateTime toDate)
        {
            string query = @"
                SELECT * FROM SalesInvoice 
                WHERE Date BETWEEN @FromDate AND @ToDate";

            var parameters = new Dictionary<string, object>
            {
                { "@FromDate", fromDate },
                { "@ToDate", toDate }
            };

            return _db.ExecuteToList<SalesInvoice>(query, parameters);
        }

        public List<SalesInvoice> GetByUserId(int userId)
        {
            string query = "SELECT * FROM SalesInvoice WHERE CreatedBy = @UserId";
            var parameters = new Dictionary<string, object> { { "@UserId", userId } };
            return _db.ExecuteToList<SalesInvoice>(query, parameters);
        }
    }
}
