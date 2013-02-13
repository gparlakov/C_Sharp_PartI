using System;

class Program
{
    static int bitsLong(int number)
    {
        int check = number;
        int counter = 0;
        while (check != 0)
        {
            counter++;
            check >>= 1;
        }
        return counter;
    }

    static int getBit(int n, int bitNumber)
    {
        int bit = 0;        
        if (((n>>bitNumber)&1)==1)
        {
            bit = 1;
        }        
        return bit;
    }
    
    static int invertBits(int n, int bitsLong)
    {
        int invertedBitsNumber=n;
        int first = 0;
        int last = bitsLong;
        do
        {
            if (first==last)
            {
                break;
            }

            if (getBit(n,first)!=getBit(n,last))
            {
                invertedBitsNumber=setBit(invertedBitsNumber,first,getBit(n,last));
                invertedBitsNumber=setBit(invertedBitsNumber,last, getBit(n,first));
            }
            //n = invertedBitsNumber;
            first++;
            last--;
        } while (first<(last));


        return invertedBitsNumber;
    }

    
    static int setBit(int param, int bit,int value)
    {
        int settBit = 0;
        int p = param;
        if (value == 0)
        {
            settBit = ~(1 << bit) & p;
        }
        else
        {
            settBit = (1 << bit) | p;
        }
        return settBit;
    }
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] numbersArray = new int[n];
        for (int i = 0; i < n; i++)
        {
            int temp=int.Parse(Console.ReadLine());
            //Console.WriteLine(Convert.ToString(temp,2));
            numbersArray[i] = invertBits(temp, bitsLong(temp)-1);
            Console.WriteLine(numbersArray[i]);
        }
    }
}
