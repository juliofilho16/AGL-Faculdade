using System;
using System.Collections.Generic;
using System.Text;

namespace POO_Prova2.cont.biblioteca.questao2
{
    public abstract class Usuario:IEmprestimo
    {
        protected string nome;
        protected string email;
        protected int matricula;
        protected string funcao;

        public Usuario(string nome, string email, int matricula, string funcao)
        {
            this.nome = nome;
            this.email = email;
            this.matricula = matricula;
            this.funcao = funcao;
        }
        public string getNome()
        {
            return nome;
        }

        public abstract int QtdDeDias();

        public void setNome(string Nome)
        {
            nome = Nome;
        }
    
    }
}
