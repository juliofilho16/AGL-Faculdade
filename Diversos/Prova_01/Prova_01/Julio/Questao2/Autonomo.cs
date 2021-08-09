using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova_01.Julio.Questao2
{
    class Autonomo : Colaborador
    {
        private double valor_hora;
        private string tipo_servico;
        private string cpf;
        private string tarefa;

        public double Valor_hora { get { return valor_hora; } set { this.valor_hora = value; } }
        public string Tipo_servico { get { return tipo_servico; } set { this.tipo_servico = value; } }
        public string CPF { get { return cpf; } set { this.cpf = value; } }
        public string Tarefa { get { return tarefa; } set { this.tarefa = value; } }

        public Autonomo(double valor_hora, string tipo_servico, string cpf, string tarefa, string nome, string endereco, string data_inicio) : base(nome, endereco, data_inicio)
        {
            this.valor_hora = valor_hora;
            this.tipo_servico = tipo_servico;
            this.cpf = cpf;
            this.tarefa = tarefa;
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
        public void Alocar(string tarefa)
        {
            this.tarefa = tarefa;
        }

        public override string ToString()
        {
            return string.Format("Nome: {4} - Endereco {5} - Data_inicio: {6} --- Valor Hora: {0} - Tipo Servico: {1} - CPF: {2} - tarefa {3}",
            valor_hora,
            tipo_servico,
            cpf,
            tarefa
            ,Nome
            ,Endereco
            , Data_inicio
            );
        }

    }
}
