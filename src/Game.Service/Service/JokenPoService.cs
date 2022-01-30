using Model.Model;
using Model.Model.Enums;
using System;

namespace Game.Service.Service
{
    public class JokenPoService
    {
        public static Gamer CheckWinner(Gamer jogador1, Gamer jogador2)
        {
            var random = new Random();
            jogador2.Play = (Play)random.Next(1,3);

            //Todo: Validar qual o jogador venceu

            return jogador1;
        }
    }
}
