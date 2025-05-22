using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fire_Sales___Sales_Management_System.Data_Access.Interfaces
{
    public interface IRepository<T>
    {
        T GetById(int id);
        List<T> GetAll();
        int Add(T entity);
        int Update(T entity);
        int Delete(int id);
    }
}
