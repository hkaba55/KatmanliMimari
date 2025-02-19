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
    public class OrderManager : IOrderService
    {

        IOrderDAL _orderDAL;

        public OrderManager(IOrderDAL orderDAL)
        {
            _orderDAL = orderDAL;
        }

        public void Add(Order order)
        {
            _orderDAL.Add(order);
        }
    }
}
