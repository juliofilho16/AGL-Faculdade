using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova_01.Julio.Questao2
{
    public abstract class Colaborador
    {
        protected string nome;
        protected string endereco;
        protected string data_inicio;

        protected Colaborador(string nome, string endereco, string data_inicio)
        {
            this.nome = nome;
            this.endereco = endereco;
            this.data_inicio = data_inicio;
        }

        //Metodos de leitura
        protected abstract string Nome { get; }
        protected abstract string Endereco { get; }
        protected abstract string Data_inicio { get; }
    }
}
