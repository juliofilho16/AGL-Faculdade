using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova_01
{
    //Prova Julio Cesar
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com a questão: 1,2 ou 3");
            int Q = int.Parse(Console.ReadLine());

            if (Q == 1)
                Prova_01.Julio.Questao1.Questao1.questao1();
            else if (Q == 2)
                Prova_01.Julio.Questao2.Questao2.questao2();
            else
                Prova_01.Julio.Questao3.Questao3.questao3();

            Console.WriteLine("Digite qualquer coisa para terminar...");
            Console.ReadKey();


        }
    }
}
