using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab6DiceRoll
{
    class Program
    {
        public static Random diceRoll = new Random();

        static void Main(string[] args)
        {
            Dice();
        }
        static void Dice()
        {

            bool reply = true;
            int num;

            while (true)
            {
                Console.WriteLine("Welcome to the Grand Circus Casino! Roll the dice? (Y or N)");
                string answer = Console.ReadLine().ToLower();

                if (answer == "y")
                {
                    Console.Write("How many sides should each dice have? ");
                    string sidesDice = Console.ReadLine();

                    reply = int.TryParse(sidesDice, out num);
                    while (reply)
                    {
                        if (!reply)
                        {
                            Console.WriteLine("\nThis is not a valid input.");
                        }
                        else
                        {
                            Console.Write("\nReady to roll the dice? (Y or N): ");
                            string response = Console.ReadLine().ToLower();
                            while (true)
                            {
                                if (response == "y")
                                {
                                    int rolledNum = RollDice(num);
                                    int rolledNumTwo = RollDice(num);

                                    Console.WriteLine($"\nRoll \n{rolledNum} \n{rolledNumTwo}");

                                    Console.Write("\nRoll again? (Y or N)");
                                    string output = Console.ReadLine().ToLower();
                                    if (output == "y")
                                    {
                                        Dice();
                                    }
                                    else if (output == "n")
                                    {
                                        return;

                                    }
                                }
                                else if (response == "n")
                                {
                                    return;
                                }
                            }
                        }

                    }
                }
                else if (answer == "n")
                {
                    return;
                }
            }
        }
        static int RollDice(int numberSides)
        {
            int sides = diceRoll.Next(1, numberSides);
            return sides;
        }
        
}
}
