using System;
using System.Security.Cryptography;

namespace JogoDosDados.ConsoleApp.Entidades;

public class Computador
{
    public static int ExecutarRodada
    (
        int posicaoComputador,
        int limiteLinhaChegada,
        int bonusAvancoExtra,
        int penalidadeRecuo
    )
    {
        Console.Clear();
        Console.WriteLine("--------------------------------------");
        Console.WriteLine("Jogo dos Dados");
        Console.WriteLine("--------------------------------------");
        Console.WriteLine("Rodada do Computador");

        int resultadoComputador = RandomNumberGenerator.GetInt32(1, 7);

        posicaoComputador += resultadoComputador;

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
            Console.WriteLine($"\nEvento: Recuo de {penalidadeRecuo} casas!");

            posicaoComputador -= penalidadeRecuo;

            Console.WriteLine($"\nO computador está na posição: {posicaoComputador} de {limiteLinhaChegada}.");
        }

        ApresentarMensagemDoComputador(posicaoComputador, limiteLinhaChegada);

        return posicaoComputador;
    }
    private static void ApresentarMensagemDoComputador(int posicaoComputador, int limiteLinhaChegada)
    {
        if (posicaoComputador >= limiteLinhaChegada)
        {
            Console.WriteLine($"Que pena! O computador alcançou a linha de chegada.");
            Console.WriteLine("--------------------------------------");
            Console.Write("Pressione ENTER para continuar...");
            Console.ReadLine();
        }
        else
        {
            Console.WriteLine("--------------------------------------");
            Console.Write("Pressione ENTER para continuar...");
            Console.ReadLine();
        }


    }

}
}
