using EFRepositories.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;

namespace EFRepositories.Persistence.Repositories
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        protected readonly DbContext context;
        private readonly DbSet<TEntity> set;

        public Repository(DbContext context)
        {
            this.context = context;
            set = context.Set<TEntity>();
        }

        public TEntity Get(int id)
        {
            return set.Find(id);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return set.ToList();
        }

        public IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate)
        {
            return set.Where(predicate);
        }

        public TEntity SingleOrDefault(Expression<Func<TEntity, bool>> predicate)
        {
            return set.SingleOrDefault(predicate);
        }

        public void Add(TEntity entity)
        {
            set.Add(entity);
        }

        public void AddRange(IEnumerable<TEntity> entities)
        {
            set.AddRange(entities);
        }

        public void Remove(TEntity entity)
        {
            set.Remove(entity);
        }

        public void RemoveRange(IEnumerable<TEntity> entities)
        {
            set.RemoveRange(entities);
        }
    }
}
