using Core.Entities.Concrete;
using Market.Core.DataAccess;
using System;
using System.Collections.Generic;
using System.Text;

namespace Market.DataAccess.Abstract
{

    public interface IUserDal : IEntityRepository<User>
    {
        List<OperationClaim> GetClaims(User user);
    }
}
