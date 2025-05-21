using Fire_Sales___Sales_Management_System.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fire_Sales___Sales_Management_System.Data_Access.Interfaces
{
    public interface ISalesReturnItemRepository : IRepository<SalesReturnItem>
    {
        List<SalesReturnItem> GetByReturnId(int returnId);
    }
}
