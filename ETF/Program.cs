using System;

namespace ETF
{
    class Program
    {
        static void Main(string[] args)
        {

            double Euro, Flaschen;
            double AwnserIsValid = 0;
            double Pfand = 0.25;

            for (; AwnserIsValid < 1;)
            {
                Console.WriteLine("ETF or FTE? : ");
                String ETFOrFTE = Convert.ToString(Console.ReadLine());
                AwnserIsValid++;
                switch (ETFOrFTE)
                {
                    case "ETF":
                        Console.WriteLine("Wie viel Euro: ");
                        Euro = Convert.ToDouble(Console.ReadLine());
                        Flaschen = Euro / Pfand;
                        Console.WriteLine("{0} Euro sind {1} Flaschen.", Euro, Flaschen);
                        Console.ReadKey();
                        System.Environment.Exit(1);
                        break;

                    case "FTE":
                        Console.WriteLine("Wie viele Flaschen: ");
                        Flaschen = Convert.ToDouble(Console.ReadLine());
                        Euro = Flaschen * Pfand;
                        Console.WriteLine("{0} Flaschen sind {1} Euro.", Flaschen, Euro);
                        Console.ReadKey();
                        System.Environment.Exit(1);
                        break;

                    default:
                        Console.WriteLine("Bitte eine richtige Aufgabe");
                        break;
                }
                AwnserIsValid--;
            }
        }
    }
}
