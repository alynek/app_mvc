using Business.Interfaces;
using Business.Models;
using Data.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Threading.Tasks;

namespace Data.Repository
{
    public class FornecedorRepository : Repository<Fornecedor>, IFornecedorRepository
    {
        public FornecedorRepository(AppDbContext db) : base(db) {}
        public async Task<Fornecedor> ObterFornecedorEEndereco(Guid id)
        {
            return await Db.Fornecedores.AsNoTracking()
                .Include(e => e.Endereco)
                .FirstOrDefaultAsync(f => f.Id == id);
        }

        public async Task<Fornecedor> ObterFornecedorProdutosEEndereco(Guid id)
        {
            return await Db.Fornecedores.AsNoTracking()
                .Include(p => p.Produto)
                .Include(e => e.Endereco)
                .FirstOrDefaultAsync(f => f.Id == id);
        }
    }
}
