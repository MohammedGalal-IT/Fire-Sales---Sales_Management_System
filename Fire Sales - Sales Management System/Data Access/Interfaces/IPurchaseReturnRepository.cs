using Fire_Sales___Sales_Management_System.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fire_Sales___Sales_Management_System.Data_Access.Interfaces
{
    public interface IPurchaseReturnRepository : IRepository<PurchaseReturn>
    {
        List<PurchaseReturn> GetByInvoiceId(int invoiceId);
        List<PurchaseReturn> GetBySupplierId(int supplierId);
        List<PurchaseReturn> GetByUserId(int userId);
        List<PurchaseReturn> GetByDateRange(DateTime start, DateTime end);
    }
}
