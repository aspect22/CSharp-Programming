using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int input = 0;
                double a = 0;
                double b = 0;
                double result = 0;

                bool loop = true;

                while (loop == true)
                {
                    try
                    {
                        Console.WriteLine("Add (1), Sub (2), Multi (3), Devide (4)");
                        input = Convert.ToInt32(Console.ReadLine());
                        loop = false;
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Invalid Input");
                    }
                }

                loop = true;
                while (loop == true)
                {
                    try
                    {
                        Console.Write("Num1: \t");
                        a = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Num2: \t");
                        b = Convert.ToDouble(Console.ReadLine());
                        loop = false;
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Invalid Input");
                    }
                }

                switch (input)
                {
                    case 1:
                        result = a + b;
                        break;
                    case 2:
                        result = a - b;
                        break;
                    case 3:
                        result = a * b;
                        break;
                    case 4:
                        result = a / b;
                        break;
                    default:
                        throw new StackOverflowException("Fuck");
                }

                Console.WriteLine(result);
            }
            catch (StackOverflowException)
            {
                while(true)
                {
                    Console.WriteLine("NIGGA IT AINT WORKIN");
                }
            }
        }
    }
}
