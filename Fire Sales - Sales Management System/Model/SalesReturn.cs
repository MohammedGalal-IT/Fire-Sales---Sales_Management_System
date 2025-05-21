using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fire_Sales___Sales_Management_System.Model
{
    public class SalesReturn
    {
        public int SalesReturnID { get; set; }
        public int SalesInvoiceID { get; set; }
        public DateTime Date { get; set; }
        public decimal TotalRefundAmount { get; set; }
        public int CreatedBy { get; set; }
    }

}
