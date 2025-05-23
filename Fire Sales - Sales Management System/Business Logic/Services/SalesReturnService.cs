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
    public class SalesReturnService : ISalesReturnService
    {
        private readonly ISalesReturnRepository _returnRepository;
        private readonly ISalesReturnItemRepository _itemRepository;

        public SalesReturnService(
            ISalesReturnRepository returnRepository,
            ISalesReturnItemRepository itemRepository)
        {
            _returnRepository = returnRepository;
            _itemRepository = itemRepository;
        }

        // SalesReturn Methods
        public List<SalesReturn> GetAllReturns()
            => _returnRepository.GetAll();

        public SalesReturn GetReturnById(int id)
            => _returnRepository.GetById(id);

        public List<SalesReturn> GetReturnsBySalesInvoiceId(int salesInvoiceId)
            => _returnRepository.GetByInvoiceId(salesInvoiceId);

        public List<SalesReturn> GetReturnsByUserId(int userId)
            => _returnRepository.GetByUserId(userId);

        public bool CreateReturn(SalesReturn salesReturn)
            => _returnRepository.Add(salesReturn) > 0;

        public bool UpdateReturn(SalesReturn salesReturn)
            => _returnRepository.Update(salesReturn) > 0;

        public bool DeleteReturn(int id)
            => _returnRepository.Delete(id) > 0;



        // SalesReturnItem Methods
        public SalesReturnItem GetReturnItemById(int itemId)
            => _itemRepository.GetById(itemId);

        public List<SalesReturnItem> GetItemsByReturnId(int returnId)
            => _itemRepository.GetBySalesReturnId(returnId);

        public List<SalesReturnItem> GetItemsByProductId(int productId)
            => _itemRepository.GetByProductId(productId);

        public bool AddReturnItem(SalesReturnItem item)
            => _itemRepository.Add(item) > 0;

        public bool UpdateReturnItem(SalesReturnItem item)
            => _itemRepository.Update(item) > 0;

        public bool DeleteReturnItem(int itemId)
            => _itemRepository.Delete(itemId) > 0;
    }

}
