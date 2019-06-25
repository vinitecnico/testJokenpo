using System.Collections.Generic;
using System.Threading.Tasks;

namespace testJokenpo.Repository
{
    public class GameRepository : IRepository
    {
        private Dictionary<string, string> conditions
        {
            get
            {
                var condition = new Dictionary<string, string>();
                condition.Add("pedra", "tesoura");
                condition.Add("papel", "pedra");
                condition.Add("tesoura", "papel");
                return condition;
            }
        }

        public GameRepository()
        {
        }

        public bool CheckValidGame(string player1, string player2)
        {
            if (!conditions.ContainsKey(player1) || !conditions.ContainsKey(player2))
            {
                return false;
            }
            return true;
        }

        public string WinningPlay(string player1, string player2)
        {
            if (!CheckValidGame(player1, player2))
            {
                return "Jogada Inválida!";
            }

            if (player1 == player2)
            {
                return "empate";
            }

            return conditions[player1] == player2 ? "player1 ganha!" : "player2 ganha!";
        }
    }
}