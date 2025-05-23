using Fire_Sales___Sales_Management_System.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fire_Sales___Sales_Management_System.Business_Logic.Interfaces
{
    public interface ISalesService
    {
        // SalesInvoice Operations
        List<SalesInvoice> GetAllInvoices();
        SalesInvoice GetInvoiceById(int id);
        SalesInvoice GetByInvoiceNumber(string invoiceNumber); 
        List<SalesInvoice> GetInvoicesByUserId(int userId);     
        List<SalesInvoice> GetInvoicesByDateRange(DateTime start, DateTime end);
        bool CreateInvoice(SalesInvoice invoice);
        bool UpdateInvoice(SalesInvoice invoice);
        bool DeleteInvoice(int id);


        // SalesItem Operations
        SalesItem GetItemById(int itemId);
        List<SalesItem> GetItemsByInvoiceId(int invoiceId);
        List<SalesItem> GetItemsByProductId(int productId);
        bool AddSalesItem(SalesItem item);
        bool UpdateSalesItem(SalesItem item);
        bool DeleteSalesItem(int itemId);
    }

}
