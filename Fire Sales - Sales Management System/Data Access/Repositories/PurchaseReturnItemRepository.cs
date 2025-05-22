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
    public class PurchaseReturnItemRepository : IPurchaseReturnItemRepository
    {
        private readonly DatabaseManager _db;

        public PurchaseReturnItemRepository(DatabaseManager db)
        {
            _db = db;
        }

        public List<PurchaseReturnItem> GetAll()
        {
            string query = "SELECT * FROM PurchaseReturnItem";
            return _db.ExecuteToList<PurchaseReturnItem>(query);
        }

        public PurchaseReturnItem GetById(int id)
        {
            string query = "SELECT * FROM PurchaseReturnItem WHERE PurchaseReturnItemID = @ID";
            var parameters = new Dictionary<string, object> { { "@ID", id } };
            var result = _db.ExecuteToList<PurchaseReturnItem>(query, parameters);
            return result.Count > 0 ? result[0] : null;
        }

        public int Add(PurchaseReturnItem item)
        {
            string query = @"
                INSERT INTO PurchaseReturnItem (PurchaseReturnID, ProductID, Quantity, ReturnAmount)
                VALUES (@ReturnID, @ProductID, @Quantity, @Amount)";

            var parameters = new Dictionary<string, object>
            {
                { "@ReturnID", item.PurchaseReturnID },
                { "@ProductID", item.ProductID },
                { "@Quantity", item.Quantity },
                { "@Amount", item.ReturnAmount }
            };

            return _db.ExecuteNonQuery(query, parameters);
        }

        public int Update(PurchaseReturnItem item)
        {
            string query = @"
                UPDATE PurchaseReturnItem SET
                    PurchaseReturnID = @ReturnID,
                    ProductID = @ProductID,
                    Quantity = @Quantity,
                    ReturnAmount = @Amount
                WHERE PurchaseReturnItemID = @ID";

            var parameters = new Dictionary<string, object>
            {
                { "@ID", item.PurchaseReturnItemID },
                { "@ReturnID", item.PurchaseReturnID },
                { "@ProductID", item.ProductID },
                { "@Quantity", item.Quantity },
                { "@Amount", item.ReturnAmount }
            };

            return _db.ExecuteNonQuery(query, parameters);
        }

        public int Delete(int id)
        {
            string query = "DELETE FROM PurchaseReturnItem WHERE PurchaseReturnItemID = @ID";
            var parameters = new Dictionary<string, object> { { "@ID", id } };
            return _db.ExecuteNonQuery(query, parameters);
        }

        public List<PurchaseReturnItem> GetByPurchaseReturnId(int returnId)
        {
            string query = "SELECT * FROM PurchaseReturnItem WHERE PurchaseReturnID = @ReturnID";
            var parameters = new Dictionary<string, object> { { "@ReturnID", returnId } };
            return _db.ExecuteToList<PurchaseReturnItem>(query, parameters);
        }

        public List<PurchaseReturnItem> GetByProductId(int productId)
        {
            string query = "SELECT * FROM PurchaseReturnItem WHERE ProductID = @ProductID";
            var parameters = new Dictionary<string, object> { { "@ProductID", productId } };
            return _db.ExecuteToList<PurchaseReturnItem>(query, parameters);
        }
    }
}
