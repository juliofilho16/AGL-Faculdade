using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trab_Excecao_M2
{
  class Questao3
  {
    public static void questao_03()
    {
      int[] vetNums = new int[10];
      bool continua = true;
      while (continua)
      {
        try
        {
          Console.Write("\nEntre com um número: ");
          int num1 = int.Parse(Console.ReadLine());
          Console.Write("\nEntre com a posição: ");
          int y = int.Parse(Console.ReadLine());

          vetNums[y] = num1;

        }
        catch (IndexOutOfRangeException ex)
        {
          Console.WriteLine("A posição informada está inválida.");
        }
        catch (FormatException ex)
        {
          Console.WriteLine("O valor informado não é um número, favor tentar novamente.");
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
