﻿using Fire_Sales___Sales_Management_System.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fire_Sales___Sales_Management_System.Data_Access.Interfaces
{
    public interface IPurchaseInvoiceRepository : IRepository<PurchaseInvoice>
    {
        PurchaseInvoice GetByInvoiceNumber(string invoiceNumber);
        List<PurchaseInvoice> GetBySupplierId(int supplierId);
        List<PurchaseInvoice> GetByDateRange(DateTime startDate, DateTime endDate);
    }
}
