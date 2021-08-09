using System;
using System.Collections.Generic;
using System.Text;

namespace Algoritimos.S1.LATP
{
  // JOGO DA FORCA 2
  //Objetivo do programa: Verificar se o jogador 2 acertou as 7 oportunidades de descobrir a palavra informada pelo jogador 1, informando se ele venceu ou não o jogo;
  //Implementar Procedimentos e função 
  //Desenvolvido por: Júlio Cesar
  public static class S1_LATP_LISTA_ALG_04
  {
    private static void MsgJogador_1()
    {
      Console.Write("\n************* Jogador 1 ************* ");
    }

    private static void MsgJogador_2()
    {
      Console.Write("\n************* Jogador 2 ************* ");
    }

    private static string lerLetra()
    {
      Console.Write("\nInforme uma letra: ");
      string letra = Console.ReadLine().ToUpper();

      return letra;
    }

    private static bool ValidaCharJaDigitado(string[] charDigitados, string charAtual)
    {
      bool result = false;
      for (int i = 0; i < charDigitados.Length; i++)
        if (charDigitados[i] == charAtual)
          result = true;

      return result;
    }

    private static bool TodosAcertos(string[] charDescobertos, string palavraInformada)
    {
      bool result = false;
      string Descobertos = "";

      for (int i = 0; i < charDescobertos.Length; i++)
        if (charDescobertos[i] != null)
          Descobertos += charDescobertos[i];

      if (Descobertos.Length == charDescobertos.Length)
        result = true;

      return result;
    }

    private static bool ValidaCharDescobertos(string[] charDescobertos, string charAtual)
    {
      bool result = false;
      for (int i = 0; i < charDescobertos.Length; i++)
        if (charDescobertos[i] == charAtual)
          result = true;

      return result;
    }

    private static void Acerto(ref int chances, char ultCharDesc)
    {
      Console.Clear();
      chances++;
      Console.WriteLine("\nParabéns você descobrir um novo caractere!");
      Console.WriteLine("\nUltimo caracter descoberto = " + ultCharDesc);
    }

    private static void CharErro(ref int chances)
    {
      Console.WriteLine("\nOps,você errou.");
      chances++;
    }

    private static void MontagemForca(ref int erros)
    {
      erros++;
      switch (erros)
      {
        case 1:
          Console.WriteLine(String.Format(@"
                     ------
                     |    |
                     |  
                     |  
                     |   
                     |
                     |========|"));
          break;
        case 2:
          Console.WriteLine(String.Format(@"
                     ------
                     |    |
                     |    O
                     |  
                     |   
                     |
                     |========|"));
          break;
        case 3:
          Console.WriteLine(String.Format(@"
                     ------
                     |    |
                     |    O
                     |    |
                     |    
                     |
                     |========|"));
          break;
        case 4:
          Console.WriteLine(String.Format(@"
                     ------
                     |    |
                     |    O
                     |    |\
                     |     
                     |
                     |========|"));
          break;
        case 5:
          Console.WriteLine(String.Format(@"
                     ------
                     |    |
                     |    O
                     |   /|\
                     |   
                     |
                     |========|"));
          break;
        case 6:
          Console.WriteLine(String.Format(@"
                     ------
                     |    |
                     |    O
                     |   /|\
                     |   / 
                     |
                     |========|"));
          break;
        default:
          break;
      }
    }

    private static bool PalavraValida(string palavra)
    {
      if (palavra.Length != 7)
        return false;

      return true;
    }

    private static void AvisoCharExist(string palavraInformada, int acertos, int chances, string[] charDescobertos)
    {
      Console.WriteLine("\nOps, caracter já digitado.");
      Console.WriteLine(String.Format("\nPlacar...\nQuantidade de caracteres já descobertos: {0} - ({3}) \nNúmero de caracteres para serem descobertos: {1}\nOportunidades de acertos: gastos = {2} - restantes = {4}"
                                  , acertos, palavraInformada.Length - acertos, chances, PegaCharDescobertos(charDescobertos), palavraInformada.Length - chances));
    }

    private static void JogoGanho()
    {
      Console.Clear();
      Console.WriteLine("\n************ Parabéns você ganhou! ************");
      Console.WriteLine("\nVocê completou a palavra corretamente e é o vencedor!");
    }

    private static void JogoPerdido()
    {
      Console.Clear();
      Console.WriteLine("\nSuas chances esgotaram e infelizmente você perdeu.");
      Console.WriteLine(String.Format(@"
                                          -----|
                                          |    |
                                          |    O
                                          |   /|\
                                          |   / \
                                          |
                                          |========|"));
    }

    private static void descobriuCaractere(string palavra, string letra, ref int acertos, ref string[] charDescobertos, ref char ultCharDesc)
    {
      for (int i = 0; i < palavra.Length; i++)
      {
        if (palavra.Substring(i, 1) == letra)
        {
          //d.ii.este seja igual a um ou mais caracteres da palavra o j2 é informado que descobriu um novo caractere;
          acertos++;
          charDescobertos[i] = letra;
          ultCharDesc = char.Parse(letra);
        }
      }
    }

    private static string PegaCharDescobertos(string[] charDescobertos)
    {
      string chars = string.Empty;
      for (int i = 0; i < charDescobertos.Length; i++)
      {
        chars += charDescobertos[i];
      }
      return chars;
    }
    
    public static void Main()
    {

      string palavraInformada;
      string[] charDigitados = new string[7];
      string[] charDescobertos = new string[7];
      string letra;
      char ultCharDesc = ' ';
      int acertos = 0, chances = 0, erros = 0;
      bool vence = false, containChar = false;

      bool palavraCorreto = false;


      //Função par verificar se a palavra é válida. -> OK
      do
      {
        MsgJogador_1();
        Console.Write("\nDigite a palavra desejada: ");
        palavraInformada = Console.ReadLine().ToUpper();


        if (!PalavraValida(palavraInformada))
        {
          Console.Clear();
          Console.WriteLine("Palavra informada é inválida");
        }
        else
        {
          palavraCorreto = true;
        }

      } while (!palavraCorreto);

      Console.Clear();

      MsgJogador_2();
      Console.Write("\nVocê terá 7 chances para descobrir a palavra informada pelo jogador 1.");
      Console.Write("\nDigite qualquer tecla para continuar....");
      Console.ReadKey();
      Console.WriteLine("");

      for (int rep = 0; rep < charDigitados.Length; rep++)
      {
        MsgJogador_2();

        //Função para ler uma letra da tentativa. ->OK
        letra = lerLetra();

        //d.i. verificar se o caractere já foi digitado:
        containChar = ValidaCharJaDigitado(charDigitados, letra);

        if (!containChar)
        {
          //d.i.1. não foi digitado, vá para o passo 01.d.ii;

          charDigitados[rep] = letra;

          descobriuCaractere(palavraInformada, letra, ref acertos, ref charDescobertos, ref ultCharDesc);

          if (TodosAcertos(charDescobertos, palavraInformada))
          {
            rep = 8;
            vence = true;
          }
          else if (ValidaCharDescobertos(charDescobertos, letra))
          {
            Acerto(ref chances, ultCharDesc);
          }
          else
          {
            CharErro(ref chances);
            MontagemForca(ref erros);
          }
        }
        else
        {
          AvisoCharExist(palavraInformada, acertos, chances, charDescobertos);
          rep--;
        }
        //2.foi digitado, informe que a palavra já foi digitada, não considere nem mesmo como tentativa perdida e vá para o passo 01.e.
        //e.Um placar informando quantas caracteres já descobriu, quantos faltam e quantas oportunidades de acertar já gastou das 7
      }

      if (vence)
        JogoGanho();
      else
        JogoPerdido();



      Console.WriteLine("\nDigite qualquer tecla para finalizar o jogo... ");
      Console.ReadLine();
    }
  }
}
