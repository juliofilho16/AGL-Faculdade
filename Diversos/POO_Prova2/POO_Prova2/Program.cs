using POO_Prova2.cont.biblioteca.questao1;
using POO_Prova2.cont.biblioteca.questao2;
using POO_Prova2.cont.biblioteca.questao3;
using System;

namespace POO_Prova2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Questão 1: \n - - - - - - Mostrar Usuários - - - - - -");
            Questao1.rodar();
            Console.WriteLine("Questão 2: \n - - - - - - Mostrar Limite de dias por tipo - - - - - -");
            Questao2.rodar();
            Console.WriteLine("Questão 3: \n - - - - - - Emprestar livros - - - - - -");
            Questao3.rodar();
            Console.ReadKey();
        }


    }
}
