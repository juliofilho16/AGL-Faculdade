using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeAssociacao.ContaDepois
{
    class Conta
    {
        private int numero { get; set; }
        private double saldo { get; set; }
        private Cliente titular { get; set; }
        public Conta(int numero, double saldo, Cliente titular)
        {
            this.numero = numero;
            this.saldo = saldo;
            this.titular = titular;
        }

        public Conta(int numero, double saldo, string nomeTitular, string cpfTitular)
        {
            this.numero = numero;
            this.titular = new Cliente(nomeTitular, cpfTitular);
            this.saldo = saldo;
        }

        public override string ToString()
        {
            return String.Format("Titular: {0} - Número {1} - Saldo {2}", titular, numero, saldo);
        }

    }
}
