using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestesVarious
{
    [AttributeUsage(AttributeTargets.Class)]
    public class Info : Attribute
    {
        static void Main(string[] args)
        {
          #if DEBUG
            Console.WriteLine("Debug version");
          #endif

          Console.ReadKey();
        }

    }
}
