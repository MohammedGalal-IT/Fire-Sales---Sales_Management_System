using Fire_Sales___Sales_Management_System.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fire_Sales___Sales_Management_System.Data_Access.Interfaces
{
    public interface IShiftReportRepository : IRepository<ShiftReport>
    {
        List<ShiftReport> GetByUserId(int userId);
        ShiftReport GetByDate(DateTime date);
        List<ShiftReport> GetByDateRange(DateTime start, DateTime end);
    }
}
