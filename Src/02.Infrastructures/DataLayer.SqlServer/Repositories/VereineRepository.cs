using DataLayer.SqlServer.Common;
using DomainClass.Models;
using DomainClass.Vereine;

namespace DataLayer.SqlServer.Repositories
{

    public class VereineRepository : EfRepository<Vereine>, IVereineRepository
    {
        public VereineRepository(NOVATestContext DbContext) : base(DbContext)
        {
        }

    }

}
