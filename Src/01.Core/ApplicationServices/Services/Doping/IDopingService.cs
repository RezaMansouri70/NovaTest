

using ApplicationServices.Model;
using ApplicationServices.Model.Doping;

namespace ApplicationServices.Services.DopingService
{
    public interface IDopingService
    {
        Task<Response<List<DopingModel>>> GetList(CancellationToken cancellationToken);
    }
}
