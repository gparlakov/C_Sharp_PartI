using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int defase = 1;
        for (int y = 0; y < n; y++)
        {
            for (int x = 0; x < 2*(n-1)-1; x++)
            {
                if (y==0||y==n-1)
                {
                    if (x==(n-2))
                    {
                        Console.Write('*');
                    }
                    else
                    {
                        Console.Write('.');
                    }
                }
                else
                {
                    if ((x>=n-1-defase)&&(x<=n-3+defase))
                    {
                        Console.Write('*');
                    }
                    else
                    {
                        Console.Write('.');
                    }
                }
            }
            Console.WriteLine();
            defase++;
        }
    }
}
