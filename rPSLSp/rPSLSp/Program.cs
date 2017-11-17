using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rPSLSp
{
    class Program
    {
        static void Main()
        {
            Game newGame = new Game(0, 0);
            Console.WriteLine("Behold, mortal!\r\nThe eternal contest, as ancient as the ground upon which you stand\r\n...or sit, as the case may be...\r\n\r\nROCK PAPER SCISSORS LIZARD SPOCK!");
            Console.WriteLine("\r\nWe, the GODS OF ROCHAMBEAU, demand your play as tribute.\r\n\r\nThe rules are simple:\r\n\nSCISSORS cuts PAPER\r\nPAPER covers ROCK\r\nROCK crushes LIZARD\r\nLIZARD poisons SPOCK\r\nSPOCK smashes SCISSORS\r\nSCISSORS decapitates LIZARD\r\nLIZARD eats PAPER\r\nPAPER disproves SPOCK, logically\r\nSPOCK vaporizes ROCK\r\n& ROCK breaks SCISSORS");
            newGame.BeginGame();
            Console.Read();
        }
    }
}
