using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeAssociacao.ContaDepois
{
    class Cliente
    {
        private string nome { get; set; }
        private string cpf { get; set; }
        public Cliente(string nome, string cpf)
        {
            this.nome = nome;
            this.cpf = cpf;
        }

        public override string ToString()
        {
            return string.Format(" Nome: {0} - CPF: {1} ",nome,cpf);
        }
    }
}
