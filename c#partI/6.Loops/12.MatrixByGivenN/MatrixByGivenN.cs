//Write a program that reads from the console a positive integer number N 
//(N < 20) and outputs a matrix like the following:

using System;
class MatrixByGivenN
{
    static void Main()
    {
        int matrixWidth;
        Console.WriteLine("Give me the matrix width/height ");
        Console.SetWindowSize(150,35);
        do
        {
            Console.WriteLine("Matrix Width: ");
        } while (!int.TryParse(Console.ReadLine(), out matrixWidth)||matrixWidth<1);
        for (int i = 0; i < matrixWidth; i++)
        {
            for (int y = 0; y < matrixWidth; y++)
            {
                Console.Write("|{0,2}|",i+y+1);
            }
            Console.WriteLine();
        }
    }
}