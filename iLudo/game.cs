using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iLudo
{
    class game
    {
        public static void Intro()
        {
            string PlayerOneName = "";

            Console.WriteLine("Ludo");
            Console.WriteLine("Welcome to Ludo");
            Console.WriteLine("Choose a name for player 1");

            PlayerOneName = Console.ReadLine();

            Console.WriteLine("player 1 is now called: " + PlayerOneName);

            Console.ReadKey();
        }

    }
}
