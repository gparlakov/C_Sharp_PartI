using System;

class Program
{
    static int returnBitFromInteger(int integer, int bit)
    {
        int mask = 1;
        mask = mask << bit;
        mask = mask & integer;
        mask = mask >> bit;
        if (mask == 1)
        {
            return 1;
        }
        else
        {
            return 0;
        }

    }

    static int modifyBitOfIntegerToValue(int integer, int bit, byte value)
    {
        int mask = 1;
        mask = mask << bit;
        if (value == 1)
        {
            integer = integer | mask;
        }
        else
        {
            integer = integer & ~mask;
        }
        return integer;
    }

    static void Main()
    {
        int[] numbers = new int[8];
        for (int i = 0; i < 8; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());
        }

        //for (int i = 0; i < 8; i++)
        //{
        //    Console.WriteLine("{0,8:d8}", Convert.ToString(numbers[i], 2));
        //}
        //Console.WriteLine();

        for (int column = 7;  column >= 0; column--)
        {
            byte lastBit = 7, nextBitUp = 7;
            while (returnBitFromInteger(numbers[lastBit], column) == 1)
            {
                lastBit--;
                nextBitUp--;
                if (nextBitUp==0)
                {
                    break;
                }
            }
            do
            {
                if (nextBitUp > 0)
                {
                    nextBitUp--;
                }
                else
                {
                    break;
                }
                if (returnBitFromInteger(numbers[nextBitUp], column) == 1)
                {
                    numbers[lastBit] = modifyBitOfIntegerToValue(numbers[lastBit], column, 1);
                    numbers[nextBitUp] = modifyBitOfIntegerToValue(numbers[nextBitUp], column, 0);
                    lastBit--;
                }               
                
            } while (nextBitUp > 0); 
        }
        for (int i = 0; i < 8; i++)
        {
            Console.WriteLine(numbers[i]);
        }
    }
}