using Core.DataAccess.EntityFramework;
using Core.Entities.Concrete;
using Market.DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace Market.DataAccess.Concrete.EntityFramework
{
    public class EfUserDal : EFEntityRepositoryBase<User, DatabaseContext>, IUserDal
    {
        public List<OperationClaim> GetClaims(User user)
        {
            using (var context = new DatabaseContext())
            {
                var result = from operationClaim in context.OperationClaims
                             join userOperationClaim in context.UserOperationClaims
                                 on operationClaim.Id equals userOperationClaim.OperationClaimId
                             where userOperationClaim.UserId == user.Id
                             select new OperationClaim { Id = operationClaim.Id, Name = operationClaim.Name };
                return result.ToList();

            }
        }
    }
}
