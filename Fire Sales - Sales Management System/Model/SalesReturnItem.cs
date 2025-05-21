using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fire_Sales___Sales_Management_System.Model
{
    public class SalesReturnItem
    {
        public int SalesReturnItemID { get; set; }
        public int SalesReturnID { get; set; }
        public int ProductID { get; set; }
        public int Quantity { get; set; }
        public decimal RefundAmount { get; set; }
    }

}
