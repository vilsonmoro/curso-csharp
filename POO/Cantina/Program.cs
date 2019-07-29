using Cantina.Classes;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Cantina
{
    class Program
    {
        static void Main(string[] args)
        {
            //declara a lista com o tipo de objeto que pode armazenar
            List<Lanche> listaLanche = new List<Lanche>();

            listaLanche.Add(new Lanche() {
                Nome = "Pastel",
                Quantidade = 10,
                Valor = 2.50
            });

            listaLanche.Add(new Lanche()
            {
                Nome = "Coxinha",
                Quantidade = 5,
                Valor = 4.50
            });

            listaLanche.Add(new Lanche()
            {
                Nome = "Empada",
                Quantidade = 15,
                Valor = 3
            });

            //percorre a lista e mostra todos os itens
            listar(ref listaLanche);


            //excluir item conforme quantidade
            foreach (Lanche item in listaLanche)
                if (item.Quantidade == 5)
                {
                    listaLanche.Remove(item);
                    break;
                }                   


            //percorre a lista e mostra todos os itens
            listar(ref listaLanche);

            //removendo usano metodo da lista e expressão lambda
            listaLanche.Remove(listaLanche.FirstOrDefault(x => x.Quantidade == 15));

            //listar novamente
            listar(ref listaLanche);

            Console.ReadKey();
        }

        static void listar(ref List<Lanche> lista)
        {
            Console.WriteLine(" Display de dados");
            foreach (Lanche item in lista)
            {
                Console.WriteLine($"Nome: {item.Nome}");
                Console.WriteLine($"Qtde: {item.Quantidade}");
                Console.WriteLine($"Valor: {item.Valor}\n");
            }
        }
    }
}
