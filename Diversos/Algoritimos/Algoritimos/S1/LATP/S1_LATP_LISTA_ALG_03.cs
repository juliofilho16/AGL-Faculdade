using System;
using System.Collections.Generic;
using System.Text;

namespace Algoritimos.S1.LATP
{
  //JOGO DA FORCA 1
  //Nesta implementação teremos dois jogadores fornecendo uma palavra com a mesma quantidade de
  //caracteres cada um. E ao final quem acertar a palavra com o menor número de tentativas vence:
  //Programador: Júlio Cesar
  //Exec pelo método main
  public static class S1_LATP_LISTA_ALG_03
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
      return Console.ReadLine().ToUpper();
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

    private static bool ValidaCharDescobertos(string palavra, string charAtual)
    {
      bool result = false;
      for (int i = 0; i < palavra.Length; i++)
        if (palavra.Substring(i, 1) == charAtual)
          result = true;

      return result;
    }

    private static void Acerto(char ultCharDesc, bool vezj1)
    {
      Console.Clear();
      if (vezj1)
        Console.WriteLine("\nParabéns jogador 1, você descobrir um novo caractere!");
      else
        Console.WriteLine("\nParabéns jogador 2, você descobrir um novo caractere!");

      Console.WriteLine("\nUltimo caracter descoberto = " + ultCharDesc);
    }

    private static void CharErro(bool vezJ1)
    {
      if (vezJ1)
        Console.WriteLine("\n *********** Jogador 1: Ops,você errou. ***********");
      else
        Console.WriteLine("\n *********** Jogador 2: Ops,você errou. ***********");

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
          Console.WriteLine(String.Format(@"
                     ------
                     |    |
                     |    O
                     |   /|\
                     |   / \
                     |
                     |========|"));
          break;
      }
    }

    private static string PegaCharDescobertos(string[] charDescobertos)
    {
      string chars = string.Empty;
      for (int i = 0; i < charDescobertos.Length; i++)
      {
        if (string.IsNullOrEmpty(charDescobertos[i]))
          chars += "_";
        else
          chars += charDescobertos[i];
      }
      return chars;
    }

    private static void AvisoCharExist(string palavraInformada, int acertos, int chances, string[] charDescobertos, string[] charDigitados, bool vezj1)
    {
      limpaCMD();
      Console.WriteLine("\nOps, caracter já digitado.");
      if (vezj1)
        Console.Write("\n************* Placar Jogador 1 *************");
      else
        Console.Write("\n************* Placar Jogador 2 *************");

      Console.Write(String.Format("\nQuantidade de caracteres já descobertos: {0} - ({1})", acertos, PegaCharDescobertos(charDescobertos)));
      Console.Write(String.Format("\nCaracteres já digitador: ({0})", PegaCharDescobertos(charDigitados)));
      Console.Write(String.Format("\nNúmero de caracteres para serem descobertos: {0}", palavraInformada.Length - acertos));
    }

    private static void JogoGanho(bool vezj1)
    {
      Console.Clear();
      if (vezj1)
        Console.WriteLine("\n************ Parabéns jogador 1 você ganhou! ************");
      else
        Console.WriteLine("\n************ Parabéns jogador 2 você ganhou! ************");

      Console.WriteLine("\nVocê completou a palavra corretamente e é o vencedor!");
    }

    private static void JogoPerdido()
    {
      Console.WriteLine("\nSuas chances esgotaram e infelizmente ninguem ganhou.");
      //Console.WriteLine(String.Format(@"
      //                                    -----|
      //                                    |    |
      //                                    |    O
      //                                    |   /|\
      //                                    |   / \
      //                                    |
      //                                    |========|"));
    }

    private static bool PalavraValida(string palavraJ1, string palavraJ2)
    {
      if (palavraJ1.Length == palavraJ2.Length)
        return true;

      return false;
    }

    private static bool PalavraDescoberta(string palavraJogador, ref int chances)
    {
      Console.Write("\nInforme a palavra: ");
      string palavraDesc = Console.ReadLine().ToUpper();

      if (palavraDesc == palavraJogador)
      {
        chances = 8;
        return true;
      }

      return false;
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

    private static void limpaCMD()
    {
      Console.Clear();
    }

    static void Main()
    {
      string palavraJ1 = "", palavraJ2 = "";
      string letra = "";
      char ultCharDesc = ' ';
      int acertosj1 = 0, acertosj2 = 0, erros_j1 = 0, erros_j2 = 0, tenta_J1 = 0, tenta_J2 = 0;
      bool vence1 = false, vence2 = false, vezJ1 = true;
      int qtdJ1 = 0, qtdJ2 = 0;

      MsgJogador_1();
      Console.Write("\nDigite a palavra desejada: ");
      palavraJ1 = Console.ReadLine().ToUpper();
      limpaCMD();

      bool palavraj2Correto = false;
      while (!palavraj2Correto)
      {
        MsgJogador_2();
        Console.Write("\nDigite uma palavra com " + palavraJ1.Length + " caracteres: ");
        palavraJ2 = Console.ReadLine().ToUpper();

        if (!PalavraValida(palavraJ1, palavraJ2))
        {
          limpaCMD();
          Console.WriteLine("Palavra informada é inválida");
        }
        else
        {
          palavraj2Correto = true;
        }
      }

      string[] charDigitados_J1 = new string[palavraJ1.Length + 7];
      string[] charDigitados_J2 = new string[palavraJ1.Length + 7];
      string[] charDescobertos_J1 = new string[palavraJ1.Length];
      string[] charDescobertos_J2 = new string[palavraJ1.Length];

      limpaCMD();
      while ((!vence1 && !vence2) || (erros_j1 == 7 && erros_j2 == 7))
      {
        if (erros_j1 == 7)
        {
          vezJ1 = false;
        }
        else if (erros_j2 == 7)
          vezJ1 = true;

        if (vezJ1)
          MsgJogador_1();
        else
          MsgJogador_2();

        string opcao = "";

        if ((vezJ1 && qtdJ1 > 0) || (!vezJ1 && qtdJ2 > 0))
        {
          int opcaoValida = 0;
          while (!int.TryParse(opcao, out opcaoValida))
          {
            Console.WriteLine("\nDigite 1 para informar uma nova letra. \nDigite 2 se já souber a palavra: ");
            opcao = Console.ReadLine();
          }
        }
        else
          opcao = "1";

        switch (opcao)
        {
          case "1":
            //Função para ler uma letra da tentativa. ->OK

            bool charDigitado = true;
            while (String.IsNullOrEmpty(letra) || charDigitado)
            {
              letra = lerLetra();

              //d.i. verificar se o caractere já foi digitado:
              if (vezJ1)
              {
                charDigitado = ValidaCharJaDigitado(charDigitados_J1, letra);
                if (charDigitado)
                  AvisoCharExist(palavraJ1, acertosj1, tenta_J1, charDescobertos_J1, charDigitados_J1, vezJ1);
              }
              else
              {
                charDigitado = ValidaCharJaDigitado(charDigitados_J2, letra);
                if (charDigitado)
                  AvisoCharExist(palavraJ2, acertosj2, tenta_J2, charDescobertos_J2, charDigitados_J2, vezJ1);
              }
            }

            //d.i.1. não foi digitado, vá para o passo 01.d.ii;
            bool AcertosTotais = false;
            bool CharDescobertos;
            if (vezJ1)
            {
              charDigitados_J1[qtdJ1] = letra;
              CharDescobertos = ValidaCharDescobertos(palavraJ2, letra);
              if (CharDescobertos)
              {
                descobriuCaractere(palavraJ2, letra, ref acertosj1, ref charDescobertos_J1, ref ultCharDesc);
                Acerto(ultCharDesc, vezJ1);
                AcertosTotais = TodosAcertos(charDescobertos_J1, palavraJ2);
              }
              else
              {
                limpaCMD();
                CharErro(vezJ1);
                MontagemForca(ref erros_j1);
              }

              if (AcertosTotais)
              {
                vence1 = true;
              }

              vezJ1 = false;
              qtdJ1++;
            }
            else
            {
              charDigitados_J2[qtdJ2] = letra;
              CharDescobertos = ValidaCharDescobertos(palavraJ1, letra);
              if (CharDescobertos)
              {
                descobriuCaractere(palavraJ1, letra, ref acertosj2, ref charDescobertos_J2, ref ultCharDesc);
                Acerto(ultCharDesc, vezJ1);
                AcertosTotais = TodosAcertos(charDescobertos_J2, palavraJ1);
              }
              else
              {
                limpaCMD();
                CharErro(vezJ1);
                MontagemForca(ref erros_j2);
              }

              if (AcertosTotais)
              {
                vence1 = true;
              }

              vezJ1 = true;
              qtdJ2++;
            }

            break;
          case "2":
            if (vezJ1)
            {
              tenta_J1++;
              vence1 = PalavraDescoberta(palavraJ2, ref tenta_J1);
              if (!vence1)
              {
                vezJ1 = false;
                Console.WriteLine("Palavra incorreta");
              }
            }
            else
            {
              tenta_J2++;
              vence2 = PalavraDescoberta(palavraJ1, ref tenta_J2);
              if (!vence2)
              {
                vezJ1 = true;
                Console.WriteLine("Palavra incorreta");
              }
            }
            break;
          default:
            break;
        }

      }

      if (vence1)
        JogoGanho(true);
      else if (vence2)
        JogoGanho(false);
      else
        JogoPerdido();

      Console.WriteLine("\nDigite qualquer tecla para finalizar...");
      Console.ReadLine();
    }
  }

}
