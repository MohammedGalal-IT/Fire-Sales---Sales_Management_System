using Fire_Sales___Sales_Management_System.Business_Logic.Interfaces;
using Fire_Sales___Sales_Management_System.Data_Access.Interfaces;
using Fire_Sales___Sales_Management_System.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fire_Sales___Sales_Management_System.Business_Logic.Services
{
    public class TransactionLogService : ITransactionLogService
    {
        private readonly ITransactionLogRepository _transactionLogRepository;

        public TransactionLogService(ITransactionLogRepository transactionLogRepository)
        {
            _transactionLogRepository = transactionLogRepository;
        }

        public List<TransactionLog> GetAll()
            => _transactionLogRepository.GetAll();

        public TransactionLog GetById(int id)
            => _transactionLogRepository.GetById(id);

        public List<TransactionLog> GetByUserId(int userId)
            => _transactionLogRepository.GetByUserId(userId);

        public List<TransactionLog> GetByDateRange(DateTime start, DateTime end)
            => _transactionLogRepository.GetByDateRange(start, end);

        public List<TransactionLog> GetByType(string transactionType)
            => _transactionLogRepository.GetByType(transactionType);

        public bool Add(TransactionLog log)
            => _transactionLogRepository.Add(log) > 0;

        public bool Delete(int id)
            => _transactionLogRepository.Delete(id) > 0;

        public bool Update(TransactionLog log)
            => _transactionLogRepository.Update(log) > 0;

    }

}
