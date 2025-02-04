// Screen sound
string mensagemDeBoasVindas = "Boas vindas ao Screen Sound!";

List<string> ListaDasBandas = new List<string>();

void Exibirlogo()
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
    Console.WriteLine("\nDigite 1 para registrar uma banda");
    Console.WriteLine("Digite 2 para mostrar todas as bandas");
    Console.WriteLine("Digite 3 para avaliar uma banda");
    Console.WriteLine("Digite 4 para exibir a média de uma banda");
    Console.WriteLine("Digite -1 para sair");

    Console.Write("\nDigite a sua opção: ");
    string opcaoEscolhida = Console.ReadLine()!;
    int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);

    switch(opcaoEscolhidaNumerica)
    {
        case 1: 
            RegistrarBandas();
            break;
        case 2:
            MostrarBandasRegistradas();
            break;
        case 3:
            Console.WriteLine("Você escolheu a opção " + opcaoEscolhidaNumerica);
            break;
        case 4:
            Console.WriteLine("Você escolheu a opção " + opcaoEscolhidaNumerica);
            break;
        case -1:
            Console.WriteLine("Até a próxima!");
            break;
        default: Console.WriteLine("Opção inválida");
            break;
    }
}

void RegistrarBandas()
{
    Console.Clear();
    ExibirTituloDaOpcao("Registro das bandas");
    Console.Write("Digite o nome da banda que deseja registrar: ");
    String nomeDaBanda = Console.ReadLine()!;
    ListaDasBandas.Add(nomeDaBanda);
    Console.WriteLine($"A banda {nomeDaBanda}, foi registrada com sucesso!");
    Thread.Sleep( 2000 );
    Console.Clear();
    ExibirOpcoesDoMenu();

}

void MostrarBandasRegistradas()
{
    Console.Clear();
    ExibirTituloDaOpcao("Exibindo todas as bandas registradas"); // Removido o espaço e os dois pontos

    foreach (string banda in ListaDasBandas)
    {
        Console.WriteLine($"Banda: {banda}");
    }

    Console.WriteLine("\nAperte uma tecla para voltar ao menu principal");
    Console.ReadKey();
    Console.Clear();
    ExibirOpcoesDoMenu();
}
void ExibirTituloDaOpcao(string titulo)
{
    int quantidadeLetras = titulo.Length;
    string asteriscos = string.Empty.PadLeft(quantidadeLetras, '*');
    Console.WriteLine(asteriscos);
    Console.WriteLine(titulo);
    Console.WriteLine(asteriscos + "\n");
}
Exibirlogo();
ExibirOpcoesDoMenu();