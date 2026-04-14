// See https://aka.ms/new-console-template for more information

using System.Security.Cryptography;

const int limiteLinhaChegada = 30;
const int bonusAvancoExtra = 3;
const int penalidadeDeRecuo = 2;

while (true)
{
    int posicaoJogador = 0;
    int posicaoComputador = 0;

    while (true)
    {
        Console.Clear();
        Console.WriteLine("----------------------------------");
        Console.WriteLine("Jogo dos Dados");
        Console.WriteLine("----------------------------------");
        Console.WriteLine("Rodada do Jogador");
        Console.WriteLine("----------------------------------");

        Console.Write("Pressione ENTER para lançar o dado...");
        Console.ReadLine();

        int resultadoJogador = RandomNumberGenerator.GetInt32(1, 7);

        posicaoJogador += resultadoJogador;

        Console.WriteLine("----------------------------------");
        Console.WriteLine("O número sorteado foi: " + resultadoJogador);
        Console.WriteLine("----------------------------------");

        Console.WriteLine($"Você está na posição: {posicaoJogador} de {limiteLinhaChegada}");

        if (posicaoJogador == 5 || posicaoJogador == 10 || posicaoJogador == 15 || posicaoJogador == 25)
        {

            Console.WriteLine($"\nEvento: Avanço de {bonusAvancoExtra} casas!");

            posicaoJogador += bonusAvancoExtra;

            Console.WriteLine($"\nVocê está na posição: {posicaoJogador} de {limiteLinhaChegada}.");
        }

        else if (posicaoJogador == 7 || posicaoJogador == 13 || posicaoJogador == 20)
        {

            Console.WriteLine($"\nEvento: Recuo de {penalidadeDeRecuo} casas!");

            posicaoJogador -= penalidadeDeRecuo;

            Console.WriteLine($"\nVocê está na posição: {posicaoJogador} de {limiteLinhaChegada}.");
        }

        if (posicaoJogador >= limiteLinhaChegada)
        {
            Console.WriteLine($"Parabéns! Você alcanou a linha de chegada.");
            Console.WriteLine("----------------------------------");
            Console.WriteLine("Pressione ENTER para contiuar");
            Console.ReadLine();

            break;
        }

        Console.WriteLine("--------------------------------------");
        Console.Write("Pressione ENTER para continuar...");
        Console.ReadLine();

        Console.Clear();
        Console.WriteLine("--------------------------------------");
        Console.WriteLine("Jogo dos Dados");
        Console.WriteLine("--------------------------------------");
        Console.WriteLine("Rodada do Computador");

        int resultadoComputador = RandomNumberGenerator.GetInt32(1, 7);

        posicaoComputador += resultadoComputador;

        Thread.Sleep(1000);

        Console.WriteLine("--------------------------------------");
        Console.WriteLine("O número sorteado foi: " + resultadoComputador);
        Console.WriteLine("--------------------------------------");

        Console.WriteLine($"O computador está na posição: {posicaoComputador} de {limiteLinhaChegada}.");

        if (posicaoComputador == 5 || posicaoComputador == 10 || posicaoComputador == 15 || posicaoComputador == 25)
        {
            Console.WriteLine($"\nEvento: Avanço de {bonusAvancoExtra} casas!");

            posicaoComputador += bonusAvancoExtra;

            Console.WriteLine($"\nO computador está na posição: {posicaoComputador} de {limiteLinhaChegada}.");
        }

        else if (posicaoComputador == 7 || posicaoComputador == 13 || posicaoComputador == 20)
        {
            Console.WriteLine($"\nEvento: Recuo de {penalidadeDeRecuo} casas!");

            posicaoComputador -= penalidadeDeRecuo;

            Console.WriteLine($"\nO computador está na posição: {posicaoComputador} de {limiteLinhaChegada}.");
        }

        if (posicaoComputador >= limiteLinhaChegada)
        {
            Console.WriteLine($"Que pena! O computador alcançou a linha de chegada.");
            Console.WriteLine("--------------------------------------");
            Console.Write("Pressione ENTER para continuar...");
            Console.ReadLine();

            break;
        }

        Console.WriteLine("--------------------------------------");
        Console.Write("Pressione ENTER para continuar...");
        Console.ReadLine();
    }

    Console.Write("Deseja continuar? (s/N): ");
    string? opcaoContinuar = Console.ReadLine()?.ToUpper();

    if (opcaoContinuar != "S")
        break;
}


