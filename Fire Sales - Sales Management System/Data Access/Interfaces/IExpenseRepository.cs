using Fire_Sales___Sales_Management_System.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fire_Sales___Sales_Management_System.Data_Access.Interfaces
{
    public interface IExpenseRepository : IRepository<Expense>
    {
        List<Expense> GetByUserId(int userId);
        List<Expense> GetByDateRange(DateTime start, DateTime end);
        List<Expense> GetByType(string type);
    }
}
