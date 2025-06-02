using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PedraPapelTesoura
{
    public class Game
    {
        public string jogar(string escolhaA, string escolhaB)
        {
            if (escolhaA == escolhaB)
                return "Empate";

            if (escolhaA == "Pedra" && escolhaB == "Papel")
                return "Pedra vence Papel!";

            if (escolhaA == "Pedra" && escolhaB == "Tesoura")
                return "Pedra vence Tesoura!";

            if (escolhaA == "Papel" && escolhaB == "Pedra")
                return "Pedra vence Papel!";

            if (escolhaA == "Papel" && escolhaB == "Tesoura")
                return "Tesoura vence Papel!";

            return "Tesoura vence" + escolhaB + "!";
        }
    }
}
