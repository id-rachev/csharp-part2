﻿using System;

class HelloPrintMethod
{
    // Write a method that asks the user for his name and prints
    // “Hello, <name>” (for example, “Hello, Peter!”).
    // Write a program to test this method.

    static void PrintGreeting()
    {
        Console.WriteLine("Hi, what's your name?");
        string userName = Console.ReadLine();
        Console.WriteLine("Hello, {0}!", userName);
    }

    static void Main()
    {
        PrintGreeting();
    }
}
