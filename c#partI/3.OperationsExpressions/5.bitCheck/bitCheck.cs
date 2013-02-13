//Write a boolean expression for finding if the bit 3
//(counting from 0) of a given integer is 1 or 0.

using System;

class bitCheck
{
    static void Main()
    {
        int integer,mask,result;
        Console.WriteLine("Integer is?");
        int.TryParse(Console.ReadLine(), out integer);
        mask = 1 << 3;
        result = ((integer & mask) >> 3);
        Console.WriteLine("The bit o position 3 (from 0) is {0}", result);
    }
}

