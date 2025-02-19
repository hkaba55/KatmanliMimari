using Core.EntityFramework;
using DataAccess.Abstract;
using Domain.Concrete.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class OrderDAL : EfEntityRepositoryBase<Order,BaseDBContext>,IOrderDAL
    {
    }
}
