﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AwesymeGym.Core.DTOs
{
    public class ResultadoInscricaoDTO
    {
        public ResultadoInscricaoDTO(bool sucesso, string mensagem)
        {
            Sucesso = sucesso;
            Mensagem = mensagem;
        }

        public bool Sucesso { get; private set; }
        public string Mensagem { get; private set; }
    }
}
