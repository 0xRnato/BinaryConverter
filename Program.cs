using System;

namespace BinaryConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            ulong bina = 0, casa = 1, resto, quo;
            string binaStr = "", binafinal = "";
            int multi = 0, multi2 = 0;

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

            while (binaStr.Length >= multi)
            {
                multi += 4;
            }

            for (int i = 0; i < multi - binaStr.Length; i++)
            {
                binafinal += "0";
                multi2 += 1;
                if (multi2 == 4)
                {
                    binafinal += " ";
                    multi2 = 0;
                }
            }

            for (int i = 0; i < binaStr.Length; i++)
            {
                binafinal += binaStr[i];
                multi2 += 1;
                if (multi2 == 4)
                {
                    binafinal += " ";
                    multi2 = 0;
                }
            }
            Console.WriteLine("Binary FIN: " + binafinal);
            Console.ReadLine();
        }
    }
}
