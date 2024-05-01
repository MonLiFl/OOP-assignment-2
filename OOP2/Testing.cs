using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace OOP2
{
    internal class Testing
    {
        public static void SevenOutTest()
        {
            try
            {
                // Instantiate the SevenOut game
                SevensOut sevensOutGame = new SevensOut();
                // Play the SevenOut game
                sevensOutGame.PlayGameSeven();

                // Calculates the total
                int totalRollP1 = sevensOutGame.roll1 + sevensOutGame.roll2;
                int totalRollP2 = sevensOutGame.roll3 + sevensOutGame.roll4;

                // Debug.Assert checks if the condition is true, otherwise it throws an assertion exception
                Debug.Assert(sevensOutGame.totalRollP1 == 7, "The total of the 2 dice should be 7");
                Debug.Assert(sevensOutGame.totalRollP2 == 7, "The total of the 2 dice should be 7");
            }
            catch (Exception)
            {
                // Catch exception
                Console.WriteLine("An error occurred");
            }
        }

        public static void ThreeOrMore()
        {
            try
            {
                // Instantiate the ThreeOrMore game
                ThreeOrMore threeOrMoreGame = new ThreeOrMore();
                // Play the ThreeOrMore game
                threeOrMoreGame.PlayGameThreeOrMore();

                // Debug.Assert checks if the condition is true, otherwise it throws an assertion exception
                Debug.Assert(threeOrMoreGame.totalScoreP1 < 20, "The total is less than 20");
                Debug.Assert(threeOrMoreGame.totalScoreP2 < 20, "The total is less than 20");
            }
            catch (Exception)
            {
                // Catch exception
                Console.WriteLine("An error occurred");
            }
        }
    }
}