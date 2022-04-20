using System;
using System.Collections.Generic;
using System.Text;
using TaskManager.Business.Abstract;
using TaskManager.DataAccess.Abstract;
using TaskManager.Entity;

namespace TaskManager.Business.Concrete
{
    public class ProductServiceManager : IProductService
    {
        private IProduct _productRepository;
        public ProductServiceManager(IProduct productRepository)
        {
            _productRepository = productRepository;
        }
        public void Create(Product entity)
        {
            _productRepository.Create(entity);
        }

        public void Delete(Product entity)
        {
            _productRepository.Delete(entity);
        }

        public List<Product> GetAll()
        {
            return _productRepository.GetAll();
        }

        public Product GetById(int id)
        {
            return _productRepository.GetById(id);
        }

        public void Update(Product entity)
        {
            _productRepository.Update(entity);
        }
    }
}
