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
    public class ExpenseService : IExpenseService
    {
        private readonly IExpenseRepository _expenseRepository;

        public ExpenseService(IExpenseRepository expenseRepository)
        {
            _expenseRepository = expenseRepository;
        }

        public List<Expense> GetAll()
            => _expenseRepository.GetAll();

        public Expense GetById(int id)
            => _expenseRepository.GetById(id);

        public List<Expense> GetByUserId(int userId)
            => _expenseRepository.GetByUserId(userId);

        public List<Expense> GetByDateRange(DateTime startDate, DateTime endDate)
            => _expenseRepository.GetByDateRange(startDate, endDate);

        public bool Add(Expense expense)
            => _expenseRepository.Add(expense) > 0;

        public bool Update(Expense expense)
            => _expenseRepository.Update(expense) > 0;

        public bool Delete(int id)
            => _expenseRepository.Delete(id) > 0;


    }

}
