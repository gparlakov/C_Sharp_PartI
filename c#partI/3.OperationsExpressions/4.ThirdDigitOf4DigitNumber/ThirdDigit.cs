//4. Write an expression that checks for given integer if
//its third digit (right-to-left) is 7. E. g. 1732  true.
using System;

class Program
{
    static void Main()
    {
        short fourDigit = 10000;
        Console.WriteLine("Please give the number from -9999 to 9999.");
        do
        {
            short.TryParse(Console.ReadLine(), out fourDigit);
            if (fourDigit > 9999 || fourDigit < -9999)
            {
                Console.WriteLine("-9999 to 9999, please."  );
            }
        } while (fourDigit > 9999 || fourDigit < -9999);

        Console.WriteLine("The third digit (right-to-left) of {0} is {1}, so is is 7? {2}", fourDigit, ((fourDigit % 1000) / 100), ((fourDigit % 1000) / 100)==7);

    }
}

