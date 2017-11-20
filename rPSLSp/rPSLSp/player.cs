using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rPSLSp
{
    public class Player
    {
        public string name;
        public bool isHuman;
        public int playerChoice;
        public int score;
        public Move move = new Move("default");
        Random randomChoice = new Random();
        public Player(string name, bool isHuman, int playerChoice, int score)
        {
            this.name = name;
            this.isHuman = isHuman;
            this.playerChoice = playerChoice;
            this.score = score;
        }
        public void GetName()
        {
            Console.WriteLine("\r\n\r\nWhat is your name, bold champion of ROCHAMBEAU?");
            name = Console.ReadLine();
        }
        public int ChooseMove()
        {
            if (isHuman == true)
            {
                Console.WriteLine("\r\n" + name + ", choose your move.\r\n\r\n1 = ROCK,\r\n2 = PAPER,\r\n3 = SCISSORS,\r\n4 = LIZARD,\r\nor 5 = SPOCK.\r\n");
                string choice = Console.ReadKey(true).KeyChar.ToString();
                if (choice.Equals("1"))
                {
                    playerChoice = 0;
                    move.name = "ROCK";
                }
                else if (choice.Equals("2"))
                {
                    playerChoice = 1;
                    move.name = "PAPER";
                }
                else if (choice.Equals("3"))
                {
                    playerChoice = 2;
                    move.name = "SCISSORS";
                }
                else if (choice.Equals("4"))
                {
                    playerChoice = 4;
                    move.name = "LIZARD";
                }
                else if (choice.Equals("5"))
                {
                    playerChoice = 3;
                    move.name = "SPOCK";
                }
                else
                {
                    Console.WriteLine("\r\n" + name + ", you dare mock the GODS OF ROCHAMBEAU? Enter a proper choice.");
                    ChooseMove();
                }
                return playerChoice;
            }
            else
            {
                playerChoice = randomChoice.Next(0, 4);
                if (playerChoice ==  0)
                {
                    move.name = "ROCK";
                }
                else if (playerChoice == 1)
                {
                    move.name = "PAPER";
                }
                else if (playerChoice == 2)
                {
                    move.name = "SCISSORS";
                }
                else if (playerChoice == 4)
                {
                    move.name = "LIZARD";
                }
                else if (playerChoice == 3)
                {
                    move.name = "SPOCK";
                }
                return playerChoice;

            }
        }
    }
}
