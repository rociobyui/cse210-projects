using System;

class Program
{
    static void Main(string[] args)
    {
        //This is prep 2
        Console.WriteLine();
        Console.WriteLine("Prep2 Done!");
        Console.WriteLine();

        // Promt the user's percentage grade by using Console,Write() function.
        Console.Write("What is your grade percentage? ");


        // Reading user's input with Console.Read() function, 
        // storing it in a string variable, and converting from a string to a float
        string gradePercentageInText = Console.ReadLine();
        float gradePercentage = float.Parse(gradePercentageInText);

        // Block of code determining the letter grade using if statements

        // Creating a variable for letter grade
        string letter = "";
        if (gradePercentage >= 90)
        {
            letter = "A";
        }
        else if (gradePercentage >= 80)
        {
            letter = "B";

        }
        else if (gradePercentage >= 70)
        {
            letter = "C";

        }
        else if (gradePercentage >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }
        // Displaying grade letter to the user
        Console.WriteLine($"Your grade letter is: {letter}");
        if (gradePercentage < 70)
        {
            Console.WriteLine("Best luck next time!");  
        }
        

    }   
}