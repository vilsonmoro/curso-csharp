using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        //Iniciando ua constante d um numero inteiro
        const int testeConst = 999;
        static void Main(string[] args)
        {
            string testePrimitivo = string.Empty;
            String outroTesteprimitivo = string.Empty;
            bool testComp = "123" == "123";
            Boolean tesstComp = "123" == "123";


            var testeFora = string.Empty;
            testeFora = "teste";

            var teste1 = "String"; //Testo
            var teste2 = 'A'; // Char
            var teste3 = 8; // Int
            var teste4 = 3.8; //Bouble
            var teste5 = 0x0f; //Hex
            //Apresentando a const
            Console.WriteLine(testeConst);
            Console.ReadKey();
        }
       


    }
}
