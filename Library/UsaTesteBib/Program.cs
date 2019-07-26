using CalculadoraShow;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TesteBib;

namespace UsaTesteBib
{
    class Program
    {
    /// <summary>
    /// Metodos Somar
    /// </summary>
    /// <param name="args">double numero1, double </param>
        static void Main(string[] args)
        {
            //variveis
            string nome = "10 breno";
            int idade = 10;
            int nacertis;

            //instancia de um objeto
            Class1 x = new Class1();
            x.Somar(10, 20);

            
            Class1 cbreno = new Class1();
           
            Console.WriteLine($"Soma { cbreno.Somar(20, 55)}");
            Console.WriteLine($"Soma { x.Somar(20, 10)}");
            

            Console.WriteLine($"Subtracao { cbreno.Diminuir(20, 55)}");
            Console.WriteLine($"Area triangulo { cbreno.areadoequilatero(20, 55)}");

            Console.ReadKey();
        }
    }
}
