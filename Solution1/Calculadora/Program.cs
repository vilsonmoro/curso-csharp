﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    public class Calculos
    {

        public void somar(int x, int y)
        {
            Console.WriteLine($"A soma dos numeros {x} 3 {y} é = {x+y}");
        }

        public void multiplicar(int x, int y)
        {
            Console.WriteLine($"O produto dos numeros {x} 3 {y} é = {x + y}");
        }


        public void subtracao(int x, int y)
        {
            Console.WriteLine($"A subtraçaõ dos numeros {x} 3 {y} é = {x + y}");
        }

        public void divisao(int x, int y)
        {
            if (y < 1){
                Console.WriteLine("Não é possivel dividir por Zero");
                return;
            }
            Console.WriteLine($"A divisão dos numeros {x} 3 {y} é = {x + y}");
        }
    }

}
