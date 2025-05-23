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
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public List<Product> GetAllProducts()
        {
            return _productRepository.GetAll();
        }

        public Product GetProductById(int id)
        {
            return _productRepository.GetById(id);
        }

        public bool CreateProduct(Product product)
        {
            return _productRepository.Add(product) > 0;
        }

        public bool UpdateProduct(Product product)
        {
            return _productRepository.Update(product) > 0;
        }

        public bool DeleteProduct(int id)
        {
            return _productRepository.Delete(id) > 0;
        }

        public List<Product> GetActiveProducts()
        {
            return _productRepository.GetActiveProducts();
        }

        public List<Product> SearchByName(string name)
        {
            return _productRepository.SearchByName(name);
        }

        public Product GetByBarcode(string barcode)
        {
            return _productRepository.GetByBarcode(barcode);
        }

        public List<Product> GetByCategoryId(int categoryId)
        {
            return _productRepository.GetByCategoryId(categoryId);
        }
    }
}
