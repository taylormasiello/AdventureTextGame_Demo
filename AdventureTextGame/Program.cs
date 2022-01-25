﻿using System;
// using static AdventureTextGame.TitleScreen;
using static System.Console;


namespace AdventureTextGame
{
    class Program
    {
        static void Main(string[] args)
        {
            TitleScreen.gameStart();
            TitleScreen.setCharName();
            
        }
    }
}

////original Dialog method
//static void Dialog(string message)
//{
//    Console.ForegroundColor = ConsoleColor.Cyan;
//    Console.WriteLine(message);
//    Console.ResetColor();
//}

//Console.Write("A stranger approaches. Clearing their throat to get your attention, they ask \n");
//Dialog("Have you seen a strange creature around here?\nAbout three feet high, greenish, with fluffy hair?\n");
//Console.Write("How do you answer? 1) Yes, 2) No, 3) Repeat the question, 4) Keep walking");

////new method
//static void Dialog(string message, string color)
//{
//    if (color == "red")
//    { Console.ForegroundColor = ConsoleColor.Red; }
//    else if (color == "green")
//    { Console.ForegroundColor = ConsoleColor.Green; }
//    else if (color == "yellow")
//    { Console.ForegroundColor = ConsoleColor.Yellow; }
//    else
//    { Console.ForegroundColor = ConsoleColor.White; }

//    Console.WriteLine(message);
//    Console.ResetColor();
//}

//Dialog("One argument version");
//Dialog("Two argument version with green", "green");
//Dialog("Two argument version with yellow", "yellow");


// The Dialog method is now overloaded; there is more than one way in which the method can be called.


