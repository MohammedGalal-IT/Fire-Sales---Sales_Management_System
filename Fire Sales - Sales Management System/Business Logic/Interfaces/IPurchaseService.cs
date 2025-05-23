using Fire_Sales___Sales_Management_System.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fire_Sales___Sales_Management_System.Business_Logic.Interfaces
{
    public interface IPurchaseService
    {
        // PurchaseInvoice Operations
        List<PurchaseInvoice> GetAllInvoices();
        PurchaseInvoice GetInvoiceById(int id);
        bool CreateInvoice(PurchaseInvoice invoice);
        bool UpdateInvoice(PurchaseInvoice invoice);
        bool DeleteInvoice(int id);
        List<PurchaseInvoice> GetInvoicesBySupplierId(int supplierId);
        List<PurchaseInvoice> GetInvoicesByUserId(int userId);
        List<PurchaseInvoice> GetInvoicesByDateRange(DateTime start, DateTime end);


        // PurchaseItem Operations
        List<PurchaseItem> GetItemsByInvoiceId(int invoiceId);
        List<PurchaseItem> GetItemsByProductId(int productId);
        bool AddPurchaseItem(PurchaseItem item);
        bool UpdatePurchaseItem(PurchaseItem item);
        bool DeletePurchaseItem(int itemId);
    }
}
