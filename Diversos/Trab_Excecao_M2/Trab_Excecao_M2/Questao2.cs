using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trab_Excecao_M2
{
  class Questao2
  {
    public static void questao_02()
    {
      try
      {
        Console.WriteLine("\nDigite o número referente à operação que deseja realizar");
        Console.WriteLine("1 – Somar os números");
        Console.WriteLine("2 – Subtrair os números");
        Console.WriteLine("3 – Produto dos números");
        Console.WriteLine("4 – Quociente e resto da divisão entre dois números");

        Console.Write("\nDigite o primeiro número: ");
        int num1 = int.Parse(Console.ReadLine());
        Console.Write("\nDigite o segundo número: ");
        int num2 = int.Parse(Console.ReadLine());

        Console.Write("\nEntre com a questão: ");
        int Menu = int.Parse(Console.ReadLine());
        
        switch (Menu)
        {
          case 1:
            Somar(num1, num2);
            break;
          case 2:
            Subtrair(num1, num2);
            break;
          case 3:
            Multiplicar(num1, num2);
            break;
          case 4:
            Dividir(num1, num2);
            break;
          default:
            throw new ArgumentOutOfRangeException("Opção inválida.");
            break;
        }


      }
      catch (FormatException ex)
      {
        Console.WriteLine("O valor informado não é um número, favor tentar novamente.");
      }
      catch (ArgumentOutOfRangeException ex)
      {
        Console.WriteLine(ex.Message);
      }
      catch (DivideByZeroException ex)
      {
        Console.WriteLine("Não é possível dividir por 0, favor tentar novamente.");
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

    private static void Somar(int num1, int num2)
    {
      Console.WriteLine(String.Format("A soma entre os números {0} e {1} é {2}", num1, num2, (num1 + num2)));
    }

    private static void Subtrair(int num1, int num2)
    {
      Console.WriteLine(String.Format("A subtração entre os números {0} e {1} é {2}", num1, num2, (num1 - num2)));
    }

    private static void Multiplicar(int num1, int num2)
    {
      Console.WriteLine(String.Format("O produto entre os números {0} e {1} é {2}", num1, num2, (num1 * num2)));
    }

    private static void Dividir(int num1, int num2)
    {
      try
      {
        Console.WriteLine(String.Format("A divisão entre os números {0} e {1} é {2} e o resto é {3}.", num1, num2, (num1 / num2), (num1 %num2)));
      }
      catch (DivideByZeroException ex)
      {
        throw;
      }
    }
  }
}
