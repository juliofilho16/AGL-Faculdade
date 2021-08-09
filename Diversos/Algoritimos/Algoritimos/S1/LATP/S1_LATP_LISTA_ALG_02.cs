using System;
using System.Collections.Generic;
using System.Text;

namespace Algoritimos.S1.LATP
{
  // Aula 11
  //
  public static class S1_LATP_LISTA_ALG_02
  {

    // 1) Faça um programa que, utilizando blocos faça:
    //a) Leia duas matrizes A e B de 2 dimensões(3x3) de elementos inteiros
    //b) Calcule e imprima a matriz C que é a soma matricial das duas anteriores
    //c) Calcule e imprima a soma dos elementos da diagonal principal da matriz C
    //d) Calcule e imprima a matriz D que é a transposta de C
    public static void Exercicio_1()
    {

      int[,] matrizA = new int[3, 3], matrizB = new int[3, 3], matrizC = new int[3, 3], matrizD = new int[3, 3];
      int num;
      for (int linha = 0; linha < 3; linha++)
      {
        for (int coluna = 0; coluna < 3; coluna++)
        {
          Console.WriteLine(String.Format("Informe um número da Matriz A [{0},{1}] ", linha, coluna));
          num = int.Parse(Console.ReadLine());
          matrizA[linha, coluna] = num;

          Console.WriteLine(String.Format("Informe um número da Matriz B[{0},{1}] ", linha, coluna));
          num = int.Parse(Console.ReadLine());
          matrizB[linha, coluna] = num;
        }
      }
      Console.WriteLine("Matriz A");
      for (int L = 0; L < 3; L++)
        for (int C = 0; C < 3; C++)
        {
          Console.Write(matrizA[L, C] + "  ");
          if (C == 2)
            Console.WriteLine();
        }

      Console.WriteLine("Matriz B");
      for (int L = 0; L < 3; L++)
        for (int C = 0; C < 3; C++)
        {
          Console.Write(matrizB[L, C] + "  ");
          if (C == 2)
            Console.WriteLine();
        }

      //Calculando e atribuindo valores para matriz c
      for (int linha = 0; linha < 3; linha++)
        for (int coluna = 0; coluna < 3; coluna++)
          matrizC[linha, coluna] = matrizA[linha, coluna] + matrizB[linha, coluna];

      Console.WriteLine("Matriz C");
      for (int L = 0; L < 3; L++)
        for (int C = 0; C < 3; C++)
        {
          Console.Write(matrizC[L, C] + "  ");
          if (C == 2)
            Console.WriteLine();
        }


      Console.WriteLine("Diagonal principal Matriz C");
      for (int L = 0; L < 3; L++)
        for (int C = 0; C < 3; C++)
        {
          if (L == C)
          {
            Console.Write(matrizC[L, C] + "  ");
            if (C == 2)
              Console.WriteLine();
          }
        }

      Console.WriteLine("d) Calcule e imprima a matriz D que é a transposta de C");
      for (int linha = 0; linha < 3; linha++)
        for (int coluna = 0; coluna < 3; coluna++)
          matrizD[linha, coluna] = matrizC[coluna, linha];

      Console.WriteLine("Matriz C");
      for (int L = 0; L < 3; L++)
        for (int C = 0; C < 3; C++)
        {
          Console.Write(matrizD[L, C] + "  ");
          if (C == 2)
            Console.WriteLine();
        }
      Console.ReadKey();
    }

    //2) Dada uma matriz 4 x 5 de inteiros faça um programa que some os elementos de cada linha da
    //matriz.Em seguida, armazene a soma da linha em cada posição em um vetor. Para finalizar,
    //imprima o resultado no console.
    public static void Exercicio_2()
    {

      int[,] matriz = new int[4, 5];
      int num, somaL1 = 0, somaL2 = 0, somaL3 = 0, somaL4 = 0;
      int[] VETSomas = new int[4];

      for (int linha = 0; linha < 4; linha++)
        for (int coluna = 0; coluna < 5; coluna++)
        {
          Console.WriteLine(String.Format("Informe um número da Matriz [{0},{1}] ", linha, coluna));
          num = int.Parse(Console.ReadLine());
          matriz[linha, coluna] = num;

        }

      Console.WriteLine("Matriz");
      for (int L = 0; L < 4; L++)
        for (int C = 0; C < 5; C++)
        {
          Console.Write(matriz[L, C] + "  ");
          if (C == 4)
            Console.WriteLine();
        }

      for (int j = 0; j <= 3; j++)
        for (int i = 0; i <= 4; i++)
        {
          if (j == 0)
            somaL1 += matriz[0, i];

          if (j == 1)
            somaL2 += matriz[1, i];

          if (j == 2)
            somaL3 += matriz[2, i];

          if (j == 3)
            somaL4 += matriz[3, i];
        }

      VETSomas[0] = somaL1;
      VETSomas[1] = somaL2;
      VETSomas[2] = somaL3;
      VETSomas[3] = somaL4;

      for (int i = 0; i < VETSomas.Length; i++)
        Console.WriteLine(String.Format("Soma dos valores da linha {0} = {1}", i, VETSomas[i]));

      Console.ReadKey();
    }

  }

}
