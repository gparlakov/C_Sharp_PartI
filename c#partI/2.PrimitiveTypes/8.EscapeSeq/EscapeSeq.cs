using System;



class EscapeSeq
{
    static void Main()
    {
        string withEscapeSequence = "The \"use\" of quotations causes difficulties.";
        string withOutEscapeSequence = @"The ""use"" of quotations causes difficulties." ;
        Console.WriteLine("{0}\n{1}",withEscapeSequence,withOutEscapeSequence);
        string withEscapeTabNewLineAndPath = "\nThis is a \ttab, this is a new \nline, and here is a path to the project on a new line \nc:\\Program Files\\VisualStudio2012\\projects";
        Console.WriteLine(withEscapeTabNewLineAndPath);
        string withOutEscapeLong = @"
This is a   tab,this is a new
line, and here is a path to the project on a new line
c:\Program Files\VisualStudio2012\projects";
        Console.WriteLine(withOutEscapeLong);
/*the /t tab = twice the keybouard tab*/    
    }

}

