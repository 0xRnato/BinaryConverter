using System;

namespace BinaryConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            ulong bina = 0, casa = 1, resto, quo;
            string binaStr = "", novabina = "";
            int binaLength, multi = 0;

            Console.Write("Enter a decimal number: ");
            quo = ulong.Parse(Console.ReadLine());

            do
            {
                resto = quo % 2;
                bina += resto * casa;
                quo /= 2;
                casa *= 10;
            } while (quo != 0);

            binaStr = Convert.ToString(bina);            
            binaLength = binaStr.Length;

            while (binaLength >= multi)
            {
                multi += 4;
            }

            for (int i = 0; i < multi-binaLength; i++)
            {
                novabina += "0";
            }

            for (int i = 0; i < binaLength; i++)
            {
                novabina += binaStr[i];
            }

            Console.WriteLine("Binary: " + bina);
            Console.WriteLine("Binary: " + binaStr);
            Console.WriteLine("Binary: " + novabina);
            Console.ReadLine();
        }
    }
}
