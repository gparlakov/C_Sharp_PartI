//Write an expression that checks for given point (x, y)
//if it is within the circle K( (1,1), 3) and out of the
//rectangle R(top=1, left=-1, width=6, height=2).

using System;

    class inOutOfFigures
    {
        static void Main()
        {
            float pointX, pointY,distanceToCircleCenter;
            Console.WriteLine("PLease give the coordinates ot the point:");
            Console.Write("X=");
            while(!float.TryParse(Console.ReadLine(), out pointX)){};
            Console.Write("Y=");
            while (!float.TryParse(Console.ReadLine(), out pointY)) { };
            distanceToCircleCenter = (float)Math.Sqrt(Math.Pow(pointX-1,2)+Math.Pow(pointY-1,2));
            if (distanceToCircleCenter <= 3)
            {
                Console.WriteLine("This point with coordinates x={0} y={1} is whithin the circle K[(1,1),3]", pointX, pointY);
            }
            else
            {
                Console.WriteLine("This point with coordinates x={0} y={1} is outside of the circle K[(1,1),3]", pointX, pointY);    
            }
            if (pointX >= -1 && pointX <= 5 && pointY <= 1 && pointY >= -2)
            {
                Console.WriteLine("This point with coordinates x={0} y={1} is whithin the rectangle with top left (1,-1) width 6 height 3", pointX, pointY);
            }
            else 
            {
                Console.WriteLine("This point with coordinates x={0} y={1} is out of the rectangle with top left (1,-1) width 6 height 3", pointX, pointY);
            }
        }
    }

