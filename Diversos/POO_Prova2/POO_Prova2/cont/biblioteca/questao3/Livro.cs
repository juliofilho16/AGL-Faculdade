using System;
using System.Collections.Generic;
using System.Text;

namespace POO_Prova2.cont.biblioteca.questao3
{
    public class Livro
    {
        public string nomeLivro { get; set; }
        public string autor { get; set; }
        public int anoPublicacao { get; set; }
        public Livro(string nomeLivro, string autor, int anoPublicacao)
        {
            this.nomeLivro = nomeLivro;
            this.autor = autor;
            this.anoPublicacao = anoPublicacao;
        }

        public Livro()
        {
        }
    }
}
