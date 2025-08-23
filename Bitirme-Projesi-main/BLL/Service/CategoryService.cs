using BLL.Abstract;
using DAL.EfCore;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Service
{
    public class CategoryService : ICategoryService
    {
        private readonly CategoryDAL category;

        public CategoryService(CategoryDAL dAL)
        {
            category = dAL;
        }

        public Task CreateAsync(Category entity)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(Category category)
        {
            throw new NotImplementedException();
        }

        public Task<List<Category>> GetAllAsync(Expression<Func<Category, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public Task<Category> GetByIdAsync(int Id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Category>> GetCategoriesAsync(Expression<Func<Category, bool>> filter = null)
        {
            return await category.GetAllAsync(filter);
        }

        public Task UpdateAsync()
        {
            throw new NotImplementedException();
        }
    }
}
