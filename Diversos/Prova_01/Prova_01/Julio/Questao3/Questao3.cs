using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova_01.Julio.Questao3
{
   static class Questao3
    {
        public static void questao3()
        {
            Autonomo autonomo = new Autonomo(23.00, "jornaleiro", "11111111111", "Entrega", "Julio", "Rua A", "Dia 1","35423020");
            Empregado empregado = new Empregado("jornaleiro", 23.00, "11111111111", "SETOR 1", "Julio", "Rua B", "Dia 2", "35423020");
            Estagiario estagiario = new Estagiario("programador", 2223.00, "11111111111", "Julio", "Rua B", "Dia 2", "35423020");
            estagiario.Alocar_setor("Setor 1");
            Console.WriteLine("************** Autonomo ************** ");
            Console.WriteLine(autonomo);
            Console.WriteLine("");
            Console.WriteLine("************** Empregado ************** ");
            Console.WriteLine(empregado);
            Console.WriteLine("************** Estagiario ************** ");
            Console.WriteLine(estagiario);


        }
    }
}
