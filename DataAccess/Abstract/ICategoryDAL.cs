using Core.DataAccess;
using Core.Entities;
using Domain.Concrete.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
   public interface ICategoryDAL:IEntityRepository<Category>
    {
        //bu nesneye özel metotlar burada oluşturlur
    }
}
