using System;

class Program
{
    static void Main()
    {
        int b = int.Parse(Console.ReadLine());
        int n = int.Parse(Console.ReadLine());
        uint number;
        int countBitsOnes,countBitsZeroes;
        
        for (int i = 0; i < n; i++)
        {
            countBitsOnes= countBitsZeroes = 0;
            int powerOfTwo = 0;
            number = uint.Parse(Console.ReadLine());
            while (number!=0)
            {
                if ((number&1)==1)
                {
                    countBitsOnes++;
                }
                else
                {
                    countBitsZeroes++;
                }
                number >>= 1;                          
            }
            if (b==1)
            {
                Console.WriteLine(countBitsOnes);  
            }
            else
            {
                Console.WriteLine(countBitsZeroes);  
            }
        }
    }
}