using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trab_Excecao_M2
{
  static class Questao1
  {
    public static void questao_01()
    {
      Console.WriteLine("\nEntre com um número.");
      bool continua = true;
      int num;
      while (continua)
      {
        try
        {
          num = int.Parse(Console.ReadLine());

          continua = false;
          int contDivisivel = 0;

          for (int i = 1; i <= num; i++)
            if (num % i == 0)
              contDivisivel++;

          if (contDivisivel == 2)
            Console.WriteLine(String.Format("O número {0} é primo!", num));
          else
            Console.WriteLine(String.Format("O número {0} não é primo!", num));
        }
        catch (FormatException ex)
        {
          Console.WriteLine("O valor informado não é um número, favor tentar novamente.");
          Console.WriteLine("Entre com um número.");
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
      }
    }
  }
}
