﻿using Fire_Sales___Sales_Management_System.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fire_Sales___Sales_Management_System.Data_Access.Interfaces
{
    public interface IPurchaseItemRepository : IRepository<PurchaseItem>
    {
        List<PurchaseItem> GetByInvoiceId(int purchaseInvoiceId);
        List<PurchaseItem> GetByProductId(int productId);
    }
}
