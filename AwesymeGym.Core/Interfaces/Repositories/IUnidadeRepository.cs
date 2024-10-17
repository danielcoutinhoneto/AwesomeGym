using AwesymeGym.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AwesymeGym.Core.Interfaces.Repositories
{
    public interface IUnidadeRepository
    {
        Task<int> Adicionar(Unidade unidade);
        Task<List<Unidade>> ObterTodos();
        Task<Unidade> ObterPorId(int id);
    }
}
