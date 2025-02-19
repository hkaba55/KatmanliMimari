using Core.EntityFramework;
using DataAccess.Abstract;
using Domain.Concrete.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class UserDAL : EfEntityRepositoryBase<User,BaseDBContext>,IUserDAL
    {
    }
}
