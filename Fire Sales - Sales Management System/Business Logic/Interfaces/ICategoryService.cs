using Fire_Sales___Sales_Management_System.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fire_Sales___Sales_Management_System.Business_Logic.Interfaces
{
    public interface ICategoryService
    {
        List<Category> GetAllCategories();
        Category GetCategoryById(int id);
        Category GetCategoryByName(string name);
        bool CreateCategory(Category category);
        bool UpdateCategory(Category category);
        bool DeleteCategory(int id);

    }
}
