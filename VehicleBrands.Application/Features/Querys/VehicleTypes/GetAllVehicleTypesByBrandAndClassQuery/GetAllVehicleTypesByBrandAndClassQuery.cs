using MasterServicesFZ.Domain;
using MediatR;

namespace MasterServicesFZ.Application.Features.Querys.VehicleTypes.GetAllVehicleTypesByBrandAndClassQuery
{
    public class GetAllVehicleTypesByBrandAndClassQuery : IRequest<List<VehicleType>>
    {
        public string ClassId { get; set; } = string.Empty;
        public string BrandId { get; set; } = string.Empty;

        public GetAllVehicleTypesByBrandAndClassQuery(string classId, string brandId)
        {
            BrandId = brandId ?? throw new ArgumentNullException(nameof(brandId));
            ClassId = classId ?? throw new ArgumentNullException(nameof(classId));
        }
    }
}
