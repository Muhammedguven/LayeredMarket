using Entities.Concrete;
using Market.Business.Abstract;
using Market.DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Market.Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public List<Category> GetAll()
        {
            //Bussiness Code
            return _categoryDal.GetAll();
        }

        public Category GetById(int categoryId)
        {
            return _categoryDal.Get(c => c.CategoryId == categoryId);

        }
    }
}
