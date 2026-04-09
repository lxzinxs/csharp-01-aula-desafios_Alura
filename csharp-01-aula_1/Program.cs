// Screen Sound
string mensagemDeBoasVindas = "Boas vindas ao Screen Sound!";
<<<<<<< HEAD
List<string> listaDasBandas = new List<string>{"matue", "oroch", "mc pedrinho"};

void ExibirLogo()
=======

void ExibirMensagem()
>>>>>>> d0f8f00618919b5547a5a65ac584ff3545987839
{
    Console.WriteLine(@"
░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░
");
    Console.WriteLine(mensagemDeBoasVindas);
}

void ExibirOpcoesDoMenu()
{
<<<<<<< HEAD
    ExibirLogo();
=======
>>>>>>> d0f8f00618919b5547a5a65ac584ff3545987839
    Console.WriteLine("\nDigite 1 para registrar uma banda");
    Console.WriteLine("Digite 2 para mostrar todas as bandas");
    Console.Write("Digite 3 para avaliar uma banda");
    Console.WriteLine("Digite 4 para exibir a média de uma banda");
    Console.WriteLine("Digite 5 para sair");

    Console.Write("\nDigite a sua opção: ");
    String opcaoEscolhida = Console.ReadLine()!;
    int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);

    switch (opcaoEscolhidaNumerica)
    {
<<<<<<< HEAD
        case 1: RegistrarBanda();
            break;
        case 2: MostrarBandasRegistradas();
=======
        case 1: Console.WriteLine("Você escolheu a opção " + opcaoEscolhidaNumerica);
            break;
        case 2: Console.WriteLine("Você escolheu a opção " + opcaoEscolhidaNumerica);
>>>>>>> d0f8f00618919b5547a5a65ac584ff3545987839
            break;
        case 3: Console.WriteLine("Você escolheu a opção " + opcaoEscolhidaNumerica);
            break;
        case 4: Console.WriteLine("Você escolheu a opção " + opcaoEscolhidaNumerica);
            break;
        case 5: Console.WriteLine("Tchau tchau :)");
            break;
        default: Console.WriteLine("Opção inválida!");
            break;
    }   
}

<<<<<<< HEAD
void RegistrarBanda()
{
    Console.Clear();
    Console.WriteLine("********************");
    Console.WriteLine("Registro de bandas:");
    Console.WriteLine("********************\n");
    Console.Write("Digite o nome da banda que deseja registrar: ");
    string nomeDaBanda = Console.ReadLine();
    listaDasBandas.Add(nomeDaBanda);
    Console.WriteLine($"A banda {nomeDaBanda} foi registrada com sucesso!");
    Thread.Sleep(2000);
    Console.Clear();
    ExibirOpcoesDoMenu();
}

void MostrarBandasRegistradas()
{
    Console.Clear();
    Console.WriteLine("**************************************");
    Console.WriteLine("Exibindo todas as bandas registradas:");
    Console.WriteLine("**************************************\n");
    //for(int i = 0; i < listaDasBandas.Count; i++)
    //{
        //Console.WriteLine($"Banda: {listaDasBandas[i]}");
    //}

    foreach(string banda in listaDasBandas)
    {
        Console.WriteLine($"Banda: {banda}");
    }

    Console.WriteLine("\nDigite uma tecla para voltar ao menu principal");
    Console.ReadKey();
    Console.Clear();
    ExibirOpcoesDoMenu();
}

=======
ExibirMensagem();
>>>>>>> d0f8f00618919b5547a5a65ac584ff3545987839
ExibirOpcoesDoMenu();