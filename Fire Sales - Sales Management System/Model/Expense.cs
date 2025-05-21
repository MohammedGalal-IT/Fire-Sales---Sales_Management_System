using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fire_Sales___Sales_Management_System.Model
{
    public enum ExpenseType
    {
        كهرباء,
        أكل,
        قات,
        شيء_آخر
    }

    public class Expense
    {
        public int ExpenseID { get; set; }
        public string Description { get; set; }
        public decimal Amount { get; set; }
        public DateTime Date { get; set; }
        public ExpenseType ExpenseType { get; set; }
        public int CreatedBy { get; set; }
    }

}
