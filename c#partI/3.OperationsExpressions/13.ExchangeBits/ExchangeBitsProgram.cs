//Write a program that exchanges bits 3, 4 and 5 with
//bits 24, 25 and 26 of given 32-bit unsigned integer.

using System;

class ExchangeBits
{
    static int returnBitFromInteger(uint integer, int bit)
    {
        uint mask = 1;
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

    static uint modifyBitOfIntegerToValue(uint integer, int bit, int value)
    {
        uint mask = 1;
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
        Console.Write("Unsigned integer=");
        uint integer1;
        while (!uint.TryParse(Console.ReadLine(), out integer1)) { Console.WriteLine("Unsigned Integer !"); }
        int buffer;
        for (int i = 3; i < 6; i++)
        {
            buffer = returnBitFromInteger(integer1, i);                                                   //keeps the i-th bit
            integer1=modifyBitOfIntegerToValue(integer1, i, returnBitFromInteger(integer1, i + 21));       //modifies the i-th bit to the (i+21)-th bit
            integer1=modifyBitOfIntegerToValue(integer1,i+21,buffer);                                     //modifies the (i+21) bit to the buffer (i-th bit originally)
        }
        Console.WriteLine(integer1);
    }
}

