using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rPSLSp
{
   public class Game
    {
        public int playerOneWins;
        public int playerTwoWins;
        public Player playerOne = new Player(false, 0, "Player", 0);
        public Player playerTwo = new Player(false, 0, "HAL 9000", 0);
        public Game (int playerOneWins, int playerTwoWins)
        {
            this.playerOneWins = playerOneWins;
            this.playerTwoWins = playerTwoWins;
        }
        public void BeginGame()
        {
            StartGame();
            SelectOpponent();
            SetGame();
            DisplayWin();
            RestartGame();
        }
        public void DecideOutcome()
        {
            int outcome = (5 + playerOne.playerChoice - playerTwo.playerChoice) % 5;
            if (outcome == 1 || outcome == 3)
            {
                playerOne.score++;
                Console.WriteLine(playerOne.move.name + " beats " + playerTwo.move.name + ".\r\n" + playerOne.name + " has won. Enjoy thy fruits of victory.");
                DisplayScore();
            }
            else if (outcome == 2 || outcome == 4)
            {
                playerTwo.score++;
                Console.WriteLine(playerTwo.move.name + " beats " + playerOne.move.name + ".\r\n" + playerTwo.name + " has won. Enjoy thy fruits of victory.");
                DisplayScore();
            }
            else
            {
                Console.WriteLine(playerOne.move.name + " and " + playerTwo.move.name + "!?\r\nBah! A tie! Shoot again mortals.");
                SetGame();
            }
        }
        public void DisplayScore()
        {
            Console.WriteLine(playerOne.score + " to " + playerTwo.score);
        }
        public void DisplayWin()
        {
            if (playerOne.score == 2)
            {
                playerOneWins++;
                Console.WriteLine(playerOne.name + ", you have triumphed, now resplendant in our divine favor.");
            }
            else if (playerTwo.score == 2)
            {
                playerTwoWins++;
                Console.WriteLine("\r\n\r\n" + playerTwo.name + ", you have triumphed, now resplendant in our divine favor.");
            }
            Console.WriteLine("\r\nThy tally rests at " + playerOneWins + " to " + playerTwoWins);
        }
        public void RelaunchGame()
        {
            playerOne.score = 0;
            playerTwo.score = 0;
            SetGame();
            DisplayWin();
            RestartGame();
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
                Console.WriteLine("\r\n" + playerOne.name + ", you have elected to contest our MACHINE. " + playerOne.name + ", prepare thyself,\r\nthe " + playerTwo.name + " awaits.\r\n\r\nWe grow impatient, begin...\r\n\r\nROCK PAPER SCISSORS LIZARD SPOCK!");
            }
            else
            {
                Console.WriteLine("\r\nDo not test our patience. That is not an option, mortal. Choose again.");
                SelectOpponent();
            }
        }
        public void SetGame()
        {
            while (playerOne.score < 2 && playerTwo.score < 2)
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
    }
}
