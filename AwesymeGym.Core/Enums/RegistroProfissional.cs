using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AwesymeGym.Core.Enums
{
    public class RegistroProfissional
    {
        protected RegistroProfissional() { }
        public RegistroProfissional(string nomeCompleto, string numeroRegistro, string descricaoProfissional, string siglaProfissional)
        {
            NomeCompleto = nomeCompleto;
            NumeroRegistro = numeroRegistro;
            DescricaoProfissional = descricaoProfissional;
            SiglaProfissional = siglaProfissional;
        }

        public int Id { get; private set; }
        public string NomeCompleto { get; private set; }
        public string NumeroRegistro { get; private set; }
        public string DescricaoProfissional { get; private set; }
        public string SiglaProfissional { get; private set; }
    }
}
