using System;



class CharFromInt
{
    static void Main()
    {
        char Symbol = '\u004a'; //hex na dec stoinost 74
        char Symbol2 = 'j';
        Console.WriteLine(Symbol);
        Console.WriteLine((char)74); //ili taka stava sashto 
        Console.WriteLine("Razlikata mejdu malki i golemi bukwi e {0}",(Symbol2-Symbol) ); 
    }
}

