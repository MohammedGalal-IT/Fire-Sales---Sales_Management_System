using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fire_Sales___Sales_Management_System.Model
{
    public class PurchaseReturnItem
    {
        public int PurchaseReturnItemID { get; set; }
        public int PurchaseReturnID { get; set; }
        public int ProductID { get; set; }
        public int Quantity { get; set; }
        public decimal ReturnAmount { get; set; }
    }

}
