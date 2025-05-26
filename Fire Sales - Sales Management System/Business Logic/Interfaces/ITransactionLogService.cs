using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using Fire_Sales___Sales_Management_System.Model;   

namespace Fire_Sales___Sales_Management_System.Business_Logic.Interfaces
{
    interface ITransactionLogService
    {
         List<TransactionLog> GetAll();
        TransactionLog GetById(int id);
        List<TransactionLog> GetByUserId(int userId);
        List<TransactionLog> GetByDateRange(DateTime start, DateTime end);
        List<TransactionLog> GetByType(string transactionType);
        bool Add(TransactionLog log);
        bool Delete(int id);
        bool Update(TransactionLog log);

    }
}
