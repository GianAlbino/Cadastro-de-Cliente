using System;
using System.Collections.Generic;
using System.Text;

namespace Teste_LG
{
    public class Contato
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public string NumeroTelefone { get; set; }
        public EnumRelacionamento Relacionamento { get; set; }
    }
}
