using MusicStoreSites.Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MusicStoreSites.Core.DAL.ADO.NET
{
    public abstract class ADORepositoryBase<TEntity, TDb> : IRepository<TEntity>
        where TEntity:BaseEntity, new()
        where TDb:ADODbContext, new()
     {
        public abstract string TableName { get; set; }

        TDb db;
        public ADORepositoryBase()
        {
            db = new TDb();
        }
        public abstract void Add(TEntity entity);

        public TEntity Get(Expression<Func<TEntity, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public ICollection<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public void Remove(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public abstract void Update(TEntity entity);

    }
}
