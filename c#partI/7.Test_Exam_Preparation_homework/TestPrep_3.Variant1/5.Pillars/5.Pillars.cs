using System;

class Program
{
       
    static void Main()
    {
        int[] numbers = new int[8];
        int column=0, row=0, resultColumn=1,resultLeft=0,resultRight=0;
        bool exists = false;

        for (int i = 0; i < 8; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());
        }
        for (int rows = 0; rows < 8; rows++)
        {
            for (int columns = 7; columns >= 0; columns--)
            {
                Console.Write((numbers[rows] >> columns) & (1));
            }
            Console.WriteLine();
        }

        for (resultColumn = 7; resultColumn >= 0; resultColumn--)
        {
            for (column = 0; column < 8; column++)
            {
                if (column == resultColumn)       //jumps over the pillar(resultColumn)
                {
                    continue;
                }

                for (row = 0; row < 8; row++)
                {
                    if ((((numbers[row] >> column) & 1) == 1) && column > resultColumn)
                    {
                        resultLeft++;
                    }
                    else if (((( numbers[row] >> column ) & 1) == 1) && column < resultColumn)
                    {
                        resultRight++;
                    }
                }
            }
            if (resultLeft == resultRight)
            {
                Console.WriteLine(resultColumn);
                Console.WriteLine(resultLeft);
                exists = true;
                break;
            }
            else
            {
                resultLeft = resultRight = 0;
            }
        }
        if (!exists)
        {
            Console.WriteLine("No");
        }
    }
}
