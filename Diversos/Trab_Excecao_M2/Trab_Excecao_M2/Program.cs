using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trab_Excecao_M2
{
  class Program
  {
    static void Main(string[] args)
    {
      try
      {
        Console.Write("Entre com a questão (1 - 2 - 3 - 4): ");
        int num = int.Parse(Console.ReadLine());

        switch (num)
        {
          case 1:
            Questao1.questao_01();
            break;
          case 2:
            Questao2.questao_02();
            break;
          case 3:
            Questao3.questao_03();
            break;
          case 4:
            Questao4.questao_04();
            break;
          default:
            throw new ArgumentOutOfRangeException("Opção inválida.","A opção informada não se encontra no menu.");
            break;
        }

      }catch (ArgumentOutOfRangeException ex)
      {
        Console.WriteLine(ex.Message);
      }
      catch (Exception erro)
      {
        Console.WriteLine(
                         erro.GetType().ToString() + "\r\n" +
                         erro.GetType().BaseType.ToString() + "\r\n" +
                         erro.GetType().BaseType.BaseType.ToString() + "\r\n" +
                         erro.GetType().BaseType.BaseType.BaseType.ToString() + "\r\n" +
                         erro.GetType().BaseType.BaseType.BaseType.BaseType.ToString()
                         );
      }
      Console.ReadKey();
    }
  }
}
