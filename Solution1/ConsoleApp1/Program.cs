using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculadora;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {


            Calculos ob = new Calculos();
            ob.somar(10, 20);
            somar(40, 50);
            Console.ReadKey();
        }

        static void somar(int x, int y)
        {
            Console.WriteLine($" Static A soma de {x} e {y} é: {x + y}");
        }
    }
}
