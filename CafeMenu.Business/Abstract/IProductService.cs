using System;
using System.Collections.Generic;
using System.Text;
using TaskManager.Entity;

namespace TaskManager.Business.Abstract
{
    public interface IProductService
    {
        Product GetById(int id);
        List<Product> GetAll();
        void Create(Product entity);
        void Delete(Product entity);
        void Update(Product entity);
    }
}
