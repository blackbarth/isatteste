using System.Collections.Generic;
using AnalProg.Domain.Entities;

namespace AnalProg.Application.Interfaces
{
    public interface IProdutoAppService : IAppServiceBase<Produto>
    {
        IEnumerable<Produto> BuscarPorNome(string nome);
    }
}