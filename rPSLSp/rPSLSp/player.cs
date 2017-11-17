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
        Random randomChoice = new Random();
        public Player(string name, bool isHuman, int playerChoice)
        {
            this.name = name;
            this.isHuman = isHuman;
            this.playerChoice = playerChoice;
        }
        public void GetName()
        {
            Console.WriteLine("\r\n\r\nWhat is your name, bold champion of ROCHAMBEAU?");
            name = Console.ReadLine();
        }
        public void ChooseMove()
        {
            if (isHuman == true)
            {
                Console.WriteLine("\r\n" + name + ", choose your move.\r\n\r\nROCK,\r\nPAPER,\r\nSCISSORS,\r\nLIZARD,\r\n or SPOCK.");
                string choice = Console.ReadLine();
                if (choice.ToLower().Equals("rock"))
                {
                    playerChoice = 0;
                }
                else if (choice.ToLower().Equals("paper"))
                {
                    playerChoice = 1;
                }
                else if (choice.ToLower().Equals("scissors"))
                {
                    playerChoice = 2;
                }
                else if (choice.ToLower().Equals("lizard"))
                {
                    playerChoice = 3;
                }
                else if (choice.ToLower().Equals("spock"))
                {
                    playerChoice = 4;
                }
                else
                {
                    Console.WriteLine("\r\n" + name + ", you dare mock the GODS OF ROCHAMBEAU? Enter a proper choice.");
                    ChooseMove();
                }
            }
            else
            {
                playerChoice = randomChoice.Next(0, 4);
            }
        }
    }
}
