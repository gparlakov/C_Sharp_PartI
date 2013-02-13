using System;
class TrapezoidDraw
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n + 1; i++)
        {
            for (int y = 0; y < 2 * n; y++)
            {
                if (y <= n - i - 1)
                {
                    Console.Write('.');
                }
                else
                {
                    if (i == 0 || i == n)
                    {
                        Console.Write('*');
                    }
                    else if (y == n - i || y == (2 * n) - 1)
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
        }
    }
}
