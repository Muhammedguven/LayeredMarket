using Entities.Concrete;
using Market.Core.DataAccess;
using System;
using System.Collections.Generic;
using System.Text;

namespace Market.DataAccess.Abstract
{
    public interface ICustomerDal:IEntityRepository<Customer>
    {

    }
}
