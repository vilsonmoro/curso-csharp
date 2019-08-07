using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modificadores
{
    class Program
    {
        static void Main(string[] args)
        {
            Teste x = new Teste();
            x.showAge();

            x.refreshAge(55);
            x.showAge();

            ahahah(ref x);

            //ahahah(ref );

           // Teste y = new Teste(43);
          //  y.showAge();     
            
        }

        public static void ahahah(ref Teste pX)
        {
              pX.showAge();
        }
    }

    public partial class Teste
    {
        public int idade = 0;
    }

    public partial class Teste
    {
        public Teste()
        {
            this.idade = 0;
        }

        public Teste(int pIdade)
        {
            this.idade = pIdade;
        }
    }

}
