using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesEscola.Classes
{

    public class Cadastro
    {
        string[,] arrayAlunos = new string[5, 5];
        Boletim ob_boletim = new Boletim();

        public void inserirAluno()
        {
            // for (int i = 0; i < arrayAlunos.Length; i++)
            for (int i = 0; i < 1; i++)
            {
                Console.WriteLine("Informe nome do aluno");
                var nome = Console.ReadLine();
                arrayAlunos[i, 0] = i.ToString();
                arrayAlunos[i, 1] = nome;
                //digita as notas do aluno
                var media = digitanotas();
                arrayAlunos[i, 2] = media.ToString();

                //verifica a frequencia
                var frequencia = informeFrequencia();
                arrayAlunos[i, 3] = frequencia.ToString();

                //informe situação
                arrayAlunos[i, 4] = ob_boletim.retornaSituacao(media, frequencia);
            }
        }

        int digitanotas()
        {
            Console.WriteLine("Informe nota 1 do aluno");
            int.TryParse(Console.ReadLine(), out int nota1);

            Console.WriteLine("Informe nota 2 do aluno");
            int.TryParse(Console.ReadLine(), out int nota2);

            Console.WriteLine("Informe nota 3 do aluno");
            int.TryParse(Console.ReadLine(), out int nota3);

            return ob_boletim.medias(nota1, nota2, nota3);
        }

        int informeFrequencia()
        {
            Console.WriteLine("Informe total de aulas");
            int.TryParse(Console.ReadLine(), out int totalAulas);

            Console.WriteLine("Informe numero de faltas");
            int.TryParse(Console.ReadLine(), out int faltas);
            return ob_boletim.frequencia(totalAulas, faltas);
        }
        public void listarAlunos()
        {
            Console.Clear();
            Console.WriteLine("-- Listagem de alunos -- \n");
            for (int i = 0; i < arrayAlunos.GetLength(0); i++)
            {
                Console.WriteLine($"ID........: {arrayAlunos[i, 0]}");
                Console.WriteLine($"Nome........: {arrayAlunos[i, 1]}");
                Console.WriteLine($"Média.......: {arrayAlunos[i, 2]}");
                Console.WriteLine($"Frequenca...: {arrayAlunos[i, 3]}%");
                Console.WriteLine($"Situação....: {arrayAlunos[i, 4]} \n");
            }
        }
    }
}
