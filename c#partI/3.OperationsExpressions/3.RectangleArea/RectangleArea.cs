//Write an expression that calculates rectangle’s area
//by given width and height.

using System;



class RectangleArea
{
    static void Main()
    {
        float width, height;
        Console.WriteLine("Write the width and height of the rectangle starting with the width and separated by comma if float");
        float.TryParse(Console.ReadLine(), out width);
        float.TryParse(Console.ReadLine(), out height);
        Console.WriteLine("This rectangle's area is {0}",width*height);
    }
}
