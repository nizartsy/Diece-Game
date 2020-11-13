using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GreedGameCore;



namespace Sample_Dies_Probelm
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                startGame();
            }
            catch (Exception)
            {
                Console.WriteLine("Please try again, Something went wrong");
            }
        }

        /// <summary>
        ///Reading user input and Call diece generating method
        /// </summary>
        private static void startGame()
        {
            int option = 0;
            try
            {
                do
                {
                    Console.Clear();
                    Console.WriteLine("..........Welcome to Diece Rolling Game......");
                    Console.WriteLine("Press 1 For Rolling Diece");
                    Console.WriteLine("Press any key to Exit");
                    option = Convert.ToInt32(Console.ReadLine());

                    if (option == 1)
                    {
                        getScore();
                        Console.WriteLine("\n Press 1 for Try Again");
                        option = Convert.ToInt32(Console.ReadLine());
                    }
                }
                while (option == 1);
            }
            catch (Exception)
            {
                Console.WriteLine("Please Enter Valid Inputs");
            }
        }

        /// <summary>
        /// Calculating the Score by calling GreedGame library
        /// </summary>
        private static void getScore()
        {
            GreedGame obj = new GreedGame();
            int[] randomeNumber = new int[5];
            try
            {
                randomeNumber = generateRandomeCombination();
                obj.Combinations = randomeNumber;
                Console.WriteLine("You Combinations");

                foreach (var item in randomeNumber)
                {
                    Console.Write(" " + item);
                }
                Console.WriteLine("\nYour Score is:" + obj.CalculateScore());
            }
            catch (Exception)
            {
                Console.WriteLine("Something Went Wrong, Please try again");
            }
        }

        /// <summary>
        /// Genrating randome number from 1-6 (diece combination)
        /// </summary>
        /// <returns></returns>
        private static int[] generateRandomeCombination()
        {
            int[] randNo = new int[5];
            Random rand = new Random();
            try
            {
                for (int i = 0; i < 5; i++)
                {
                    randNo[i] = rand.Next(1, 7);
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Something Went Wrong Please try again");
            }
            return randNo;
        }
    }
}
