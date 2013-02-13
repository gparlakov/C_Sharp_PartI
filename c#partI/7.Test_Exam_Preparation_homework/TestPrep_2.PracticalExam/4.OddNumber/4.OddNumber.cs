using System;


class Program
{
    static void Main()
    {
       // long[] test = new long[long.MaxValue];
        int n = int.Parse(Console.ReadLine());
        long[] numbersAndHits = new long[99999];
        long hits = 0;
        int index = 0;

        for (int i = 0; i < n; i++)
        {
            numbersAndHits[i] = long.Parse(Console.ReadLine());
        }
        for (int i = 0; i < n; i++)
        {
            if (numbersAndHits[index] == numbersAndHits[i])
            {
                hits++;
            }
            if (i == (n - 1))
            {
                if ((hits % 2) == 1)
                {
                    Console.WriteLine(numbersAndHits[index]);
                    break;
                }
                else
                {
                    hits = 0;
                    i = -1;
                    index++;
                }
            }
        }

    }
}