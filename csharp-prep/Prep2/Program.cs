using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string userInput = Console.ReadLine();
        float percentage = float.Parse(userInput);
        string letter = "";
        
        if (percentage >= 90)
        {
            letter = "A";
            //Console.WriteLine("Your letter grade is A");
            //Console.WriteLine("Congratulation, you passed the class!");
        }
        else if (percentage >= 80)
        {
            letter = "B";
            //Console.WriteLine("Your letter grade is B");
            //Console.WriteLine("Congratulation, you passed the class!");
        }
        else if (percentage >= 70)
        {
            letter = "C";
            //Console.WriteLine("Your letter grade is C");
            //Console.WriteLine("Congratulation, you passed the class!");   
        }
        else if (percentage >= 60)
        {
            letter = "D";
            //Console.WriteLine("Your letter grade is D");
            //Console.WriteLine("Next time try harder. You did not pass the class!");
        }
        else
        {
            letter = "F";
            //Console.WriteLine("Your letter grade is F");
            //Console.WriteLine("Next time try harder. You did not pass the class!");
        }
        
        Console.WriteLine($"Your letter grade is: {letter}");

        if(percentage >= 70)
        {
            Console.WriteLine("Congratulations, you passed the class!");
        }
        else if(percentage < 70)
        {
            Console.WriteLine("Next time try harder. You did not pass the class!");
        }

    }
}