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
    public class GenderService : IGenderService
    {
        private readonly GenderDAL gender;
        public GenderService(GenderDAL dAL)
        {
            gender = dAL;
        }

        public Task CreateAsync(Gender entity)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(Gender category)
        {
            throw new NotImplementedException();
        }

        public Task<List<Gender>> GetAllAsync(Expression<Func<Gender, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public Task<Gender> GetByIdAsync(int Id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Gender>> GetGendersAsync(Expression<Func<Gender, bool>> filter = null)
        {
            return await gender.GetAllAsync(filter);
        }

        public Task UpdateAsync()
        {
            throw new NotImplementedException();
        }
    }
}
