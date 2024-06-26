﻿using System;

namespace OOP2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Options to select from
                Console.WriteLine("1. Sevens Out");
                Console.WriteLine("2. Three or More");
                Console.WriteLine("3. Testing");

                // Stores user's choice
                int choice;
                while (!int.TryParse(Console.ReadLine(), out choice)) ;

                // Switch statement based on user's choice
                switch (choice)
                {
                    case 1:
                        SevensOut sevensOutGame = new SevensOut();
                        sevensOutGame.PlayGameSeven();
                        break;
                    case 2:
                        ThreeOrMore threeOrMoreGame = new ThreeOrMore();
                        threeOrMoreGame.PlayGameThreeOrMore();
                        break;
                    case 3:
                        Console.WriteLine("1. Sevens Out");
                        Console.WriteLine("2. Three Or More");

                        // Stores user's choice for testing
                        int testingChoice;
                        while (!int.TryParse(Console.ReadLine(), out testingChoice)) ;

                        // Switch statement for testing
                        switch (testingChoice)
                        {
                            case 1:
                                Testing.SevenOutTest();
                                break;
                            case 2:
                                Testing.ThreeOrMore();
                                break;
                        }
                        break;
                }
            }
            catch (Exception)
            {
                // Handle the exception
                Console.WriteLine("An error occurred");
            }
        }
    }
}
