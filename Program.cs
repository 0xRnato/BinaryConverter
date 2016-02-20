using System;

namespace BinaryConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            ulong bina = 0, casa = 1, resto, quo;
            string binaStr = "", binafinal = "";
            int multi = 0, nibbleCount = 0;

            Console.Write("Enter a decimal number: ");
            quo = ulong.Parse(Console.ReadLine());
            Console.Write("\n");

            //get binary number
            do
            {
                //Step by step solving
                Console.WriteLine(quo + "/2 = " + quo / 2 + " Resta: " + quo % 2);
                resto = quo % 2;
                bina += resto * casa;
                quo /= 2;
                casa *= 10;
            } while (quo != 0);

            binaStr = Convert.ToString(bina);

            //formatting result
            while (binaStr.Length > multi)
            {
                multi += 4;
            }

            for (int i = 0; i < multi - binaStr.Length; i++)
            {
                binafinal += "0";
                nibbleCount += 1;
                if (nibbleCount == 4)
                {
                    binafinal += " ";
                    nibbleCount = 0;
                }
            }

            for (int i = 0; i < binaStr.Length; i++)
            {
                binafinal += binaStr[i];
                nibbleCount += 1;
                if (nibbleCount == 4)
                {
                    binafinal += " ";
                    nibbleCount = 0;
                }
            }

            Console.WriteLine("\nBinary: " + binafinal);
            Console.ReadLine();
        }
    }
}
