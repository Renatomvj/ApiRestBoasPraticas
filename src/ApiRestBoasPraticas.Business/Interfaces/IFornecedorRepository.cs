using ApiRestBoasPraticas.Business.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ApiRestBoasPraticas.Business.Interfaces
{
  
        public interface IFornecedorRepository : IRepository<Fornecedor>
        {
            Task<Fornecedor> ObterFornecedorEndereco(Guid id);
            Task<Fornecedor> ObterFornecedorProdutosEndereco(Guid id);
        }
  
}
