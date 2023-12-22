

using Application.Models.General;
using ApplicationServices.Model;
using ApplicationServices.Model.Doping;
using ApplicationServices.Services.DopingService;
using DomainClass.Altersklassen;
using DomainClass.Teilnehmer;

namespace ApplicationServices.Services.Doping
{

    public class DopingService : IDopingService
    {
        private readonly IAltersklassenRepository _altersklassenRepository;
        private readonly ITeilnehmerRepository _teilnehmerRepository;


        public DopingService(IAltersklassenRepository altersklassenRepository, ITeilnehmerRepository teilnehmerRepository)
        {
            _altersklassenRepository = altersklassenRepository;
            _teilnehmerRepository = teilnehmerRepository;
        }

        public async Task<Response<List<DopingModel>>> GetList(Filter filter, CancellationToken cancellationToken)
        {
            try
            {
                // Select Randomly From Teilnehmer
                var resultList = _teilnehmerRepository.GetQueryable().GroupBy(x => x.Verband)
                    .Select(y => new DopingModel() { TeilnehmerName = y.First().Name, TeilnehmerVerband = y.First().Verband, TeilnehmerIstGewicht = y.First().IstGewicht }).OrderBy(r => Guid.NewGuid());

                // Pagination
                var result = resultList.Skip((filter.PageIndex - 1) * filter.PageSize)
                    .Take(filter.PageSize).ToList();
                return new Response<List<DopingModel>>()
                {
                    Data = result,
                    Success = true,
                    PageIndex = filter.PageIndex,
                    PageSize = filter.PageSize,
                    TotalRecords = resultList.Count()
                };
            }
            catch (Exception ex)
            {

                return new Response<List<DopingModel>>()
                {
                    Data = new List<DopingModel>(),
                    Success = false,
                    PageIndex = filter.PageIndex,
                    PageSize = filter.PageSize,
                    TotalRecords = 0,
                    ErrorMessage = ex.Message
                };
                // We Can Log Err Here
            }

        }
    }
}
