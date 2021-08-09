using AtividadeAssociacao.ContaAntes;
using AtividadeAssociacao.ContaDepois;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeAssociacao
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com 1 para o teste da Conta Antes ou 2 para Conta Depois: ");
            int r = int.Parse(Console.ReadLine());

            if (r == 1)
                AtividadeAssociacao.ContaAntes.Teste.Teste1();
            else
                AtividadeAssociacao.ContaDepois.Teste.Teste2();

            Console.WriteLine("Deseja verificar o outro teste? sim = 1/não = 2");
            int r2 = int.Parse(Console.ReadLine());

            if (r2 == 1)
            {
                Console.Clear();
                if (r == 1)
                    AtividadeAssociacao.ContaDepois.Teste.Teste2();
                else
                    AtividadeAssociacao.ContaAntes.Teste.Teste1();
            }
            Console.WriteLine("Digite qualquer tecla para finalizar...");
            Console.ReadKey();
        }
    }
}
