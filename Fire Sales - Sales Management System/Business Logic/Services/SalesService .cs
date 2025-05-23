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
    public class SalesService : ISalesService
    {
        private readonly ISalesInvoiceRepository _invoiceRepository;
        private readonly ISalesItemRepository _itemRepository;

        public SalesService(ISalesInvoiceRepository invoiceRepository, ISalesItemRepository itemRepository)
        {
            _invoiceRepository = invoiceRepository;
            _itemRepository = itemRepository;
        }

        // SalesInvoice Methods
        public List<SalesInvoice> GetAllInvoices()
            => _invoiceRepository.GetAll();

        public SalesInvoice GetInvoiceById(int id)
            => _invoiceRepository.GetById(id);

        public SalesInvoice GetByInvoiceNumber(string invoiceNumber)
            => _invoiceRepository.GetByInvoiceNumber(invoiceNumber);

        public List<SalesInvoice> GetInvoicesByUserId(int userId)
            => _invoiceRepository.GetByUserId(userId);

        public List<SalesInvoice> GetInvoicesByDateRange(DateTime start, DateTime end)
            => _invoiceRepository.GetByDateRange(start, end);

        public bool CreateInvoice(SalesInvoice invoice)
            => _invoiceRepository.Add(invoice) > 0;

        public bool UpdateInvoice(SalesInvoice invoice)
            => _invoiceRepository.Update(invoice) > 0;

        public bool DeleteInvoice(int id)
            => _invoiceRepository.Delete(id) > 0;


        // SalesItem Methods
        public SalesItem GetItemById(int itemId)
            => _itemRepository.GetById(itemId);

        public List<SalesItem> GetItemsByInvoiceId(int invoiceId)
            => _itemRepository.GetByInvoiceId(invoiceId);

        public List<SalesItem> GetItemsByProductId(int productId)
            => _itemRepository.GetByProductId(productId);

        public bool AddSalesItem(SalesItem item)
            => _itemRepository.Add(item) > 0;

        public bool UpdateSalesItem(SalesItem item)
            => _itemRepository.Update(item) > 0;

        public bool DeleteSalesItem(int itemId)
            => _itemRepository.Delete(itemId) > 0;
    }

}
