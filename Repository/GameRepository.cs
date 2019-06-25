using System.Collections.Generic;
using System.Threading.Tasks;
using testJokenpo.Entities;

namespace testJokenpo.Repository
{
    public class GameRepository : IRepository
    {
        private Dictionary<string, Dictionary<string, string>> conditions
        {
            get
            {
                var _conditions = new Dictionary<string, Dictionary<string, string>>();
                var condition = new Dictionary<string, string>();
                
                condition.Add("papel", "Tesoura corta papel!");
                condition.Add("lagarto", "Tesoura decapita lagarto!");
                _conditions.Add("tesoura", condition);

                condition = new Dictionary<string, string>();
                condition.Add("pedra", "Papel cobre pedra!");
                condition.Add("spock", "Papel refuta Spock!");
                _conditions.Add("papel", condition);

                condition = new Dictionary<string, string>();
                condition.Add("lagarto", "Pedra esmaga lagarto!");
                condition.Add("tesoura", "Pedra quebra tesoura!");
                _conditions.Add("pedra", condition);
                
                condition = new Dictionary<string, string>();
                condition.Add("spock", "Lagarto envenena Spock!");
                condition.Add("papel", "Lagarto come papel!");
                _conditions.Add("lagarto", condition);

                condition = new Dictionary<string, string>();
                condition.Add("tesoura", "Spock esmaga (ou derrete) tesoura!");
                condition.Add("pedra", "Spock vaporiza pedra!");
                _conditions.Add("spock", condition);

                return _conditions;
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

            var condition = conditions[player1];
            if(condition.ContainsKey(player2)) {
                return "player1 ganha, " + condition[player2].ToString();
            } else {
                condition = conditions[player2];
                return "player2 ganha, " + condition[player1].ToString();
            }
        }
    }
}