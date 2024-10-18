using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AwesymeGym.Core.Entities
{
    public class ExameMedico
    {
        protected ExameMedico() { }

        public ExameMedico(int alunoId, DateTime dataExame, DateTime validade, string tipoExame, string resultados, string nomeMedico, string crmMedico)
        {
            AlunoId = alunoId;
            DataExame = dataExame;
            Validade = validade;
            TipoExame = tipoExame;
            Resultados = resultados;
            NomeMedico = nomeMedico;
            CrmMedico = crmMedico;
        }

        public int Id { get; private set; } 
        public int AlunoId { get; private set; }
        public Aluno Aluno { get; private set; }
        public DateTime DataExame { get; private set; } 
        public DateTime Validade { get; private set; } 
        public string TipoExame { get; private set; } 
        public string Resultados { get; private set; } 
        public string NomeMedico { get; private set; } 
        public string CrmMedico { get; private set; } 
        public string Observacoes { get; private set; } 

        public void AtualizarExame(DateTime dataExame, DateTime validade, string tipoExame, string resultados, string nomeMedico, string crmMedico, string observacoes)
        {
            DataExame = dataExame;
            Validade = validade;
            TipoExame = tipoExame;
            Resultados = resultados;
            NomeMedico = nomeMedico;
            CrmMedico = crmMedico;
            Observacoes = observacoes;
        }
    }
}
