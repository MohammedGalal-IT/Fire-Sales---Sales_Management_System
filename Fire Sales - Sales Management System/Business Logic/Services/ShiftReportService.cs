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
    public class ShiftReportService : IShiftReportService
    {
        private readonly IShiftReportRepository _shiftReportRepository;

        public ShiftReportService(IShiftReportRepository shiftReportRepository)
        {
            _shiftReportRepository = shiftReportRepository;
        }

        public List<ShiftReport> GetAll()
        {
            return _shiftReportRepository.GetAll();
        }

        public ShiftReport GetById(int reportId)
        {
            return _shiftReportRepository.GetById(reportId);
        }

        public bool Add(ShiftReport report)
        {
            return _shiftReportRepository.Add(report) > 0;
        }

        public bool Update(ShiftReport report)
        {
            return _shiftReportRepository.Update(report) > 0;
        }

        public bool Delete(int reportId)
        {
            return _shiftReportRepository.Delete(reportId) > 0;
        }

        public List<ShiftReport> GetByUserId(int userId)
        {
            return _shiftReportRepository.GetByUserId(userId);
        }

        public List<ShiftReport> GetByDateRange(DateTime start, DateTime end)
        {
            return _shiftReportRepository.GetByDateRange(start, end);
        }

        public ShiftReport GetByDate(DateTime date)
        {
            return _shiftReportRepository.GetByDate(date);
        }
    }
}
