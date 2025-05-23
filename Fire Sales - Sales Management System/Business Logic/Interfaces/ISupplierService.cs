using Fire_Sales___Sales_Management_System.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fire_Sales___Sales_Management_System.Business_Logic.Interfaces
{
    public interface ISupplierService
    {
        List<Supplier> GetAllSuppliers();
        Supplier GetSupplierById(int id);
        bool CreateSupplier(Supplier supplier);
        bool UpdateSupplier(Supplier supplier);
        bool DeleteSupplier(int id);

        List<Supplier> GetActiveSuppliers();
        List<Supplier> SearchByName(string name);
    }
}
