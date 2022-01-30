using Game.Service.Service;
using Model.Model;
using Model.Model.Enums;
using System;

namespace ConsoleApp1
{
    public class Program
    {
        private static Gamer _jogador1 = new Gamer();
        private static Gamer _jogador2 = new Gamer() { PlayerType = PlayerType.Machine, Name = "MrRobot" };

        static void Main(string[] args)
        {
            Console.WriteLine("Digite o seu nome: \n");
            _jogador1.Name = Console.ReadLine();

            Console.WriteLine($"Ola {_jogador1.Name}, Vamos jogar Joken Po, escolha uma das opcoes a baixo: \n");

            Console.WriteLine("1 - Pedra");
            Console.WriteLine("2 - Papel");
            Console.WriteLine("3 - Tesoura\n");

            var jogada = 0;
            int.TryParse(Console.ReadLine(), out jogada);

            _jogador1.Play = (Play)jogada;
            _jogador1.PlayerType = PlayerType.Player;

            if (jogada == 0)
                Console.WriteLine("Erro ao escolher jogada\n");

            var winner = JokenPoService.CheckWinner(_jogador1, _jogador2);

            Console.WriteLine($"Vencedor e o jogador: {winner.Name} ");
        }
    }
}
