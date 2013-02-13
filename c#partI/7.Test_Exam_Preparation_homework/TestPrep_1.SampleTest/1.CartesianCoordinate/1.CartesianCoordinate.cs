using System;

class Program
{
    static void Main()
    {
        double x = double.Parse(Console.ReadLine());
        double y = double.Parse(Console.ReadLine());
        int res = -1;
        if (x==0&&y==0)
        {
            res = 0;
        }
        else if (x==0)
        {
            res = 5;
        }
        else if (y == 0)
        {
            res = 6;
        }
        else if ((x>0)&&(y>0))
        {
            res = 1;
        }
        else if ((x<0)&&(y>0))
        {
            res = 2;
        }
        else if ((x<0)&&(y<0))
        {
            res = 3;
        }
        else
        {
            res = 4;
        }
        Console.WriteLine(res);
    }
}