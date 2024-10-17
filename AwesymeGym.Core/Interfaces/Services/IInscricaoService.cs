using AwesymeGym.Core.DTOs;
using AwesymeGym.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AwesymeGym.Core.Interfaces.Services
{
    public interface IInscricaoService
    {
        ResultadoInscricaoDTO Realizar(Aluno aluno, Unidade unidade, TurmaAtividade turmaAtividade);
    }
}
