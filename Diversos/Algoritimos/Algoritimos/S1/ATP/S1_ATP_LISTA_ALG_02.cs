using System;
using System.Collections.Generic;
using System.Text;

namespace Algoritimos.S1.ATP
{
  // Parte 2 – Estrutura condicional (comando SE)
  //
  public static class S1_ATP_LISTA_ALG_02
  {

    //1 – Faça um programa em C# que receba dois números e imprima qual é o menor e qual é o maior. 
    //
    static void Atv_1()
    {
      int num1, num2;
      Console.WriteLine("Informe o primeiro número");
      num1 = int.Parse(Console.ReadLine());
      Console.WriteLine("Informe o segundo número");
      num2 = int.Parse(Console.ReadLine());
      if (num1 > num2)
        Console.WriteLine(String.Format("O número maior é {0} e o menor número é {1}", num1,
       num2));
      else
        Console.WriteLine(String.Format("O número maior é {0} e o menor número é {1}", num2,
       num1));
      Console.Write("\nDigite uma tecla para finalizar...");
      Console.ReadKey();
    }

    //4 – Faça um programa em C# que leia um número e imprima se ele é par ou ímpar. 
    //
    static void Atv_4()
    {
      int num;
      Console.WriteLine("Informe um número");
      num = int.Parse(Console.ReadLine());
      if (num % 2 == 0)
        Console.WriteLine(String.Format("O número {0} é par", num));
      else
        Console.WriteLine(String.Format("O número {0} é impar", num));
      Console.Write("\nDigite uma tecla para finalizar...");
      Console.ReadKey();
    }

    //7 – Faça um programa em C# que leia um número e imprima a raiz quadrada do número caso ele 
    //seja positivo ou igual a zero.Se o número for negativo, imprima a mensagem: “Não é possível calcular a
    //raiz quadrada do número XXX”, onde XXX é o número digitado.
    static void Atv_7()
    {
      int num;
      Console.WriteLine("Informe um número");
      num = int.Parse(Console.ReadLine());
      if (num > 0)
        Console.WriteLine(String.Format("A raiz quadrada do número {0} é {1}", num,
       Math.Sqrt(num)));
      else
        Console.WriteLine(String.Format("“Não é possível calcular a raizquadrada do número {0}", num));
      Console.Write("\nDigite uma tecla para finalizar...");
      Console.ReadKey();
    }

    //    * 8 – Faça um programa em C# que receba o salário de um funcionário e calcule sua participação nos 
    //lucros da empresa.Funcionários com salário inferior a R$ 500,00 receberão R$ 150,00 mais 14,78% sobre
    //o salário.Funcionários que recebam entre R$ 500,01 e R$ 1.000,00 receberão R$ 250,00 mais 9,5% sobre
    //o salário.Finalmente, funcionários com salário superior a R$1.000,01 receberão R$ 450,00 mais 6,43% 
    //sobre o salário.
    static void Atv_8()
    {
      double salarioFunc, salFinal;
      Console.WriteLine("Informe o sálario do funcionário");
      salarioFunc = double.Parse(Console.ReadLine());
      if (salarioFunc < 500.00)
        salFinal = (salarioFunc + 150) + (0.1478 * salarioFunc);
      else
       if (salarioFunc < 1000.00)
        salFinal = (salarioFunc + 250) + (0.095 * salarioFunc);
      else
        salFinal = (salarioFunc + 450) + (0.0643 * salarioFunc);
      Console.WriteLine(String.Format("O sálario desde funcionário é de: R${0}", Math.Round(salFinal, 2)));
      Console.Write("\nDigite uma tecla para finalizar...");
      Console.ReadKey();
    }

    //    ** 10 – Faça um programa em C# que receba dois números e a opção referente à operação que o usuário 
    //deseja executar.Imprima o resultado da operação:
    //    Opção Operação 
    //1 Média aritmética entre os números 
    //2 Produto dos números 
    //3 Quociente da divisão inteira do primeiro pelo segundo(não permitir divisão por
    //Zero, informar ao usuário que a operação não pode ser realizada)
    //Caso a opção desejada seja outra, o usuário deve ser informado que o valor não é aceito.
    static void Atv_10()
    {
      double num1, num2, resultado;
      int menu;
      Console.WriteLine("Digite o número referente à operação que deseja realizar");
      Console.WriteLine("1 – Média aritmética entre os números");
      Console.WriteLine("2 – Produto dos números");
      Console.WriteLine("3 – Quociente da divisão inteira do primeiro pelo segundo");
      menu = int.Parse(Console.ReadLine());
      if (menu == 1)
      {
        Console.WriteLine("Digite o primeiro número");
        num1 = double.Parse(Console.ReadLine());
        Console.WriteLine("Digite o segundo número");
        num2 = double.Parse(Console.ReadLine());
        resultado = (num1 + num2) / 2;
        Console.WriteLine(String.Format("Média aritmética entre os números {0} e {1} é {2}",
       num1, num2, resultado));
      }
      else if (menu == 2)
      {
        Console.WriteLine("Informe o primeiro número");
        num1 = double.Parse(Console.ReadLine());
        Console.WriteLine("Informe o segundo número");
        num2 = double.Parse(Console.ReadLine());
        resultado = num1 * num2;
        Console.WriteLine(String.Format("O Produto dos números {0} e {1} é {2}", num1, num2,
       resultado));
      }
      else if (menu == 3)
      {
        Console.WriteLine("Informe o dividendo");
        num1 = double.Parse(Console.ReadLine());
        Console.WriteLine("Informe o divisor");
        num2 = double.Parse(Console.ReadLine());
        if (num2 == 0)
          Console.Write("Não é possível dividir por 0");
        else
        {
          resultado = num1 / num2;
          Console.WriteLine(String.Format("O resultado da divisão do número {0} por {1} é {2}",
         num1, num2, resultado));
        }
      }
      else
        Console.WriteLine("Valor invalido");
      Console.Write("\nDigite uma tecla para finalizar...");
      Console.ReadKey();
    }

    //** 11 – Faça um programa em C# que determine a data cronologicamente maior de duas datas fornecidas 
    //pelo usuário.Cada data deve ser fornecida por três valores inteiros(dia, mês e ano). 
    static void Atv_11()
    {
      int dia1, mes1, ano1, dia2, mes2, ano2;
      Console.WriteLine("Informe o dia da primeira data");
      dia1 = int.Parse(Console.ReadLine());
      Console.WriteLine("Informe o mês da primeira data");
      mes1 = int.Parse(Console.ReadLine());
      Console.WriteLine("Informe o ano da primeira data");
      ano1 = int.Parse(Console.ReadLine());
      Console.WriteLine("Informe o dia da segunda data");
      dia2 = int.Parse(Console.ReadLine());
      Console.WriteLine("Informe o mês da segunda data");
      mes2 = int.Parse(Console.ReadLine());
      Console.WriteLine("Informe o ano da segunda data");
      ano2 = int.Parse(Console.ReadLine());
      if (ano1 == ano2 && mes1 == mes2 && dia1 == dia2)
        Console.WriteLine("As datas informadas são iguais");
      else
       if (ano1 > ano2 || (ano1 == ano2 && mes1 > mes2) || (ano1 == ano2 && mes1 == mes2 &&
      dia1 > dia2))
        Console.WriteLine("A 1º data informada é maior");
      else
        Console.WriteLine("A 2º data informada é maior");
      Console.Write("\nDigite uma tecla para finalizar...");
      Console.ReadKey();
    }

    //** 13 – Faça um programa em C# que informe a quantidade total de calorias de uma refeição a partir do 
    //usuário que deverá informar o prato, a sobremesa e a bebida(veja a tabela a seguir).
    //Sugestão: enumere cada opção de prato, sobremesa e bebida.
    //Prato: 1 - vegetariano, 2 – Peixe, 3 – Frango, 4 – Carne
    //Sobremesa: 1 – Abacaxi, 2 – Sorvete diet, 3 – Mouse diet, 4 – Mouse chocolate Bebida: 
    //1 – Chá, 2 - Suco de laranja, 3 – Suco de melão, 4 – Refrigerante diet.
    static void Atv_13()
    {
      int prato, sobremesa, bebida, qtdCal = 0;
      Console.WriteLine("Informe a sua refeição de acordo com as opções abaixo.");
      Console.WriteLine("Pratos: 1 - vegetariano, 2 – Peixe, 3 – Frango, 4 – Carne");
      prato = int.Parse(Console.ReadLine());
      Console.WriteLine("Sobremesas: 1 – Abacaxi, 2 – Sorvete diet, 3 – Mouse diet, 4 – Mouse chocolate");
      sobremesa = int.Parse(Console.ReadLine());
      Console.WriteLine("Bebidas: 1 – Chá, 2 - Suco de laranja, 3 – Suco de melão, 4 – Refrigerante diet.");
      bebida = int.Parse(Console.ReadLine());
      if (prato == 1)
        qtdCal += 180;
      else if (prato == 2)
        qtdCal += 230;
      else if (prato == 3)
        qtdCal += 250;
      else if (prato == 4)
        qtdCal += 350;
      else
        Console.Write("Valor Inválido...");
      if (sobremesa == 1)
        qtdCal += 75;
      else if (sobremesa == 2)
        qtdCal += 110;
      else if (sobremesa == 3)
        qtdCal += 170;
      else if (sobremesa == 4)
        qtdCal += 200;
      else
        Console.Write("Valor Inválido...");
      if (bebida == 1)
        qtdCal += 20;
      else if (bebida == 2)
        qtdCal += 70;
      else if (bebida == 3)
        qtdCal += 100;
      else if (bebida == 4)
        qtdCal += 65;
      else
        Console.Write("Valor Inválido...");
      Console.WriteLine(String.Format("A quantidade de caloria consumida foi de {0} calorias",
      qtdCal));
      Console.Write("\nDigite uma tecla para finalizar...");
      Console.ReadKey();
    }

    //    ** 14 – Faça um programa em C# que leia uma data (ler dia, mês e ano em variáveis separadas) e verifique 
    //se a data é válida(dia válido no mês, mês válido e ano compreendido entre 1900 e 2007). Se a data for 
    //válida, imprima a data no padrão DD/MM/AAAA, senão imprima a mensagem DATA INVÁLIDA.
    //Observação: Os meses de janeiro, março, maio, julho, agosto, outubro e dezembro tem 31 dias.Os meses
    //de abril, junho, setembro e novembro tem 30 dias.O mês de fevereiro tem 28 dias (desconsiderar anos
    //bissextos). 
    static void Atv_14()
    {
      int dia, mes, ano;
      Console.WriteLine("Informe o dia da data");
      dia = int.Parse(Console.ReadLine());
      Console.WriteLine("Informe o mês da data");
      mes = int.Parse(Console.ReadLine());
      Console.WriteLine("Informe o ano da data");
      ano = int.Parse(Console.ReadLine());
      bool dtValida = true;
      if (ano < 1900 || ano > 2007)
        dtValida = false;
      else
       if (mes > 12 || mes <= 0)
        dtValida = false;
      else
       if (mes == 02 && (dia <= 0 || dia > 28))
        dtValida = false;
      else
       if (mes % 2 == 0 && (dia <= 0 || dia > 30))
        dtValida = false;
      else
       if ((dia <= 0 || dia > 31))
        dtValida = false;
      if (dtValida)
        Console.WriteLine(String.Format("Data: {0}/{1}/{2}", dia, mes, ano));
      else
        Console.WriteLine("Data inválida");
      Console.Write("\nDigite uma tecla para finalizar...");
      Console.ReadKey();
    }

    //    ** 15 – Para descobrirmos se um ano é bissexsto, basta verificar se ele é divisível por 400 ou se o ano é
    //divisível por 4 mas não por 100. 
    //Por exemplo: 
    //◼ 1996 é bissexto(divisível por 4 mas não por 100)
    //◼ 1900 não é bissexto(divisível por 4 e também por 100)
    //◼ 2000 é bissexto(divisível por 400)
    //Faça um programa em C# que leia um determinado ano e informe se ele é bissexto. 
    static void Atv_15()
    {
      int ano;
      Console.WriteLine("Informe o ano");
      ano = int.Parse(Console.ReadLine());
      if (ano % 400 == 0 || (ano % 4 == 0 && ano % 100 != 0))
        Console.WriteLine("O ano é bissexto");
      else
        Console.WriteLine("O ano não é bissexto");
      Console.Write("\nDigite uma tecla para finalizar...");
      Console.ReadKey();
    }

    //    ** 17 – Faça um programa em C# que leia o dia e mês e indique a que estação a data se refere. OBS: seu 
    //programa não deve se preocupar se o usuário digitar uma data inválida(Ex: 29/2 em ano não bissexto ou
    //32/5)
    static void Atv_17()
    {
      int dia, mes;
      Console.WriteLine("Informe o dia");
      dia = int.Parse(Console.ReadLine());
      Console.WriteLine("Informe o mês");
      mes = int.Parse(Console.ReadLine());
      if ((mes == 12 && dia >= 22) || (mes < 3) || (mes == 3 && dia <= 19))
        Console.WriteLine("A estação do ano na data informada é Verão");
      else
       if (mes < 6 || (mes == 6 && dia <= 20))
        Console.WriteLine("A estação do ano na data informada é Outono");
      else
       if (mes < 9 || (mes <= 9 && dia <= 22))
        Console.WriteLine("A estação do ano na data informada é Inverno");
      else
        Console.WriteLine("A estação do ano na data informada é Primavera");
      Console.Write("\nDigite uma tecla para finalizar...");
      Console.ReadKey();
    }

    //    ** 18 – Faça um programa em C# que leia um dia, mês e ano e verifique se a data é válida. Seu algoritmo 
    //deve levar em consideração os anos bissextos.
    static void Atv_18()
    {
      int dia, mes, ano;
      Console.WriteLine("Informe o dia da data");
      dia = int.Parse(Console.ReadLine());
      Console.WriteLine("Informe o mês da data");
      mes = int.Parse(Console.ReadLine());
      Console.WriteLine("Informe o ano da data");
      ano = int.Parse(Console.ReadLine());
      bool dtValida = true;
      if (ano < 1900 || ano > 2007)
        dtValida = false;
      else
       if (mes > 12)
        dtValida = false;
      else
       if (mes == 02)
      {
        if ((ano % 400 == 0 || (ano % 4 == 0 && ano % 100 != 0)))
        {
          if ((dia <= 0 || dia > 29))
            dtValida = false;
        }
        else if (dia <= 0 || dia > 28)
          dtValida = false;
      }
      else
       if (mes % 2 == 0 && (dia <= 0 || dia > 30))
        dtValida = false;
      else
       if ((dia <= 0 || dia > 31))
        dtValida = false;
      if (dtValida)
        Console.WriteLine(String.Format("A data informada é válida. Data: {0}/{1}/{2}", dia,
       mes, ano));
      else
        Console.WriteLine("Data inválida");
      Console.Write("\nDigite uma tecla para finalizar...");
      Console.ReadKey();
    }

    //    ** 19 – Em estatística, a mediana é dada pelo valor central em uma série ordenada, a amplitude é
    //calculada através da subtração do maior pelo menor valor da série e a média aritmética é a soma de todos
    //os valores divido pela quantidade(ex: 3,8,9 – mediana = 8, amplitude = 6, média = 6.67). Faça um
    //programa que leia 3 números, coloque-os em ordem crescente, e calcule as 3 medidas acima.
    static void Atv_19()
    {
      int num1, num2, num3, maior, mediana, menor;
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
      if ((num1 >= num2 && num1 <= num3) || (num1 >= num3 && num1 <= num2))
        mediana = num1;
      else if ((num2 >= num1 && num2 <= num3) || (num2 >= num3 && num2 <= num1))
        mediana = num2;
      else if ((num3 >= num2 && num3 <= num1) || (num3 >= num1 && num3 <= num2))
        mediana = num3;
      else
        mediana = 0;
      if (num1 <= num2 && num1 <= num3)
        menor = num1;
      else
        if (num2 <= num3 && num2 <= num1) menor = num2;
      else if (num3 <= num2 && num3 <= num1)
        menor = num3;
      else
        menor = 0;
      if (mediana != 0)
        Console.WriteLine(String.Format("Mediana: {0}", mediana));
      else
        Console.WriteLine(String.Format("Ops, não é possível calcular a Mediana"));
      if (maior != 0)
        Console.WriteLine(String.Format("Amplitude: {0}", maior - menor));
      else
        Console.WriteLine(String.Format("Ops, não é possível calcular a Amplitude"));
      if (num1 != 0 && num2 != 0 && num3 != 0)
        Console.WriteLine(String.Format("Média Aritimética: {0}", (num1 + num2 + num3) / 3));
      Console.Write("\nDigite uma tecla para finalizar...");
      Console.ReadKey();
    }

    //    ** 20 – O Índice de Massa Corporal(IMC) é um índice simples adotado pela Organização Mundial de Saúde
    //(OMS) para avaliação do peso de uma pessoa.No website da OMS (World Health Organization, em inglês)
    //http://apps.who.int/bmi/index.jsp?introPage=intro_3.html, podemos encontrar a classificação utilizada 
    //atualmente para o IMC.
    //Faça um programa em C# que calcule o IMC de uma pessoa e imprima uma mensagem mostrando qual o 
    //seu IMC e sua situação.Se a pessoa estiver abaixo do peso ideal, calcule e imprima qual seria o seu peso
    //mínimo ideal e quantos quilos ela deveria ganhar. Caso a pessoa esteja acima do peso ideal, calcule e
    //imprima qual é o seu peso máximo ideal e quantos quilos ela deveria perder. 
    //IMC Situação 
    //< 16 Magreza severa 
    //16 – 16.99 Magreza moderada 
    //17 – 18.49 Magreza leve 
    //18.5 – 24.99 Peso ideal 
    //25 – 29.99 Sobrepeso (pré-obesidade)
    //30 – 34.99 Obesidade grau I 
    //35 – 39.99 Obesidade grau II(severa)
    //>= 40 Obesidade grau III(mórbida)
    static void Atv_20()
    {
      double peso, altura, imc, pesoIdeal, pesoIdealMax;
      Console.WriteLine("Cálculo IMC");
      Console.Write("Informe seu peso (kg): ");
      peso = double.Parse(Console.ReadLine());
      Console.Write("Informe sua altura (m): ");
      altura = double.Parse(Console.ReadLine());
      imc = peso / Math.Pow(altura, 2);
      pesoIdeal = 18.5 * Math.Pow(altura, 2);
      pesoIdealMax = 24.99 * Math.Pow(altura, 2);
      if (imc < 16)
        Console.WriteLine(String.Format(@"\nSituação: Magreza severa - IMC: {0}.\nPeso ideal 
       mínimo: {1} -necessidade de ganhar {2}  kg", Math.Round(imc, 2), Math.Round(pesoIdeal, 2),
        Math.Round(pesoIdeal - imc, 2)));
      else if (imc < 16.99)
        Console.WriteLine(String.Format(@"\nSituação: Magreza moderada - IMC: {0}.\nPeso ideal 
       seria: {1}
      -necessidade de ganhar {2}
      kg", Math.Round(imc, 2), Math.Round(pesoIdeal, 2), Math.Round(pesoIdeal - imc, 2)));
      else if (imc < 18.49)
        Console.WriteLine(String.Format(@"\nSituação: Magreza leve - IMC: {0}.\nPeso ideal 
       seria: {1} -necessidade de ganhar {2}  kg", Math.Round(imc, 2), Math.Round(pesoIdeal, 2), Math.Round(pesoIdeal - imc, 2)));
      else if (imc < 24.99)
        Console.WriteLine(String.Format("\nSituação: Peso ideal - IMC: {0}.", Math.Round(imc,
       2)));
      else if (imc < 29.99)
        Console.WriteLine(String.Format(@"\nSituação: Sobrepeso (pré-obesidade) - IMC de: {0}.\nPeso ideal seria: {1}
      -necessidade de perder {2}
      kg", Math.Round(imc, 2), Math.Round(pesoIdeal, 2), Math.Round(pesoIdealMax - imc, 2)));
      else if (imc < 34.99)
        Console.WriteLine(String.Format(@"\nSituação: Obesidade grau I - IMC de: {0}.\nPeso 
       ideal seria: {1}
      -necessidade de perder {2}
      kg", Math.Round(imc, 2), Math.Round(pesoIdeal, 2), Math.Round(pesoIdealMax - imc, 2)));
      else if (imc < 39.99)
        Console.WriteLine(String.Format(@"\nSituação: Obesidade grau II (severa) - IMC de: {0}.\nPeso ideal seria: {1}
      -necessidade de perder {2}
      kg", Math.Round(imc, 2), Math.Round(pesoIdeal, 2), Math.Round(pesoIdealMax - imc, 2)));
      else
        Console.WriteLine(String.Format(@"\nSituação: Obesidade grau III (mórbida) - IMC de: {0}.\nPeso ideal seria: {1}
      -necessidade de perder {2}
      kg", Math.Round(imc, 2), Math.Round(pesoIdeal, 2), Math.Round(pesoIdealMax - imc, 2)));
      Console.Write("\nDigite uma tecla para finalizar...");
      Console.ReadKey();
    }

    //    ** 21 – A aceleração da gravidade na superfície terrestre é de 9,80665 m/s² (o valor real pode variar
    //ligeiramente ao longo da superfície da Terra). Esta medida é conhecida como g.A lista que se segue
    //apresenta a força da gravidade (em múltiplos de g) na superfície de alguns planetas do Sistema Solar.
    //Para calcular a sua massa em outro planeta, basta multiplicar o valor se sua massa pela gravidade
    //relativa do outro planeta. Por exemplo, se a massa de uma pessoa na terra é 50kg, ela terá uma massa
    //de 117 kg (50 x 2.34) em Júpiter.
    //Planeta Gravidade relativa
    //Mercúrio 0.376 
    //Vênus 0.903 
    //Marte 0.38 
    //Júpiter 2.34 
    //Saturno 1.16 
    //Urano 1.15 
    //Netuno 1.19 
    //Faça um programa em C# que leia uma massa (em kg) e o nome do planeta. Efetue a conversão das massas 
    //com base na tabela acima.
    static void Atv_21()
    {
      double massaTerra, massaPlanetas = 0;
      string nome;
      Console.WriteLine("Planeta:");
      Console.WriteLine("Mercúrio\nVênus\nMarte\nJúpiter\nSaturno\nUrano\n");
      Console.WriteLine("Informe o nome do planeta de acordo com a tabela acima: ");
      nome = Console.ReadLine();
      Console.WriteLine("Informe a sua massa corporal em Kg: ");
      massaTerra = double.Parse(Console.ReadLine());
      if (nome.Equals("Mercúrio"))
        massaPlanetas = massaTerra * 0.376;
      else if (nome.Equals("Vênus"))
        massaPlanetas = massaTerra * 0.903;
      else if (nome.Equals("Marte"))
        massaPlanetas = massaTerra * 0.38;
      else if (nome.Equals("Júpiter"))
        massaPlanetas = massaTerra * 2.34;
      else if (nome.Equals("Saturno"))
        massaPlanetas = massaTerra * 1.16;
      else if (nome.Equals("Urano"))
        massaPlanetas = massaTerra * 1.15;
      else
        massaPlanetas = massaTerra * 1.19;
      if (massaPlanetas == 0)
        Console.Write("O nome digitado está incorreto.");
      else
        Console.Write(String.Format("Sua massa será de {0} kg.", massaPlanetas));
      Console.Write("\nDigite uma tecla para finalizar...");
      Console.ReadKey();
    }

  }

}
