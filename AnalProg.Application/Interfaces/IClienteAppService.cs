using System.Collections.Generic;
using AnalProg.Domain.Entities;

namespace AnalProg.Application.Interfaces
{
    public interface IClienteAppService : IAppServiceBase<Cliente>
    {
        IEnumerable<Cliente> ObterClientesEspeciais();
    }
}