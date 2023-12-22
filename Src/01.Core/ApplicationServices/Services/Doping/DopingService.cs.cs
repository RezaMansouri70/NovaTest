

using Application.Models.General;
using ApplicationServices.Model;
using ApplicationServices.Model.Doping;
using ApplicationServices.Services.DopingService;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ApplicationServices.Services.Doping
{

    public class DopingService : IDopingService
    {
        public async Task<Response<List<DopingModel>>> GetList(Filter filter, CancellationToken cancellationToken)
        {
            var data = new List<DopingModel>() { new DopingModel() { TeilnehmerName = "Reza" } };
            return new Response<List<DopingModel>>()
            {
                Data = data,
                Success = true,
                PageIndex = filter.PageIndex,
                PageSize = filter.PageSize,
                TotalRecords = data.Count()
            };
        }
    }
}
