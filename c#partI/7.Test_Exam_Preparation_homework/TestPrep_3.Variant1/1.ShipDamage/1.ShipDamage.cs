using System;

class Program
{
    static int checkDamage(int x1,int y1,int x2,int y2,int h, int x, int y) 
    {
        int dam = 0;
        int Y=h-(y-h);
        if (Y==y1||Y==y2)
        {
            if (x==x1||x==x2)
            {
                dam = 25; 
            }
            else if(x>x1&&x<x2)
            {
                dam = 50;
            }
        }
        else if ((( y1<y2 )&&(Y>y1 && Y<y2))||(( y1>y2 )&&( Y>y2 )&&( Y<y1 )))
        { 
            if ((x>x1)&&(x<x2))
	        {
                 dam = 100;
	        }
            else if (x==x1||x==x2)
            {
                dam = 50;
            }
        }

        return dam;
    }
    
    static void Main()
    {
        int sx1 = int.Parse(Console.ReadLine());
        int sy1 = int.Parse(Console.ReadLine());
        int sx2 = int.Parse(Console.ReadLine());
        int sy2 = int.Parse(Console.ReadLine());
        int h = int.Parse(Console.ReadLine());
        int cx1 = int.Parse(Console.ReadLine());
        int cy1 = int.Parse(Console.ReadLine());
        int cx2 = int.Parse(Console.ReadLine());
        int cy2 = int.Parse(Console.ReadLine());
        int cx3 = int.Parse(Console.ReadLine());
        int cy3 = int.Parse(Console.ReadLine());
        int temp,damage=0;
        if (sx1>sx2)
        {
            temp = sx1;
            sx1 = sx2;
            sx2 = temp;
            temp = sy1;
            sy1 = sy2;
            sy2 = temp;
        }        

        damage += checkDamage(sx1, sy1, sx2, sy2, h, cx1, cy1);
        damage += checkDamage(sx1, sy1, sx2, sy2, h, cx2, cy2);
        damage += checkDamage(sx1, sy1, sx2, sy2, h, cx3, cy3);
        Console.WriteLine("{0}%",damage);
    }
}