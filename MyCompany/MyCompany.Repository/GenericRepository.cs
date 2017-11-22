using MyCompany.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyCompany.Repository
{
    public sealed class GenericRepository<TEntity, TContext> : Repository<TEntity, TContext>, IRepository<TEntity>
        where TEntity : class
       where TContext : MyCompanyContext
    {
        public GenericRepository(TContext context) : base(context) { }

    }
}
