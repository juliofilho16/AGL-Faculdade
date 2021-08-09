using System;
using System.Collections.Generic;
using System.Text;

namespace POO_Prova2.cont.biblioteca.questao1
{
   static class Questao1
    {
        public static void rodar()
        {
            Professor professor = new Professor("julio", "teste@teste", 2556, "");
            Aluno aluno = new Aluno("julio", "teste@teste", 2556, "");
            Bibliotecario bibliotecario = new Bibliotecario("julio", "teste@teste", 2556, "");

            Console.WriteLine(professor);
            Console.WriteLine(aluno);
            Console.WriteLine(bibliotecario);
        }
    }
}
