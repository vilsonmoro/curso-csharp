using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace While
{
    class Program
    {
        static void Main(string[] args)
        {
            var tecla = solicitaDados();
            //Console.ReadKey();
            while (tecla == "1")
            {
                Console.WriteLine("Hello world!");
                //precisa ler a variavel de controle novamente
                tecla = solicitaDados();
            }     

        }

        public static string solicitaDados()
        {
            Console.WriteLine("");  
            Console.WriteLine("Deseja cadastrar? Sim(1) ");
            return Console.ReadKey().KeyChar.ToString();
        }
    }
}
