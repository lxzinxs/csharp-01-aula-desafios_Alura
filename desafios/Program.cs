using System.Diagnostics.CodeAnalysis;

static void CalcularMedia()
{
    Console.WriteLine("Digite a primeira nota: ");
    int nota1 = int.Parse(Console.ReadLine());

    Console.WriteLine("Digite a segunda nota: ");

    int nota2 = int.Parse(Console.ReadLine());

    int media = (nota1 + nota2) / 2;

    Console.WriteLine("A média das suas notas são: " + media);
}


static void Lista()
{
    String[] linguagens = { "Java", "javascript", "C#" };

    foreach (String linguagem in linguagens)
    {
        Console.WriteLine(linguagem);
    }
}


static void Calculadora()
{
    Console.WriteLine("-----MENU-----");
    Console.WriteLine("Digite a opçao que deseja executar: ");
    Console.WriteLine("1 - somar");
    Console.WriteLine("2 - subtrair");
    Console.WriteLine("3 - multiplicar");
    Console.WriteLine("4 - dividir");
    Console.WriteLine("5 - sair");
    int opcao = int.Parse(Console.ReadLine());

    if (opcao == 1)
    {
        Console.Write("Escreva o primeiro numero: ");
        double numero1 = double.Parse(Console.ReadLine());

        Console.Write("Escreva o primeiro numero: ");
        double numero2 = double.Parse(Console.ReadLine());

        double resultado = numero1 + numero2;

        Console.WriteLine("O resultado da operação é: " + resultado);
    }
    else if (opcao == 2)
    {
        Console.Write("Escreva o primeiro numero: ");
        double numero1 = double.Parse(Console.ReadLine());

        Console.Write("Escreva o primeiro numero: ");
        double numero2 = double.Parse(Console.ReadLine());

        double resultado = numero1 - numero2;

        Console.WriteLine("O resultado da operação é: " + resultado);
    }
    else if (opcao == 3)
    {
        Console.Write("Escreva o primeiro numero: ");
        double numero1 = double.Parse(Console.ReadLine());

        Console.Write("Escreva o primeiro numero: ");
        double numero2 = double.Parse(Console.ReadLine());

        double resultado = numero1 * numero2;

        Console.WriteLine("O resultado da operação é: " + resultado);
    }
    else if (opcao == 4)
    {
        Console.Write("Escreva o primeiro numero: ");
        double numero1 = double.Parse(Console.ReadLine());

        Console.Write("Escreva o primeiro numero: ");
        double numero2 = double.Parse(Console.ReadLine());

        if (numero2 == 0)
        {
            Console.WriteLine("Não é possível dividir um número por 0");
        }
        else
        {
            double resultado = numero1 / numero2;

            Console.WriteLine("O resultado da operação é: " + resultado);
        }
    }
    else if (opcao == 5)
    {
        Console.WriteLine("Você encerrou o programa!");
        return;
    }
    else
    {
        Console.WriteLine("Escreva uma opção válida!");
    }
}


void MediaAluno()
{
   Dictionary<string, List<double>> alunos = new Dictionary<string, List<double>>();

    string nomeAluno = "Lucas";
    alunos.Add(nomeAluno, new List<double> {10, 9, 10});

    if(alunos.ContainsKey(nomeAluno))
    {
        List<double> notas = alunos[nomeAluno];

        double soma = 0;

        foreach (double nota in notas)
        {
            soma = soma + nota;
        }

        double media = soma / notas.Count;

        Console.WriteLine($"A média do aluno {nomeAluno} é: {media:F2}");
    }
}
MediaAluno();
