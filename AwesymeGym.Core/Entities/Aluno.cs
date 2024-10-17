using AwesymeGym.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AwesymeGym.Core.Entities
{
    public class Aluno
    {
        protected Aluno() { }
        public Aluno(string nomeCompleto, string observacoesMedicas, DateTime dataNascimento)
        {
            NomeCompleto = nomeCompleto;
            ObservacoesMedicas = observacoesMedicas;
            DataNascimento = dataNascimento;
            Status = StatusAlunoEnum.Ativo;
        }

        public int Id { get; private set; }
        public string NomeCompleto { get; private set; }
        public string ObservacoesMedicas { get; private set; }
        public DateTime DataNascimento { get; private set; }
        public StatusAlunoEnum Status { get; private set; }
    }

}

