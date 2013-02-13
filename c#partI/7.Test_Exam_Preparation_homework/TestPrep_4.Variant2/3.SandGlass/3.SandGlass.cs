using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int middle = n / 2 + 1;
        int counter = 0;
        for (int rowIndex = 0; rowIndex < n; rowIndex++)
        {
            for (int colIndex = 0; colIndex < n; colIndex++)
            {
                //Console.Write(Math.Abs(colIndex - rowIndex));
                if (rowIndex==0||rowIndex==n-1)
                {
                    Console.Write('*');
                }
                else if (colIndex <(n-counter) && colIndex >= counter)
                {
                    Console.Write('*');
                }
                else
                {
                    Console.Write('.');    
                }                
            }
            Console.WriteLine();
            if (rowIndex<n/2)
            {
                counter++; 
            }
            else
            {
                counter--;
            }
        }
    }
}