using System;
using System.Collections.Generic;
using System.Text;

namespace Teste_LG
{
   public  class Cliente
    {
        public string Nome { get; set; }
        public string CpfCnpj { get; set; }
        public string NumeroTelefone { get; set; }
        public List<Contato> Contatos { get; set; }
    }
}
