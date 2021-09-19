using Business.Models;
using System;
using System.Threading.Tasks;

namespace Business.Interfaces
{
    public interface IFornecedorRepository : IRepository<Fornecedor>
    {
        Task<Fornecedor> ObterFornecedorEEndereco(Guid id);
        Task<Fornecedor> ObterFornecedorProdutosEEndereco(Guid id);
    }
}
