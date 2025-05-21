using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fire_Sales___Sales_Management_System.Model
{
    public class PurchaseReturn
    {
        public int PurchaseReturnID { get; set; }
        public int PurchaseInvoiceID { get; set; }
        public DateTime Date { get; set; }
        public decimal TotalReturnAmount { get; set; }
        public int CreatedBy { get; set; }
    }

}
