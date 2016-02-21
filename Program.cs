using System;

namespace BinaryConverter
{
    class Program
    {
        static void BinaToDeci()
        {
            Console.Clear();
            string bina = "";
            int[] deci;
            int deciFinal = 0;

            Console.Write("Enter a binary number: ");
            bina = Console.ReadLine();
            Console.Write("\n");

            deci = new int[bina.Length];

            for (int i = 0; i < deci.Length; i++)
            {
                deci[i] = Convert.ToInt32(bina[i].ToString());
            }

            for (int i = deci.Length; i > 0; i--)
            {
                deciFinal += deci[deci.Length - i] * (int)Math.Pow(2, i - 1);
                //Step by step solving
                Console.WriteLine(deci[deci.Length - i] + " * " + "2^" + (i - 1) + " = " + deci[deci.Length - i] * (int)Math.Pow(2, i - 1));
            }

            Console.WriteLine("\nDecimal: " + deciFinal);
        }
        static void DeciToBina()
        {
            Console.Clear();
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
        }
        static void Main(string[] args)
        {
            //navigation menu
            int menu = 0;
            Console.WriteLine("Decimal to Binary: X");
            Console.WriteLine("Binary to Decimal:");
            Console.WriteLine("\nUse UpArrow/DownArrow to navigate and press Enter to confirm.");

            ConsoleKeyInfo input;
            do
            {
                input = Console.ReadKey(true);

                if (input.Key == ConsoleKey.UpArrow)
                {
                    Console.Clear();
                    Console.WriteLine("Decimal to Binary: X");
                    Console.WriteLine("Binary to Decimal:");
                    Console.WriteLine("\nUse UpArrow/DownArrow to navigate and press Enter to confirm.");
                    menu = 0;
                }
                else if (input.Key == ConsoleKey.DownArrow)
                {
                    Console.Clear();
                    Console.WriteLine("Decimal to Binary:");
                    Console.WriteLine("Binary to Decimal: X");
                    Console.WriteLine("\nUse UpArrow/DownArrow to navigate and press Enter to confirm.");
                    menu = 1;
                }
            } while (input.Key != ConsoleKey.Enter);

            //DECIMAL TO BINATY
            if (menu == 0)
                DeciToBina();
            //BINARY TO DECIMAL
            else
                BinaToDeci();

            input = Console.ReadKey(true);
        }
    }
}