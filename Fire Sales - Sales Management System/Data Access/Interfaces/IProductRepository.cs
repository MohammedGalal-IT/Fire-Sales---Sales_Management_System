using Fire_Sales___Sales_Management_System.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fire_Sales___Sales_Management_System.Data_Access.Interfaces
{
    public interface IProductRepository : IRepository<Product>
    {
        List<Product> GetActiveProducts();
        List<Product> SearchByName(string name);
        Product GetByBarcode(string barcode);
        List<Product> GetByCategoryId(int categoryId);
    }
}
