using System;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your first name? ");
        string first = Console.ReadLine();

        Console.Write("What is your last name? ");
        string last = Console.ReadLine();

        // My code. 
        //Console.WriteLine(Environment.NewLine + "Your name is " + last + "," + " " + first + " " + last + ".");
        
        //Using "$" to format the display. It is the right one.
        Console.WriteLine();
        Console.WriteLine($"Your name is {last}, {first} {last}.");
    
        
    }
}