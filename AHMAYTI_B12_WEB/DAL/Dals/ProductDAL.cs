using DAL.Context;
using Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;


namespace DAL.Dals
{
    public class ProductDAL
    {
        private readonly DataContext db;

        public ProductDAL()
        {
            db = new DataContext();
        }

        public async Task<List<Product>> GetAllAsync(Expression<Func<Product,bool>> filter = null)
        {
            var Products = db.Products.Include(i => i.Gender).AsQueryable();

            if (filter != null)
            {
                Products = Products.Where(filter);
            }

            return await Products.ToListAsync();
        } 


    }
}
