using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int position = 0;
        
        for (int i = 0; i < (2*n)-1; i++)
        {
            for (int y = 0; y < n; y++)
            {
                if (position == y)
                {
                    Console.Write('*');
                }
                else
                {
                    Console.Write('.');
                }
            }
            Console.WriteLine();
            
            if (i<(n-1))
            {
                position++;
            }
            else
            {
                position--;
            }

        }
    }
}