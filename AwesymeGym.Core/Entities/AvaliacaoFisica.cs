using AwesymeGym.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AwesymeGym.Core.Entities
{
    public class AvaliacaoFisica
    {
        protected AvaliacaoFisica() { }
        public AvaliacaoFisica(int alunoId, DateTime dataAvaliacao, int peso, int altura, string observacoes)
        {
            AlunoId = alunoId;
            DataAvaliacao = dataAvaliacao;
            Peso = peso;
            Altura = altura;
            IMC = CalcularIMC(peso, altura);
            Observacoes = observacoes;
        }

        public int Id { get; private set; }
        public int AlunoId { get; private set; }
        public DateTime DataAvaliacao { get; private set; }
        public int Peso { get; private set; }
        public int Altura { get; private set; }
        public double IMC { get; private set; }
        public string Observacoes { get; private set; }

        public void AtualizarAvaliacao(int peso, int altura, string observacoes)
        {
            Peso = peso;
            Altura = altura;
            IMC = CalcularIMC(peso, altura);
            Observacoes = observacoes;
        }

        private double CalcularIMC(int peso, int altura)
        {
            // IMC = Peso(kg) / (Altura(m) * Altura(m))
            // Convertendo altura de cm para metros
            double alturaEmMetros = altura / 100.0;
            return Math.Round(peso / (alturaEmMetros * alturaEmMetros), 2);
        }
    }
}
