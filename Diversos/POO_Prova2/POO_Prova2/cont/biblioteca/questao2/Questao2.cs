using System;
using System.Collections.Generic;
using System.Text;

namespace POO_Prova2.cont.biblioteca.questao2
{
   static class Questao2
    {
        public static void rodar()
        {
            Professor professor = new Professor("Professor", "teste@teste", 2556, "");
            Aluno aluno = new Aluno("Aluno", "teste@teste", 2556, "");
            Bibliotecario bibliotecario = new Bibliotecario("bibliotecario", "teste@teste", 2556, "");

            Console.WriteLine("Eu sou um Aluno - limite de dias: " + aluno.QtdDeDias());
            Console.WriteLine("Eu sou um bibliotecario - limite de dias: " + bibliotecario.QtdDeDias());
            Console.WriteLine("Eu sou um Professor - limite de dias: "+ professor.QtdDeDias());
        }
    }
}
