using System;
using System.Collections.Generic;
using System.Threading.Tasks;    
using System.Text;

using System.Threading;               
using System.Globalization;                 // tezi dvete za current.......



class Program
{
    static int firstPlayerResult = 0;
    static int secondPlayerResult = 0;
    
    static int pad1Size = 4;
    static int pad2Size = 4;
    static int ballPositionX = 0;
    static int ballPositionY = 0;
    static bool ballDirectionUp = true;             //determines whether the ball moves up/down left/right
    static bool ballDirectionRight = true;         //
    
    static int firstPlayerPosition = 0;
    static int secondPlayerPosition = 0;
    static Random randomGenerator = new Random();
   

    static void removeScrollbars()
    {
        Console.BufferHeight = Console.WindowHeight;
        Console.BufferWidth = Console.WindowWidth;
    }

    static void drawFirstPlayer()
    {
        for (int y = firstPlayerPosition; y < firstPlayerPosition + pad1Size; y++)
        {
            PrintAtPosition(0,y,'|');
            PrintAtPosition(1, y, '|');
        }
    }

    static void drawSecondPlayer()
    {
        for (int y1 = secondPlayerPosition; y1 < secondPlayerPosition+pad2Size; y1++)
        {
            PrintAtPosition(Console.WindowWidth - 1, y1, '|');
            PrintAtPosition(Console.WindowWidth - 2, y1, '|'); 
        }    
    }


    static void PrintAtPosition(int x, int y, char simvol)
    {
        Console.SetCursorPosition(x, y);
        Console.Write(simvol);
    }

    static void setInitialConditions()
    {
        firstPlayerPosition = (Console.WindowHeight / 2) - (pad1Size / 2);
        secondPlayerPosition = (Console.WindowHeight / 2) - (pad2Size / 2);
        setBallInTheMiddleOfScreen();

    }
     static void setBallInTheMiddleOfScreen()
    {
        ballPositionX = Console.WindowWidth / 2;
        ballPositionY = Console.WindowHeight / 2;
    }


    static void drawBall()
    {
        PrintAtPosition(ballPositionX, ballPositionY, '@');
    }

    static void moveFirstPlayerDown()
    {
        if (firstPlayerPosition>0)
        {
            firstPlayerPosition--;
        }
    }

    static void moveFirstPlayerUp()
    {   
        if (firstPlayerPosition<(Console.WindowHeight-pad1Size))
        {
            firstPlayerPosition ++;
        }
    }

    static void moveSecondPlayerDown()
    {
        if (secondPlayerPosition > 0)
        {
            secondPlayerPosition--;
        }
    }

    static void moveSecondPlayerUp()
    {
        if (secondPlayerPosition < (Console.WindowHeight - pad1Size))
        {
            secondPlayerPosition++;
        }
    }

    static void secondPlayerAIMove()
    {
        int randomNumber = randomGenerator.Next(0, 2);
        if (randomNumber == 1)
        {
            moveSecondPlayerUp();
        }
        else
        {
            moveSecondPlayerDown();
        }
    }

    private static void moveBall()
    {
        if (ballPositionY == 0)
        {
            ballDirectionUp = false;
        }

        if (ballPositionY == Console.WindowHeight)
        {
            ballDirectionUp = true;
        }
        
        if (ballDirectionUp)
        {
            ballPositionY++;
        }
        else
        {
            ballPositionY--;
        }

        if (ballDirectionRight)
        {
            ballPositionX++;
        }
        else
        {
            ballPositionX--;
        }

        if (ballPositionX < 3) 
        {
            if (ballPosition >= firstPlayerPosition && ballPositionY <= firstPlayerPositon + pad1Size)
            {
                ballDirectionRight = true;
            }
        }
        
        if (ballPositionX == Console.WindowWidth - 1)
        {
            setBallInTheMiddleOfScreen();
            ballDirectionRight = false;
            ballDirectionUp = false;
            firstPlayerResult++;
        }


        if (ballPositionX == 0)
        {
            setBallInTheMiddleOfScreen();
            ballDirectionRight = true;
            ballDirectionUp = true;
            secondPlayerresult++;
        }

    }

    



    static void Main()                      // w konzolata byrabyra.exe > output.txt wkarwa wsi4ko koeto e izpisano na konzolata wyw faila
                                            //byrabyra.exe < input.txt wkarwa danni ot input.txt.....
    {           
                                            // ako stigne kraq na faila - readLine wryshta null
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;  // razdelitelq e . a ne ,



        removeScrollbars();
        setInitialConditions();

        while (true)
        {
            if (Console.KeyAvailable)
            {

                ConsoleKeyInfo keyInfo = Console.ReadKey();

                if (keyInfo.Key == ConsoleKey.UpArrow)
                {
                    moveFirstPlayerUp();
                }
                if (keyInfo.Key == ConsoleKey.DownArrow)
                {
                    moveFirstPlayerDown();
                }
            }
            secondPlayerAIMove();
            moveBall();
            //redraw all
            Console.Clear(); // clear all
            drawFirstPlayer();  
            drawSecondPlayer();
            drawBall();
            // - print score
            Thread.Sleep(60);        
        }


    }

   
   
}

