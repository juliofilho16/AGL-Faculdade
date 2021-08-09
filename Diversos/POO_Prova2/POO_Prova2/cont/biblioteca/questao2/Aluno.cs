using System;
using System.Collections.Generic;
using System.Text;

namespace POO_Prova2.cont.biblioteca.questao2
{
    class Aluno:Usuario
    {
        public Aluno(string nome, string email, int matricula, string funcao)
            : base(nome, email, matricula, funcao)
        {
        }

        public void setFuncao(string Funcao)
        {
            funcao = Funcao;
        }

        public string getFuncao()
        {
            return funcao;
        }


        public string mostrarPapel()
        {
            return "a";
        }
        public override string ToString()
        {
            return $"{nome} | {email} | Eu sou um Aluno";
        }
        public override int QtdDeDias()
        {
            return 8;
        }
    }
}
