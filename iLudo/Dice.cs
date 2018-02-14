using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iLudo
{
    public class Dice
    {
        private int roll;
        Random random = new Random();

        public Dice()
        {
            this.roll = this.random.Next(1, 7);
        }


        public int Throwdice()
        {
            this.roll = this.random.Next(1, 7);

            for (int i = 3; i > 0; i--)
            {
                Console.Write("Rolling...");
                System.Threading.Thread.Sleep(500);
            }

            return this.roll;
        }

        public int GetValue()
        {
            return this.roll;
        }

    }
}
