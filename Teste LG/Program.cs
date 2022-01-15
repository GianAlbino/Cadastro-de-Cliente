using System;
using System.Collections.Generic;
using System.Linq;

namespace Teste_LG
{
    class Program
    {
        private static readonly List<Contato> Contatos = new List<Contato>();

        static void Main()
        {
            Popular();
        }

        private static void Popular()
        {
            AddContatos(new Contato
            {
                Codigo = 6736,
                Nome = "Claudio",
                NumeroTelefone = "+55 22 9 2222-2222",
                Relacionamento = EnumRelacionamento.Pai
            });

            AddContatos(new Contato
            {
                Codigo = 3424,
                Nome = "Maria",
                NumeroTelefone = "+55 22 9 2222-2222",
                Relacionamento = EnumRelacionamento.Mae
            });

            AddContatos(new Contato
            {
                Codigo = 2123,
                Nome = "Nelson",
                NumeroTelefone = "+55 55 9 5555-5555",
                Relacionamento = EnumRelacionamento.Irmao
            });

            AddContatos(new Contato
            {
                Codigo = 9124,
                Nome = "André",
                NumeroTelefone = "+55 66 9 6666-6666",
                Relacionamento = EnumRelacionamento.Irmao
            });

            AddContatos(new Contato
            {
                Codigo = 9849,
                Nome = "Miranda",
                NumeroTelefone = "+55 77 9 7777-7777",
                Relacionamento = EnumRelacionamento.Amigo
            });

            AddContatos(new Contato
            {
                Codigo = 8975,
                Nome = "Kaue",
                NumeroTelefone = "+55 77 9 7777-7777",
                Relacionamento = EnumRelacionamento.Amigo
            });

            var cliente = new Cliente
            {
                Nome = "João",
                CpfCnpj = "11.111.111/0001-11",
                NumeroTelefone = "+55 11 9 1111-1111",
                Contatos = OrderByCodigo()
            };

            Console.WriteLine($"Nome do Cliente: " +
                $"{cliente.Nome}");
            Console.WriteLine($"CPF/CNPJ do Cliente: " +
                $"{cliente.CpfCnpj}");
            Console.WriteLine($"Telefone do Cliente: " +
                $"{cliente.NumeroTelefone}");

            Console.WriteLine();
            Console.WriteLine("Contatos:");

            foreach (var contato in cliente.Contatos)
            {
                Console.WriteLine($"Código do Contato: " +
                    $"{contato.Codigo}");
                Console.WriteLine($"Nome do Contato: " +
                    $"{contato.Nome}");
                Console.WriteLine($"Telefone do Contato: " +
                    $"{contato.NumeroTelefone}");
                Console.WriteLine($"Relacionamento do Contato: " +
                    $"{Util.GetDescription(contato.Relacionamento)}");

                Console.WriteLine();
            }
        }

        private static void AddContatos(Contato contato)
        {
            if(VerificarDuplicidade(contato.NumeroTelefone, 
                contato.Relacionamento) == false)
            {
                Contatos.Add(contato);
            }
            else
            {
                Console.WriteLine($"Contato {contato.Nome} duplicado");
                Console.WriteLine();
            }
        }

        private static bool VerificarDuplicidade(string numeroTelefone,
            EnumRelacionamento relacionamento)
        {
            var contato = Contatos.Find(x => x.NumeroTelefone == numeroTelefone 
            && x.Relacionamento == relacionamento);

            if(contato != null)
            {
                return true;
            }

            return false;
        }

        private static List<Contato> OrderByCodigo()
        {
            var listOrdenada = Contatos.OrderBy(x => x.Codigo).ToList();

            return listOrdenada;
        }
    }
}
