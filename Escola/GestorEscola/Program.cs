using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassesEscola.Classes;

namespace GestorEscola
{
    class Program
    {
        static void Main(string[] args)
        {
            Cadastro cad = new Cadastro();
            cad.inserirAluno();

            cad.listarAlunos();

            Console.ReadKey();
        }
    }
}
