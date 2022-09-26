using System;

namespace HighLowGame
{
    class Program
    {
        static void Main(string[] args)
        {
            double AwnserIsTrue = 0;
            double anwser;
            Random rnd = new Random();
            double RandNum = rnd.Next(1, 100);
            Console.WriteLine("Guess a Number between 1 and 100");
            anwser = Convert.ToDouble(Console.ReadLine());

            for (; AwnserIsTrue < 1;)
            {
                AwnserIsTrue++;
                switch (anwser)
                {
                    case var expression when anwser == RandNum:
                        Console.WriteLine("You Win the Number was: {0}", RandNum);
                        Console.ReadKey();
                        System.Environment.Exit(1);
                        break;

                    case var expression when anwser > RandNum:
                        Console.WriteLine("The Number is too Big");
                        AwnserIsTrue--;
                        Console.WriteLine("Guess Again:");
                        anwser = Convert.ToDouble(Console.ReadLine());
                        break;

                    case var expression when anwser < RandNum:
                        Console.WriteLine("The Number is too small");
                        AwnserIsTrue--;
                        Console.WriteLine("Guess Again:");
                        anwser = Convert.ToDouble(Console.ReadLine());
                        break;
                }
            }
        }
    }
}