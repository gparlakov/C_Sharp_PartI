//draws Telrik Logo on Console given a lenght 

using System;

namespace TelerikLogo
{
    class TelerikLogo
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            int y = x, z = (x + 1) / 2, side = x * 3 - 2;

            int modifier1 = z - 1, modifier3 = z, modifier2 = side / 2 - 1, modifier4 = 2;


            for (int posY = 0; posY < x; posY++)
            {
                for (int posX = 0; posX < side; posX++)
                {
                    if (posX == modifier1 || posX == side - modifier1 - 1 || (posX == modifier3 - 1) || (posX == side - modifier3))
                    {
                        Console.Write('*');
                    }
                    else
                    {
                        Console.Write('.');
                    }
                }
                modifier1++;
                modifier3--;
                Console.WriteLine();
            }

            for (int posY = x; posY < side - x; posY++)
            {
                for (int posX = 0; posX < side; posX++)
                {
                    if (posX == modifier2 || posX == side - modifier2 - 1)
                    {
                        Console.Write('*');
                    }

                    else
                    {
                        Console.Write('.');
                    }
                }
                modifier2--;
                Console.WriteLine();
            }

            modifier1 = z - 1;
            for (int posY = side - x; posY < side; posY++)
            {
                for (int posX = 0; posX < side; posX++)
                {
                    if (posX == modifier1 || posX == side - modifier1 - 1)
                    {
                        Console.Write('*');
                    }


                    else
                    {
                        Console.Write('.');
                    }
                }
                modifier1++;
                Console.WriteLine();
            }
        }
    }
}
