using AwesymeGym.Core.Enums;

namespace AwesymeGym.Core.Entities
{
    public class Aluno
    {
        protected Aluno() { }
        public Aluno(string nomeCompleto, string cpf, DateTime dataNascimento, string celular, string telefone, string emailAluno)
        {
            NomeCompleto = nomeCompleto;
            CPF = cpf;
            DataNascimento = dataNascimento;
            Celular = celular;
            Telefone = telefone;
            EmailAluno = emailAluno;
            Status = StatusAlunoEnum.Ativo;
        }

        public int Id { get; private set; }
        public string NomeCompleto { get; private set; }
        public string CPF { get; private set; }
        public DateTime DataNascimento { get; private set; }
        public string Celular { get; set; }
        public string Telefone { get; private set; }
        public string EmailAluno { get; private set; } 
        public ExameMedico ExameMedico { get; private set; }
        public Endereco Endereco { get; private set; }
        public StatusAlunoEnum Status { get; private set; }

        public List<ExameMedico> ExamesMedicos { get; private set; }

        public void AdicionarExameMedico(ExameMedico exame)
        {
            ExamesMedicos.Add(exame);
        }

    }

}

