using System;
using static PwdGenerator.Tools;

namespace PwdGenerator
{
    class Program
    {
        private static int AskPwdLength(int min, int max)
        {
            int length = 0;
            while (length < min || length > max)
            {
                Console.WriteLine($"Choose a length (min {min}, max {max})");
                try
                {
                    length = int.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Pick a valid number");
                }
            }
            return length;
        }
        private static int AskPwdDifficulty()
        {
            int difficulty = 0;
            while (difficulty == 0)
            {
                Console.WriteLine("Choose a difficulty: \n" +
                    "1 - Low\n" +
                    "2 - Medium\n" +
                    "3 - Hard\n");
                try
                {
                    difficulty = int.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Pick a valid number");
                }
            }
            return difficulty;
        }
        private static string GetPwdAlphabet(int userChoice)
        {
            string alphabet;
            switch(userChoice)
            {
                case 1:
                    alphabet = lower;
                    break;
                case 2:
                    alphabet = lower + upper + integers;
                    break;
                case 3:
                    alphabet = lower + upper + integers + specials;
                    break;
                default:
                    alphabet = lower;
                    break;
            }
            return alphabet;
        }
        private static void GeneratePwd()
        {
            int length = AskPwdLength(4, 10);
            int difficulty = AskPwdDifficulty();
            string pwdAlphabet = GetPwdAlphabet(difficulty);
            string pwd = "";
            Random rand = new Random();
            for (int i = 0; i < length; i++)
            {
                int index = rand.Next(0, pwdAlphabet.Length);
                pwd += pwdAlphabet[index];
            }
            Console.WriteLine($"Your pwd is: {pwd}");
            Console.WriteLine();
            Console.WriteLine($"Want another password? y/n");
            string res = Console.ReadLine();

            if(res == "y")
            {
                GeneratePwd();
            }
        }
        static void Main(string[] args)
        { 
            GeneratePwd();
        }
    }
}
