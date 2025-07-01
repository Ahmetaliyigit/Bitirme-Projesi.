using DAL.Dals;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class CategoryService
    {
        private readonly CategoryDAL categorys;

        public CategoryService()
        {
            categorys = new CategoryDAL();
        }

        public async Task<List<Category>> GettAllAsync(Expression<Func<Category,bool>> filter = null)
        {
            return await categorys.GetAllAsync(filter);
        }
    }
}
