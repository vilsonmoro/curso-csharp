using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MetodosCalculadora;
using LibraryContas;

namespace UsaCalculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Calculadora.somar(10,20));
            Console.WriteLine(Juros.desconto(100, 10));
            Console.ReadKey();
        }
    }
}
