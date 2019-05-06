using System.Collections.Generic;
using AnalProg.Domain.Entities;

namespace AnalProg.Domain.Interfaces.Services
{
    public interface IProdutoService : IServiceBase<Produto>
    {
        IEnumerable<Produto> BuscarPorNome(string nome);
    }
}