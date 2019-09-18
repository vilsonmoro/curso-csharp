using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodosCalculadora
{
   public class Calculadora
    {
        static void Main(string[] args)
        {
        }

       static public double somar(double n1, double n2)
        {
            return n1 + n2;
        }

        public double subtrair(double n1, double n2)
        {
            return n1 - n2;
        }

        public double multiplicar(double n1, double n2)
        {
            return n1 * n2;
        }

        public double dividr(double n1, double n2)
        {
            return n1 / n2;
        }
    }
}
