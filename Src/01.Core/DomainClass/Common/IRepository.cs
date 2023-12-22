namespace DomainClass.Common
{

    public interface IRepository<TEntity> where TEntity : BaseEntity, new()
    {
        void Insert(TEntity entity);
        void Remove(TEntity entity);
        void Update(TEntity entity);
        void SaveChanges();
        IEnumerable<TEntity> GetAll();
        IQueryable<TEntity> GetQueryable();

    }
}
