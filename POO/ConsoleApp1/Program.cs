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
            CustomList c = new CustomList();
            for (int i = 0; i < 10; i++)
            {
                c.Add(i * 10);
            }

            //
            for (int i = 0; i < 10; i++)
            {

                Console.WriteLine($"valor {c[i]}");
            }
            Console.ReadKey();
        }
    }
}
