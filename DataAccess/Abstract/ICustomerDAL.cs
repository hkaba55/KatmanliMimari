using Core.DataAccess;
using Domain.Concrete.Entity;

namespace DataAccess.Abstract
{
    public interface ICustomerDAL:IEntityRepository<Customer>
    {
    }
}
