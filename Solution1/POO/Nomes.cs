using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    class Nomes
    {
        
        public void CarregaInformacoesEListaElasEmTela(string [,] arrayBi)
        {
            for (int i = 0; i < arrayBi.GetLength(0); i++)
            {
                arrayBi[i, 0] = i.ToString();
                arrayBi[i, 1] = $"Felipe_{i}";
            }
        }

        public void listarDados(string[,] arrayBi)
        {
            for (int i = 0; i < arrayBi.GetLength(0); i++)
            {
                Console.WriteLine($"ID:{arrayBi[i, 0]} - Nome:{arrayBi[i, 1]}");
            }

        }
    }
}
