using DataLayer.SqlServer.Common;
using DomainClass.Altersklassen;
using DomainClass.Models;
using DomainClass.Verbaende;

namespace DataLayer.SqlServer.Repositories
{

    public class VerbaendeRepository : EfRepository<Verbaende>, IVerbaendeRepository
    {
        public VerbaendeRepository(NOVATestContext DbContext) : base(DbContext)
        {
        }

    }

}
