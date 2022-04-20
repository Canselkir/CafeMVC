using System;
using System.Collections.Generic;
using System.Text;
using TaskManager.Entity;

namespace TaskManager.Business.Abstract
{
    public interface IPropertyService
    {
        Property GetById(int id);
        List<Property> GetAll();
        void Create(Property entity);
        void Delete(Property entity);
        void Update(Property entity);
    }
}
