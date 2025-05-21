using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fire_Sales___Sales_Management_System.Model
{
    public class PurchaseInvoice
    {
        public int PurchaseInvoiceID { get; set; }
        public string InvoiceNumber { get; set; }
        public int SupplierID { get; set; }
        public DateTime Date { get; set; }
        public decimal TotalAmount { get; set; }
        public int CreatedBy { get; set; }
    }

}
