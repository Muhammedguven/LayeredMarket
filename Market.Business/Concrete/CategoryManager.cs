using Core.Utilities.Results;
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

        public IDataResult<List<Category>> GetAll()
        {
            //Bussiness Code
            return new SuccessDataResult<List<Category>>(_categoryDal.GetAll());
        }

        public IDataResult<Category> GetById(int categoryId)
        {
            return new SuccessDataResult<Category>(_categoryDal.Get(c => c.CategoryId == categoryId));

        }
    }
}
