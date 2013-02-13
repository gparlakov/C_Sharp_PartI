using System;
using System.Text; // Encoding.UTF8 е от тък

class TheCopyrightSymbol
{
    static void Main()
    {
        char copyRight = '\u00a9';
        Console.OutputEncoding=Encoding.UTF8; //без този ред не излиза правилно в конзолата
        Console.WriteLine(@"
    {0}
   {0} {0}
  {0}   {0}
 {0} {0} {0} {0}", copyRight);
        
    }
}


