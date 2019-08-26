using ApiRestBoasPraticas.Business.Interfaces;
using ApiRestBoasPraticas.Business.Models;
using ApiRestBoasPraticas.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ApiRestBoasPraticas.Data.Repository
{
    public class EnderecoRepository : Repository<Endereco>, IEnderecoRepository
    {
        private readonly ApiContextoDb _apiContextoDb;

        public EnderecoRepository(ApiContextoDb apiContextoDb) : base(apiContextoDb)
        {
            _apiContextoDb = apiContextoDb;
        }
        public async Task<Endereco> ObterEnderecoPorFornecedor(Guid fornecedorId)
        {
            return await Db.Enderecos.AsNoTracking()
                .FirstOrDefaultAsync(f => f.FornecedorId == fornecedorId);
        }

    }
}
