using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeclareVAriaveis
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome = "Vilson", sobrenome = "Moro";

            //variavel array dimensional
            string[] cores = new string[]
            {
                "azul", "preto", "branco", "azul"
            };

            //array bidimensional
            string[,] tabuleiro = new string[2, 3];
            tabuleiro[0, 0] = "bispo";
            tabuleiro[0, 1] = "cavalo";
            tabuleiro[0, 2] = "peao";

            tabuleiro[1, 0] = "rainha";
            tabuleiro[1, 1] = "torre";
            tabuleiro[1, 2] = "rei";

            for (int i = 0; i < tabuleiro.GetLength(0); i++) //getLenght retorna tamanho das linhas
            {
                Console.WriteLine(tabuleiro[i, 0]);
                Console.WriteLine(tabuleiro[i, 1]);
                Console.WriteLine(tabuleiro[i, 2]);
                Console.WriteLine("---");
            }

            //inicializando a matriz
            string[,] contato = new string[,]
            {
                {"vilson", "98851-1764" },
                {"Barbara", "99160-2373" },
                {"Bruna", "98851-2594" },
                {"bia", "98851-0852" }

            };

            for (int i = 0; i < contato.GetLength(0); i++) //getLenght retorna tamanho das linhas
            {
                Console.WriteLine(contato[i, 0]);
                Console.WriteLine(contato[i, 1]);
                Console.WriteLine(contato[i, 2]);
                Console.WriteLine("---");
            }

            Console.ReadKey();
        }
    }
}
