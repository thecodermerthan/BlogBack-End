using Business.Interfaces;
using DataAccess.Interfaces;
using DTO.DTOs.CategoryBlogDtos;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class BlogManager : GenericManager<Blog>, IBlogService
    {
        private readonly IGenericDal<Blog> _genericDal;
        private readonly IGenericDal<CategoryBlog> _categoryBlogService;
        private readonly IBlogDal _blogDal;
        public BlogManager(IGenericDal<Blog> genericDal, 
            IGenericDal<CategoryBlog> categoryBlogService, IBlogDal blogDal) : base(genericDal)
        {
            _blogDal = blogDal;
            _categoryBlogService = categoryBlogService;
            _genericDal = genericDal;
        }
       
        public async Task<List<Blog>> GetAllSortedByPostedTimeAsync()
        {
            return await _genericDal.GetAllAsync(I => I.PostedTime);
        }

        public async Task AddToCategoryAsync(CategoryBlogDto categoryBlogDto)
        {
            var control = await _categoryBlogService.GetAsync(I => I.CategoryId == categoryBlogDto.CategoryId
            && I.BlogId == categoryBlogDto.BlogId);
            if(control==null)
            {
                await _categoryBlogService.AddAsync(new CategoryBlog
                {
                    BlogId = categoryBlogDto.BlogId,
                    CategoryId = categoryBlogDto.CategoryId
                });
            }
            
        }

        public async Task RemoveFromCategoryAsync(CategoryBlogDto categoryBlogDto)
        {
            var deletedCategoryBlog = await _categoryBlogService.GetAsync(I => I.CategoryId == categoryBlogDto.CategoryId
            && I.BlogId == categoryBlogDto.BlogId);
            if(deletedCategoryBlog!=null)
            {
                await _categoryBlogService.RemoveAsync(deletedCategoryBlog);
            }
            
        }

        public async Task<List<Blog>> GetAllByCategoryIdAsync(int categoryId)
        {
            return await _blogDal.GetAllByCategoryIdAsync(categoryId);
        }
    }
}
