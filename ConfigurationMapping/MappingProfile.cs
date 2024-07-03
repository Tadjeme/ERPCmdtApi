using aApprosModels.ModelsAppros;
using aApprosModels.ModelsBase;
using AutoMapper;
using ERPCmdtApi.ViewModelsAppro;
namespace ERPCmdtApi.ConfigurationMapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile() 
        {
            CreateMap<Campagne, CampagneVm>()
                .ReverseMap();

            CreateMap<AppelOffre, AppelOffreVm>()
                .ForMember(dest =>dest.IdCampagne, opt =>opt.MapFrom(src => src.Campagne.Id))
                .ForMember(dest => dest.LibelleCampagne, opt => opt.MapFrom(src => src.Campagne.Libelle))
                .ReverseMap();
            CreateMap<Contrat, ContratVm>()
                 .ForMember(dest => dest.IdAppelOffres, opt => opt.MapFrom(src => src.AppelOffre.Id))
                 .ForMember(dest => dest.NoAppelOffre, opt => opt.MapFrom(src => src.AppelOffre.NoAppelOffre))
                 .ReverseMap();
        }
    }
}
