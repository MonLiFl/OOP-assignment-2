using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace OOP_2
{
    internal class ThreeOrMore
    {
        // Declaring instances of Die Class
        private Die die1 = new Die();
        private Die die2 = new Die();
        private Die die3 = new Die();
        private Die die4 = new Die();
        private Die die5 = new Die();
        private Die die6 = new Die();
        private Die die7 = new Die();
        private Die die8 = new Die();
        private Die die9 = new Die();
        private Die die10 = new Die();

        // Properties
        public int totalScoreP1 { get; private set; }
        public int totalScoreP2 { get; private set; }



        public void PlayGameThreeOrMore()
        {
            // Variables
            int gameOver = 0;
            int round = 1;
            int totalScoreP1 = 0;
            int totalScoreP2 = 0;


            // Loops until game is over
            while (gameOver == 0)
            {
                {   // Loop for every round
                    while (totalScoreP1 < 20 && totalScoreP2 < 20)
                    {
                        // Player 1 turn
                        Console.WriteLine("Player 1 press any key to roll the dice.");
                        Console.ReadKey(true);
                        Console.WriteLine("Player 1 is rolling the dice...");
                        // Rolls Dice for player 1
                        int roll1 = die1.Roll();
                        int roll2 = die2.Roll();
                        int roll3 = die3.Roll();
                        int roll4 = die4.Roll();
                        int roll5 = die5.Roll();

                        Console.WriteLine("Rolled Dice :" + roll1 + " , " + roll2 + " , " + roll3 + " , " + roll4 + " , " + roll5);

                        // Stores the value in array
                        int[] rollsP1 = { roll1, roll2, roll3, roll4, roll5 };

                        // Checks if its a 2 of a kind
                        if (TwoOfAkind(rollsP1))
                        {
                            Console.WriteLine("Two Of A Kind rolled");
                            Console.WriteLine("1. Reroll all dice");
                            Console.WriteLine("2. Reroll remaining dice");

                            int choice;
                            while (!int.TryParse(Console.ReadLine(), out choice)) ;

                            switch (choice)
                            {
                                case 1:
                                    Console.WriteLine("Rerolling all dice");
                                    roll1 = die1.Roll();
                                    roll2 = die2.Roll();
                                    roll3 = die3.Roll();
                                    roll4 = die4.Roll();
                                    roll5 = die5.Roll();
                                    rollsP1 = new int[] { roll1, roll2, roll3, roll4, roll5 };
                                    break;
                            }
                        }

                        // Checks for 3 of a kind
                        if (ThreeOfAKind(rollsP1))
                        {
                            Console.WriteLine("Three Of A Kind rolled : 3 points ");
                            totalScoreP1 += 3;
                            Console.WriteLine("Player 1 Round " + round + " Total " + totalScoreP1);
                        }

                        // Checks for 4 of a kind
                        if (FourOfAKind(rollsP1))
                        {
                            Console.WriteLine("Four Of A Kind rolled : 6 points ");
                            totalScoreP1 += 6;
                            Console.WriteLine("Player 1 Round " + round + " Total " + totalScoreP1);
                        }

                        // Checks for 5 of a kind
                        if (FiveOfAKind(rollsP1))
                        {
                            Console.WriteLine("Five Of A Kind rolled : 12 points ");
                            totalScoreP1 += 12;
                            Console.WriteLine("Player 1 Round " + round + " Total " + totalScoreP1);
                        }

                        // Else one of a kind was rolled
                        else
                        {
                            Console.WriteLine("One Of A Kind rolled");
                            Console.WriteLine("No points added");
                            Console.WriteLine("Round " + round + " Total " + totalScoreP1);

                        }

                        // Player 2 rolls the dice
                        Console.WriteLine("///////////////////////////////////////////");
                        Console.WriteLine("Player 2 press any key to roll the dice.");
                        Console.ReadKey(true);
                        Console.WriteLine("Player 2 is rolling the dice...");

                        // Rolls players 2 dice
                        int roll6 = die6.Roll();
                        int roll7 = die7.Roll();
                        int roll8 = die8.Roll();
                        int roll9 = die9.Roll();
                        int roll10 = die10.Roll();

                        Console.WriteLine("Rolled Dice :" + roll6 + " , " + roll7 + " , " + roll8 + " , " + roll9 + " , " + roll10);

                        // Stores them in array
                        int[] rollsP2 = { roll6, roll7, roll8, roll9, roll10 };

                        // Checks for 2 of a kind
                        if (TwoOfAkind(rollsP2))
                        {
                            Console.WriteLine("Two Of A Kind rolled");
                            Console.WriteLine("1. Reroll all dice");
                            Console.WriteLine("2. Reroll remaining dice");

                            int choice;
                            while (!int.TryParse(Console.ReadLine(), out choice)) ;

                            switch (choice)
                            {
                                case 1:
                                    Console.WriteLine("Rerolling all dice");
                                    roll6 = die6.Roll();
                                    roll7 = die7.Roll();
                                    roll8 = die8.Roll();
                                    roll9 = die9.Roll();
                                    roll10 = die10.Roll();
                                    rollsP2 = new int[] { roll6, roll7, roll8, roll9, roll10 };
                                    break;
                            }
                        }

                        // Checks for 3 of a kind
                        if (ThreeOfAKind(rollsP2))
                        {
                            Console.WriteLine("Three Of A Kind rolled : 3 points ");
                            totalScoreP1 += 3;
                            Console.WriteLine("Player 2 Round " + round + " Total " + totalScoreP1);
                        }

                        // Checks for 4 of a kind
                        if (FourOfAKind(rollsP2))
                        {
                            Console.WriteLine("Four Of A Kind rolled : 6 points ");
                            totalScoreP1 += 6;
                            Console.WriteLine("Player 2 Round " + round + " Total " + totalScoreP1);
                        }



                        // Checks for 5 of a kind
                        if (FiveOfAKind(rollsP2))
                        {
                            Console.WriteLine("Five Of A Kind rolled : 12 points ");
                            totalScoreP1 += 12;
                            Console.WriteLine("Player 2 Round " + round + " Total " + totalScoreP1);
                        }

                        // Else one of a kind was rolled
                        else
                        {
                            Console.WriteLine("One Of A Kind rolled");
                            Console.WriteLine("No points added");
                            Console.WriteLine("Round " + round + " Total " + totalScoreP1);

                        }

                    }
                    // Increments round total
                    round ++;
                }
                // Add scores for the round to the statistics

            }
        }

        // Methods for checking the rolls
        private bool FiveOfAKind(int[] rolls)
        {
            int[] counts = new int[7];
            foreach (int roll in rolls)
            {
                counts[roll]++;
            }

            foreach (int count in counts)
            {
                if (count == 5)
                {
                    return true;
                }
            }

            return false;
        }
        private bool FourOfAKind(int[] rolls)
        {
            int[] counts = new int[7];
            foreach (int roll in rolls)
            {
                counts[roll]++;
            }

            foreach (int count in counts)
            {
                if (count == 4)
                {
                    return true;
                }
            }

            return false;
        }
        private bool ThreeOfAKind(int[] rolls)
        {
            int[] counts = new int[7];
            foreach (int roll in rolls)
            {
                counts[roll]++;
            }

            foreach (int count in counts)
            {
                if (count == 3)
                {
                    return true;
                }
            }

            return false;
        }
        private bool TwoOfAkind(int[] rolls)
        {
            int[] counts = new int[7];
            foreach (int roll in rolls)
            {
                counts[roll]++;
            }

            foreach (int count in counts)
            {
                if (count == 2)
                {
                    return true;
                }
            }

            return false;
        }
    }
}