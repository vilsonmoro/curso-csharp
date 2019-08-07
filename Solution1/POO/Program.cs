using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] lista = new string[5, 2];
            Nomes nomes = new Nomes();
            nomes.CarregaInformacoesEListaElasEmTela(lista);
            nomes.listarDados(lista);
            Console.ReadKey();
        }
    }
}
