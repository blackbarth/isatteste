using System.Collections.Generic;
using AnalProg.Domain.Entities;

namespace AnalProg.Domain.Interfaces.Repositories
{
    public interface IProdutoRepository : IRepositoryBase<Produto>
    {
        IEnumerable<Produto> BuscarPorNome(string nome);
    }
}