using AwesymeGym.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AwesymeGym.Core.Entities
{
    public class Funcionario
    {
        protected Funcionario() { }
        public Funcionario(string nomeCompleto, DateTime dataInicio)
        {
            NomeCompleto = nomeCompleto;
            DataInicio = dataInicio;
            CadastradoEm = DateTime.Now;
            Status = StatusFuncionarioEnum.Ativo;
        }

        public int Id { get; private set; }
        public string NomeCompleto { get; private set; }
        public DateTime DataInicio { get; private set; }
        public DateTime? DataFim { get; private set; }
        public DateTime CadastradoEm { get; private set; }
        public StatusFuncionarioEnum Status { get; private set; }
    }
}

