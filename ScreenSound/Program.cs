// Screen sound
string mensagemDeBoasVindas = "Boas vindas ao Screen Sound!";

// List<string> ListaDasBandas = new List<string> {"U2", "Beatles", "Pink Floyd"}; // lista pré montada para visualização na opção 2

Dictionary<string, List<int>> bandasRegistradas = new Dictionary<string, List<int>>(); //criado dicionário vazio
bandasRegistradas.Add("Linkin Park", new List<int> { 10, 8, 6 });
bandasRegistradas.Add("Beatles", new List<int>());

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
    Console.WriteLine(mensagemDeBoasVindas); // exibe logo exagerada e mensagem de boas vindas declarada na linha 2
}

void ExibirOpcoesDoMenu() // função que exibe as opções do menu
{
    Console.WriteLine("\nDigite 1 para registrar uma banda");
    Console.WriteLine("Digite 2 para mostrar todas as bandas");
    Console.WriteLine("Digite 3 para avaliar uma banda");
    Console.WriteLine("Digite 4 para exibir a média de uma banda");
    Console.WriteLine("Digite -1 para sair");

    Console.Write("\nDigite a sua opção: ");
    string opcaoEscolhida = Console.ReadLine()!; //faz com que o programa leia o que o usuário escreveu
    int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida); //transforma a opção que era texto antes se tornar um número para prosseguir o código

    switch(opcaoEscolhidaNumerica) //função de if e else mais elaborada
    {
        case 1: 
            RegistrarBandas(); //função na linha 57
            break;
        case 2:
            MostrarBandasRegistradas(); //função na linha 71
            break;
        case 3:
            AvaliarUmaBanda();
            break;
        case 4:
            ExibirMediaDaBanda();
            break;
        case -1:
            Console.WriteLine("Até a próxima!");
            break;
        default: Console.WriteLine("Opção inválida");
            break;
    }
}

/*funçoes que temos no nosso código:
 * Registrar bandas
 * Mostrar bandas registradas
 * Exibir título da opçao
 * Avaliar uma banda
*/
void RegistrarBandas() // função que registra bandas
{
    Console.Clear();
    ExibirTituloDaOpcao("Registro das bandas");
    Console.Write("Digite o nome da banda que deseja registrar: "); //deixa o usuário digitar a banda desejada
    String nomeDaBanda = Console.ReadLine()!; //faz com que o programa leia o que foi escrito e armazene na string
    bandasRegistradas.Add(nomeDaBanda, new List<int>()); //adiciona no dicionario
    Console.WriteLine($"A banda {nomeDaBanda}, foi registrada com sucesso!"); //mensagem de confirmação 
    Thread.Sleep( 2000 ); // tempo em milisegundos para o usuário ler 
    Console.Clear(); // limpa o console
    ExibirOpcoesDoMenu(); //volta a exibir as opções do menu

}

void MostrarBandasRegistradas()
{
    Console.Clear();
    ExibirTituloDaOpcao("Exibindo todas as bandas registradas"); // Removido o espaço e os dois pontos

    foreach (string banda in bandasRegistradas.Keys) //para cada banda no dicionario bandas registradas (Keys significa que vai pegar somente o principal, sem os valores)
    {
        Console.WriteLine($"Banda: {banda}"); //exibe a banda
    }

    Console.WriteLine("\nAperte uma tecla para voltar ao menu principal");
    Console.ReadKey();
    Console.Clear();
    ExibirOpcoesDoMenu();
}
void ExibirTituloDaOpcao(string titulo) //função para deixar os títulos com asteriscos
{
    int quantidadeLetras = titulo.Length; //lê a quantidade de caracteres com o length
    string asteriscos = string.Empty.PadLeft(quantidadeLetras, '*'); //cria string asteriscos, deixa ela vazia por padrao e usa o PadLeft que faz com que a quantidade de caracteres seja igual a de asteriscos
    Console.WriteLine(asteriscos); //escreve os asteriscos com base no tamanho do titulo
    Console.WriteLine(titulo); //título
    Console.WriteLine(asteriscos + "\n"); //escreve os asteriscos com base no tamanho do titulo
}

void AvaliarUmaBanda()
{
    //digite qual banda deseja avaliar
    //se a banda existir no dicionario >> atribuir uma nota
    //se nao, volta ao menu principal

    Console.Clear();
    ExibirTituloDaOpcao("Avaliar banda");
    Console.Write("Digite o nome da banda que deseja avaliar:");
    string nomeDaBanda = Console.ReadLine()!;
    if (bandasRegistradas.ContainsKey(nomeDaBanda))
    {
        Console.Write($"Qual a nota que a banda {nomeDaBanda} merece? ");
        int nota = int.Parse(Console.ReadLine()!);
        bandasRegistradas[nomeDaBanda].Add(nota);
        Console.WriteLine($"\nA nota {nota} foi registrada com sucesso para a banda {nomeDaBanda}");
        Thread.Sleep(4000);
        Console.Clear();
        ExibirOpcoesDoMenu();
    }
    else
    {
        Console.WriteLine($"Banda {nomeDaBanda} não registrada ou digitada incorretamente");
        Console.WriteLine("Deseja tentar novamente ou voltar ao menu?");
        Console.WriteLine("1 - Tentar novamente");
        Console.WriteLine("2 - Voltar ao menu");

        string opcaoEscolhida = Console.ReadLine()!;
        int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);

        switch (opcaoEscolhidaNumerica)
        {
            case 1:
                AvaliarUmaBanda();
                break;
            case 2:
                Console.Clear();
                ExibirOpcoesDoMenu();
                break;
        }


    }
}

void ExibirMediaDaBanda()
{
 /*
  * limpar terminal
  * Exibir título (Exibir média de nota de uma banda)
  * perguntar qual banda deseja exibir média de nota
  * verificar se a banda existe
  * se existir, verificar o resultado da média das notas
  * 
  * 
  * 
  * o que preciso fazer então?
  * pegar length da lista de notas e dividir pelo mesmo número
  * exibir nota específica da banda quando chamá-la
 */

    Console.Clear();
    ExibirTituloDaOpcao("Média de notas de uma banda");
    Console.Write("Digite a banda que deseja verificar a média: ");
    String nomeDaBanda = Console.ReadLine()!;
    if (bandasRegistradas.ContainsKey(nomeDaBanda))
    {

    }
    else
    {
        Console.WriteLine($"Banda {nomeDaBanda} não registrada ou digitada incorretamente");
        Console.WriteLine("Deseja tentar novamente ou voltar ao menu?");
        Console.WriteLine("1 - Tentar novamente");
        Console.WriteLine("2 - Voltar ao menu");

        string opcaoEscolhida = Console.ReadLine()!;
        int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);

        switch (opcaoEscolhidaNumerica)
        {
            case 1: 
                ExibirMediaDaBanda();
                break;
            case 2: 
                Console.Clear();
                ExibirOpcoesDoMenu();
                break;
        }
        

    }
}
Exibirlogo();
ExibirOpcoesDoMenu();