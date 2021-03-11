using Core.DataAccess.EntityFramework;
using Entities.Concrete;
using Entities.DTOs;
using Market.DataAccess.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Market.DataAccess.Concrete.EntityFramework
{
    public class EFProductDal : EFEntityRepositoryBase<Product, DatabaseContext>, IProductDal
    {
        public List<ProductDetailDto> GetProductDetails()
        {
            using (DatabaseContext context = new DatabaseContext())
            {
                var result = from p in context.Products
                             join c in context.Categories
                             on p.CategoryId equals c.CategoryId
                             select new ProductDetailDto
                             {
                                 ProductId = p.ProductId,
                                 ProductName = p.ProductName,
                                 CategoryName = c.CategoryName,
                                 UnitsInStock = p.UnitsInStock
                             };
                return result.ToList();
            }
        }
    }
}
