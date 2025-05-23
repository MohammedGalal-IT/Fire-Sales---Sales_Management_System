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
    public class PurchaseService : IPurchaseService
    {
        private readonly IPurchaseInvoiceRepository _invoiceRepository;
        private readonly IPurchaseItemRepository _itemRepository;

        public PurchaseService(
            IPurchaseInvoiceRepository invoiceRepository,
            IPurchaseItemRepository itemRepository)
        {
            _invoiceRepository = invoiceRepository;
            _itemRepository = itemRepository;
        }

        // PurchaseInvoice Methods
        public List<PurchaseInvoice> GetAllInvoices()
        {
            return _invoiceRepository.GetAll();
        }

        public PurchaseInvoice GetInvoiceById(int id)
        {
            return _invoiceRepository.GetById(id);
        }

        public bool CreateInvoice(PurchaseInvoice invoice)
        {
            return _invoiceRepository.Add(invoice) > 0;
        }

        public bool UpdateInvoice(PurchaseInvoice invoice)
        {
            return _invoiceRepository.Update(invoice) > 0;
        }

        public bool DeleteInvoice(int id)
        {
            return _invoiceRepository.Delete(id) > 0;
        }

        public List<PurchaseInvoice> GetInvoicesBySupplierId(int supplierId)
        {
            return _invoiceRepository.GetBySupplierId(supplierId);
        }

        public List<PurchaseInvoice> GetInvoicesByUserId(int userId)
        {
            return _invoiceRepository.GetByUserId(userId);
        }

        public List<PurchaseInvoice> GetInvoicesByDateRange(DateTime start, DateTime end)
        {
            return _invoiceRepository.GetByDateRange(start, end);
        }

        // PurchaseItem Methods
        public List<PurchaseItem> GetItemsByInvoiceId(int invoiceId)
        {
            return _itemRepository.GetByInvoiceId(invoiceId);
        }

        public List<PurchaseItem> GetItemsByProductId(int productId)
        {
            return _itemRepository.GetByProductId(productId);
        }

        public bool AddPurchaseItem(PurchaseItem item)
        {
            return _itemRepository.Add(item);
        }

        public bool UpdatePurchaseItem(PurchaseItem item)
        {
            return _itemRepository.Update(item);
        }

        public bool DeletePurchaseItem(int itemId)
        {
            return _itemRepository.Delete(itemId);
        }
    }
}
