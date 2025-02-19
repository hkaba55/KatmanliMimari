using BusinessLayer.Abstract;
using DataAccess.Abstract;
using Domain.Concrete.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class UserManager : IUserService
    {
        IUserDAL _userDAL;

        public UserManager(IUserDAL userDAL)
        {
            _userDAL = userDAL;
        }

        public void Add(User user)
        {
            _userDAL.Add(user);
        }

        public List<User> GetAllUser()
        {
             List<User> users = _userDAL.GetAll();
            return users;
        }
    }
}
