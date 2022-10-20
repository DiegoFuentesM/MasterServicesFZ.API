using AutoMapper;
using MasterServicesFZ.Application.Features.Shared.VMs;
using MasterServicesFZ.Domain;

namespace MasterServicesFZ.Application.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<VehicleClassBrand, VehicleClassVM>();
        }

    }
}
