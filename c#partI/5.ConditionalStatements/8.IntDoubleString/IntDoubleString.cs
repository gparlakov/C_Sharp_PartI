//Write a program that, depending on the user's choice inputs int, double or string variable.
//If the variable is integer or double, increases it with 1. If the variable is string, appends "*" 
//at its end. The program must show the value of that variable as a console output. Use switch statement.

using System;

class IntDoubleString
{
    static void Main()
    {
        byte choice;
        string userString;
        double userDouble;
        int userInt;
        Console.WriteLine("Input : \n1.String\n2.Real number\n3.Integer number:\n");
        while(!byte.TryParse(Console.ReadLine(),out choice) || choice>3){Console.WriteLine("1 2 or 3:");}
        switch(choice)
        {
            case 1:
                {
                    Console.WriteLine("Input your string");
                    userString=Console.ReadLine();
                    Console.WriteLine("Altered: {0}",userString,userString+'*' );
                    break;
                }
            case 2:
                {
                    while (!double.TryParse(Console.ReadLine(), out userDouble)) { Console.WriteLine("Real number:"); }
                    Console.WriteLine("Altered: {0}",userDouble+1);
                    break;
                }
            default:
                {
                    while (!int.TryParse(Console.ReadLine(),out userInt) ) { Console.WriteLine("Integer:"); }
                    Console.WriteLine("Altered: {0}",userInt);
                    break;
                }
        }

    }
}
