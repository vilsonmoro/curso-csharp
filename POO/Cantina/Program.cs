using Cantina.Classes;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Cantina
{
    class Program
    {
        static List<Lanche> listaLanche = new List<Lanche>();
        static void Main(string[] args)
        {
            var op = 1;
            while(op != 4)
            {
                op = menu();
                switch(op)
                {
                    case 1: inserir(); break;
                    case 2: listar(); break;
                    case 3:
                        {
                            Console.WriteLine("Informe o nome do lanche que deseja excluir");
                            excluir(Console.ReadLine()); break;
                        }                   
                }
            }
            
            Console.ReadKey();
        }

        private static void inserir()
        {
            Console.WriteLine("Informe nome, quantidade e preço");
            listaLanche.Add(new Lanche() { Nome = Console.ReadLine(),
                                           Quantidade = Convert.ToInt32(Console.ReadLine()),
                                           Valor = Convert.ToDouble(Console.ReadLine())
                                          });
        }

        static void excluir(string lanche)
        {
            //excluir item conforme quantidade
            foreach (Lanche item in listaLanche)
                if (item.Nome.ToLower() == lanche.ToLower())
                {
                    listaLanche.Remove(item);
                    break;
                }
        }

        static void listar()
        {
            Console.WriteLine(" Display de dados");
            foreach (Lanche item in listaLanche)
            {
                Console.WriteLine($"Nome: {item.Nome}");
                Console.WriteLine($"Qtde: {item.Quantidade}");
                Console.WriteLine($"Valor: {item.Valor}\n");
            }
            Console.ReadKey();
        }


        static int menu()
        {
            Console.Clear();
            Console.WriteLine("1 - Inserir ");
            Console.WriteLine("2 - Listar ");
            Console.WriteLine("3 - Excluir ");
            Console.WriteLine("4 - Sair");

            Console.WriteLine("Informe uma opção: ");
            int.TryParse(Console.ReadLine(), out int opcao);
            return opcao;

        }
    }
}
