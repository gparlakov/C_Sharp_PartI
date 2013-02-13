//* Write a program that exchanges bits {p, p+1, …,
//p+k-1) with bits {q, q+1, …, q+k-1} of given 32-bit
//unsigned integer


using System;


class ExchangeBits
{
    /*from given integer and bit-number - returns its value 0/1*/
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

    /*from given integer and bit-number - modifies its value 0/1*/
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
        Console.WriteLine("We'll exchange exchanges bits {p, p+1, …,p+k-1) with bits {q, q+1, …, q+k-1} of given 32-bit unsigned integer");

        Console.Write("Unsigned integer=");
        /*modifiefInt stores the new bits because if q = 5 p = 4 their k-intervals intersect and we loose data */
        uint intNumber, modifiedInt;
        int buffer, difference, p = -1;
        int q = -1;
        int k = -1;

        bool check = true;

        while (!uint.TryParse(Console.ReadLine(), out intNumber)) { Console.WriteLine("Unsigned Integer !"); }
        modifiedInt = intNumber;

        Console.Write("p=");
        while (p == -1)
        {
            check = int.TryParse(Console.ReadLine(), out p);        //p must be 0 to 31 because unsigned int has 32 bits
            if (p > 31 || p < 0 || check == false)
            {
                Console.WriteLine("Integer between 0 and 31!");
                p = -1;
            }
        }

        Console.Write("q=");
        while (q == -1)                                               //q must be 0 to 31 because unsigned int has 32 bits
        {
            check = int.TryParse(Console.ReadLine(), out q);
            if (p > 31 || p < 0 || check == false || p == q)
            {
                Console.WriteLine("Integer between 0 and 31! and different from p!!");
                q = -1;
            }
        }



        if ((p - q) < 0)
        {                               //so p will be the bigger of the two numbers 
            buffer = p;                   //even if user gives them the other way
            p = q;
            q = buffer;
        }

        Console.Write("k=");
        while (k == -1)                                               //k must be lesser than 31-p
        {
            check = int.TryParse(Console.ReadLine(), out k);
            if (p > 31 || p < 0 || check == false || k > 31 - p)
            {
                Console.WriteLine("k must be less than 31-{0}={1}", p, 31 - p);
                k = -1;
            }
        }
        buffer = 0;
        difference = p - q;

        for (int i = q; i <= k + q; i++)
        {
            modifiedInt = modifyBitOfIntegerToValue(modifiedInt, i, returnBitFromInteger(intNumber, (i + difference)));      //modifies the i-th bit to the (i+21)-th bit
            modifiedInt = modifyBitOfIntegerToValue(modifiedInt, (i + difference), returnBitFromInteger(intNumber, i));      //modifies the (i+21) bit to the buffer (i-th bit originally)
        }
        Console.WriteLine("intNumber={0},modified={1}, p={2},q={3},k={4}, difference= {5}", intNumber, modifiedInt, p, q, k, difference);//Console.WriteLine(intNumber);

    }
}
