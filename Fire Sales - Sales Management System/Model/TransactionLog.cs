using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fire_Sales___Sales_Management_System.Model
{
    public enum TransactionType
    {
        Sale,
        Purchase,
        SaleReturn,
        PurchaseReturn,
        Expense,
        Adjustment
    }

    public class TransactionLog
    {
        public int TransactionLogID { get; set; }
        public TransactionType TransactionType { get; set; }
        public int ReferenceID { get; set; }
        public decimal Amount { get; set; }
        public DateTime Date { get; set; }
        public int CreatedBy { get; set; }
        public string Note { get; set; }
    }

}
