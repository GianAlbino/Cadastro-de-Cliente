using System;
using System.ComponentModel;
using System.Linq;
using System.Reflection;

namespace Teste_LG
{
    public class Util
    {
        public static string GetDescription(Enum value)
        {
            return value
                .GetType()
                .GetMember(value.ToString())
                .FirstOrDefault()
                ?.GetCustomAttribute<DescriptionAttribute>()
                ?.Description;
        }
    }
}
