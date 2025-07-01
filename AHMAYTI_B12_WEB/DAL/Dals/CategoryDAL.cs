using DAL.Context;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Dals
{
    public class CategoryDAL
    {
        private readonly DataContext context;

        public CategoryDAL()
        {
            context = new DataContext();
        }

        public async Task<List<Category>> GetAllAsync(Expression<Func<Category,bool>> filter = null)
        {
            var Categorys = context.Categories.ToList().AsQueryable();

            if (filter != null)
            {
                Categorys = Categorys.Where(filter);
            }

            return Categorys.ToList();
        }

    }
}
