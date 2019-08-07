using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Execicio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe sua idade: ");
            int.TryParse(Console.ReadLine(), out int idade);

            if (idade < 18)
            {
                Console.WriteLine("Você e menor de idade e não pode ingerir bebidas alcoolicas.");
            }
            else
                Console.WriteLine("Vai beber pinguço");

            Console.ReadKey();

        }
    }
}
