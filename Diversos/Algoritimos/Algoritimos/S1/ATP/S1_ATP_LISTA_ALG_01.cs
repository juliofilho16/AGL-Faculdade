using System;
using System.Collections.Generic;
using System.Text;

namespace Algoritimos.S1.ATP
{
  // Parte 1
  //
  public static class S1_ATP_LISTA_ALG_01
  {
    // 1 – Faça um programa em C# que leia dois números e calcule a soma, diferença, produto, quociente
    // inteiro e o quociente exato dos dois números.
    static void Atv_1()
    {
      int num1, num2;
      Console.Write("Digite o primeiro número: ");
      num1 = int.Parse(Console.ReadLine());
      Console.Write("\nDigite o segundo número: ");
      num2 = int.Parse(Console.ReadLine());
      Console.WriteLine(String.Format("A soma dos números {0} e {1} é: {2}", num1, num2, num1 +
      num2));
      //if (num1 > num2)
      Console.WriteLine(String.Format("A diferença é: {0}", num1 - num2));
      //else
      // Console.WriteLine(String.Format("A diferença é: {0}", num2 - num1));
      Console.WriteLine(String.Format("O produto é: {0}", num1 * num2));
      if (num1 % num2 == 0)
        Console.WriteLine(String.Format("Quociente: {0}", num1 / num2));
      else
        Console.WriteLine(String.Format("O quociente inteiro é: {0} e o quociente exato: { 0},{ 1}", num1 / num2, num1 % num2));
      Console.Write("\nDigite uma tecla para finalizar...");
      Console.ReadKey();
    }

    //2 – Faça um programa em C# que leia três números inteiros e imprima a soma, a média, o maior e 
    // o menor número digitado.
    static void Atv_2()
    {
      int num1, num2, num3, maior, menor;
      Console.WriteLine("Informe o 1º número");
      num1 = int.Parse(Console.ReadLine());
      Console.WriteLine("Informe o 2º número");
      num2 = int.Parse(Console.ReadLine());
      Console.WriteLine("Informe o 3º número");
      num3 = int.Parse(Console.ReadLine());
      if (num1 >= num2 && num1 >= num3)
        maior = num1;
      else
      if (num2 >= num3 && num2 >= num1)
        maior = num2;
      else if (num3 >= num2 && num3 >= num1)
        maior = num3;

      else
        maior = 0;
      if (num1 <= num2 && num1 <= num3)
        menor = num1;
      else
      if (num2 <= num3 && num2 <= num1)
        menor = num2;
      else if (num3 <= num2 && num3 <= num1)
        menor = num3;
      else
        menor = 0;
      Console.WriteLine(String.Format("A soma dos números: {0},{1} e {2} é: {3}", num1, num2,
      num3, num1 + num2 + num3));
      if (maior != 0)
        Console.WriteLine(String.Format("Maior número: {0}", maior));
      if (menor != 0 && menor != 0 && menor != 0)
        Console.WriteLine(String.Format("Média: {0}", (num1 + num2 + num3) / 3));
      else
        Console.WriteLine(String.Format("Ops, não é possível calcular a média aritimética"));
      Console.Write("\nDigite uma tecla para finalizar...");
      Console.ReadKey();
    }

    //3 – Faça um programa em C# que leia o salário de um funcionário e o percentual de aumento, 
    //calcule e mostre o valor do aumento e seu novo salário.
    static void Atv_3()
    {
      double salario, aumento;
      Console.WriteLine("Conversão de real pra Euro e Dólar");
      Console.Write("Informe o seu salário: R$");
      salario = double.Parse(Console.ReadLine());
      Console.Write("Informe o percentual de aumento (%): ");
      aumento = double.Parse(Console.ReadLine());
      Console.Write(String.Format("O valor do aumento é de R${0}. \nSeu novo salário: R${1}",
      aumento / 100 * salario, Math.Round(aumento / 100 * salario + salario, 2)));
      Console.Write("\nDigite uma tecla para finalizar...");
      Console.ReadKey();
    }

    //4 – Faça um programa em C# que leia o ano de nascimento de uma pessoa e o ano atual. Calcule e 
    //imprima a idade dessa pessoa, e quando ela fez(ou fará) 50 anos de idade.
    static void Atv_4()
    {
      int anoNasc, anoAtual, idade;
      Console.Write("Informe o seu ano de nascimento: ");
      anoNasc = int.Parse(Console.ReadLine());
      Console.Write("Informe o ano atual: ");
      anoAtual = int.Parse(Console.ReadLine());
      idade = anoAtual - anoNasc;
      if (idade < 50)
        Console.Write("Sua idade é de:{0}anos, você fará 50 anos no ano de {1}", idade, anoNasc
       + 50);
      else if (idade == 50)
        Console.Write("Sua idade é de:{0}anos, você fará 50 anos no ano de {1}", idade,
       anoAtual);
      else
        Console.Write("Sua idade é de:{0}anos, você fez 50 anos no ano de {1}", idade, anoNasc
       + 50);
      Console.Write("\nDigite uma tecla para finalizar...");
      Console.ReadKey();
    }

    //** 5– Joãozinho possui dois gatos, aos quais alimenta com ração.Ele comprou um saco de ração e deseja
    //saber em quantos dias seus gatos vão consumir toda a ração. Faça um programa em C# que leia o peso 
    //do saco de ração (em quilogramas) e a quantidade diária consumida por cada um de seus gatos (em
    //gramas). Você deve calcular e imprimir : 
    //a.Consumo diário dos gatos (em quilogramas)
    //b. Consumo semanal (em quilogramas)
    //c. Quanto tempo vai durar o saco de ração
    static void Atv_5()
    {
      double pesoSaco, qtdConsuG1, qtdConsuG2, consumoDiario, consumoSemanal;
      int tempDuracao;
      Console.WriteLine("Informe o peso do saco de ração (em Kg)");
      pesoSaco = double.Parse(Console.ReadLine());
      Console.WriteLine("Informe a quantidade diária consumida pelo 1º gato (em g)");
      qtdConsuG1 = double.Parse(Console.ReadLine());
      Console.WriteLine("Informe a quantidade diária consumida pelo 2º gato (em g)");
      qtdConsuG2 = double.Parse(Console.ReadLine());
      consumoDiario = (qtdConsuG1 + qtdConsuG2) / 1000;
      consumoSemanal = (qtdConsuG1 * 7 + qtdConsuG2 * 7) / 1000;
      tempDuracao = Convert.ToInt32(pesoSaco / consumoDiario);
      Console.WriteLine(String.Format("Consumo diário dos gatos: {0} Kg", consumoDiario));
      Console.WriteLine(String.Format("Consumo semanal dos gatos: {0} Kg", consumoSemanal));
      Console.WriteLine(String.Format("Tempo vai durar o saco de ração: {0} dias",
      tempDuracao));
      Console.ReadKey();
    }

    //6 – Faça um programa em C# que leia um determinado valor em Reais (R$) e a cotação do 
    //Dólar e do Euro(em reais) e faça a conversão do valor em Reais para essas duas moedas.
    static void Atv_6()
    {
      double valor, cotacaoDola, cotacaoEuro;
      Console.WriteLine("Conversão de real pra Euro e Dólar");
      Console.Write("Informe o valor: R$");
      valor = double.Parse(Console.ReadLine());
      Console.Write("Informe a cotação do Dólar: ");
      cotacaoDola = double.Parse(Console.ReadLine());
      Console.Write("Informe a cotação do Euro: ");
      cotacaoEuro = double.Parse(Console.ReadLine());
      Console.Write(String.Format("R${0} reais equivale a {1} em Euro e a {2} em dólar", valor,
      Math.Round(valor / cotacaoEuro, 2), Math.Round(valor / cotacaoDola, 2)));
      Console.Write("\nDigite uma tecla para finalizar...");
      Console.ReadKey();
    }

    //** 7 – Faça um programa em C# que calcule e mostre a
    //         tabuada de um número digitado pelo usuário. 
    static void Atv_7()
    {
      int num;
      Console.Write("Digite um número para montarmos a tabuada: ");
      num = int.Parse(Console.ReadLine());
      Console.WriteLine(String.Format(@"Tabuada do número: {0} \n {0} x 1 = {1} \n {0} x 2 = {2} \n { 0}
      x 3 = {3} \n {0}
      x 4 = {4} \n {0}
      x 5 = {5} \n {0}
      x 6 = {6} \n {0}
      x 7 = {7} \n {0}
      x 8 = {8} \n {0}
      x 9 = {9} ", num, num * 1, num * 2, num * 3, num * 4, num * 5, num * 6, num * 7, num * 8, num * 9));
      Console.Write("Digite uma tecla para finalizar...");
      Console.ReadKey();
    }

    //    ** 8 – Faça um programa em C# que receba o ano de nascimento de uma pessoa e o ano atual, calcule 
    //e mostre: 
    //a.A idade dessa pessoa em anos
    //b.A idade dessa pessoa em meses(aproximadamente)
    //c.A idade dessa pessoa em semanas(aproximadamente)
    //d.A idade dessa pessoa em dias(aproximadamente)
    static void Atv_8()
    {
      int anoNasc, anoAtual;
      string Pessoa;
      Console.Write("Digite o nome da pessoa: ");
      Pessoa = Console.ReadLine();
      Console.Write("Digite o ano de nascimento: ");
      anoNasc = int.Parse(Console.ReadLine());
      Console.Write("Digite o ano atual: ");
      anoAtual = int.Parse(Console.ReadLine());
      Console.WriteLine(String.Format("{0} tem {1} anos", Pessoa, anoAtual - anoNasc));
      Console.WriteLine(String.Format(@"A idade do(a) {0} em meses é aproximadamente de {1}  meses", Pessoa, (anoAtual - anoNasc) * 12));
      Console.WriteLine(String.Format(@"A idade do(a) {0} em semanas é aproximadamente de {1} semanas", Pessoa, (anoAtual - anoNasc) * 365 / 7));
      Console.WriteLine(String.Format(@"A idade do(a) {0} em dias é aproximadamente de {1} dias", Pessoa, (anoAtual - anoNasc) * 365));
      Console.Write("\nDigite uma tecla para finalizar...");
      Console.ReadKey();
    }

    //    ** 9 – Um funcionário recebe um salário fixo mais 4% de comissão sobre as vendas.Faça um programa
    //em C# que receba o salário fixo de um funcionário e o valor de suas vendas, calcule e imprima o valor da 
    //comissão e o salário final.
    static void Atv_9()
    {
      double salarioFixo, valVendas;
      Console.Write("Digite o salário fixo: R$");
      salarioFixo = double.Parse(Console.ReadLine());
      Console.Write("Digite o valor das vendas: R$");
      valVendas = double.Parse(Console.ReadLine());
      Console.WriteLine(String.Format("valor da comissão: R${0}", valVendas * 0.04));
      Console.WriteLine(String.Format("valor salário atual: R${0}", (valVendas * 0.04) +
      salarioFixo));
      Console.Write("\nDigite uma tecla para finalizar...");
      Console.ReadKey();
    }

    //    ** 10 – Faça um programa em C# que leia um número inteiro entre 0 e 99999 (caso seja digitado um 
    //número fora desse intervalo, você deve mostrar uma mensagem para o usuário). Decomponha esse
    //número e imprima os 5 algarismos que o compõe, um em cada linha.
    //Ex: 
    //Digite um número entre 0 e 99999: 34581 Número
    //válido! 
    //3 
    //4 
    //5 
    //8 
    //1
    static void Atv_10()
    {
      int num, numAux, y1, y2, y3, y4, y5;
      Console.Write("Digite um número: ");
      num = int.Parse(Console.ReadLine());
      if (num >= 10000 && num <= 99999)
      {
        Console.WriteLine(String.Format("Número válido"));
        numAux = num / 10000;
        y1 = numAux;
        numAux = num / 1000;
        y2 = numAux % 10;
        numAux = num / 100;
        y3 = numAux % 10;
        numAux = num / 10;
        y4 = numAux % 10;
        y5 = num % 10;
        Console.WriteLine(String.Format("{0}\n{1}\n{2}\n{3}\n{4}", y1, y2, y3, y4, y5));
      }
      else if (num >= 1000 && num <= 9999)
      {
        Console.WriteLine(String.Format("Número válido"));
        numAux = num / 1000;
        y1 = numAux;
        numAux = num / 100;
        y2 = numAux % 10;
        numAux = num / 10;
        y3 = numAux % 10;
        y4 = num % 10;
        Console.WriteLine(String.Format("{0}\n{1}\n{2}\n{3}", y1, y2, y3, y4));
      }
      else if (num >= 100 && num <= 999)
      {
        Console.WriteLine(String.Format("Número válido"));
        numAux = num / 100;
        y1 = numAux;
        numAux = num / 10;
        y2 = numAux % 10;
        y3 = num % 10;
        Console.WriteLine(String.Format("{0}\n{1}\n{2}", y1, y2, y3));
      }
      else if (num >= 10 && num <= 99)
      {
        Console.WriteLine(String.Format("Número válido"));
        numAux = num / 10;
        y1 = numAux;
        y2 = num % 10;
        Console.WriteLine(String.Format("{0}\n{1}", y1, y2));
      }
      else if (num > 0)
      {
        Console.WriteLine(String.Format("Número válido"));
        Console.WriteLine(String.Format("{0}", num));
      }
      else
        Console.WriteLine(String.Format("Número inválido"));
      Console.Write("\nDigite uma tecla para finalizar...");
      Console.ReadKey();
    }

    //    ** 11 – Uma P.A. (progressão aritmética) fica determinada pela sua razão(r) e pelo primeiro termo(a1). 
    //Faça um programa em C# que seja capaz de determinar qualquer termo de uma P.A., dado a razão e o 
    //primeiro termo.
    //an =a1 +(n−1)×r
    static void Atv_11()
    {
      int A1, razao, AN, n;
      Console.Write("Informe o valor do 1º termo da PA: ");
      A1 = int.Parse(Console.ReadLine());
      Console.Write("Informe o valor da razão da PA: ");
      razao = int.Parse(Console.ReadLine());
      Console.WriteLine("Informe a quantidade de termos: ");
      n = int.Parse(Console.ReadLine());
      AN = A1 + (n - 1) * 1;
      Console.WriteLine(String.Format("Termo: {0}", AN));
      Console.Write("\nDigite uma tecla para finalizar...");
      Console.ReadKey();
    }

    //    ** 12 – Certo dia o professor de Johann Friederich Carl Gauss(aos 10 anos de idade) mandou que os
    //alunos somassem os números de 1 a 100. Imediatamente Gauss achou a resposta(5050) aparentemente
    //sem cálculos.Supõe-se que já aí, Gauss, houvesse descoberto a fórmula de uma soma de uma progressão
    //aritmética.
    //Faça um programa em C# para realizar a soma de uma P.A. de N termos, sendo o primeiro a1 e o último an.
    static void Atv_12()
    {
      int A1, An, Sn;
      Console.Write("Informe o valor do 1º termo da PA: ");
      A1 = int.Parse(Console.ReadLine());
      Console.Write("Informe o valor do ultimo termo da PA: ");
      An = int.Parse(Console.ReadLine());
      Sn = (A1 + An) * An / 2;
      Console.WriteLine(String.Format("A soma dos números de {0} a {1} é {2}", A1, An, Sn));
      Console.Write("\nDigite uma tecla para finalizar...");
      Console.ReadKey();
    }

    //    ** 13 – João recebeu seu salário e precisa pagar duas contas que estão atrasadas.Ele deve pagar 2% de
    //multa + juros de 0,25% ao dia. Faça um programa em C# que leia o valor da conta do João e os dias de 
    //atraso, e calcule o valor total a pagar.
    static void Atv_13()
    {
      int valorConta, diasAtraso;
      Console.WriteLine("Informe o valor da conta do João");
      valorConta = int.Parse(Console.ReadLine());
      Console.WriteLine("Informe a quantidade de dias que a conta está atrasada");
      diasAtraso = int.Parse(Console.ReadLine());
      Console.WriteLine(String.Format("O valor total a pagar é: R${0}", (0.02 * valorConta +
      0.0025 * diasAtraso) + valorConta));
      Console.Write("\nDigite uma tecla para finalizar...");
      Console.ReadKey();
    }

    //    ** 14 – Generalize o programa acima para o usuário informe, além do valor da prestação e da quantidade
    //de dias em atraso, o percentual de multa e o percentual de juros.
    static void Atv_14()
    {
      int valorConta, diasAtraso;
      double percentMulta, percentJuros;
      Console.Write("Informe o valor da conta do João: R$");
      valorConta = int.Parse(Console.ReadLine());
      Console.Write("\nInforme a quantidade de dias que a conta está atrasada: ");
      diasAtraso = int.Parse(Console.ReadLine());
      Console.Write("\nInforme o percentual de multa (%): ");
      percentMulta = double.Parse(Console.ReadLine());
      Console.Write("\nInforme o percentual de juros (%): ");
      percentJuros = double.Parse(Console.ReadLine());
      Console.Write(String.Format("\nO valor total a pagar é: {0} reais", (((percentMulta /
      100) * valorConta) + (percentJuros / 100) * diasAtraso) + valorConta));
      Console.Write("\nDigite uma tecla para finalizar...");
      Console.ReadKey();
    }

    // ** 15 – Faça um programa em C# que calcule a área e perímetro de diversas figuras geométricas planas. 
    //O seu algoritmo deve apresentar o seguinte menu: 
    //Opções de cálculo 
    //1 – Área e perímetro de um quadrado 2 
    //– Área de um triângulo 
    //3 – Área e perímetro de um retângulo 
    //4 – Área e comprimento de uma circunferência 
    //5 – Área e perímetro de um losango 
    //6 – Área de um setor circular 
    //7 – Área da elipse 
    //8 – Área e perímetro do paralelogramo
    static void Atv_15()
    {
      double b, h, lado, r, D, d, anguloCentral, rMaior, rMenor;
      Console.WriteLine("Informe o número para calcular a área e perímetro de um figura geométrica plana");
      Console.WriteLine("1 – Área e perímetro de um quadrado");
      Console.WriteLine("2 – Área de um triângulo");
      Console.WriteLine("3 – Área e perímetro de um retângulo");
      Console.WriteLine("4 – Área e comprimento de uma circunferência");
      Console.WriteLine("5 – Área e perímetro de um losango");
      Console.WriteLine("6 – Área de um setor circular");
      Console.WriteLine("7 – Área da elipse");
      Console.WriteLine("8 – Área e perímetro do paralelogramo");
      int escolha = int.Parse(Console.ReadLine());
      if (escolha == 1)
      {
        Console.WriteLine("Informe o valor de um dos lados do quadrado");
        lado = double.Parse(Console.ReadLine());
        Console.WriteLine(String.Format("Área: {0} Perimetro: {1}", Math.Pow(lado, 2), 4 *
       lado));
      }
      else if (escolha == 2)
      {
        Console.WriteLine("Informe o valor da base do triângulo");
        b = double.Parse(Console.ReadLine());
        Console.WriteLine("Informe o valor da base do triângulo");
        h = double.Parse(Console.ReadLine());
        Console.WriteLine(String.Format("Área: {0} Perimetro: {1}", (b * h) / 2, 2 * h + b));
      }
      else if (escolha == 3)
      {
        Console.WriteLine("Informe o valor da base do triângulo");
        b = double.Parse(Console.ReadLine());
        Console.WriteLine("Informe o valor da base do triângulo");
        h = double.Parse(Console.ReadLine());
        Console.WriteLine(String.Format("Área: {0} Perimetro: {1}", b * h, 2 * h + 2 * b));
      }
      else if (escolha == 4)
      {
        Console.WriteLine("Informe o valor do raio");
        r = double.Parse(Console.ReadLine());
        Console.WriteLine(String.Format("Área: {0} Perimetro: {1}", 3.14 * Math.Pow(r, 2), 2 *
       3.14 * r));
      }
      else if (escolha == 5)
      {
        Console.WriteLine("Informe o valor da diagonal maior");
        D = double.Parse(Console.ReadLine());
        Console.WriteLine("Informe o valor da diagonal menor");
        d = double.Parse(Console.ReadLine());
        Console.WriteLine("Informe o valor de um dos lados");
        lado = double.Parse(Console.ReadLine());
        Console.WriteLine(String.Format("Área: {0} Perimetro: {1}", D * d / 2, 4 * lado));
      }
      else if (escolha == 6)
      {
        Console.WriteLine("Informe o valor do raio");
        r = double.Parse(Console.ReadLine());
        Console.WriteLine("Informe o valor do ângulo central");
        anguloCentral = double.Parse(Console.ReadLine());
        double comprimento = 2 * 3.14 * r * (anguloCentral / 360);
        Console.WriteLine(String.Format("Área: {0} Perimetro: {1}", anguloCentral * 3.14 *
       Math.Pow(r, 2) / 360, r + r + comprimento));
      }
      else if (escolha == 7)
      {
        Console.WriteLine("Informe o valor do raio maior");
        rMaior = double.Parse(Console.ReadLine());
        Console.WriteLine("Informe o valor do raio menor");
        rMenor = double.Parse(Console.ReadLine());
        Console.WriteLine(String.Format("Área: {0} ", rMaior * rMenor * 3.14));
      }
      else
      {
        Console.WriteLine("Informe o valor da base do paralelogramo ");
        b = double.Parse(Console.ReadLine());
        Console.WriteLine("Informe o valor da base do paralelogramo");
        h = double.Parse(Console.ReadLine());
        Console.WriteLine(String.Format("Área: {0} Perimetro: {1}", b * h, 2 * (b + h)));
      }
      Console.Write("\nDigite uma tecla para finalizar...");
      Console.ReadKey();
    }

  }

}
