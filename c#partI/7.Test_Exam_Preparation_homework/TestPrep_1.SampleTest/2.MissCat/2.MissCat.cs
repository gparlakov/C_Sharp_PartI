using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] votes = new int[11];
        int result = 0;                                             
        
        for (int i = 0; i < n; i++)
        {
            votes[int.Parse(Console.ReadLine())]++;
        }
        for (int i = 1; i <= 10; i++)
        {
            if (votes[i]>votes[0])
            {
                votes[0] = votes[i];
                result = i;
            } 
        }
        Console.WriteLine(result);
    }
}

