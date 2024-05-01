using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_2
{
    internal class Die
    {
        // Constructor
        public Die() { }

        // Object for generating random numbers
        private static Random random = new Random();

        // Property
        public int RollValue { get; private set; }

        // Method for rolling Dice
        public int Roll()
        {
            try
            {
                // Generates a random number between 1-6
                RollValue = random.Next(1, 7);
                return RollValue;
            }
            // Catch exception to handle any errors
            catch (Exception)
            {
                Console.WriteLine("An error occured in generating a random value");
                //  Sets the random number to 1 incase of a error to allow the program to work
                return 1;
            }
        }
    }
}