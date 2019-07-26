using System;
namespace Modificadores
{
    public partial class Teste
    {
        public void showAge()
        {
            Console.WriteLine("Idade " + this.idade);
            Console.ReadKey();
        }

        public void refreshAge(int pIdade)
        {
            this.idade = pIdade;
        }
    }
}