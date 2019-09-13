using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arrayLinear = new string[2];
            arrayLinear[0] = "Felipe";
            arrayLinear[1] = "Giomar";

            List<string> listalinear = new List<string>
            {
                "Felipe",
                "Giomar",
                "Eiricledson"
            };
            Console.WriteLine(arrayLinear[0]);
            Console.WriteLine(listalinear[0]);
            Console.ReadKey(); 
        }
    }
}
