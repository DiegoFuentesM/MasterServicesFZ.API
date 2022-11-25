using AutoMapper;
using MasterServicesFZ.Application.Features.Shared.VMs;
using MasterServicesFZ.Domain;

namespace MasterServicesFZ.Application.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<VehicleClassBrand, GenericResponseVM>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.clase_vehiculo_id))
                .ForMember(dest => dest.Value, opt => opt.MapFrom(src => src.clasevehiculo));

            CreateMap<VehicleBrand, GenericResponseVM>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.id))
                .ForMember(dest => dest.Value, opt => opt.MapFrom(src => src.nombre));

            CreateMap<Department, GenericResponseVM>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.CodigoLP))
                .ForMember(dest => dest.Value, opt => opt.MapFrom(src => src.Nombre));

            CreateMap<Fee, GenericResponseVM>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.id))
                .ForMember(dest => dest.Value, opt => opt.MapFrom(src => src.tasa));

            CreateMap<IdentificactionType, GenericResponseVM>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.id))
                .ForMember(dest => dest.Value, opt => opt.MapFrom(src => src.nombre));

            CreateMap<Municipality, GenericResponseVM>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.CodigoLP))
                .ForMember(dest => dest.Value, opt => opt.MapFrom(src => src.Nombre));

            CreateMap<Occupation, GenericResponseVM>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.CodigoScr))
                .ForMember(dest => dest.Value, opt => opt.MapFrom(src => src.Descripcion));

            CreateMap<VehicleModel, GenericResponseVM>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.id))
                .ForMember(dest => dest.Value, opt => opt.MapFrom(src => src.modelovehiculo_id));

            CreateMap<VehicleType, GenericResponseVM>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.id))
                .ForMember(dest => dest.Value, opt => opt.MapFrom(src => src.tipo));

            CreateMap<ContractType, GenericResponseVM>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.CodigoScr))
                .ForMember(dest => dest.Value, opt => opt.MapFrom(src => src.Descripcion));

            CreateMap<AccountType, GenericResponseVM>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.TipoCuentaID))
                .ForMember(dest => dest.Value, opt => opt.MapFrom(src => src.Nombre));

            CreateMap<MaritalStatus, GenericResponseVM>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.CodigoScr))
                .ForMember(dest => dest.Value, opt => opt.MapFrom(src => src.Descripcion));

            CreateMap<ResidenceType, GenericResponseVM>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.CodigoScr))
                .ForMember(dest => dest.Value, opt => opt.MapFrom(src => src.Descripcion));

            CreateMap<InternationalBusiness, GenericResponseVM>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.id))
                .ForMember(dest => dest.Value, opt => opt.MapFrom(src => src.tipo_operacion));

            CreateMap<Profession, GenericResponseVM>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.id))
                .ForMember(dest => dest.Value, opt => opt.MapFrom(src => src.nombre));
            
            CreateMap<InitialPaymentOrigin, GenericResponseVM>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.Value, opt => opt.MapFrom(src => src.Descripcion));
        }

    }
}
