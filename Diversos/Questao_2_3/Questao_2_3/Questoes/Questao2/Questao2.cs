using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova_01.Questoes.Questao2
{
  static class Questao2
  {
    public static void questao2()
    {
      Autonomo autonomo = new Autonomo(23.00, "jornaleiro", "11111111111", "Entrega", "Julio", "Rua A", "Dia 1");
      Empregado empregado = new Empregado("jornaleiro", 23.00, "11111111111", "SETOR 1", "Julio", "Rua B", "Dia 2");
      Estagiario estagiario = new Estagiario("programador", 2223.00, "11111111111", "Julio", "Rua B", "Dia 2");
      estagiario.Alocar_setor("Setor 1");
      Console.WriteLine(autonomo);
      Console.WriteLine("");
      Console.WriteLine(empregado);
      Console.WriteLine("");
      Console.WriteLine(estagiario);


    }
  }
}
