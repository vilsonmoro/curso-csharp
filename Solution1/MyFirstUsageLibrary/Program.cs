using BibliotecaDeArquivosDoWindows;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstUsageLibrary
{
    class Program
    {
        static void Main(string[] args)
        {
            GetFiles gf = new GetFiles();

            imprimirArquivos(gf.RetornaArquivosImagesFiles());

            imprimirArquivos(gf.RetornaArquivosGit());

            imprimirArquivos(gf.RetornaArquivosImagesFiles());
        }

        static void imprimirArquivos(string[] lista)
        {
            if (lista == null)
            {
                Console.WriteLine("Não existem dados para exibir");
            }
            else
            {
                for (int i = 0; i < lista.Length; i++)
                {
                    Console.WriteLine(lista[i]);
                }
            }
            Console.ReadKey();
        }
    }
}
