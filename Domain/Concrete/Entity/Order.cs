
using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Concrete.Entity
{
    public class Order:IEntity
    {
        public int ID { get; set; }
        public string orderNumber { get; set; }
        public decimal price { get; set; }
    }
}
