using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1._5
{
    class Program
    {
        static void Main(string[] args)
        {
            var primeiroTexto = "Oi meu nome é Filipe e logo eu Filipe tenho vntade de codr" +
                "ar muito poruq eu  Felipe  gosto de codar durante miha vida";
            Console.WriteLine(primeiroTexto);Console.Witeline($"Texto contem: {primeiroTexto.Length}carateres".);

            primeiroTexto = primeiroTexto.Replace("Felipe", "1")Replace("Colar").Replac("ou", "3");
        }
    }
}
