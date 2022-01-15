using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Teste_LG
{
    public enum EnumRelacionamento
    {
        [Description("Pai")]
        Pai = 0,
        [Description("Mãe")]
        Mae = 1,
        [Description("Irmão")]
        Irmao = 2,
        [Description("Amigo")]
        Amigo = 3,
        [Description("Outros")]
        Outros = 4
    }
}
