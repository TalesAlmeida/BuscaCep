﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsultaCepClient.Model
{
    public class ResultadoCep
    {
        public string Cep { get; set; }
        public string  Logradouro { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string Localidade { get; set; }
        public string Uf { get; set; }
        public string Unidade { get; set; }
        public string Ibge { get; set; }
        public string Gia { get; set; }
        
        public override string ToString()
        {
            return Cep+"\n"+Logradouro+"\n"+Bairro+"\n"+Localidade+"\n"+Uf+"\n"+Ibge;
        }

    }
}
