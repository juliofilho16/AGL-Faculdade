using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeAssociacao.ContaAntes
{
    class ContaAntes
    {
        private int numero { get; set; }
        private double saldo { get; set; }
        private string titular { get; set; }

        public ContaAntes(int numero, double saldo, string nomeTitular)
        {
            this.numero = numero;
            this.saldo = saldo;
            this.titular = nomeTitular;
        }
        public override string ToString()
        {
            return String.Format("Titular: {0} - Número {1} - Saldo {2}", titular, numero, saldo);
        }
    }
}
