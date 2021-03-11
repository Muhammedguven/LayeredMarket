﻿using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Market.Business.Abstract
{
    public interface ICategoryService
    {
        List<Category> GetAll();
        Category GetById(int categoryId);

    }
}
