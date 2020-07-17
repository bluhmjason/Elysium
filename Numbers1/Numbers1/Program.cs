using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Numbers1
{
    class Program
    {
        static void Main(string[] args)
        {
        startGame:
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Would you like to play a game?");
            Console.WriteLine("Y or N");
            string userAnswer = Console.ReadLine();
            
            if (userAnswer == "Y" || userAnswer == "N")
            {
                if (userAnswer == "N")
                {
                    goto endProgram;
                }
                Console.WriteLine("Get ready.");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("That's not a valid answer.");
                goto startGame;

            }
            Console.Clear();
            int randomNumber = new Random().Next(1, 20);
            int userGuess = 0;
            int userTries = 7;
            Console.WriteLine("Let's get started then.");
        retryHere:
            Console.WriteLine("Guess a number between 1 and 20.");
            int.TryParse(Console.ReadLine(), out userGuess);
            while (userGuess != randomNumber)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("That doesn't look quite right.");
                userTries--;
                if (userTries == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Looks like you are out of tries.");
                    goto startGame;
                }
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine($"You have {userTries} tries left.");
                goto retryHere;
            }
            if (userGuess == randomNumber)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Huh, you're smarter than I thought you were.");
                Thread.Sleep(2000);
                Console.Clear();
                goto endProgram;
            }
        endProgram:
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Have a nice day.");
            Console.ForegroundColor = ConsoleColor.White;
            Environment.Exit(0);
        }
    }
}
