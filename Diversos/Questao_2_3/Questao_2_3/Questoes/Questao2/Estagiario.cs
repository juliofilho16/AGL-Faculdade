using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova_01.Questoes.Questao2
{
    class Estagiario : Colaborador
    {

        private string funcao;
        private double salario;
        private string registro_estagio;
        private string setor;
        private string tarefa;

        public double Salario { get { return salario; } set { this.salario = value; } }
        public string Funcao { get { return funcao; } set { this.funcao = value; } }
        public string Registro_estagio { get { return registro_estagio; } set { this.registro_estagio = value; } }
        public string Setor { get { return setor; } set { this.setor = value; } }
        public string Tarefa { get { return tarefa; } set { this.tarefa = value; } }

        public Estagiario(string funcao, double salario, string registro_estagio, string nome, string endereco, string data_inicio) : base(nome, endereco, data_inicio)
        {
            this.funcao = funcao;
            this.salario = salario;
            this.registro_estagio = registro_estagio;
        }

        protected override string Nome
        {
            get
            {
                return nome;
            }
        }
        protected override string Data_inicio
        {
            get
            {
                return data_inicio;
            }
        }
        protected override string Endereco
        {
            get
            {
                return endereco;
            }
        }
        public void Alocar_tarefa(string tarefa)
        {
            if (this.setor == "")
                this.tarefa = tarefa;
        }
        public void Alocar_setor(string setor)
        {
            if (this.tarefa == "")
                this.setor = setor;
        }

        public override string ToString()
        {
            string retorno = string.Format("Nome: {0} - Endereco {1} - Data_inicio: {2} --- funcao: {3} - Salário: {4} - registro_estagio: {5} - tarefa: {6} - setor: {7}"
              , Nome
              , Endereco
              , Data_inicio
               , funcao
             , salario
             , registro_estagio
             , tarefa
             , setor
              );


            return retorno;
        }

    }
}
