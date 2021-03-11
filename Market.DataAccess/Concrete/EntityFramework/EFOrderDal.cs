using Core.DataAccess.EntityFramework;
using Entities.Concrete;
using Market.DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Market.DataAccess.Concrete.EntityFramework
{
    public class EFOrderDal: EFEntityRepositoryBase<Order,DatabaseContext>,IOrderDal
    {

    }
}
