using System;
using System.Collections.Generic;
using System.Text;

namespace Algoritimos.S1.ATP
{
  // Parte 4 – Vetor
  //
  public static class S1_ATP_LISTA_ALG_04
  {
    //1 – Faça um programa em C# que crie vetores (nome alunos, nota, sexo e aprovação) e leia os 4 vetores (para testar, crie vetores com 5 posições). Imprima agora os dados de cada aluno.
    //
    static void Exercicios_01()

    {

      string[] nome = new string[5];

      int[] notas = new int[5];

      char[] sexo = new char[5];

      string[] aprovacao = new string[5];

      for (int i = 0; i < nome.Length; i++)

      {

        Console.Write(String.Format("Informe os dados do {0}° aluno. \nNome:", i + 1));

        nome[i] = Console.ReadLine();

        Console.Write("Nota: ");

        notas[i] = int.Parse(Console.ReadLine());

        Console.Write("Sexo (M / F): ");

        sexo[i] = char.Parse(Console.ReadLine().ToUpper()); ;

        Console.Write("Aprovação: ");

        aprovacao[i] = Console.ReadLine();

      }

      for (int i = 0; i < nome.Length; i++)

        Console.WriteLine(String.Format("{0} \nNota: {1} | Sexo: {2} | Aprovação: {3}\n", nome[i], notas[i], sexo[i], aprovacao[i]));

      Console.ReadKey();

    }

    //2 – Faça um programa em C# que crie vetores para armazenar o nome e nota de 10 alunos. Imprima o nome dos alunos que tiveram nota >= 80.
    //
    static void Exercicios_02()
    {
      string[] nome = new string[10];

      int[] nota = new int[10];

      for (int i = 0; i < nome.Length; i++)
      {
        Console.Write(String.Format("Informe os dados do {0}° aluno. \nNome:", i + 1));

        nome[i] = Console.ReadLine();

        Console.Write("Nota: ");

        nota[i] = int.Parse(Console.ReadLine());

      }

      Console.Clear();
      Console.WriteLine("Alunos que tiraram mais que 80: ");

      for (int i = 0; i < nome.Length; i++)
        if (nota[i] >= 80)
          Console.WriteLine(nome[i]);

      Console.ReadKey();
    }
    
    //3 – Faça um programa em C# que crie vetores para armazenar o nome e nota de 10 alunos. Imprima a quantidade de alunos que tiveram nota >= 75.
    //
    static void Exercicios_03()

    {

      string[] nome = new string[10];

      int[] nota = new int[10];

      int cont = 0;

      for (int i = 0; i < nome.Length; i++)

      {

        Console.Write(String.Format("Informe os dados do {0}° aluno. \nNome:", i + 1));

        nome[i] = Console.ReadLine();

        Console.Write($"Nota: ");

        nota[i] = int.Parse(Console.ReadLine());

      }

      Console.Clear();

      Console.WriteLine("Número de alunos que teve nota maior que 75: ");

      for (int i = 0; i < nome.Length; i++)

        if (nota[i] >= 75)

          cont++;

      Console.ReadKey();

    }

    //4 – Faça um programa em C# que crie vetores para armazenar o nome e nota de 10 alunos. Calcule e imprima a nota média. Calcule e imprima o nome e nota dos alunos que tiveram nota acima da média da turma.
    //
    static void Exercicios_04()

    {

      string[] nome = new string[10];

      int[] nota = new int[10];

      int acumulador = 0;

      double media;

      for (int i = 0; i < nome.Length; i++)

      {

        Console.Write(String.Format("Informe os dados do {0}° aluno. \nNome:", i + 1));

        nome[i] = Console.ReadLine();

        Console.Write($"Nota: ");

        nota[i] = int.Parse(Console.ReadLine());

        acumulador += nota[i];

      }

      Console.Clear();

      Console.WriteLine("Número de alunos que teve nota maior que a média: ");

      media = acumulador / 10.0;

      for (int i = 0; i < nome.Length; i++)

        if (nota[i] >= media)

          Console.WriteLine(nome[i]);

      Console.ReadKey();

    }

    //5 – Faça um programa em C# que crie um vetor de inteiros de 10 posições. Leia o vetor e depois imprima na ordem inversa.
    //
    static void Exercicios_05()

    {

      int[] vetor = new int[10];

      Console.WriteLine("Informe os valores do vetor");

      for (int i = 0; i < vetor.Length; i++)

      {

        Console.Write(String.Format("{0}° valor: ", i + 1));

        vetor[i] = int.Parse(Console.ReadLine());

      }

      Console.WriteLine("O vetor em ordem reversa: ");

      for (int i = vetor.Length - 1; i >= 0; i--)

      {

        Console.Write(String.Format("{0} | ", vetor[i]));

      }

      Console.ReadKey();

    }

    //9 – Faça um programa em C# que crie e leia um vetor de 10 posições e faça a inversão das posições sem criar outro vetor.
    //
    static void Exercicios_09()

    {

      int[] vetor = new int[10];

      int temp;

      Console.WriteLine("Informe os valores do vetor");

      for (int i = 0; i < vetor.Length; i++)

      {

        Console.Write(String.Format("{0}° valor: ", i + 1));

        vetor[i] = int.Parse(Console.ReadLine());

      }

      for (int i = 0; i < 5; i++)

      {

        temp = vetor[vetor.Length - 1 - i];

        vetor[vetor.Length - 1 - i] = vetor[i];

        vetor[i] = temp;

      }

      Console.WriteLine("O vetor em ordem reversa: ");

      for (int i = 0; i < vetor.Length; i++)

      {

        Console.Write(String.Format("{0} | ", vetor[i]));

      }

      Console.ReadKey();

    }

    //10 - Faça um programa em C# que armazene em um vetor todos os números múltiplos de 5, no intervalo de 1 a 500. Após isso, o programa deve imprimir todos os valores armazenados.
    //
    static void Exercicios_10()

    {

      int[] vetor = new int[101];

      for (int i = 1; i < vetor.Length; i++)

        vetor[i] = 5 * i;

      Console.WriteLine("Os multíplos de 5 no intervalo de 1 a 500 é igual a: ");

      for (int i = 1; i < vetor.Length; i++)

        Console.Write(String.Format("{0} | ", vetor[i]));

      Console.ReadKey();

    }

    //11 - Faça um programa em C# que armazene em um vetor todos os números pares no intervalo de 0 a 100. Após isso, o programa deve imprimir todos os valores armazenados.
    //
    static void Exercicios_11()
    {
      int[] vetor = new int[51];

      for (int i = 0; i < vetor.Length; i++)

        vetor[i] = 2 * i;

      Console.WriteLine("Números pares no intervalo de 0 a 100 é igual a: ");

      for (int i = 0; i < vetor.Length; i++)

        Console.Write($"{vetor[i]} | ");

      Console.ReadKey();

    }

    //12 - Faça um programa em C# que armazene em um vetor os 100 primeiros números ímpares. Após isso, o programa deve imprimir todos os valores armazenados.
    //
    static void Exercicios_12()
    {

      int[] vetor = new int[50];

      for (int i = 0; i < vetor.Length; i++)

        vetor[i] = 2 * i + 1;

      Console.WriteLine("Números ímpares no intervalo de 0 a 100 é igual a: ");

      for (int i = 0; i < vetor.Length; i++)

        Console.Write($"{vetor[i]} | ");

      Console.ReadKey();

    }

    //13 - Faça um programa em C# que armazene em um vetor o quadrado dos números ímpares no intervalo de 1 a 20.
    //Após isso, o programa deve imprimir todos os valores armazenados.
    static void Exercicios_13()
    {

      int[] vetor = new int[10];

      for (int i = 0; i < vetor.Length; i++)

        vetor[i] = (2 * i + 1) * (2 * i + 1);

      for (int i = 0; i < vetor.Length; i++)

        Console.Write($"{vetor[i]} | ");

      Console.ReadKey();

    }

    //14 - Faça um programa em C# que armazene em um vetor os 200 primeiros termos da série de Fibonacci. Dados 2 números, o próximo termo da série de Fibonacci é a soma desses termos, e assim por diante. Ex:
    //1+1+2+3+5+8+13+21+...
    static void Exercicios_14()
    {

      ulong[] vetor = new ulong[200];

      ulong num1, num2;

      Console.WriteLine("Informe dois números para as duas primeiras posições do vetor.\nNúmero 1: ");

      num1 = ulong.Parse(Console.ReadLine());

      Console.WriteLine("Número 2: ");

      num2 = ulong.Parse(Console.ReadLine());

      vetor[0] = num1;

      vetor[1] = num2;

      for (int i = 2; i < vetor.Length; i++)

        vetor[i] = vetor[i - 1] + vetor[i - 2];

      Console.WriteLine("Sequencia de Fibonacci");

      for (int i = 0; i < vetor.Length; i++)

        Console.WriteLine($"{i + 1}° termo: {vetor[i]}");

      Console.ReadKey();

    }

  }

}
