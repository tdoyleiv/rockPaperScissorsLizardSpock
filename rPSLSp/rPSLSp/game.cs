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
        public Player playerOne = new Player("Player", false, 0);
        public Player playerTwo = new Player("HAL 9000", false, 0);
        public Game (int playerOneScore, int playerTwoScore)
        {
            this.playerOneScore = playerOneScore;
            this.playerTwoScore = playerTwoScore;
        }
        public void BeginGame()
        {
            StartGame();
            SelectOpponent();
            SetGame();
            DisplayScore();
            RestartGame();
        }
        public void RelaunchGame()
        {
            SetGame();
            DisplayScore();
            RestartGame();
        }
        public void StartGame()
        {
            Console.WriteLine("\r\nDare you play? Press Y/N");
            ConsoleKeyInfo info = Console.ReadKey();
            if ((info.KeyChar == 'Y') || (info.KeyChar == 'y'))
            {
                playerOne.isHuman = true;
                playerOne.GetName();               
            }
            else if ((info.KeyChar == 'N') || (info.KeyChar == 'n'))
            {
                Console.WriteLine("\r\n\r\nCoward, thou. Get thee hence, knave!");
                Console.ReadKey();
                Environment.Exit(0);
            }
        }
        public void SelectOpponent()
        {
            Console.WriteLine("\r\nIs this battle versus MAN or MACHINE?");
            string info = Console.ReadLine();
            if (info.ToLower().Equals("man"))
            {
                playerTwo.isHuman = true;
                playerTwo.GetName();
                Console.WriteLine("\r\nWe, the GODS OF ROCHAMBEAU, are pleased, mortals.\r\n\r\n" + playerOne.name + "...\r\n\r\n" + playerTwo.name + "...\r\n\r\nprepare thyselves for...\r\n\r\nROCK PAPER SCISSORS LIZARD SPOCK!");
            }
            else if (info.ToLower().Equals("machine"))
            {
                Console.WriteLine("\r\n" + playerOne.name + ", you have elected to contest our MACHINE. " + playerOne.name + ", prepare thyself, the " + playerTwo.name + " awaits.\r\n\r\n We grow impatient, begin...\r\n\r\n ROCK PAPER SCISSORS LIZARD SPOCK!");
            }
            else
            {
                Console.WriteLine("\r\nDo not test our patience. That is not an option, mortal. Choose again.");
                SelectOpponent();
            }
        }
        public void SetGame()
        {
            if (playerTwo.isHuman == true)
            {
                Console.WriteLine("\r\nHonor among thieves. DO NOT peek at your opponent entering their choice!\r\n");
                playerOne.ChooseMove();
                playerTwo.ChooseMove();
                DecideOutcome();
            }
            else
            {
                playerOne.ChooseMove();
                playerTwo.ChooseMove();
                DecideOutcome();
            }
        }
        public void DecideOutcome()
        {
            int outcome = (5 + playerOne.playerChoice - playerTwo.playerChoice) % 5;
            if (outcome == 1 || outcome == 3)
            {
                playerOneScore++;
                Console.WriteLine(playerOne.name + ", you have played well. Enjoy thy fruits of victory.");
            }
            else if (outcome == 2 || outcome == 4)
            {
                playerTwoScore++;
                Console.WriteLine(playerTwo.name + ", you have played well. Enjoy thy fruits of victory.");
            }
            else
            {
                Console.WriteLine("Bah! A tie! Shoot again mortals.");
                SetGame();
            }
        }
        public void DisplayScore()
        {
            Console.WriteLine(playerOneScore + " to " + playerTwoScore);
        }
        public void RestartGame()
        {
            Console.WriteLine("\r\nDare you play again? Press Y/N");
            ConsoleKeyInfo info = Console.ReadKey();
            if ((info.KeyChar == 'Y') || (info.KeyChar == 'y'))
            {
                RelaunchGame();
            }
            else if ((info.KeyChar == 'N') || (info.KeyChar == 'n'))
            {
                Console.WriteLine("\r\n\r\nCoward, thou. Get thee hence, knave!");
                Console.ReadKey();
                Environment.Exit(0);
            }
        }
    }
}
