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
    public class ColorService : IColorService
    {
        private readonly ColorDAL color;

        public ColorService(ColorDAL dAL)
        {
            color = dAL;
        }

        public Task CreateAsync(Color entity)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(Color category)
        {
            throw new NotImplementedException();
        }

        public Task<List<Color>> GetAllAsync(Expression<Func<Color, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public Task<Color> GetByIdAsync(int Id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Color>> GetColorsAsync(Expression<Func<Color, bool>> filter = null)
        {
            return await color.GetAllAsync(filter);
        }

        public Task UpdateAsync()
        {
            throw new NotImplementedException();
        }
    }
}
