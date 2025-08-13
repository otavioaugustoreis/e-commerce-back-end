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
            CreateMap<UsuarioEntity, UsuarioModelResponse>().ReverseMap();
            
            CreateMap<LoginEntity, LoginModelRequest>().ReverseMap();
            CreateMap<LoginEntity, LoginModelResponse>().ReverseMap();

            CreateMap<ProdutoEntity, ProdutoModelRequest>().ReverseMap();
            CreateMap<ProdutoEntity, ProdutoModelResponse>().ReverseMap();

            CreateMap<PedidoModelRequest, PedidoEntity>()
                 .ForMember(dest => dest.FkUsuario, opt => opt.MapFrom(src => src.FkUsuario))
                 .ForMember(dest => dest.PagamentoEntity, opt => opt.MapFrom(src => src.Pagamento))
                 .ForMember(dest => dest.PedidoItemEntity, opt => opt.MapFrom(src => src.FkProdutos))
                 .ReverseMap();
            
            CreateMap<PedidoEntity, PedidoModelResponse>().ReverseMap();

            CreateMap<PedidoItemEntity, PedidoItemModelRequest>().ReverseMap();
            CreateMap<PedidoItemEntity, PedidoItemModelResponse>().ReverseMap();

            CreateMap<PagamentoEntity, PagamentoModelRequest>().ReverseMap();
            CreateMap<PagamentoEntity, PagamentoModelResponse>().ReverseMap();

        }
    }
}
