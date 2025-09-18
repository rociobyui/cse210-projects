using System;
using System.Runtime.InteropServices.Marshalling;

class Program
{
    static void Main(string[] args)
    {
        // Using Console.Write() to prompt the user first name Python = print
        Console.Write("What is your first name? ");
        // Reading the user's first name
        string first = Console.ReadLine();

        //Using Console.Write() to prompt the user for last name in the same line
        Console.Write("What is your last name? ");
        // Reading and storing the user's last name in the string variable
        string last = Console.ReadLine();

        // Leaving a blank line
        Console.WriteLine();

        // Displaying or printing the user's full name, first only last and then full name.
        Console.WriteLine($"Your name is {last}, {first} {last}.");
    }
}