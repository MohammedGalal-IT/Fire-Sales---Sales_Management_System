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
    public class ProductRepository : IProductRepository
    {
        private readonly DatabaseManager _db;

        public ProductRepository(DatabaseManager db)
        {
            _db = db;
        }

        public List<Product> GetAll()
        {
            string query = "SELECT * FROM Product";
            return _db.ExecuteToList<Product>(query);
        }

        public Product GetById(int id)
        {
            string query = "SELECT * FROM Product WHERE ProductID = @ProductID";
            var parameters = new Dictionary<string, object> { { "@ProductID", id } };
            var result = _db.ExecuteToList<Product>(query, parameters);
            return result.Count > 0 ? result[0] : null;
        }

        public int Add(Product product)
        {
            string query = @"
                INSERT INTO Product (Name, Barcode, CategoryID, CostPrice, SellingPrice, StockQuantity, Unit, IsActive)
                VALUES (@Name, @Barcode, @CategoryID, @CostPrice, @SellingPrice, @StockQuantity, @Unit, @IsActive)";

            var parameters = new Dictionary<string, object>
            {
                { "@Name", product.Name },
                { "@Barcode", product.Barcode },
                { "@CategoryID", product.CategoryID },
                { "@CostPrice", product.CostPrice },
                { "@SellingPrice", product.SellingPrice },
                { "@StockQuantity", product.StockQuantity },
                { "@Unit", product.Unit },
                { "@IsActive", product.IsActive }
            };

            return _db.ExecuteNonQuery(query, parameters);
        }

        public int Update(Product product)
        {
            string query = @"
                UPDATE Product SET 
                    Name = @Name,
                    Barcode = @Barcode,
                    CategoryID = @CategoryID,
                    CostPrice = @CostPrice,
                    SellingPrice = @SellingPrice,
                    StockQuantity = @StockQuantity,
                    Unit = @Unit,
                    IsActive = @IsActive
                WHERE ProductID = @ProductID";

            var parameters = new Dictionary<string, object>
            {
                { "@ProductID", product.ProductID },
                { "@Name", product.Name },
                { "@Barcode", product.Barcode },
                { "@CategoryID", product.CategoryID },
                { "@CostPrice", product.CostPrice },
                { "@SellingPrice", product.SellingPrice },
                { "@StockQuantity", product.StockQuantity },
                { "@Unit", product.Unit },
                { "@IsActive", product.IsActive }
            };

            return _db.ExecuteNonQuery(query, parameters);
        }

        public int Delete(int id)
        {
            string query = "UPDATE Product SET IsActive = 0 WHERE ProductID = @ProductID";
            var parameters = new Dictionary<string, object> { { "@ProductID", id } };
            return _db.ExecuteNonQuery(query, parameters);
        }

        // Mohammed Galal: The Addtional Functions

        public List<Product> GetActiveProducts()
        {
            string query = "SELECT * FROM Product WHERE IsActive = 1";
            return _db.ExecuteToList<Product>(query);
        }

        public List<Product> SearchByName(string name)
        {
            string query = "SELECT * FROM Product WHERE Name LIKE @Name";
            var parameters = new Dictionary<string, object>
            {
                { "@Name", "%" + name + "%" }
            };
            return _db.ExecuteToList<Product>(query, parameters);
        }

        public Product GetByBarcode(string barcode)
        {
            string query = "SELECT * FROM Product WHERE Barcode = @Barcode";
            var parameters = new Dictionary<string, object>
            {
                { "@Barcode", barcode }
            };
            var result = _db.ExecuteToList<Product>(query, parameters);
            return result.Count > 0 ? result[0] : null;
        }

        public List<Product> GetByCategoryId(int categoryId)
        {
            string query = "SELECT * FROM Product WHERE CategoryID = @CategoryID";
            var parameters = new Dictionary<string, object>
            {
                { "@CategoryID", categoryId }
            };
            return _db.ExecuteToList<Product>(query, parameters);
        }
    }
}
