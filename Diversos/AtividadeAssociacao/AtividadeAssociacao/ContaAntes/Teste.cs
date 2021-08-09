using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeAssociacao.ContaAntes
{
    static class Teste
    {
        public static void Teste1()
        {

            Console.WriteLine("Entre com o nome do titular: ");
            string nome = Console.ReadLine();
            Console.WriteLine("Entre com o saldo: ");
            double saldo = double.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o número");
            int numero = int.Parse(Console.ReadLine());

            ContaAntes contaAntes = new ContaAntes(numero, saldo, nome);
            Console.WriteLine(contaAntes);
        }

    }
}
