using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco.Classes
{
    class Conta
    {
        private double saldo;
        public double Saldo { get { return saldo; } }
         
        public Conta()
        {
            saldo = 1000;
        }

        public void sacar(double valor)
        {
            if (saldo >= valor)
            {
                saldo -= valor;
            }
            else
            {
                Console.WriteLine("Sem saldo disponivel para realiza a operação");
            }
        }

        public void mostraSaldo()
        {
            Console.WriteLine($"Saldo disponivel: {saldo.ToString("N2")}");
        }
    }
}
