using CSI.Core.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace CSI.Infrastructure.Repositories
{
    public class Repository<T> : IRepository<T> where T : class
    {
        protected readonly ApplicationDbContext context;

        public Repository(ApplicationDbContext context)
        {
            this.context = context;
        }

        public virtual async Task AddAsync(T entity)
        {
            await this.context.Set<T>().AddAsync(entity);
        }

        public virtual async Task AddRangeAsync(IEnumerable<T> entities)
        {
            await this.context.Set<T>().AddRangeAsync(entities);
        }

        public virtual Task<IEnumerable<T>> FindAsync(Expression<Func<T, bool>> expression)
        {
            return Task.Run(() => this.context.Set<T>().Where(expression).AsEnumerable());
        }

        public virtual Task<T> FindSingleAsync(Expression<Func<T, bool>> expression)
        {
            return Task.Run(() => this.context.Set<T>().Where(expression).FirstOrDefault());
        }

        public virtual Task<IEnumerable<T>> GetAllAsync()
        {
            return Task.Run(() => this.context.Set<T>().AsEnumerable());
        }

        public virtual async Task<T> GetByIdAsync(int id)
        {
            return await this.context.Set<T>().FindAsync(id);
        }

        public virtual void Remove(T entity)
        {
            this.context.Set<T>().Remove(entity);
        }

        public async Task RemoveByIdAsync(int id)
        {
            var entity = await this.GetByIdAsync(id);

            this.Remove(entity);
        }

        public void RemoveRange(IEnumerable<T> entities)
        {
            this.context.Set<T>().RemoveRange(entities);
        }

        public void Update(T entity)
        {
            this.context.Set<T>().Update(entity);
        }
    }
}
