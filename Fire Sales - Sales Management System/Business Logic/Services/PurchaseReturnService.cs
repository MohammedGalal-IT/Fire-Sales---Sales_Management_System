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
    public class PurchaseReturnService : IPurchaseReturnService
    {
        private readonly IPurchaseReturnRepository _returnRepository;
        private readonly IPurchaseReturnItemRepository _itemRepository;

        public PurchaseReturnService(
            IPurchaseReturnRepository returnRepository,
            IPurchaseReturnItemRepository itemRepository)
        {
            _returnRepository = returnRepository;
            _itemRepository = itemRepository;
        }

        // PurchaseReturn Methods
        public List<PurchaseReturn> GetAllReturns()
            => _returnRepository.GetAll();

        public PurchaseReturn GetReturnById(int id)
            => _returnRepository.GetById(id);

        public List<PurchaseReturn> GetReturnsByPurchaseInvoiceId(int purchaseInvoiceId)
            => _returnRepository.GetByInvoiceId(purchaseInvoiceId);

        public List<PurchaseReturn> GetReturnsByUserId(int userId)
            => _returnRepository.GetByUserId(userId);

        public bool CreateReturn(PurchaseReturn purchaseReturn)
            => _returnRepository.Add(purchaseReturn) > 0;

        public bool UpdateReturn(PurchaseReturn purchaseReturn)
            => _returnRepository.Update(purchaseReturn) > 0;

        public bool DeleteReturn(int id)
            => _returnRepository.Delete(id) > 0;

        public List<PurchaseReturn> GetReturnsByDateRange(DateTime start, DateTime end)
            => _returnRepository.GetByDateRange(start, end);

        public List<PurchaseReturn> GetReturnsBySupplierId(int supplierId)
            => _returnRepository.GetBySupplierId(supplierId);


        // PurchaseReturnItem Methods
        public PurchaseReturnItem GetReturnItemById(int itemId)
            => _itemRepository.GetById(itemId);

        public List<PurchaseReturnItem> GetItemsByReturnId(int returnId)
            => _itemRepository.GetByPurchaseReturnId(returnId);

        public List<PurchaseReturnItem> GetItemsByProductId(int productId)
            => _itemRepository.GetByProductId(productId);

        public bool AddReturnItem(PurchaseReturnItem item)
            => _itemRepository.Add(item) > 0;

        public bool UpdateReturnItem(PurchaseReturnItem item)
            => _itemRepository.Update(item) > 0;

        public bool DeleteReturnItem(int itemId)
            => _itemRepository.Delete(itemId) > 0;
    }

}
