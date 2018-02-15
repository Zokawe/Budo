using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iLudo
{
    public static class Moving
    {

        private static Dice dice = new Dice();

        //get player 1 name
        //get player 2 name

        public static int PlayerOneGlobalPosition = 0;
        public static int PlayerTwoGlobalPosition = 0;

        //set player1globalposition = 0
        //set player2globalposition = 0

        public static int Turn = 0;

        //set turn 0

        private static int roll = 0;
        private static int NumberOfThrows = 0;

        public static void LeaveTheVoid()
        {
            roll = dice.GetValue();
            while (roll != 6 && NumberOfThrows < 3)
            {
                dice.DiceThrow();
                dice.GetValue();
                NumberOfThrows++;
                Console.WriteLine("Rolling..." + "you got a " + dice.GetValue());
                System.Threading.Thread.Sleep(500);

                roll = dice.GetValue();
                Console.ReadKey();

                if(roll == 6) // && TheVoid is empty) //if no pieces are available move 6 spaces
                {
                    Console.WriteLine("You placed a piece on the board");
                    Console.ReadKey();
                }
            }

        }

        public static void LeaveZoneTwo()
        {

        }



        //i want to loop until player1globalposition = cirka 56
        //or player2globalposition = cirka 56
        //turn = turn + 1
        //if turn modulus 2 = 0 then
        //must be player2's turn
        //display player1name + "rolled: " + display roll
        // "new board poistion: " + display player1globalposition mod 42

        //player1globalposition = player1globalposition + roll

        //else

        //must be player2's turn
        //display player2name + "rolled: " + display roll
        //"new board position: " + display player2globalposition mod 42

        //player2globalposition = player2globalposition + roll

        //then go back and loop for the next turn

        // display winner


    }
}
