using System.Runtime.InteropServices.Java;

static void CalcularMedia()
        {
    Console.WriteLine("Digite a primeira nota: ");
    int nota1 = int.Parse(Console.ReadLine());

    Console.WriteLine("Digite a segunda nota: ");

    int nota2 = int.Parse(Console.ReadLine());

    int media = (nota1 + nota2) / 2;

    Console.WriteLine("A média das suas notas são: " + media);
}
CalcularMedia();


static void lista()
{
    String[] linguagens = {"Java", "javascript", "C#"};

    foreach (String linguagem in linguagens)
    {
        Console.WriteLine(linguagem);
    }
}
lista();


static void calculadora()
{
    Console.WriteLine("-----MENU-----");
    Console.WriteLine("Digite a opçao que deseja executar: ");
    Console.WriteLine("1 - somar");
    Console.WriteLine("2 - subtrair");
    Console.WriteLine("3 - multiplicar");
    Console.WriteLine("4 - dividir");
    Console.WriteLine("5 - sair");
    int opcao = int.Parse(Console.ReadLine());

    if(opcao == 1)
    {
        Console.Write("Escreva o primeiro numero: ");
        double numero1 = double.Parse(Console.ReadLine());

        Console.Write("Escreva o primeiro numero: ");
        double numero2 = double.Parse(Console.ReadLine());

        double resultado = numero1 + numero2;

        Console.WriteLine("O resultado da operação é: " + resultado);
    }
    else if(opcao == 2)
    {
        Console.Write("Escreva o primeiro numero: ");
        double numero1 = double.Parse(Console.ReadLine());

        Console.Write("Escreva o primeiro numero: ");
        double numero2 = double.Parse(Console.ReadLine());

        double resultado = numero1 - numero2;

        Console.WriteLine("O resultado da operação é: " + resultado);
    }
    else if(opcao == 3)
    {
        Console.Write("Escreva o primeiro numero: ");
        double numero1 = double.Parse(Console.ReadLine());

        Console.Write("Escreva o primeiro numero: ");
        double numero2 = double.Parse(Console.ReadLine());

        double resultado = numero1 * numero2;

        Console.WriteLine("O resultado da operação é: " + resultado);
    }
    else if(opcao == 4)
    {
        Console.Write("Escreva o primeiro numero: ");
        double numero1 = double.Parse(Console.ReadLine());

        Console.Write("Escreva o primeiro numero: ");
        double numero2 = double.Parse(Console.ReadLine());

        if(numero2 == 0)
        {
            Console.WriteLine("Não é possível dividir um número por 0");
        }
        else
        {
            double resultado = numero1 / numero2;

            Console.WriteLine("O resultado da operação é: " + resultado);
        }  
    }
    else if(opcao == 5)
    {
        Console.WriteLine("Você encerrou o programa!");
        return;
    }
    else
    {
        Console.WriteLine("Escreva uma opção válida!");
    }
}
calculadora();


