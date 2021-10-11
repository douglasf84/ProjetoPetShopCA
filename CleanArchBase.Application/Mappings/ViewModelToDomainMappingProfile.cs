using AutoMapper;
using CleanArchBase.Application.ViewModels;
using CleanArchBase.Domain.Entities;

namespace CleanArchBase.Application.Mappings
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public ViewModelToDomainMappingProfile()
        {
            CreateMap<CategoriaViewModel, Categoria>();
            CreateMap<ClientePFViewModel, ClientePF>();
            CreateMap<ClientePJViewModel, ClientePJ>();
            CreateMap<EnderecoViewModel, Endereco>();
            CreateMap<EstoqueViewModel, Estoque>();
            CreateMap<MarcaViewModel, Marca>();
            CreateMap<ModeloViewModel, Modelo>();
            CreateMap<ProdutoViewModel, Produto>();
        }
    }
}
