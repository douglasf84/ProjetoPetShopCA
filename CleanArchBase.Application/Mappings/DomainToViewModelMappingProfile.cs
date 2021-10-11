using AutoMapper;
using CleanArchBase.Application.ViewModels;
using CleanArchBase.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchBase.Application.Mappings
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public DomainToViewModelMappingProfile()
        {
            CreateMap<Produto, ProdutoViewModel>();
            CreateMap<Categoria, CategoriaViewModel>();
            CreateMap<ClientePF, ClientePFViewModel>();
            CreateMap<ClientePJ, ClientePJViewModel>();
            CreateMap<Endereco, EnderecoViewModel>();
            CreateMap<Estoque, EstoqueViewModel>();
            CreateMap<Marca, MarcaViewModel>();
            CreateMap<Modelo, ModeloViewModel>();
        }
    }
}
