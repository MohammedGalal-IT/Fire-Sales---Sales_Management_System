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
    public class PurchaseItemRepository : IPurchaseItemRepository
    {
        private readonly DatabaseManager _db;

        public PurchaseItemRepository(DatabaseManager db)
        {
            _db = db;
        }

        public List<PurchaseItem> GetAll()
        {
            string query = "SELECT * FROM PurchaseItem";
            return _db.ExecuteToList<PurchaseItem>(query);
        }

        public PurchaseItem GetById(int id)
        {
            string query = "SELECT * FROM PurchaseItem WHERE PurchaseItemID = @ID";
            var parameters = new Dictionary<string, object> { { "@ID", id } };
            var result = _db.ExecuteToList<PurchaseItem>(query, parameters);
            return result.Count > 0 ? result[0] : null;
        }

        public int Add(PurchaseItem item)
        {
            string query = @"
                INSERT INTO PurchaseItem (PurchaseInvoiceID, ProductID, Quantity, UnitPrice)
                VALUES (@PurchaseInvoiceID, @ProductID, @Quantity, @UnitPrice)";

            var parameters = new Dictionary<string, object>
            {
                { "@PurchaseInvoiceID", item.PurchaseInvoiceID },
                { "@ProductID", item.ProductID },
                { "@Quantity", item.Quantity },
                { "@UnitPrice", item.UnitPrice }
            };

            return _db.ExecuteNonQuery(query, parameters);
        }

        public int Update(PurchaseItem item)
        {
            string query = @"
                UPDATE PurchaseItem SET 
                    PurchaseInvoiceID = @PurchaseInvoiceID,
                    ProductID = @ProductID,
                    Quantity = @Quantity,
                    UnitPrice = @UnitPrice
                WHERE PurchaseItemID = @ID";

            var parameters = new Dictionary<string, object>
            {
                { "@ID", item.PurchaseItemID },
                { "@PurchaseInvoiceID", item.PurchaseInvoiceID },
                { "@ProductID", item.ProductID },
                { "@Quantity", item.Quantity },
                { "@UnitPrice", item.UnitPrice }
            };

            return _db.ExecuteNonQuery(query, parameters);
        }

        public int Delete(int id)
        {
            string query = "DELETE FROM PurchaseItem WHERE PurchaseItemID = @ID";
            var parameters = new Dictionary<string, object> { { "@ID", id } };
            return _db.ExecuteNonQuery(query, parameters);
        }

        //------
        public List<PurchaseItem> GetByInvoiceId(int purchaseInvoiceId)
        {
            string query = "SELECT * FROM PurchaseItem WHERE PurchaseInvoiceID = @PurchaseInvoiceID";
            var parameters = new Dictionary<string, object> { { "@PurchaseInvoiceID", purchaseInvoiceId } };
            return _db.ExecuteToList<PurchaseItem>(query, parameters);
        }

        public List<PurchaseItem> GetByProductId(int productId)
        {
            string query = "SELECT * FROM PurchaseItem WHERE ProductID = @ProductID";
            var parameters = new Dictionary<string, object> { { "@ProductID", productId } };
            return _db.ExecuteToList<PurchaseItem>(query, parameters);
        }
    }
}
