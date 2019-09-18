using System;

namespace LibraryContas
{
    public class Juros
    {
        
        static public double somar(double n1, double n2)
        {
            return n1 + n2;
        }

        public  static double subtrair(double n1, double n2)
        {
            return n1 - n2;
        }

        public static double multiplicar(double n1, double n2)
        {
            return n1 * n2;
        }

        public static double dividr(double n1, double n2)
        {
            return n1 / n2;
        }

        public static double desconto(double valor, double taxa)
        {
            return valor - (valor * (taxa/100));
        }

    }
}
