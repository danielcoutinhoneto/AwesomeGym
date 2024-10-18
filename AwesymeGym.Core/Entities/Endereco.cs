namespace AwesymeGym.Core.Entities
{
    public class Endereco
    {
        protected Endereco() { }
        public Endereco(string logradouro, string complemento, int numero, string bairro, string cidade, string estado, string cep, string pais)
        {
            Logradouro = logradouro;
            Complemento = complemento;
            Numero = numero;
            Bairro = bairro;
            Cidade = cidade;
            Estado = estado;
            CEP = cep;
            Pais = pais;
        }

        public int Id { get; private set; }
        public string Logradouro { get; private set; }
        public string Complemento { get; private set; }
        public int Numero { get; private set; }
        public string Bairro { get; private set; }
        public string Cidade { get; private set; }
        public string Estado { get; private set; }
        public string CEP { get; private set; }
        public string Pais { get; private set; }
    }
}