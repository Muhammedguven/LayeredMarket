using Market.Core.DataAccess;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Market.DataAccess.Abstract
{
    public interface ICategoryDal : IEntityRepository<Category>
    {
       
    }
}
