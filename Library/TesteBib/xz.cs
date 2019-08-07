using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteBib
{
   public class xz
    {
        public void MetodoXZ()
        {
            Console.WriteLine("testando classe interna");
            Console.ReadKey();
        }

        public double Somar(double n1, double n2)
        {
            return n1 + n2;
        }

        public double AreaRetangulo(double ladoA, double ladoB)
        {
            return ladoA * ladoB;
        }
        /// <summary>
        /// A=L²*V3/4;
        /// </summary>
        /// <param name="lado"></param>
        /// <returns></returns>
        public double areaEquilatero(int lado) {
            var l = (lado * lado);   //L²  
            var raiz = Math.Sqrt(3); //V3 extrai a raiz quadrada de 3 
            var area = (l * raiz) / 4; //dividi resultado por 4
            return area;
        }

        public double areaEquilatero2(int lado, int altura)
        {
            var area = ( lado * altura) / 2; //dividi resultado por 4
            return area;
        }


    }
}
