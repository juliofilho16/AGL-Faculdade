using System;
using System.Collections.Generic;
using System.Text;

namespace Algoritimos.S1.ATP
{
  // Parte 3 – Vetores e Loops
  //
  public static class S1_ATP_LISTA_ALG_03
  {
    #region Parte 1 – Comando FOR

    //2 - Faça um programa em C# que imprima os números de 1 a 10 e seus valores elevados 
    //quadrado e  ao cubo respectivamente.Ex:
    //Numero = 1 Quadrado = 1 Cubo = 1
    //Numero = 2 Quadrado = 4 Cubo = 8 24 //......
    //Numero = 10 Quadrado = 100 Cubo = 1000
    public static void exercicio_2()
    {
      for (int i = 1; i <= 10; i++)
        Console.WriteLine(String.Format("Numero = {0} Quadrado = {1} Cubo = {2}!", i,
       Math.Pow(i, 2), Math.Pow(i, 3)));

      Console.ReadKey();
    }

    //3 – Faça um programa em C# que simule uma contagem regressiva de 10 minutos, ou 
    //seja, imprima 9:59,
    //9:58, 9:57, ... , 0:01, 0:00. (Dica: use um for decrescente – de 9 até 0 - para os minutos 
    //e outro para os 37 //segundos – de 59 até 0).
    public static void exercicio_3()
    {


      for (int m = 10; m >= 0; m--)
        for (int s = 59; s >= 0; s--)
          Console.WriteLine(String.Format("Contagem = {0}:{1}", m, s));

      Console.ReadKey();
    }

    // 4 – Faça um programa em C# que leia um número e verifique se ele é primo ou não. 
    //Dica: para verificar
    //se um número x é primo, divida - o por todos os números entre 1 e x. Se x for divisível 
    //por 1 ou 2 números, 50 // ele é primo.
    public static void exercicio_4()
    {
      Console.WriteLine("Digite um número");
      int num = int.Parse(Console.ReadLine());
      int contDivisivel = 0;


      for (int i = 1; i <= num; i++)
        if (num % i == 0)
          contDivisivel++;

      if (contDivisivel == 2)
        Console.WriteLine(String.Format("O número {0} é primo!", num));
      else
        Console.WriteLine(String.Format("O número {0} não é primo!", num));


      Console.ReadKey();
    }

    //5 – Faça um programa em C# que leia 10 números inteiros positivos e imprima se o 
    //número é par, ímpar
    //e/ ou primo.Dica: antes de tentar esse exercício, faça o exercício 4.
    //Exemplos:
    // num = 7 : ímpar primo
    // num = 9 : ímpar não primo
    // num = 18 : par não primo
    public static void exercicio_5()
    {


      int[] numeros = new int[10];
      string[] resultado = new string[10];

      for (int i = 0; i < numeros.Length; i++)
      {
        Console.WriteLine(String.Format("Digite o {0}º número", i + 1));
        numeros[i] = int.Parse(Console.ReadLine());
      }

      int contDivisivel = 0;

      for (int rep = 0; rep < numeros.Length; rep++)
      {
        for (int i = 1; i <= numeros[rep]; i++)
        {
          if (numeros[rep] % i == 0)
            contDivisivel++;
        }


        if (contDivisivel == 2)
          resultado[rep] = String.Format("é primo!", numeros[rep]);
        else
          resultado[rep] = String.Format("não é primo!", numeros[rep]);

        contDivisivel = 0;

        if (numeros[rep] % 2 == 0)
          resultado[rep] = String.Format("{0} - é par!", resultado[rep]);
        else
          resultado[rep] = String.Format("{0} - é impar!", resultado[rep]);
      }

      for (int i = 0; i < numeros.Length; i++)

        Console.WriteLine(String.Format("Número = {0} : {1}", numeros[i], resultado[i]));

      Console.ReadKey();
    }

    //6 – Faça um programa em C# que leia dois números x e y, e imprima TODOS os 
    //números primos no
    //intervalo fechado entre x e y.Dica: antes de fazer esse exercício, faça os exercícios 4 e 5.
    public static void exercicio_6()
    {

      Console.WriteLine("Digite o número de partida da contagem");
      int numP = int.Parse(Console.ReadLine());
      Console.WriteLine("Digite o número final da contagem");
      int numF = int.Parse(Console.ReadLine());
      int contDivisivel = 0;
      int length = (numF - numP) + 1;
      int[] numeros = new int[length];
      string[] resultado = new string[length];

      for (int rep = 0; rep < numeros.Length; rep++)
        numeros[rep] = numP + rep;

      //Imprimindo apenas para conferir a alimentação do array numeros
      //for (int i = 0; i < numeros.Length; i++)
      // Console.WriteLine(numeros[i]);

      for (int rep = 0; rep < numeros.Length; rep++)
      {
        for (int i = 1; i <= numeros[rep]; i++)
        {
          if (numeros[rep] % i == 0)
            contDivisivel++;
        }

        if (contDivisivel == 2)
          Console.WriteLine(String.Format("O Número {0} é primo!", numeros
         [rep]));

        contDivisivel = 0;
      }

      //for (int i = 0; i < numeros.Length; i++)
      // Console.WriteLine(String.Format("Número = {0} : {1}", numeros[i], resultado[i]));

      Console.ReadKey();
    }

    //7 – Faça um programa em C# que leia um número e verifique se ele é perfeito. Um 
    //número perfeito é um
    //número inteiro para o qual a soma de todos os seus divisores positivos 
    //próprios(excluindo ele mesmo) é
    //igual ao próprio número.Ex: 6 é perfeito a soma de seus divisores próprios (1 + 2 + 3) = 
    public static void exercicio_7()
    {
      Console.WriteLine("Digite um número");
      int numero = int.Parse(Console.ReadLine());
      int divisores = 0;

      for (int i = 1; i < numero; i++)
        if (numero % i == 0)
          divisores += i;

      if (divisores == numero)
        Console.WriteLine(String.Format("O número {0} é perfeito", numero));
      else
        Console.WriteLine(String.Format("O número {0} não é perfeito", numero));

      Console.ReadKey();
    }

    //10 – Faça um programa em C# que leia um número inteiro entre 1 e 9 e calcule sua 
    //tabuada.
    //Ex: Número 7:
    // 7 x 1 = 7 183 // 7 x 2 = 14 184 // ...
    // 7 x 10 = 70
    public static void exercicio_10()
    {
      Console.WriteLine("Informe um número entre 1 e 9.");
      int num = int.Parse(Console.ReadLine());

      if (num > 0 && num < 10)
      {
        Console.WriteLine(String.Format("******** Tabuada do número {0} ********", num));
        for (int i = 1; i <= 9; i++)
          Console.WriteLine(String.Format("{0} * {1} = {2}", num, i, num * i));
      }
      Console.ReadKey();
    }

    //11 – Faça um programa em C# que imprima a tabuada dos números entre 1 e 9. 
    //
    public static void exercicio_11()
    {

      for (int num = 1; num <= 9; num++)
      {
        Console.WriteLine(String.Format("******** Tabuada do número {0} ********",
       num));
        for (int i = 1; i <= 9; i++)
          Console.WriteLine(String.Format("{0} * {1} = {2}", num, i, num * i));
      }


      Console.ReadKey();
    }

    //Faça um programa em C# que leia o peso e altura de 10 pessoas e calcule a quantidade 
    //de pessoas
    //obesas (IMC >= 30).OBS: IMC = peso / alt2.
    public static void exercicio_12()
    {
      string[] pessoa = new string[10];
      double[] altura = new double[10];
      double[] peso = new double[10];
      int qtdObesas = 0;
      double imc;
      for (int i = 0; i < pessoa.Length; i++)
      {
        Console.WriteLine(String.Format("Digite o nome da {0}º pessoa", i + 1));
        pessoa[i] = Console.ReadLine();

        Console.WriteLine(String.Format("Digite a altura da(o) {0}", pessoa[i]));
        altura[i] = double.Parse(Console.ReadLine());

        Console.WriteLine(String.Format("Digite o peso da(o) {0}", pessoa[i]));
        peso[i] = double.Parse(Console.ReadLine());
      }
      for (int i = 0; i < pessoa.Length; i++)
      {
        imc = peso[i] / Math.Pow(altura[i], 2);
        if (imc >= 30)
          qtdObesas++;
      }
      Console.WriteLine(String.Format(" a quantidade de pessoas obesas é de: {0} pessoas", qtdObesas));
      Console.ReadKey();
    }

    //13 – Faça um programa em C# que leia o peso e altura de 10 pessoas e calcule a 
    //quantidade de pessoas
    //na faixa de peso ideal (IMC entre 20 e 25), abaixo do peso(IMC < 20) e acima do 
    //peso(IMC > 25).
    public static void exercicio_13()
    {
      string[] pessoa = new string[10];
      double[] altura = new double[10];
      double[] peso = new double[10];
      int qtdAcima = 0;
      int qtdPIdeal = 0;
      int qtdAbaixo = 0;
      double imc;
      for (int i = 0; i < pessoa.Length; i++)
      {
        Console.WriteLine(String.Format("Digite o nome da {0}º pessoa", i + 1));
        pessoa[i] = Console.ReadLine();

        Console.WriteLine(String.Format("Digite a altura da(o) {0}", pessoa[i]));
        altura[i] = double.Parse(Console.ReadLine());

        Console.WriteLine(String.Format("Digite o peso da(o) {0}", pessoa[i]));
        peso[i] = double.Parse(Console.ReadLine());
      }
      for (int i = 0; i < pessoa.Length; i++)
      {

        imc = peso[i] / Math.Pow(altura[i], 2);

        if (imc < 20)
          qtdAbaixo++;
        else
        if (imc <= 25)
          qtdPIdeal++;
        else
          qtdAcima++;
      }
      Console.WriteLine(String.Format("Quantidade de pessoas com: Peso Ideal = {0} -  Abaixo do peso = {1} -Acima do peso = {2} ", qtdPIdeal, qtdAbaixo, qtdAcima));
      Console.ReadKey();
    }

    #endregion Parte 1 – Comando FOR

    #region Parte 2 – COMANDO WHILE E DO WHILE

    //1 – Faça um programa em C# que leia o nome, idade, peso e altura de diversas pessoas. 
    //Calcule e imprima
    //para cada pessoa o seu IMC e situação.Ao final do programa imprima a quantidade de 
    //pessoas abaixo do
    //peso(IMC < 18), no peso ideal(IMC entre 18 e 25) e a quantidade de pessoas acima do 
    //peso(IMC > 25).
    public static void exParte2_01()
    {
      string NomePe;
      int idade;
      double altura;
      double peso;
      int qtdAcima = 0, qtdPIdeal = 0, qtdAbaixo = 0;
      double imc;
      bool continua = true;
      while (continua)
      {
        Console.WriteLine(String.Format("Digite o nome da pessoa"));
        NomePe = Console.ReadLine();

        Console.WriteLine(String.Format("Digite a idade da(o) {0}", NomePe));
        idade = int.Parse(Console.ReadLine());

        Console.WriteLine(String.Format("Digite a altura da(o) {0}", NomePe));
        altura = double.Parse(Console.ReadLine());

        Console.WriteLine(String.Format("Digite o peso da(o) {0}", NomePe));
        peso = double.Parse(Console.ReadLine());

        imc = peso / Math.Pow(altura, 2);


        if (imc < 20)
        {
          Console.WriteLine(String.Format("IMC = {0} - Situação = Abaixo do peso", imc));

          qtdAbaixo++;
        }
        else
        if (imc <= 25)
        {
          Console.WriteLine(String.Format("IMC = {0} - Situação = Peso ideal", imc));
          qtdPIdeal++;
        }
        else
        {
          Console.WriteLine(String.Format("IMC = {0} - Situação = Acima do Peso", imc));
          qtdAcima++;
        }

        Console.WriteLine("Deseja realizar o calculo de mais pessoas? (Digite S para Sim ou  N para Não)");
        char resp = char.Parse(Console.ReadLine().ToUpper());

        if (resp != 'S')
          continua = false;

      }
      Console.WriteLine(String.Format("Quantidade de pessoas com: Peso Ideal = {0} - Abaixo do peso = {1}-Acima do peso = {2}", qtdPIdeal, qtdAbaixo, qtdAcima));
      Console.ReadKey();
    }

    //2 – Faça um programa em C# que leia o sexo (‘M’ ou ‘F’), idade, altura e peso de 
    //diversas pessoas.Calculee imprima:
    //a.Quantidade de mulheres
    //b.Quantidade de homens
    //c.Idade média
    //d.Altura média
    //e.Peso médio
    public static void exParte2_02()
    {

      char sexo;
      int idade, somaIdade = 0;
      double altura, peso, Soma_h = 0, Soma_p = 0;
      int qtdHomens = 0, qtdMulheres = 0;
      bool continua = true;
      while (continua)
      {
        Console.WriteLine(String.Format("Digite o sexo (‘M’ ou ‘F’) da pessoa."));
        sexo = char.Parse(Console.ReadLine().ToUpper());

        Console.WriteLine("Digite a idade.");
        idade = int.Parse(Console.ReadLine());

        somaIdade += idade;

        Console.WriteLine("Digite a altura.");
        altura = double.Parse(Console.ReadLine());

        Soma_h += altura;


        Console.WriteLine("Digite o peso.");
        peso = double.Parse(Console.ReadLine());

        Soma_p += peso;

        if (sexo == 'F')
          qtdMulheres++;
        else
          qtdHomens++;

        Console.WriteLine("Deseja realizar o calculo de mais pessoas? (Digite S para Sim ou N para Não)");
        char resp = char.Parse(Console.ReadLine().ToUpper());

        if (resp != 'S')
          continua = false;

      }
      Console.WriteLine(String.Format(@"Quantidade de mulheres = {0}-
                                    Quantidade de homens = {1}
                                    -Idade média = {2}
                                    -Altura média = {3}
                                    -
                                    Peso médio = {4}"
      , qtdMulheres, qtdHomens, somaIdade / (qtdHomens + qtdMulheres),
     Soma_h / (qtdHomens + qtdMulheres), Soma_p /
     (qtdHomens + qtdMulheres)));
      Console.ReadKey();
    }

    //3 – Faça um programa em C# que leia o nome, idade, peso, altura, salário, quantidade de dependentes e
    //sexo (M ou F) de diversas pessoas.Calcule e imprima:
    //a.Quantidade de homens com mais de 30 anos, que possuam dependentes e não têm salário
    //b.Quantidade de mulheres com idade entre 24 e 40 anos com IMC acima de 30
    //c.O nome da pessoa com maior valor de IMC
    //d.Percentual de homens e o percentual de mulheres
    //e.Salário médio das pessoas que não possuam dependentes
    public static void exParte2_03()
    {
      string NomePe, nomeMaiorIMC = string.Empty;
      char sexo;
      int idade, qtdH_M_30 = 0, qtdMul_24 = 0, qtdDep = 0, qtdNaoDep = 0, totalPessoas = 0;
      double altura, peso, salario, SomaSalario = 0, imc, maiorImc = 0, totalH = 0, totalMu
     = 0;
      bool continua = true;
      while (continua)
      {
        Console.WriteLine(String.Format("Digite o nome da pessoa"));
        NomePe = Console.ReadLine();

        Console.WriteLine(String.Format("Digite a idade da(o) {0}.", NomePe));
        idade = int.Parse(Console.ReadLine());


        Console.WriteLine(String.Format("Digite o peso da(o) {0}", NomePe));
        peso = double.Parse(Console.ReadLine());

        Console.WriteLine(String.Format("Digite a altura da(o) {0}", NomePe));
        altura = double.Parse(Console.ReadLine());

        Console.WriteLine(String.Format("Digite o salário da(o) {0}", NomePe));
        salario = double.Parse(Console.ReadLine());

        Console.WriteLine(String.Format("Digite a quantidade de dependentes da(o) {0}.",
       NomePe));
        qtdDep = int.Parse(Console.ReadLine());

        Console.WriteLine(String.Format("Digite o sexo (‘M’ ou ‘F’) da(o) {0}.", NomePe));
        sexo = char.Parse(Console.ReadLine().ToUpper());

        totalPessoas++;
        imc = peso / Math.Pow(altura, 2);

        if (imc > maiorImc)
        {
          maiorImc = imc;
          nomeMaiorIMC = NomePe;
        }

        if (qtdDep == 0)
        {
          SomaSalario += salario;
          qtdNaoDep++;
        }

        if (sexo == 'F')
        {
          totalMu++;
          if ((idade >= 24 && idade <= 40) && imc > 30)
            qtdMul_24++;
        }
        else
        {
          totalH++;

          if (idade > 30 && qtdDep > 0 && salario <= 0)
            qtdH_M_30++;
        }

        Console.WriteLine("Deseja realizar o calculo de mais pessoas? (Digite S para Sim ou N para Não)");
        char resp = char.Parse(Console.ReadLine().ToUpper());

        if (resp != 'S')
          continua = false;

      }
      Console.WriteLine(String.Format("Quantidade de homens com mais de 30 anos, que possuam dependentes e não têm salário = {0}", qtdH_M_30));
      Console.WriteLine(String.Format("Quantidade de mulheres com idade entre 12 24 e 40 anos com IMC acima de 30 = {0} ", qtdMul_24));
      Console.WriteLine(String.Format("O nome da pessoa com maior valor de IMC é {0}",
     nomeMaiorIMC));
      Console.WriteLine(String.Format("Percentual de homens = {0}% - Percentual de mulheres = {1}% ", (totalH / totalPessoas) * 100,
      (totalMu / totalPessoas) * 100));
      Console.WriteLine(String.Format("Salário médio das pessoas que não possuam dependentes = {0} ", SomaSalario / qtdNaoDep));
      Console.ReadKey();

    }

    //4 – Faça um programa em C# que leia o nome, nota e sexo de diversos alunos. Calcule e imprima:
    //a. Qtde.de mulheres
    //b.Qtde.de homens
    //c. % de alunos aprovados (geral)
    //d. % de mulheres aprovadas
    public static void exParte2_04()
    {
      string NomePe;
      double nota, qtdAprovados = 0, qtdMuAprovada = 0;
      char sexo;
      int totalPessoas = 0, qtdMu = 0, qtdHo = 0;
      double imc;
      bool continua = true;
      while (continua)
      {
        Console.WriteLine(String.Format("Digite o nome da pessoa"));
        NomePe = Console.ReadLine();

        Console.WriteLine(String.Format("Digite a nota da(o) {0}", NomePe));
        nota = double.Parse(Console.ReadLine());

        Console.WriteLine(String.Format("Digite o sexo (‘M’ ou ‘F’) da(o) {0}.", NomePe));
        sexo = char.Parse(Console.ReadLine().ToUpper());

        totalPessoas++;
        if (nota >= 60)
          qtdAprovados++;

        if (sexo == 'F')
        {
          qtdMu++;
          if (nota >= 60)
            qtdMuAprovada++;
        }
        else
          qtdHo++;


        Console.WriteLine("Deseja realizar o calculo de mais pessoas? (Digite S para Sim ou N para Não)");
        char resp = char.Parse(Console.ReadLine().ToUpper());

        if (resp != 'S')

          continua = false;
      }
      Console.WriteLine(String.Format("Qtde. de mulheres = {0}.", qtdMu));
      Console.WriteLine(String.Format("Qtde. de homens = {0}.", qtdHo));
      Console.WriteLine(String.Format("% de alunos aprovados (geral) = {0}%.", (qtdAprovados / totalPessoas) * 100));
      Console.WriteLine(String.Format("% de mulheres aprovadas = {0}%.",
     (qtdMuAprovada / totalPessoas) * 100));
      Console.ReadKey();
    }

    //5 – Faça um programa em C# que leia o nome, idade, sexo, estado civil (‘C’, ‘S’ ou ‘O’), peso, altura e
    //salário de diversas pessoas.Calcule e imprima:
    //a.Média salarial dos homens e das mulheres
    //b. % de pessoas obesas (IMC >= 30)
    //c.Qtde.mulheres solteiras com idade >= 40 anos
    //d.Nome e salário do homem solteiro que possui o maior salário.
    public static void exParte2_05()
    {
      string NomePe, nomeMaiorSalario = string.Empty;
      char sexo, estadoCivil;
      int idade, totalPessoas = 0;
      double altura, peso, salario, maiorSal = 0, SomaSalarioH = 0, SomaSalarioM = 0, imc,
     qtdObesas = 0, totalMuSol = 0, totalMu = 0, totalH = 0;
      bool continua = true;
      while (continua)
      {
        Console.WriteLine(String.Format("Digite o nome da pessoa"));
        NomePe = Console.ReadLine();

        Console.WriteLine(String.Format("Digite a idade da(o) {0}.", NomePe));
        idade = int.Parse(Console.ReadLine());

        Console.WriteLine(String.Format("Digite o sexo (‘M’ ou ‘F’) da(o) {0}.", NomePe));
        sexo = char.Parse(Console.ReadLine().ToUpper());

        Console.WriteLine(String.Format("Digite o estado civil (‘C’, ‘S’ ou ‘O’) da(o) {0}.", NomePe));
        estadoCivil = char.Parse(Console.ReadLine().ToUpper());

        Console.WriteLine(String.Format("Digite o peso da(o) {0}", NomePe));
        peso = double.Parse(Console.ReadLine());

        Console.WriteLine(String.Format("Digite a altura da(o) {0}", NomePe));
        altura = double.Parse(Console.ReadLine());

        Console.WriteLine(String.Format("Digite o salário da(o) {0}", NomePe));
        salario = double.Parse(Console.ReadLine());

        totalPessoas++;

        imc = peso / Math.Pow(altura, 2);


        if (imc >= 30)
          qtdObesas++;

        if (sexo == 'F')
        {
          totalMu++;
          SomaSalarioM += salario;
          if (estadoCivil == 'S' && idade >= 40)
            totalMuSol++;
        }
        else
        {
          SomaSalarioH += salario;
          totalH++;
          if (salario > maiorSal)
          {
            nomeMaiorSalario = NomePe;
            maiorSal = salario;
          }
        }

        Console.WriteLine("Deseja realizar o calculo de mais pessoas? (Digite S para Sim ou N para Não)");
        char resp = char.Parse(Console.ReadLine().ToUpper());

        if (resp != 'S')
          continua = false;

      }
      Console.WriteLine(String.Format("Média salarial dos homens = {0} - Das mulheres = {1}", (SomaSalarioH / totalH), (SomaSalarioM / totalMu)));
      Console.WriteLine(String.Format("% de pessoas obesas (IMC >= 30) = {0}", (qtdObesas / totalPessoas) * 100));
      Console.WriteLine(String.Format("Qtde. mulheres solteiras com idade >= 40 anos = {0}",
      totalMuSol));
      Console.WriteLine(String.Format("Nome e salário do homem solteiro que possui o maior salário é: {0} - {1}", nomeMaiorSalario, maiorSal));

      Console.ReadKey();
    }

    //6 – Faça um programa em C# que leia o sexo (M ou ‘F’), idade, altura e peso de diversas pessoas.Calculee imprima:
    //a.Quantidade de mulheres
    //b.Quantidade de homens
    //c.Idade média
    //d.Altura média
    //e.Peso médio
    public static void exParte2_06()
    {
      char sexo;
      int idade, totalPessoas = 0, totalMu = 0, totalHo = 0;
      double altura, peso, somaIdade = 0, somaAltura = 0, somaPeso = 0;
      bool continua = true;
      while (continua)

      {
        Console.WriteLine(String.Format("Digite o sexo (‘M’ ou ‘F’)."));
        sexo = char.Parse(Console.ReadLine().ToUpper());
        Console.WriteLine(String.Format("Digite a idade "));
        idade = int.Parse(Console.ReadLine());

        Console.WriteLine(String.Format("Digite a altura"));
        altura = double.Parse(Console.ReadLine());

        Console.WriteLine(String.Format("Digite o peso"));
        peso = double.Parse(Console.ReadLine());

        totalPessoas++;
        somaIdade += idade;
        somaPeso += peso;
        somaAltura += altura;

        if (sexo == 'F')
          totalMu++;
        else
          totalHo++;

        Console.WriteLine("Deseja realizar o calculo de mais pessoas? (Digite S para Sim ou N para Não)");
        char resp = char.Parse(Console.ReadLine().ToUpper());

        if (resp != 'S')
          continua = false;

      }
      Console.WriteLine(String.Format("Quantidade de mulheres é {0}", totalMu));
      Console.WriteLine(String.Format("Quantidade de homens é = {0}%", totalHo));
      Console.WriteLine(String.Format("Idade média = {0}", somaIdade / totalPessoas));
      Console.WriteLine(String.Format("Altura média= {0}", somaAltura / totalPessoas));
      Console.WriteLine(String.Format("Peso médio = {0}", somaPeso / totalPessoas));

      Console.ReadKey();
    }

    //– Faça um programa em C# que leia o nome, idade, peso, altura, salário, quantidade de dependentes e
    //sexo (M ou F) de diversas pessoas.Calcule e imprima:
    //a.Quantidade de homens com mais de 30 anos, que possuam dependentes e não têm salário
    //b.Quantidade de mulheres com idade entre 24 e 40 anos com IMC acima de 30
    //c.Salário médio das pessoas que não possuam dependentes
    public static void exParte2_07()
    {
      string NomePe;
      char sexo;
      int idade, qtdH_M_30 = 0, qtdMul_24 = 0, qtdDep = 0, qtdNaoDep = 0, totalPessoas = 0;

      double altura, peso, salario, SomaSalario = 0, imc, totalH = 0, totalMu = 0;
      bool continua = true;

      while (continua)
      {
        Console.WriteLine(String.Format("Digite o nome da pessoa"));
        NomePe = Console.ReadLine();

        Console.WriteLine(String.Format("Digite a idade da(o) {0}.", NomePe));
        idade = int.Parse(Console.ReadLine());

        Console.WriteLine(String.Format("Digite o peso da(o) {0}", NomePe));
        peso = double.Parse(Console.ReadLine());

        Console.WriteLine(String.Format("Digite a altura da(o) {0}", NomePe));
        altura = double.Parse(Console.ReadLine());

        Console.WriteLine(String.Format("Digite o salário da(o) {0}", NomePe));
        salario = double.Parse(Console.ReadLine());

        Console.WriteLine(String.Format("Digite a quantidade de dependentes da(o) {0}.",
       NomePe));
        qtdDep = int.Parse(Console.ReadLine());

        Console.WriteLine(String.Format("Digite o sexo (‘M’ ou ‘F’) da(o) {0}.", NomePe));
        sexo = char.Parse(Console.ReadLine().ToUpper());

        totalPessoas++;
        imc = peso / Math.Pow(altura, 2);

        if (qtdDep == 0)
        {
          SomaSalario += salario;
          qtdNaoDep++;
        }

        if (sexo == 'F')
        {
          totalMu++;
          if ((idade >= 24 && idade <= 40) && imc > 30)
            qtdMul_24++;
        }
        else
        {
          totalH++;

          if (idade > 30 && qtdDep > 0 && salario <= 0)
            qtdH_M_30++;
        }

        Console.WriteLine("Deseja realizar o calculo de mais pessoas? (Digite S para Sim ou N para Não)");
        char resp = char.Parse(Console.ReadLine().ToUpper());

        if (resp != 'S')
          continua = false;

      }
      Console.WriteLine(String.Format("Quantidade de homens com mais de 30 anos, que possuam dependentes e não têm salário = {0}", qtdH_M_30));
      Console.WriteLine(String.Format("Quantidade de mulheres com idade entre 24 e 40 anos com IMC acima de 30 = {0}", qtdMul_24));
      Console.WriteLine(String.Format("Salário médio das pessoas que não possuam  dependentes = {0}", SomaSalario / qtdNaoDep));
      Console.ReadKey();
    }

    //8 – Faça um programa em C# que leia o nome, idade, sexo, estado civil (‘C’, ‘S’ ou ‘O’), peso, altura e
    //salário de diversas pessoas.Calcule e imprima:
    //a.Média salarial dos homens e das mulheres
    //b.Qtde.mulheres solteiras com idade >= 40 anos
    public static void exParte2_08()
    {
      string NomePe;
      char sexo, estadoCivil;
      int idade, totalPessoas = 0;
      double altura, peso, salario, SomaSalarioH = 0, SomaSalarioM = 0, totalMuSol = 0, totalMu = 0, totalH = 0;
      bool continua = true;
      while (continua)
      {
        Console.WriteLine(String.Format("Digite o nome da pessoa"));
        NomePe = Console.ReadLine();

        Console.WriteLine(String.Format("Digite a idade da(o) {0}.", NomePe));
        idade = int.Parse(Console.ReadLine());

        Console.WriteLine(String.Format("Digite o sexo (‘M’ ou ‘F’) da(o) {0}.", NomePe));
        sexo = char.Parse(Console.ReadLine().ToUpper());

        Console.WriteLine(String.Format("Digite o estado civil (‘C’, ‘S’ ou ‘O’) da(o) {0}.", NomePe));
        estadoCivil = char.Parse(Console.ReadLine().ToUpper());

        Console.WriteLine(String.Format("Digite o peso da(o) {0}", NomePe)); peso =
      double.Parse(Console.ReadLine());

        Console.WriteLine(String.Format("Digite a altura da(o) {0}", NomePe));
        altura = double.Parse(Console.ReadLine());

        Console.WriteLine(String.Format("Digite o salário da(o) {0}", NomePe));
        salario = double.Parse(Console.ReadLine());

        totalPessoas++;

        if (sexo == 'F')
        {
          totalMu++;
          SomaSalarioM += salario;
          if (estadoCivil == 'S' && idade >= 40)
            totalMuSol++;
        }
        else

        {
          SomaSalarioH += salario;
          totalH++;
        }

        Console.WriteLine("Deseja realizar o calculo de mais pessoas? (Digite S para Sim ou N para Não)");
        char resp = char.Parse(Console.ReadLine().ToUpper());

        if (resp != 'S')
          continua = false;

      }
      Console.WriteLine(String.Format("Média salarial dos homens = {0} - Das mulheres = {1}", (SomaSalarioH / totalH), (SomaSalarioM / totalMu)));
      Console.WriteLine(String.Format("Qtde. mulheres solteiras com idade >= 40 anos = {0}", totalMuSol));

      Console.ReadKey();

    }

    //9 – Faça um programa em C# que leia os dados de diversas multas (nome, idade e sexo do condutor,
    //quantidade de pontos perdidos na carteira e valor da multa). Calcule e imprima:
    //a.Idade média dos condutores (ambos os sexos)
    //b.Valor total de todas as multas
    //c.Quantidade de pessoas que perderam 7 pontos na carteira 809
    public static void exParte2_09()
    {
      string NomePe;
      int idade, qtdPtsPe = 0, totalCont = 0, perd7Pts = 0;
      char sexo;
      double valorMulta, somaIdade = 0, somaMultas = 0;
      bool continua = true;
      while (continua)
      {
        Console.WriteLine(String.Format("Digite o nome da pessoa"));
        NomePe = Console.ReadLine();

        Console.WriteLine(String.Format("Digite a idade da(o) {0}", NomePe));
        idade = int.Parse(Console.ReadLine());

        Console.WriteLine(String.Format("Digite o sexo (‘M’ ou ‘F’) da(o) {0}.", NomePe));
        sexo = char.Parse(Console.ReadLine().ToUpper());

        Console.WriteLine(String.Format("Digite quantidade de pontos perdidos na carteira"));
        qtdPtsPe = int.Parse(Console.ReadLine());

        Console.WriteLine(String.Format("Digite o valor da multa)"));
        valorMulta = double.Parse(Console.ReadLine());

        totalCont++;
        somaIdade += idade;
        somaMultas += valorMulta;


        if (qtdPtsPe == 7)
          perd7Pts++;

        Console.WriteLine("Deseja realizar o calculo de mais pessoas? (Digite S para Sim ou N para Não)");
        char resp = char.Parse(Console.ReadLine().ToUpper());

        if (resp != 'S')
          continua = false;

      }
      Console.WriteLine(String.Format("Idade média dos condutores de ambos os sexos é de: {0}", somaIdade / totalCont));
      Console.WriteLine(String.Format("Valor total de todas as multas é de: {0}", somaMultas));
      Console.WriteLine(String.Format("Quantidade de pessoas que perderam 7 pontos na carteira é de {0}pessoas.", perd7Pts));
      Console.ReadKey();
    }

    //10 – Faça um programa em C# que leia a idade, salário, sexo, escolaridade (1 - 1º grau, 2 - 2º grau, 3 -
    //superior incompleto, 4 - superior completo) e o nome do curso(se escolaridade superior) de diversas 856 //pessoas.Calcule e imprima:
    //a.Salário médio das pessoas que não tem faculdade
    //b.Quantidade de engenheiros entrevistados
    public static void exParte2_10()
    {
      string NomePe, nomeCurso = string.Empty;
      int qtdEng = 0, escolaridade, totalPe = 0;
      char sexo;
      double salario, SomaSal = 0;
      bool continua = true;
      while (continua)
      {
        Console.WriteLine(String.Format("Digite o nome da pessoa"));
        NomePe = Console.ReadLine();

        Console.WriteLine(String.Format("Digite o sexo (‘M’ ou ‘F’) da(o) {0}.", NomePe));
        sexo = char.Parse(Console.ReadLine().ToUpper());

        Console.WriteLine(String.Format("Digite o seu salário"));
        salario = int.Parse(Console.ReadLine());

        Console.WriteLine(String.Format("Digite a escolaridade (1 - 1º grau, 2 - 2º grau, 3 -superior incompleto, 4 - superior completo)"));
        escolaridade = int.Parse(Console.ReadLine());

        if (escolaridade == 4)
        {
          Console.WriteLine(String.Format("Digite o nome do curso"));
          nomeCurso = Console.ReadLine();
        }
        else
        {

          totalPe++;
          SomaSal += salario;
        }

        if (nomeCurso == "Engenheiro")
          qtdEng++;

        Console.WriteLine("Deseja realizar o calculo de mais pessoas? (Digite S para Sim ou N para Não)");
        char resp = char.Parse(Console.ReadLine().ToUpper());

        if (resp != 'S')
          continua = false;

      }
      Console.WriteLine(String.Format("Salário médio das pessoas que não tem faculdade é {0}", SomaSal / totalPe));
      Console.WriteLine(String.Format("Quantidade de engenheiros entrevistados é de {0}",
      qtdEng));
      Console.ReadKey();
    }


    #endregion Parte 2 – COMANDO WHILE E DO WHILE

    #region Parte 3 – VETORES
    //1.Faça um programa em C# que leia um vetor de 10 posições. Imprima os números pares e suas
    //respectivas posições.
    public static void exParte3_01()
    {

      int[] numeros = new int[10];

      for (int i = 0; i < numeros.Length; i++)
      {
        Console.WriteLine("Informe o {0}º número", i + 1);
        numeros[i] = int.Parse(Console.ReadLine());
      }

      for (int i = 0; i < numeros.Length; i++)
      {
        if (numeros[i] % 2 == 0)
          Console.WriteLine("{0} - posição {1}", numeros[i], i + 1);
      }

      Console.ReadKey();
    }

    //2.Uma concessionária vende apenas 8 modelos de carros, os quais são identificados pelos códigos
    //1 a 8.Faça um programa que leia o nome de cada modelo, a quantidade vendida de cada modelo e o
    public static void exParte3_02()
    {


      //preço de cada um. Imprima a quantidade total de carros vendidos e o valor total da venda(qtde * preço 936 //de cada produto), por modelo.

      string[] modelos = new string[8];
      int[] qtdes = new int[8];
      double[] precos = new double[8];

      for (int i = 0; i < modelos.Length; i++)
      {
        Console.WriteLine("Informe o nome do {0}º modelo", i + 1);
        modelos[i] = Console.ReadLine();

        Console.WriteLine("Informe a quantidade do modelo {0}", modelos[i]);
        qtdes[i] = int.Parse(Console.ReadLine());

        Console.WriteLine("Informe o preço do modelo {0}", modelos[i]);
        precos[i] = double.Parse(Console.ReadLine());
      }


      for (int i = 0; i < modelos.Length; i++)
        Console.WriteLine("{0} – {1} unidades vendidas – total de vendas = R$ {2}", modelos[i], qtdes[i], precos[i]);


      Console.ReadKey();
    }

    //3.Faça um programa em C# que leia 3 vetores inteiros de 10 posições. Gere um quarto vetor que
    //armazenará a soma dos 3 vetores lidos (vide exemplo abaixo). 966
    public static void exParte3_03()
    {
      int[] VET1 = new int[10], VET2 = new int[10], VET3 = new int[10], VETSOMA = new int[10];

      for (int i = 0; i < VET1.Length; i++)
      {
        Console.WriteLine("Informe o {0}º número do vetor 1", i + 1);
        VET1[i] = int.Parse(Console.ReadLine());

        Console.WriteLine("Informe o {0}º número do vetor 2", i + 1);
        VET2[i] = int.Parse(Console.ReadLine());

        Console.WriteLine("Informe o {0}º número do vetor 3", i + 1);
        VET3[i] = int.Parse(Console.ReadLine());
      }

      for (int i = 0; i < VET1.Length; i++)
        VETSOMA[i] = VET1[i] + VET2[i] + VET3[i];

      Console.Write("Vetor Soma: ");
      for (int i = 0; i < VETSOMA.Length; i++)
        Console.Write(VETSOMA[i] + " - ");

      Console.ReadKey();


    }

    //4.Faça um programa em C# que leia um vetor inteiro de 10 posições. Gere um segundo vetor
    //formado pelos índices dos elementos pares do primeiro vetor. 996
    public static void exParte3_04()
    {

      int[] VET1 = new int[10], VET2 = new int[10];
      for (int i = 0; i < VET1.Length; i++)
      {
        Console.WriteLine("Informe o {0}º número do vetor 1", i + 1);
        VET1[i] = int.Parse(Console.ReadLine());
      }

      for (int i = 0; i < VET1.Length; i++)
      {
        if (VET1[i] % 2 == 0)
          VET2[i] = i + 1;
      }

      Console.Write("Vetor 2: ");
      for (int i = 0; i < VET2.Length; i++)
      {
        if (VET2[i] != 0)
          Console.Write(VET2[i] + " ");
      }

      Console.ReadKey();
    }

    //5.Faça um programa em C# que crie 2 vetores inteiros de 10 posições. Leia o primeiro vetor.
    //Percorra todas as posições do primeiro vetor: se o elemento for ímpar, preencha a posição
    //correspondente no segundo vetor com - 1.Caso o elemento seja par, preencha a posição correspondente  //no segundo vetor com + 1.
    public static void exParte3_05()
    {
      int[] VET1 = new int[10], VET2 = new int[10];
      for (int i = 0; i < VET1.Length; i++)
      {
        Console.WriteLine("Informe o {0}º número do vetor 1", i + 1);
        VET1[i] = int.Parse(Console.ReadLine());
      }

      for (int i = 0; i < VET1.Length; i++)
      {
        if (VET1[i] % 2 == 0)
          VET2[i] = 1;
        else
          VET2[i] = -1;
      }


      Console.Write("Vetor 2: ");
      for (int i = 0; i < VET2.Length; i++)
        Console.Write(VET2[i] + " ");

      Console.ReadKey();
    }

    //6.Faça um programa em C# que crie dois vetores (o primeiro com 10 e o segundo com 5 posições).
    //Leia o primeiro vetor e preencha o segundo vetor apenas com os valores das posições pares do primeiro 1057 //vetor.
    public static void exParte3_06()
    {

      int[] VET1 = new int[10], VET2 = new int[5];

      for (int i = 0; i < VET1.Length; i++)
      {
        Console.WriteLine(String.Format("Informe o {0}º número do vetor 1", i + 1));
        VET1[i] = int.Parse(Console.ReadLine());
      }
      int set = 0;
      for (int rep = 0; rep < VET1.Length; rep += 2)
      {
        VET2[set] = VET1[rep + 1];
        set++;
      }

      Console.Write("Vetor 2: ");
      for (int i = 0; i < VET2.Length; i++)
        Console.Write(VET2[i] + " - ");

      Console.ReadKey();

    }

    //7.Faça um programa em C# que crie um vetor que armazenará o nome de 10 pessoas que estão em
    //uma fila. Leia um nome qualquer e imprima em que posição da fila essa pessoa se encontra.Se essa pessoa
    //não for encontrada, informe o fato ao usuário.
    public static void exParte3_07()
    {
      string[] nomes = new string[10] { "Julio", "Mateus", "Ana", "Cassio", "Maria", "Jessica", "Fernada", "Micaela", "Alex", "Melissa" };
      string nomeInfo;
      //for (int i = 0; i < 10; i++)
      //{
      // Console.WriteLine(String.Format("Iforme o nome da pessoa {0}º pessoa.",i+1));
      // string nomeTemp = Console.ReadLine();
      // Console.WriteLine(String.Format("Informe a posição da(o) {0} na .",nomeTemp));
      // nomes[int.Parse(Console.ReadLine())] = nomeTemp;
      //}
      Console.WriteLine("Informe um nome");

      nomeInfo = Console.ReadLine();
      for (int i = 0; i < nomes.Length; i++)
      {
        if (nomes[i] == nomeInfo)
          Console.WriteLine(String.Format("A posição da(o) {0} na fila é a {1}º posição.", nomes[i], i + 1));
      }
      Console.ReadKey();
    }

    //11. Faça um programa em C# que crie e leia um vetor de 10 posições e o copie para outro vetor de
    //10 posições em ordem inversa. (Vide exemplo abaixo)
    public static void exParte3_11()
    {
      int[] VET1 = new int[10], VET2 = new int[10];

      for (int i = 0; i < VET1.Length; i++)
      {
        Console.WriteLine("Informe o {0}º número do vetor", i + 1);
        VET1[i] = int.Parse(Console.ReadLine());
      }

      Console.Write("Vetor 1: ");
      for (int i = 0; i < VET1.Length; i++)
        Console.Write(VET1[i] + " - ");

      int cont = 0;
      for (int i = 9; i >= 0; i--)
      {
        VET2[cont] = VET1[i];
        cont++;
      }

      Console.ReadKey();

    }

    //12.Faça um programa em C# que crie três vetores (o primeiro com 10 e os outros com 5 posições).
    //Leia o primeiro vetor e preencha o segundo vetor apenas com os valores das posições ímpares do primeiro
    //vetor.Preencha o terceiro vetor apenas com as posições pares do primeiro vetor.
    public static void exParte3_12()
    {
      int[] VET1 = new int[10], VET2 = new int[5], VET3 = new int[5];

      for (int i = 0; i < VET1.Length; i++)
      {
        Console.WriteLine(String.Format("Informe o {0}º número do vetor 1", i + 1));
        VET1[i] = int.Parse(Console.ReadLine());
      }
      int set = 0;


      for (int rep = 1; rep < VET1.Length; rep += 2)
      {
        VET2[set] = VET1[rep];
        set++;
      }
      set = 0;
      for (int rep = 0; rep < VET1.Length; rep += 2)
      {
        VET3[set] = VET1[rep];
        set++;
      }

      Console.Write("Vetor 2: ");
      for (int i = 0; i < VET2.Length; i++)
        Console.Write(VET2[i] + " - ");


      Console.Write("Vetor 3: ");
      for (int i = 0; i < VET2.Length; i++)
        Console.Write(VET3[i] + " - ");
      Console.ReadKey();
    }

    //15.Faça um programa em C# para calcular a média de valores PARES e ÍMPARES, de 50 números
    //que serão digitados pelo usuário e armazenados em um VETOR.Ao final o algoritmo deve mostrar estas
    //duas médias.O algoritmo deve mostrar também o maior número PAR digitado e o menor número
    //ÍMPAR digitado
    public static void exParte3_15()
    {
    
      int[] VET1 = new int[50];
      int qtdPar = 0, qtdImp = 0, somaPar = 0, somaImp = 0, maiorPar = 0, menorImp;

      for (int i = 0; i < VET1.Length; i++)
      {
        Console.WriteLine(String.Format("Informe o {0}º número.", i + 1));
        VET1[i] = int.Parse(Console.ReadLine());
      }
      menorImp = VET1[1];
      for (int i = 0; i < VET1.Length; i++)
        if (VET1[i] % 2 == 0)
        {
          somaPar += VET1[i];
          qtdPar++;
          if (VET1[i] > maiorPar)
            maiorPar = VET1[i];
        }
        else
        {
          somaImp += VET1[i];
          qtdImp++;
          if (VET1[i] < menorImp)
            menorImp = VET1[i];
        }


      Console.WriteLine(String.Format("A média dos valores PARES é = {0}", somaPar /
     qtdPar));
      Console.WriteLine(String.Format("A média dos valores IMPARES é = {0}", somaImp /
     qtdImp));
      Console.WriteLine(String.Format("O maior número PAR digitado é: {0} - O menor número ÍMPAR digitado é: { 1}", maiorPar, menorImp));
      Console.ReadKey();
    }

    #endregion Parte 3 – VETORES

  }

}
