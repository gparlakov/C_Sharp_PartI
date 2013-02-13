//Write an expression that extracts from a given
//integer i the value of a given bit number b.
//Example: i=5; b=2  value=1.


using System;



class WhatIsBitb
{
    static void Main()
    {
        int integer, bitB;
        int mask = 1;
       
        Console.WriteLine("We'll check in integer i, what is bit at position b  (counting from 0) has value of 1.");

        Console.Write("i=");
        while (!int.TryParse(Console.ReadLine(), out integer)) { Console.WriteLine("integer please "); }

        Console.Write("p=");
        while (!int.TryParse(Console.ReadLine(), out bitB)) { Console.WriteLine("integer please "); }

        mask = mask << bitB;
        mask = mask & integer;
        mask = mask >> bitB;
        if (mask == 1)
        {
            Console.WriteLine("The bit {0} of {1} is 1", bitB, integer);
        }
        else 
        {
            Console.WriteLine("The bit {0} of {1} is 0", bitB, integer);
        }
       
    }
}

