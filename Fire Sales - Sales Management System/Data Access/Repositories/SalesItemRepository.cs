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
    public class SalesItemRepository : ISalesItemRepository
    {
        private readonly DatabaseManager _db;

        public SalesItemRepository(DatabaseManager db)
        {
            _db = db;
        }

        public List<SalesItem> GetAll()
        {
            string query = "SELECT * FROM SalesItem";
            return _db.ExecuteToList<SalesItem>(query);
        }

        public SalesItem GetById(int id)
        {
            string query = "SELECT * FROM SalesItem WHERE SalesItemID = @ID";
            var parameters = new Dictionary<string, object> { { "@ID", id } };
            var result = _db.ExecuteToList<SalesItem>(query, parameters);
            return result.Count > 0 ? result[0] : null;
        }

        public int Add(SalesItem item)
        {
            string query = @"
                INSERT INTO SalesItem (SalesInvoiceID, ProductID, Quantity, CostPrice, Discount)
                VALUES (@InvoiceID, @ProductID, @Quantity, @CostPrice, @Discount)";

            var parameters = new Dictionary<string, object>
            {
                { "@InvoiceID", item.SalesInvoiceID },
                { "@ProductID", item.ProductID },
                { "@Quantity", item.Quantity },
                { "@CostPrice", item.CostPrice },
                { "@Discount", item.Discount }
            };

            return _db.ExecuteNonQuery(query, parameters);
        }

        public int Update(SalesItem item)
        {
            string query = @"
                UPDATE SalesItem SET
                    SalesInvoiceID = @InvoiceID,
                    ProductID = @ProductID,
                    Quantity = @Quantity,
                    CostPrice = @CostPrice,
                    Discount = @Discount
                WHERE SalesItemID = @ID";

            var parameters = new Dictionary<string, object>
            {
                { "@ID", item.SalesItemID },
                { "@InvoiceID", item.SalesInvoiceID },
                { "@ProductID", item.ProductID },
                { "@Quantity", item.Quantity },
                { "@CostPrice", item.CostPrice },
                { "@Discount", item.Discount }
            };

            return _db.ExecuteNonQuery(query, parameters);
        }

        public int Delete(int id)
        {
            string query = "DELETE FROM SalesItem WHERE SalesItemID = @ID";
            var parameters = new Dictionary<string, object> { { "@ID", id } };
            return _db.ExecuteNonQuery(query, parameters);
        }

        //-----

        public List<SalesItem> GetByInvoiceId(int invoiceId)
        {
            string query = "SELECT * FROM SalesItem WHERE SalesInvoiceID = @InvoiceID";
            var parameters = new Dictionary<string, object> { { "@InvoiceID", invoiceId } };
            return _db.ExecuteToList<SalesItem>(query, parameters);
        }

        public List<SalesItem> GetByProductId(int productId)
        {
            string query = "SELECT * FROM SalesItem WHERE ProductID = @ProductID";
            var parameters = new Dictionary<string, object> { { "@ProductID", productId } };
            return _db.ExecuteToList<SalesItem>(query, parameters);
        }
    }
}
