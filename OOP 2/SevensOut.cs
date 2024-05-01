using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace OOP_2
{
    internal class SevensOut
    {
        // Declaring instances of Die class
        private Die die1 = new Die();
        private Die die2 = new Die();
        private Die die3 = new Die();
        private Die die4 = new Die();

        // Properties
        public int roll1 { get; private set; }
        public int roll2 { get; private set; }

        public int roll3 { get; private set; }
        public int roll4 { get; private set; }

        public int totalRollP1 { get; private set; }

        public int totalRollP2 { get; private set; }

        // Method to play the game
        public void PlayGameSeven()
        {
            // Variables used in game
            int gameOver = 0;
            int round = 1;
            int totalScoreP1 = 0;
            int totalScoreP2 = 0;

            // Loops until game is over
            while (gameOver == 0)
            {
                {
                    // Loops for every round
                    while (true)
                    {
                        // Player 1 turn
                        Console.WriteLine("Player 1 press any key to roll the dice.");
                        Console.ReadKey(true);
                        Console.WriteLine("Player 1 is rolling the dice...");
                        int roll1 = die1.Roll();
                        int roll2 = die2.Roll();
                        int roll3 = die3.Roll();
                        int roll4 = die4.Roll();
                        int totalRollP1 = roll1 + roll2;
                        int totalRollP2 = roll3 + roll4;

                        Console.WriteLine("Player 1 Rolled: " + roll1 + " and " + roll2);

                        // Checks the winning condition
                        if (totalRollP1 == 7)
                        {
                            totalScoreP1 += totalRollP1;
                            Console.WriteLine("Player 1 rolled a 7! Game Over.");
                            Console.WriteLine("Player's 1 Total Score " + totalScoreP1);
                            Console.WriteLine("Player's 2 Total Score " + totalScoreP2);

                            gameOver = 1;
                            break;
                        }
                        else
                        {
                            if (roll1 == roll2)
                            {
                                totalScoreP1 += totalRollP1 * 2;
                                Console.WriteLine("Player 1 rolled a double! Score doubled. Total P1 score " + totalScoreP1);
                            }
                            else
                            {
                                totalScoreP1 += totalRollP1;
                                Console.WriteLine("Added " + totalRollP1 + " To Player 1 Score");
                                Console.WriteLine("Total P1 Score for round " + round + ": =   " + totalScoreP1);
                            }
                        }
                        // Player 2 turn
                        Console.WriteLine("///////////////////////////////////////////");
                        Console.WriteLine("Player 2 press any key to roll the dice.");
                        Console.ReadKey(true);
                        Console.WriteLine("Player 2 is rolling the dice...");

                        Console.WriteLine("Player 2 Rolled: " + roll3 + " and " + roll4);

                        // Checks the winning condition
                        if (totalRollP2 == 7)
                        {
                            totalScoreP2 += totalRollP2;
                            Console.WriteLine("Player 2 rolled a 7! Game Over.");
                            Console.WriteLine("Player's 1 Total Score " + totalScoreP1);
                            Console.WriteLine("Player's 2 Total Score " + totalScoreP2);
                            gameOver = 1;
                            break;
                        }
                        else
                        {
                            if (roll3 == roll4)
                            {
                                totalScoreP2 += totalRollP2 * 2;
                                Console.WriteLine("Player 2 rolled a double! Score doubled. Total P2 score " + totalScoreP2);
                            }
                            else
                            {
                                totalScoreP2 += totalRollP2;
                                Console.WriteLine("Added " + totalRollP2 + " To Player 2 Score");
                                Console.WriteLine("Total P2 Score for round " + round + ": =   " + totalScoreP2);
                            }
                        }
                        Console.WriteLine("///////////////////////////////////////////");

                        // increments round counter
                        round++;
                        if (gameOver == 1)
                        break; // Game ends if a player rolls a 7
                    }
                }
            }
        }
    }

} 