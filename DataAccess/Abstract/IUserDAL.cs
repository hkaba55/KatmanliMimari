using Core.DataAccess;
using Domain.Concrete.Entity;

namespace DataAccess.Abstract
{
    public interface IUserDAL:IEntityRepository<User>
    {
    }
}
