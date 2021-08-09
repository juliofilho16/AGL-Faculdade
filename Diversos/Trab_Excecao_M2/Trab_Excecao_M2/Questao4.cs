using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trab_Excecao_M2
{
  class Questao4
  {
    public static void questao_04()
    {
      int acumulador = 0;
      bool continua = true;
      while (continua)
      {
        try
        {
          Console.Write("\nEntre com um número: ");
          int num1 = int.Parse(Console.ReadLine());
          acumulador += num1;

          if (acumulador > 100)
          {
            continua = false;
            Console.Write("\nDigite uma tecla para finalizar...");
          }
       

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
