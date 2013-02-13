//We are given integer number n, value v (v=0 or 1)
//and a position p. Write a sequence of operators that
//modifies n to hold the value v at the position p from
//the binary representation of n.


using System;

    class ModifyBitOfGivenInteger
    {
        static int modifyBitOfIntegerToValue(int integer, int bit,int value)
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
            int N, P, V=2;
            Console.WriteLine("We're going to modyfy the bit at position P of integer N to value v (1 or 0)");
            Console.Write("N=");
            while (!int.TryParse(Console.ReadLine(), out N)) { Console.WriteLine("integer please "); }
            Console.Write("P=");
            while (!int.TryParse(Console.ReadLine(), out P)) { Console.WriteLine("integer please "); }
            Console.Write("V=");
            while (V==2)
            {
                bool text=true;                                              //checks whether v is string or char
                text=int.TryParse(Console.ReadLine(), out V);
                if (V > 1 || V < 0 || text==false)
                {
                    V = 2;
                    Console.WriteLine("1 or 0 please");
                }
            }
            
            N=modifyBitOfIntegerToValue(N, P, V);
            Console.WriteLine(N);
        }

    }
