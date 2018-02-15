using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iLudo
{
    public static class Game
    {
        public static string PlayerOneName = "";
        public static string PlayerTwoName = "";

        public static void Intro()
        {

            Console.WriteLine("Ludo");
            Console.WriteLine("Welcome to Ludo");
            Console.WriteLine("Choose a name for player 1");

            PlayerOneName = Console.ReadLine();

            Console.WriteLine("Choose a name for player 2");

            PlayerTwoName = Console.ReadLine();

            Console.WriteLine("player 1 is now called: " + PlayerOneName);
            Console.WriteLine("player 2 is now called: " + PlayerTwoName);

            Console.ReadKey();
        }

    }
}
