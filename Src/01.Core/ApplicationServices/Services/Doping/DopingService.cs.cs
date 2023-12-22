

using ApplicationServices.Model;
using ApplicationServices.Model.Doping;
using ApplicationServices.Services.DopingService;

namespace ApplicationServices.Services.Doping
{

    public class DopingService : IDopingService
    {
        public async Task<Response<List<DopingModel>>> GetList(CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
