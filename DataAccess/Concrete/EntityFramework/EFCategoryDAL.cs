using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Domain.Concrete.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
   public class EFCategoryDAL: EfEntityRepositoryBase<Category,BaseDBContext>,ICategoryDAL
    {

    }
}
