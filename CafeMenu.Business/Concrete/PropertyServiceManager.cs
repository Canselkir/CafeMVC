using System;
using System.Collections.Generic;
using System.Text;
using TaskManager.Business.Abstract;
using TaskManager.DataAccess.Abstract;
using TaskManager.Entity;

namespace TaskManager.Business.Concrete
{
    public class PropertyServiceManager : IPropertyService
    {
        private IProperty _propertyRepository;
        public PropertyServiceManager(IProperty propertRepository)
        {
            _propertyRepository = propertRepository;
        }
        public void Create(Property entity)
        {
            _propertyRepository.Create(entity);
        }

        public void Delete(Property entity)
        {
            _propertyRepository.Delete(entity);
        }

        public List<Property> GetAll()
        {
            return _propertyRepository.GetAll();
        }

        public Property GetById(int id)
        {
            return _propertyRepository.GetById(id);
        }

        public void Update(Property entity)
        {
            _propertyRepository.Update(entity);
        }
    }
}
