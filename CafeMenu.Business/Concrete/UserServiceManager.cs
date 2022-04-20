using System;
using System.Collections.Generic;
using System.Text;
using TaskManager.Business.Abstract;
using TaskManager.DataAccess.Abstract;
using TaskManager.Entity;

namespace TaskManager.Business.Concrete
{
    public class UserServiceManager : IUserService
    {
        private IUser _userRepository;
        public UserServiceManager(IUser userRepository)
        {
            _userRepository = userRepository;
        }
        public void Create(User entity)
        {
            _userRepository.Create(entity);
        }

        public void Delete(User entity)
        {
            _userRepository.Delete(entity);
        }

        public List<User> GetAll()
        {
            return _userRepository.GetAll();
        }

        public User GetById(int id)
        {
            return _userRepository.GetById(id);
        }

        public void Update(User entity)
        {
            _userRepository.Update(entity);
        }
    }
}
