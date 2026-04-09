Random aleatorio = new Random();

void NumeroAleatorio()
{

    int numeroAleatorio = aleatorio.Next(0, 101);

    for(int tentativas = 0; tentativas <=100; tentativas++)
    {
        Console.WriteLine("Tente adivinhar o numero entre 0 e 100: ");
        int numeroDigitado = int.Parse(Console.ReadLine());

        if(numeroDigitado > numeroAleatorio)
        {
            Console.WriteLine("O número é menor que " + numeroDigitado);
        }
        else if(numeroDigitado <  numeroAleatorio)
        {
            Console.WriteLine("O número é maior que " + numeroDigitado);
        }
        else if(numeroDigitado == numeroAleatorio)
        {
            Console.WriteLine("Você acertou com " + tentativas + " tentativas!");
            break;
        }
    }
    
}

NumeroAleatorio();