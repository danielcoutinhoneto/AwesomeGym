using AwesymeGym.Core.Enums;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace AwesymeGym.Core.Entities
{
    public class Funcionario
    {
        protected Funcionario() { }
        public Funcionario(string nomeCompleto, string emailFuncionario, string cpf, DateTime dataInicio)
        {
            NomeCompleto = nomeCompleto;
            EmailFuncionario = emailFuncionario;
            CPF = cpf;
            DataInicio = dataInicio;
            CadastradoEm = DateTime.Now;
            Status = StatusFuncionarioEnum.Ativo;
        }

        public int Id { get; private set; }
        public string NomeCompleto { get; private set; }
        public string CPF { get; private set; }
        public DateTime DataNascimento { get; set; }
        public string Celular { get; set; }
        public string Telefone { get; private set; }
        public string EmailFuncionario { get; private set; }
        public DateTime DataInicio { get; private set; }
        public DateTime? DataFim { get; private set; }
        public DateTime CadastradoEm { get; private set; }
        public Endereco Endereco { get; private set; }
        public RegistroProfissional RegistroProfissional { get; private set; }
        public FucionariosEnum Funcionarios { get; private set; }
        public StatusFuncionarioEnum Status { get; private set; }

    }
}

