using Fire_Sales___Sales_Management_System.Business_Logic.Interfaces;
using Fire_Sales___Sales_Management_System.Data_Access.Interfaces;
using Fire_Sales___Sales_Management_System.Data_Access.Repositories;
using Fire_Sales___Sales_Management_System.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fire_Sales___Sales_Management_System.Business_Logic.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository _categoryRepository;

        public CategoryService(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        public List<Category> GetAllCategories()
        {
            return _categoryRepository.GetAll();
        }

        public Category GetCategoryById(int id)
        {
            return _categoryRepository.GetById(id);
        }

        public Category GetCategoryByName(string name)
        {
            return _categoryRepository.GetByName(name);
        }

        public bool CreateCategory(Category category)
        {
            return _categoryRepository.Add(category) > 0;
        }

        public bool UpdateCategory(Category category)
        {
            return _categoryRepository.Update(category) > 0;
        }

        public bool DeleteCategory(int id)
        {
            return _categoryRepository.Delete(id) > 0;
        }
    }
}
