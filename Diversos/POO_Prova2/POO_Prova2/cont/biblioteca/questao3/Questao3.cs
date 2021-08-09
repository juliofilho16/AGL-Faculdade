using System;
using System.Collections.Generic;
using System.Text;

namespace POO_Prova2.cont.biblioteca.questao3
{
    static class Questao3
    {
        public static void rodar()
        {

            Console.WriteLine("Informe o nome: ");
            string nome = Console.ReadLine();

            Console.WriteLine("Informe o email: ");
            string email = Console.ReadLine();

            Console.WriteLine("Informe a matricula: ");
            int matricula = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe o função: ");
            string f = Console.ReadLine();

            Livro livro = new Livro();
            if (matricula > 100 && matricula <= 150)
            {
                Bibliotecario usuario = new Bibliotecario(nome, email, matricula, f);
                livro = usuario.efetivarEmprestimo();
                Console.WriteLine("Emprestimo para bibliotecário! ");
            }
            else if (matricula > 150 && matricula <= 200)
            {
                Professor usuario = new Professor(nome, email, matricula, f);
                livro = usuario.efetivarEmprestimo();
                Console.WriteLine("Emprestimo para professores!");
            }
            else if (matricula > 200 && matricula <= 999)
            {
                Aluno usuario = new Aluno(nome, email, matricula, f);
                livro = usuario.efetivarEmprestimo();
                Console.WriteLine("Emprestimo para alunos!");
            }
            else
            {
                Console.WriteLine("Erro. matricula fora do intervalo");
            }

            Console.WriteLine("\n - - - - - - Emprestar livros - - - - - -");
            Console.WriteLine("Livro: "+ livro.nomeLivro + "Ano: "+ livro.anoPublicacao+" Autor" + livro.autor);

        }
    }
}
