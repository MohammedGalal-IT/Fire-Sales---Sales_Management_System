using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fire_Sales___Sales_Management_System.Model
{
    public class SalesItem
    {
        public int SalesItemID { get; set; }
        public int SalesInvoiceID { get; set; }
        public int ProductID { get; set; }
        public int Quantity { get; set; }
        public decimal CostPrice { get; set; }
        public decimal Discount { get; set; }
    }

}
