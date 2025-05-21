using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fire_Sales___Sales_Management_System.Model
{
    public class ShiftReport
    {
        public int ReportID { get; set; }
        public DateTime Date { get; set; }
        public decimal TotalSales { get; set; }
        public decimal TotalReturns { get; set; }
        public decimal TotalExpenses { get; set; }
        public decimal NetTotal { get; set; }
        public string Note { get; set; }
        public int CreatedBy { get; set; }
    }
}
