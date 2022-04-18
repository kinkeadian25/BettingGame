using System;

namespace BettingGame
{
    public class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            double odds = .75;

            Guy player = new Guy() {Cash = 100, Name = "The Player"};

            Console.WriteLine("Welcome to the casino. The odds are " + odds);
            while (player.Cash > 0)
            {
                player.WriteMyInfo();
                Console.WriteLine("How much would you like to bet?");
                string howMuch = Console.ReadLine();
                if (int.TryParse(howMuch, out int amount))
                {
                    int pot = player.GiveCash(amount) * 2;
                    if (pot > 0)
                    {
                        if (random.NextDouble() > odds)
                        {
                            int winnings = pot;
                            Console.WriteLine("You win " + winnings);
                        }
                        else
                        {
                            Console.WriteLine("Bad luck, you lose.");
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Please enter a valid number.");
                }
            }

            Console.WriteLine("The House always wins.");
        }
    }
}
