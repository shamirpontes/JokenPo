using Model.Model;
using Model.Model.Enums;
using System;

namespace Game.Service.Service {
    public class JokenPoService {
        public static Gamer CheckWinner(Gamer jogador1, Gamer jogador2) {
            var random = new Random();
            jogador2.Play = (Play)random.Next(1, 3);

            //Todo: Validar qual o jogador venceu
            if (jogador1.Play == Play.Pedra && jogador2.Play == Play.Tesoura)
                return jogador1;

            else if (jogador1.Play == Play.Papel && jogador2.Play == Play.Pedra)
                return jogador1;

            else if (jogador1.Play == Play.Tesoura && jogador2.Play == Play.Papel)
                return jogador1;

            if (jogador1.Play == Play.Pedra && jogador2.Play == Play.Papel)
                return jogador2;

            else if (jogador1.Play == Play.Papel && jogador2.Play == Play.Tesoura)
                return jogador2;

            else if (jogador1.Play == Play.Tesoura && jogador2.Play == Play.Pedra)
                return jogador2;

            if (jogador1.Play == Play.Pedra && jogador2.Play == Play.Pedra)
                return null;

            else if (jogador1.Play == Play.Tesoura && jogador2.Play == Play.Tesoura)
                return null;

            else if (jogador1.Play == Play.Papel && jogador2.Play == Play.Papel)
                return null;

            Console.WriteLine("O jogo empatou, Mr.ROBOT fez a mesma jogada que você!");




            return jogador1;
        }
    }
}
