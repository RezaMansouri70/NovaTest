using DataLayer.SqlServer.Common;
using DomainClass.Gewichtsklassen;
using DomainClass.Models;

namespace DataLayer.SqlServer.Repositories
{

    public class GewichtsklassenRepository : EfRepository<Gewichtsklassen>, IGewichtsklassenRepository
    {
        public GewichtsklassenRepository(NOVATestContext DbContext) : base(DbContext)
        {
        }

    }

}
