using DAL.Concrate.EfCore.Context;
using Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EfCore
{
    public class ProductDAL:Repository<Product>
    {
        private readonly DataContext db;

        public ProductDAL(DataContext context) : base(context)
        {
            db = context;
        }

    }
}


