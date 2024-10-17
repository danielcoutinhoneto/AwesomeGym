using AwesymeGym.Core.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AwesymeGym.Core.Interfaces.Services
{
    public interface IErpIntegrationService
    {
        Task AdicionarPessoa(AdicionarPessoaErpDTO pessoa);
    }
}
