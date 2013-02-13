//Write a program that prints all possible cards from a standard deck of 52 cards 
//(without jokers). The cards should be printed with their English names.
//Use nested for loops and switch-case.

using System;

class All52Cards
{
    static void Main()
    {
        int positionY=0, positionX=0;
        string[] colours = { "Spades", "Hearts", "Diamonds", "Clubs" };
        foreach (string colour in colours)
        {
            for (int y = 0; y < 13; y++)
            {
                string card;
                switch (y)
                {
                    case 0:
                        {
                            card = "Ace";
                            break;
                        }
                    case 1:
                        {
                            card = "King";
                            break;
                        }
                    case 2:
                        {
                            card = "Queen";
                            break;
                        }
                    case 3:
                        {
                            card = "Jack";
                            break;
                        }
                    case 4:
                        {
                            card = "Ten";
                            break;
                        }
                    case 5:
                        {
                            card = "Nine";
                            break;
                        }
                    case 6:
                        {
                            card = "Eight";
                            break;
                        }
                    case 7:
                        {
                            card = "Seven";
                            break;
                        }
                    case 8:
                        {
                            card = "Six";
                            break;
                        }
                    case 9:
                        {
                            card = "Five";
                            break;
                        }
                    case 10:
                        {
                            card = "Four";
                            break;
                        }
                    case 11:
                        {
                            card = "Three";
                            break;
                        }
                    default:
                        {
                            card = "Two";
                            break;
                        }

                        
                }
                Console.SetCursorPosition(positionX, positionY);
                Console.Write("{0,-5} of {1,6}",card,colour);
                positionY++;
                

            }
            positionX+=20;
            positionY = 0;
        }
        Console.WriteLine();
    }
}