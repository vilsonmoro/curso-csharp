using Banco.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    class Program
    {
        static void Main(string[] args)
        {
            Conta conta = new Conta();

            conta.mostraSaldo();
            Console.ReadKey();

           // conta.Cpf = Console.ReadLine();

            Console.WriteLine(conta.Saldo);

            conta.sacar(2000);
            Console.ReadKey();

        }
    }
}
