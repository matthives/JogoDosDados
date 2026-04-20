/*
   Regras do Jogo
       1. O jogo ocorre em uma pista com um limite de 30 casas.
       2. O jogador e o computador jogam alternadamente.
       3. Cada turno, um dado é sorteado (valores entre 1 e 6) para determinar o avanço.
       4. Eventos especiais ocorrem em determinadas posições:
           - Avanço extra (+3 casas):
               - Posições: 5, 10, 15, 25

           - Recuo (-2 casas):
               - Posições: 7, 13, 20

           - Rodada extra:
               - Se o competidor tirar 6 no dado, ele ganha uma rodada extra.

       5. O primeiro a alcançar ou ultrapassar a linha de chegada vence.
*/

namespace JogoDosDados.ConsoleApp;

using JogoDosDados.ConsoleApp.Entidades;
class Program
{
    static void Main(string[] args)
    {
        const int limiteLinhaChegada = 30;
        const int bonusAvancoExtra = 3;
        const int penalidadeRecuo = 2;

        while (true)
        {
            int posicaoJogador = 0;
            int posicaoComputador = 0;

            while (true)
            {
                // 1. Rodada do Jogador
                posicaoJogador = Jogador.ExecutarRodada(
                    posicaoJogador,
                    limiteLinhaChegada,
                    bonusAvancoExtra,
                    penalidadeRecuo
                );

                if (posicaoJogador >= limiteLinhaChegada)
                    break;

                // 2. Rodada do Computador
                posicaoComputador = Computador.ExecutarRodada(
                    posicaoComputador,
                    limiteLinhaChegada,
                    bonusAvancoExtra,
                    penalidadeRecuo
                );

                if (posicaoComputador >= limiteLinhaChegada)
                    break;
            }

            Console.WriteLine("--------------------------------------");
            Console.Write("Deseja continuar? (s/N): ");
            string? opcaoContinuar = Console.ReadLine()?.ToUpper();

            if (opcaoContinuar != "S")
                break;
        }
    }
}

