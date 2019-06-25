using System.Collections.Generic;

namespace testJokenpo.Repository
{
    public interface IRepository 
    {
        string WinningPlay(string player1, string player2);
        bool CheckValidGame(string player1, string player2);
    }
}