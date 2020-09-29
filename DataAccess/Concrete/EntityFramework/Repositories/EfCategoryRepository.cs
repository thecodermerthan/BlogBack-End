using DataAccess.Concrete.EntityFramework.Context;
using DataAccess.Interfaces;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework.Repositories
{
    public class EfCategoryRepository : EfGenericRepository<Category>, ICategoryDal
    {
        public async Task<List<Category>> GetAllWithCategoryBlogsAsync()
        {
            using var context = new BlogContext();
            return await context.Categories.OrderByDescending(I=>I.Id).Include(I => I.CategoryBlogs).ToListAsync();
        }
    }
}
