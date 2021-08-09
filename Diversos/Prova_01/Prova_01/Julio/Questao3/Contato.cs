using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova_01.Julio.Questao3
{
   public class Contato
    {   
        protected string nome;
        protected string endereco;
        protected string telefone;

        public string Nome { get { return nome; } set { this.nome = value; } }
        public string Endereco { get { return endereco; } set { this.endereco = value; } }
        public string Telefone { get { return telefone; } set { this.telefone = value; } }

        public Contato(string nome, string endereco, string telefone)
        {
            this.nome = nome;
            this.endereco = endereco;
            this.telefone = telefone;
        }
    }
}
