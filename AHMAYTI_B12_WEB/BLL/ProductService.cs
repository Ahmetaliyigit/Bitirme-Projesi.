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
    public class ProductService
    {
        private readonly ProductDAL product;

        public ProductService()
        {
            product = new ProductDAL();
        }

        public async Task<List<Product>> GetAllAsync(Expression<Func<Product,bool>> filter = null)
        {
            return await product.GetAllAsync(filter);
        }
    }
}
