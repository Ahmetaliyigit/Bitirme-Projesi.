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
    public class ProductService : IProductService
    {
        private readonly ProductDAL products;

        public ProductService(ProductDAL dal)
        {
            products = dal;
        }

        public async Task<List<Product>> GetallAsync(Expression<Func<Product, bool>> filter = null)
        {
            return await products.GetAllAsync(filter);
        }

        public void UpdateProductAsync(Product product)
        {
            products.UpdateAsync();
        }
        public async Task AddProductAsync(Product product)
        {
            await products.CreateAsync(product);
        }

        public Task CreateAsync(Product entity)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync()
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(Product category)
        {
            throw new NotImplementedException();
        }

        public Task<List<Product>> GetAllAsync(Expression<Func<Product, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public Task<Product> GetByIdAsync(int Id)
        {
            throw new NotImplementedException();
        }
    }
}
