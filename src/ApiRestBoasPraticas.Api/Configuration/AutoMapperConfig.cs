using ApiRestBoasPraticas.Api.DTO;
using ApiRestBoasPraticas.Business.Models;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiRestBoasPraticas.Api.Configuration
{
    public class AutoMapperConfig : Profile
    {
        public AutoMapperConfig()
        {
            CreateMap<Fornecedor, FornecedorDTO>().ReverseMap();
            CreateMap<Endereco, EnderecoDTO>().ReverseMap();
            CreateMap<ProdutoImagemDTO, Produto>().ReverseMap();
            CreateMap<ProdutoDTO, Produto>().ReverseMap(); 
            CreateMap<Produto, ProdutoDTO>()
               .ForMember(dest => dest.NomeFornecedor, opt => opt.MapFrom(src => src.Fornecedor.Nome));
        }
    }
}
