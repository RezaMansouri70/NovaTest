using DataLayer.SqlServer.Common;
using DomainClass.Altersklassen;
using DomainClass.Models;

namespace DataLayer.SqlServer.Repositories
{

    public class AltersklassenRepository : EfRepository<Altersklassen>, IAltersklassenRepository
    {
        public AltersklassenRepository(NOVATestContext DbContext) : base(DbContext)
        {
        }

    }

}
