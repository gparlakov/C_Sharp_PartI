//* Write a program that converts a number in the range [0...999] 
//to a text corresponding to its English pronunciation. Examples
//0  "Zero"
//    273  "Two hundred seventy three"
//    400  "Four hundred"
//    501  "Five hundred and one"
//    711  "Seven hundred and eleven"

using System;

class ConvertNumberToText
{
    static void Main()
    {
        string[] digits = {null,"One ", "Two ", "Three ", "Four ", "Five ", "Six ", "Seven ", "Eight ", "Nine " };
        string[] ten = { "ten ", "twenty ", "thirty ", "fourty ", "fifty ", "sixty ", "seventy ", "sighty ", "ninety " };
        string[] specials = { "eleven ", "twelve ", "thirteen ", "fourteen ", "fifteen ", "sixteen ", "seventeen ", "eightteen ", "nineteen " };
        uint number, hundreds, tens, ones;
        string finalHundred = null;
        string finalTen = null;
        string finalOne = null;

        do
        {
            Console.WriteLine("Number 0-999:");
        } while (!uint.TryParse(Console.ReadLine(), out number) || number > 999);
        hundreds = number / 100;
        tens = (number % 100) / 10;
        ones = (number % 100) % 10;

        if (tens == 0)
        {
            if (ones == 0&&hundreds==0)
            {
                finalOne = "Zero";
            }
            else 
            {
                finalOne = digits[ones];
                finalHundred = digits[hundreds];
            }
        }
        else if (tens == 1)
        {
            if (ones == 0)
            {
                finalTen = ten[0];
            }
            else
            {
                finalTen = specials[(number % 10) - 1];
            }
        }
        else
        {
            finalTen = ten[tens-1];
            finalOne = digits[ones];
        }
        if (hundreds!=0) 
        {
            finalHundred=digits[hundreds]+"hundred ";
        }        
        Console.WriteLine(finalHundred+finalTen+finalOne);
    }
}
        