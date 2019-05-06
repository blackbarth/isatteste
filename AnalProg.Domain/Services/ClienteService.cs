using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AnalProg.Domain.Entities;
using AnalProg.Domain.Interfaces.Repositories;
using AnalProg.Domain.Interfaces.Services;

namespace AnalProg.Domain.Services
{
    public class ClienteService : ServiceBase<Cliente>, IClienteService
    {
        private readonly IClienteRepository _clienteRepository;

        public ClienteService(IClienteRepository clienteRepository)
            : base(clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }

        public IEnumerable<Cliente> ObterClientesEspeciais(IEnumerable<Cliente> clientes)
        {
            return null; //clientes.Where(c => c.ClienteEspecial(c));
        }
    }
}
