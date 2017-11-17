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
            Console.WriteLine("BEHOLD, MORTAL!\r\nAn immortal contest, as ancient as the ground upon which you stand\r\n...or sit, as the case may be...\r\n\r\nROCK PAPER SCISSORS LIZARD SPOCK");
            Console.WriteLine("\r\nSo basically, some time ago, network executives at CBS \ngreenlit a television show based upon appropriation of \nnerd & geek culture for mass consumption by 'normies.'\r\nTherein, the writing staff co-opted a variant of Rochambeau, \ncreated by one Sam Kass, without permission, although they paid him \nlip service during the relevant episode and the man has since \nmonetized the exposure, so all is right with the universe, according to network executives, at any rate");
            Console.WriteLine("\r\nThe rules are simple:\r\n\nSCISSORS cuts PAPER\r\nPAPER covers ROCK\r\nROCK crushes LIZARD\r\nLIZARD poisons SPOCK\r\nSPOCK smashes SCISSORS\r\nSCISSORS decapitates LIZARD\r\nLIZARD eats PAPER\r\nPAPER disproves SPOCK, logically\r\nSPOCK vaporizers ROCK\r\n& ROCK breaks SCISSORS");
            newGame.StartGame();
            
            Console.Read();
        }
    }
}
