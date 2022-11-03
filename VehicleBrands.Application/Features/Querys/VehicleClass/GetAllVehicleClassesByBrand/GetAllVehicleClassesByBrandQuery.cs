using MasterServicesFZ.Application.Features.Shared.VMs;
using MediatR;

namespace MasterServicesFZ.Application.Features.Querys.VehicleClass.GetAllVehicleClassesByBrand
{
    public class GetAllVehicleClassesByBrandQuery : IRequest<List<GenericResponseVM>>
    {
        public string _BrandId { get; set; } = String.Empty;

        public GetAllVehicleClassesByBrandQuery(string brandId)
        {
            _BrandId = brandId ?? throw new ArgumentNullException(nameof(brandId));
        }
    }
}
