using System;
using System.Collections.Generic;
using System.Text;

namespace Algoritimos.S1.LATP
{
  // Aula 9
  //
  public static class S1_LATP_LISTA_ALG_01
  {
    //1) Escreva um programa em C# que, utilizando a estrutura de repetição WHILE, leia um valor
    //inteiro e positivo N e imprima o valor de S, sabendo que S = 1 + 1 /1!+1 / 2!+1 / 3! ... 1 / N!
    public static void exercicio_1()
    {

      double fat = 1, soma = 1;
      int num, contador = 1;
      Console.WriteLine("Digite um número");
      num = int.Parse(Console.ReadLine());
      while (contador <= num)
      {
        if (contador != 1)
        {
          int n = contador;
          while (n > 1)
          {
            fat = fat * (n - 1);
            n--;
          }
          //Imprimindo o fatorial
          Console.WriteLine(String.Format("{0}! = {1}", contador, fat));
        }

        soma = soma + (1 / fat);
        contador++;
        fat = contador;
      }
      Console.WriteLine(String.Format("Soma = {0}", soma));
      Console.ReadKey();
    }

    //2) Escreva um programa em C# que, utilizando a estrutura de repetição DO - WHILE, leia um valor
    //inteiro e positivo N e imprima o valor de S, sabendo que S = 1 + 1 /1!+1 / 2!+1 / 3! ... 1 / N!
    public static void exercicio_2()
    {
      double fat = 1, soma = 1;
      int num, contador = 1;
      Console.WriteLine("Digite um número");
      num = int.Parse(Console.ReadLine());
      do
      {
        if (contador != 1)
        {
          int n = contador;
          do
          {
            fat = fat * (n - 1);
            n--;
          } while (n > 1);
          //Imprimindo o fatorial
          Console.WriteLine(String.Format("{0}! = {1}", contador, fat));
        }
        soma = soma + (1 / fat);
        contador++;
        fat = contador;
      } while (contador <= num);
      Console.WriteLine(String.Format("Soma = {0}", soma));
      Console.ReadKey();
    }

    //3) Escreva um programa em C# que, utilizando a estrutura de repetição FOR, leia um valor inteiro
    //e positivo N e imprima o valor de S, sabendo que S = 1 + 1 / 1!+1 / 2! +1 / 3! ... 1 / N!
    public static void exercicio_3()
    {
      double fat = 1, soma = 1;
      int num, contador = 1;
      Console.WriteLine("Digite um número");
      num = int.Parse(Console.ReadLine());
      for (int i = contador; i <= num; i++)
      {
        if (contador != 1)
          for (int n = contador; n > 1; n--)
            fat = fat * (n - 1);
        //Imprimindo o fatorial
        Console.WriteLine(String.Format("{0}! = {1}", contador, fat));
        soma = soma + (1 / fat);
        contador++;
        fat = contador;
      }
      Console.WriteLine(String.Format("Soma = {0}", soma));
      Console.ReadKey();
    }

    //4) Elabore um programa que leia 10 números inteiros. Ao final,informar:
    //a) a quantidade de números pares lidos;
    //b) a quantidade de números ímpares lidos;
    //c) a média dos 10 números.
    public static void exercicio_4()
    {
      int num, numPar = 0, numImpar = 0;
      double soma = 0;
      for (int i = 1; i <= 10; i++)
      {
        Console.WriteLine("Digite um número");
        num = int.Parse(Console.ReadLine());
        soma += num;
        if (num % 2 == 0)
          numPar++;
        else
          numImpar++;
      }
      Console.WriteLine(String.Format("Quantidade de números pares lidos{0}", numPar));
      Console.WriteLine(String.Format("Quantidade de números ímpares lidos = {0}", numImpar));
      Console.WriteLine(String.Format("Média dos 10 números = {0}", (numPar + numImpar) / 10));
      Console.ReadKey();
    }

    //5) Um comerciante deseja fazer o levantamento do lucro das mercadorias que ele comercializa.
    //Para isto, mandou digitar uma linha para cada mercadoria com o preço de compra e de venda
    //de cada uma.A última linha contém preço de compra igual a 0.Escreva um programa que:
    //a) Determine e escreva quantas mercadorias proporcionaram:
    //i) Lucro < 10 %
    //ii) 10 % <= lucro <= 20 %
    //iii) Lucro > 20 %
    //b) Determine e escreva o valor total de compra e de venda de todas as mercadorias, assim
    //como o lucro total.
    public static void exercicio_5()
    {
      double P_Compra = 1, P_Venda, somaP_Venda = 0, somaP_Compra = 0;
      int qtdMercadorias = 0, qtdMercMenor10 = 0, qtdMercMenor20 = 0, qtdMercMaior20 = 0;
      bool continua = true;
      while (continua)
      {
        Console.WriteLine("Digite o preço de compra");
        P_Compra = double.Parse(Console.ReadLine());

        if (P_Compra == 0)
          continua = false;
        else
        {
          qtdMercadorias++;

          Console.WriteLine("Digite o preço de venda");
          P_Venda = double.Parse(Console.ReadLine());
          double lucro = ((P_Venda - P_Compra) / P_Compra) * 100;

          if (lucro < 10)
            qtdMercMenor10++;
          else
            if (lucro <= 20)
            qtdMercMenor20++;
          else
            qtdMercMaior20++;

          somaP_Compra += P_Compra;
          somaP_Venda += P_Venda;
        }
      }
      Console.WriteLine(String.Format("{0} mercadorias proporcionaram lucro < 10% .", qtdMercMenor10));
      Console.WriteLine(String.Format("{0} mercadorias proporcionaram lucro entre 10% e 20% = {0}", qtdMercMenor20));
      Console.WriteLine(String.Format("{0} mercadorias proporcionaram lucro > 20% ", qtdMercMaior20));
      Console.WriteLine(String.Format("Valor total de compra é R${0} - Valor total de vendas é R${1} - Lucro total é de R${2} = lucro de {3}%", somaP_Compra, somaP_Venda, (somaP_Venda - somaP_Compra), ((somaP_Venda - somaP_Compra) / somaP_Compra) * 100));
      Console.ReadKey();
    }

    //6) A prefeitura de uma cidade fez uma pesquisa entre seus habitantes,coletando dados sobre o
    //salário e número de filhos.A prefeitura deseja saber:
    //a) média do salário da população;
    //b) média do número de filhos;
    //c) maior salário;
    //d) percentual de pessoas com salário até R$1.000,00.
    //O final da leitura de dados se dará com a entrada de um salárionegativo
    public static void exercicio_6()
    {

      double salario = 1, somaSal = 0, maiorSalario = 0, somaNumFilhos = 0, habitantes = 0;
      int numFilhos, qtdSalMil = 0;
      while (salario > 0)
      {
        Console.WriteLine("Digite o salário");
        salario = double.Parse(Console.ReadLine());
        if (salario > 0)
        {
          Console.WriteLine("Digite o número de filhos");
          numFilhos = int.Parse(Console.ReadLine());
          if (salario > maiorSalario)
            maiorSalario = salario;
          if (salario <= 1000.00)
            qtdSalMil++;
          habitantes++;
          somaNumFilhos += numFilhos;
          somaSal += salario;
        }
      }
      Console.WriteLine(String.Format("Média do salário da população = {0}", somaSal / habitantes));
      Console.WriteLine(String.Format("Média do número de filhos = {0}", somaNumFilhos / habitantes));
      Console.WriteLine(String.Format("Maior salário = {0}", maiorSalario));
      Console.WriteLine(String.Format("Percentual de pessoas com salário até R $1.000, 00 = {0}% ", (qtdSalMil / habitantes) * 100));
      Console.ReadKey();
    }

  }
}
