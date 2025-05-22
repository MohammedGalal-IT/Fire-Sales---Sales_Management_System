using Fire_Sales___Sales_Management_System.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fire_Sales___Sales_Management_System.Data_Access.Interfaces
{
    public interface ITransactionLogRepository : IRepository<TransactionLog>
    {
        List<TransactionLog> GetByUserId(int userId);
        List<TransactionLog> GetByDateRange(DateTime start, DateTime end);
        List<TransactionLog> GetByType(string type);
    }
}
