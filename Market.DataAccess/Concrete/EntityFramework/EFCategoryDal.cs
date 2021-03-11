using Core.DataAccess.EntityFramework;
using Entities.Concrete;
using Market.DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Market.DataAccess.Concrete.EntityFramework
{
    public class EFCategoryDal : EFEntityRepositoryBase<Category, DatabaseContext>,ICategoryDal
    {
        
    }
}
