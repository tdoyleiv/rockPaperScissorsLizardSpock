using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rPSLSp
{
   public class Game
    {
        public int playerOneScore;
        public int playerTwoScore;
        public Player playerOne = new Player("Player", false);
        public Player playerTwo = new Player("Computer", false);
        public Game (int playerOneScore, int playerTwoScore)
        {
            this.playerOneScore = playerOneScore;
            this.playerTwoScore = playerTwoScore;
        }
        public void StartGame()
        {
            Console.WriteLine("Would you like to play? Press Y/N");
            ConsoleKeyInfo info = Console.ReadKey();
            if ((info.KeyChar == 'Y') || (info.KeyChar == 'y'))
            {
                playerOne.isHuman = true;
                playerOne.GetName();               
            }
            else if ((info.KeyChar == 'N') || (info.KeyChar == 'n'))
            {
            }
        }
        //public void DetermineOutcome()
        //{
           // determination = (5 + aChoice - bChoice) % 5;
        //}
    }
}
