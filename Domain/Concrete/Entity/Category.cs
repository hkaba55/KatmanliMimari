using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Concrete.Entity
{
   public class Category:IEntity
    {
        public int ID { get; set; }
        public string CategoryName { get; set; }
    }

}
