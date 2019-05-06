using System.Collections.Generic;
using System.Linq;
using AnalProg.Domain.Entities;
using AnalProg.Domain.Interfaces.Repositories;

namespace AnalProg.Infra.Data.Repositories
{
    public class ProdutoRepository : RepositoryBase<Produto>, IProdutoRepository
    {
        public IEnumerable<Produto> BuscarPorNome(string nome)
        {
            return Db.Produtos.Where(p => p.Nome == nome);
        }
    }
}