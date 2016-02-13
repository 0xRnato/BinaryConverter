using System;

namespace BinaryConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            string key;
            do
            {
                ulong bina = 0, resto = 0, quo = 0, casa = 1;

                Console.Write("Enter a decimal number: ");
                quo = ulong.Parse(Console.ReadLine());

                do
                {
                    resto = quo % 2;
                    bina += resto * casa;
                    quo /= 2;
                    casa *= 10;
                } while (quo != 0);
                Console.WriteLine("Binary: " + bina);
                Console.Write("\nEnter 'E' to exit... ");
                key = Console.ReadLine();
                Console.Clear();
            } while (key != "e" && key != "E");
        }
    }
}
