using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeAssociacao.ContaDepois
{
    static class Teste
    {
        public static void Teste2()
        {

            Console.WriteLine("Entre com o nome do titular: ");
            string nome = Console.ReadLine();
            Console.WriteLine("Entre com o cpf do titular");
            string cpf = Console.ReadLine();
            Console.WriteLine("Entre com o saldo: ");
            double saldo = double.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o número");
            int numero = int.Parse(Console.ReadLine());


            Conta contaAntes = new Conta(numero, saldo, nome, cpf);
            Console.WriteLine(contaAntes);
        }
    }
}
