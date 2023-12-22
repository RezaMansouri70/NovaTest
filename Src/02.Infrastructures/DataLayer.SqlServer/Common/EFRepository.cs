using DomainClass.Common;
using DomainClass.Models;

namespace DataLayer.SqlServer.Common
{
    public class EfRepository<TEntity> : IRepository<TEntity> where TEntity : BaseEntity, new()
    {
        protected readonly NOVATestContext dbContext;

        public EfRepository(NOVATestContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public void Insert(TEntity entity)
        {
            dbContext.Add(entity);
            dbContext.SaveChanges();
        }

        public void Remove(TEntity entity)
        {
            dbContext.Remove(entity);
            dbContext.SaveChanges();
        }

   
        public IEnumerable<TEntity> GetAll()
        {
            return dbContext.Set<TEntity>().ToList();
        }

        public void Update(TEntity entity)
        {
            dbContext.Update(entity);
            dbContext.SaveChanges();
        }

        public void SaveChanges()
        {
            dbContext.SaveChanges();
        }

        public IQueryable<TEntity> GetQueryable()
        {
            return dbContext.Set<TEntity>().AsQueryable();
        }
    }

}
