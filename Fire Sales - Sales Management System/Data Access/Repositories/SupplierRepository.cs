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
    public class SupplierRepository : ISupplierRepository
    {
        private readonly DatabaseManager _db;

        public SupplierRepository(DatabaseManager db)
        {
            _db = db;
        }

        public List<Supplier> GetAll()
        {
            string query = "SELECT * FROM Supplier";
            return _db.ExecuteToList<Supplier>(query);
        }

        public Supplier GetById(int id)
        {
            string query = "SELECT * FROM Supplier WHERE SupplierID = @SupplierID";
            var parameters = new Dictionary<string, object> { { "@SupplierID", id } };
            var result = _db.ExecuteToList<Supplier>(query, parameters);
            return result.Count > 0 ? result[0] : null;
        }

        public int Add(Supplier supplier)
        {
            string query = @"
                INSERT INTO Supplier (Name, Phone, Email, Address, IsActive)
                VALUES (@Name, @Phone, @Email, @Address, @IsActive)";

            var parameters = new Dictionary<string, object>
            {
                { "@Name", supplier.Name },
                { "@Phone", supplier.Phone },
                { "@Email", supplier.Email },
                { "@Address", supplier.Address },
                { "@IsActive", supplier.IsActive }
            };

            return _db.ExecuteNonQuery(query, parameters);
        }

        public int Update(Supplier supplier)
        {
            string query = @"
                UPDATE Supplier SET 
                    Name = @Name,
                    Phone = @Phone,
                    Email = @Email,
                    Address = @Address,
                    IsActive = @IsActive
                WHERE SupplierID = @SupplierID";

            var parameters = new Dictionary<string, object>
            {
                { "@SupplierID", supplier.SupplierID },
                { "@Name", supplier.Name },
                { "@Phone", supplier.Phone },
                { "@Email", supplier.Email },
                { "@Address", supplier.Address },
                { "@IsActive", supplier.IsActive }
            };

            return _db.ExecuteNonQuery(query, parameters);
        }

        public int Delete(int id)
        {
            string query = "UPDATE Supplier SET IsActive = 0 WHERE SupplierID = @SupplierID";
            var parameters = new Dictionary<string, object> { { "@SupplierID", id } };
            return _db.ExecuteNonQuery(query, parameters);
        }

        //--------

        public List<Supplier> GetActiveSuppliers()
        {
            string query = "SELECT * FROM Supplier WHERE IsActive = 1";
            return _db.ExecuteToList<Supplier>(query);
        }

        public List<Supplier> SearchByName(string name)
        {
            string query = "SELECT * FROM Supplier WHERE Name LIKE @Name";
            var parameters = new Dictionary<string, object>
            {
                { "@Name", "%" + name + "%" }
            };
            return _db.ExecuteToList<Supplier>(query, parameters);
        }
    }
}
