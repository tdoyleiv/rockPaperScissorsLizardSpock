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
        public Player(string name, bool isHuman)
        {
            this.name = name;
            this.isHuman = isHuman;
        }
        public void GetName()
        {
            Console.WriteLine("\r\nWhat is your name, bold champion?");
            name = Console.ReadLine();
        }

    }
}
