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
    public class SalesReturnItemRepository : ISalesReturnItemRepository
    {
        private readonly DatabaseManager _db;

        public SalesReturnItemRepository(DatabaseManager db)
        {
            _db = db;
        }

        public List<SalesReturnItem> GetAll()
        {
            string query = "SELECT * FROM SalesReturnItem";
            return _db.ExecuteToList<SalesReturnItem>(query);
        }

        public SalesReturnItem GetById(int id)
        {
            string query = "SELECT * FROM SalesReturnItem WHERE SalesReturnItemID = @ID";
            var parameters = new Dictionary<string, object> { { "@ID", id } };
            var result = _db.ExecuteToList<SalesReturnItem>(query, parameters);
            return result.Count > 0 ? result[0] : null;
        }

        public int Add(SalesReturnItem item)
        {
            string query = @"
                INSERT INTO SalesReturnItem (SalesReturnID, ProductID, Quantity, RefundAmount)
                VALUES (@ReturnID, @ProductID, @Qty, @Refund)";

            var parameters = new Dictionary<string, object>
            {
                { "@ReturnID", item.SalesReturnID },
                { "@ProductID", item.ProductID },
                { "@Qty", item.Quantity },
                { "@Refund", item.RefundAmount }
            };

            return _db.ExecuteNonQuery(query, parameters);
        }

        public int Update(SalesReturnItem item)
        {
            string query = @"
                UPDATE SalesReturnItem SET
                    SalesReturnID = @ReturnID,
                    ProductID = @ProductID,
                    Quantity = @Qty,
                    RefundAmount = @Refund
                WHERE SalesReturnItemID = @ID";

            var parameters = new Dictionary<string, object>
            {
                { "@ID", item.SalesReturnItemID },
                { "@ReturnID", item.SalesReturnID },
                { "@ProductID", item.ProductID },
                { "@Qty", item.Quantity },
                { "@Refund", item.RefundAmount }
            };

            return _db.ExecuteNonQuery(query, parameters);
        }

        public int Delete(int id)
        {
            string query = "DELETE FROM SalesReturnItem WHERE SalesReturnItemID = @ID";
            var parameters = new Dictionary<string, object> { { "@ID", id } };
            return _db.ExecuteNonQuery(query, parameters);
        }


        //---
        public List<SalesReturnItem> GetBySalesReturnId(int salesReturnId)
        {
            string query = "SELECT * FROM SalesReturnItem WHERE SalesReturnID = @ReturnID";
            var parameters = new Dictionary<string, object> { { "@ReturnID", salesReturnId } };
            return _db.ExecuteToList<SalesReturnItem>(query, parameters);
        }

        public List<SalesReturnItem> GetByProductId(int productId)
        {
            string query = "SELECT * FROM SalesReturnItem WHERE ProductID = @ProductID";
            var parameters = new Dictionary<string, object> { { "@ProductID", productId } };
            return _db.ExecuteToList<SalesReturnItem>(query, parameters);
        }
    }
}
