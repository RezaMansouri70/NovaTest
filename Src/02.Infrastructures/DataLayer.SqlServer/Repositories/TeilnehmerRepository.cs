using DataLayer.SqlServer.Common;
using DomainClass.Altersklassen;
using DomainClass.Models;
using DomainClass.Teilnehmer;

namespace DataLayer.SqlServer.Repositories
{

    public class TeilnehmerRepository : EfRepository<Teilnehmer>, ITeilnehmerRepository
    {
        public TeilnehmerRepository(NOVATestContext DbContext) : base(DbContext)
        {
        }

    }

}
