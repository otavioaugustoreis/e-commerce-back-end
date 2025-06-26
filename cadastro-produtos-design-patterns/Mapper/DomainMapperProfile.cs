using AutoMapper;
using Cadastro.Domain.Entities;
using cadastro_produtos_design_patterns.Model.Request;
using cadastro_produtos_design_patterns.Model.Response;

namespace cadastro_produtos_design_patterns.Mapper
{
    public class DomainMapperProfile : Profile
    {
        public DomainMapperProfile()
        {
            CreateMap<UsuarioEntity, UsuarioModelRequest>().ReverseMap();
            CreateMap<UsuarioModelRequest, UsuarioModelResponse>().ReverseMap();
            CreateMap<UsuarioEntity, UsuarioModelResponse>().ReverseMap();
            
            CreateMap<LoginEntity, LoginModelRequest>().ReverseMap();
            CreateMap<LoginEntity, LoginModelResponse>().ReverseMap();
        }
    }
}
