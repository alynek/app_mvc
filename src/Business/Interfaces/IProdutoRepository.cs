using Business.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Business.Interfaces
{
    public interface IProdutoRepository : IRepository<Produto>
    {
        Task<IEnumerable<Produto>> ObterProdutosPorFornecedor(Guid FornecedorId);
        Task<IEnumerable<Produto>> ObterProdutosEFornecedores();
        Task<Produto> ObterProdutoEFornecedor(Guid id);
    }
}
