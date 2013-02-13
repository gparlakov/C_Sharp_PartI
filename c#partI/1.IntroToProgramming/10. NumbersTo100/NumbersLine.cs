using System;

class NumbersTo100
{
    static void Main()                              //Извежда първите 10 члена на редицата 2,-3,4,-5,6,-7....
    {
        for (int i = 2; i < 12; i++)
        {
            Console.Write("№ {0}: ",(i-1));
            if ((i % 2) == 0)
            {
                Console.WriteLine(i);
            }
            else
            {
                Console.WriteLine("-" + i);
            }
        }
    }
}

