
using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Concrete.Entity
{
    public class Product:IEntity
    {
        public int ID { get; set; }

        public string productName { get; set; }
        public int Qantity { get; set; }


    }
}
