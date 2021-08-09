using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova_01.Julio.Questao1
{
   static class Questao1
    {
        public static void questao1()
        {
            Autonomo autonomo = new Autonomo(23.00, "jornaleiro", "11111111111", "Entrega", "Julio", "Rua A", "Dia 1");
            Empregado empregado = new Empregado("jornaleiro", 23.00, "11111111111", "SETOR 1", "Julio", "Rua B", "Dia 2");
            Console.WriteLine("************** Autonomo ************** ");
            Console.WriteLine(autonomo);
            Console.WriteLine("");
            Console.WriteLine("************** Empregado ************** ");
            Console.WriteLine(empregado);

        }
    }
}
