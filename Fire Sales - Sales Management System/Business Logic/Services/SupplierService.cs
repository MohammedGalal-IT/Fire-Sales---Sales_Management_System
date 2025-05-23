using Fire_Sales___Sales_Management_System.Business_Logic.Interfaces;
using Fire_Sales___Sales_Management_System.Data_Access.Interfaces;
using Fire_Sales___Sales_Management_System.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fire_Sales___Sales_Management_System.Business_Logic.Services
{
    public class SupplierService : ISupplierService
    {
        private readonly ISupplierRepository _supplierRepository;

        public SupplierService(ISupplierRepository supplierRepository)
        {
            _supplierRepository = supplierRepository;
        }

        public List<Supplier> GetAllSuppliers()
        {
            return _supplierRepository.GetAll();
        }

        public Supplier GetSupplierById(int id)
        {
            return _supplierRepository.GetById(id);
        }

        public bool CreateSupplier(Supplier supplier)
        {
            return _supplierRepository.Add(supplier) > 0;
        }

        public bool UpdateSupplier(Supplier supplier)
        {
            return _supplierRepository.Update(supplier) > 0;
        }

        public bool DeleteSupplier(int id)
        {
            return _supplierRepository.Delete(id) > 0;
        }

        public List<Supplier> GetActiveSuppliers()
        {
            return _supplierRepository.GetActiveSuppliers();
        }

        public List<Supplier> SearchByName(string name)
        {
            return _supplierRepository.SearchByName(name);
        }
    }
}
