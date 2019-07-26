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

            string[] listaDoc = gf.RetornaArquivosDoMeuDocumentos();

            for (int i = 0; i < listaDoc.Length; i++)
            {
                Console.WriteLine(listaDoc[i]);   
            }

            Console.ReadKey();
        }
    }
}
