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

