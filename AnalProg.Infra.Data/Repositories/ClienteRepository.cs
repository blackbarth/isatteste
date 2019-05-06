using AnalProg.Domain.Entities;
using AnalProg.Domain.Interfaces.Repositories;

namespace AnalProg.Infra.Data.Repositories
{
    public class ClienteRepository : RepositoryBase<Cliente>, IClienteRepository
    {
    }
}