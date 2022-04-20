using System;
using System.Collections.Generic;
using System.Text;
using TaskManager.Entity;

namespace TaskManager.Business.Abstract
{
    public interface IUserService
    {
        User GetById(int id);
        List<User> GetAll();
        void Create(User entity);
        void Delete(User entity);
        void Update(User entity);
    }
}
