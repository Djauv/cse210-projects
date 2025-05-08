using System;


/*
Ask the user for their grade percentage, then write a series of if, else if, else statements 
to print out the appropriate letter grade. (At this point, you'll have a separate print statement for 
each grade letter in the appropriate block.)

Assume that you must have at least a 70 to pass the class. After determining the letter grade 
and printing it out. Add a separate if statement to determine if the user passed the course, 
and if so display a message to congratulate them. If not, display a different message to encourage 
them for next time.

Change your code from the first part, so that instead of printing the letter grade in the body of 
each if, else if, or else block, instead create a new variable called letter and then in each block, 
set this variable to the appropriate value. Finally, after the whole series of if, else if, else statements, 
have a single print statement that prints the letter grade once.
*/

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your grade percent?");
        string grade = Console.ReadLine();
        float number = float.Parse(grade);

        if (number >= 90)
        {
            string letter = "A";
            Console.WriteLine($"Letter Grade: {letter}!");
        }
        else if (number >= 80 && number < 90)
        {
            string letter = "B";
            Console.WriteLine($"Letter Grade: {letter}!");
        }
        else if (number >= 70 && number < 80)
        {
            string letter = "C";
            Console.WriteLine($"Letter Grade: {letter}!");
        }
        else if (number >= 60 && number < 70)
        {
            string letter = "D";
            Console.WriteLine($"Letter Grade: {letter}!");
        }
        else if (number < 60)
        {
            string letter = "F";
            Console.WriteLine($"Letter Grade: {letter}!");
        }
        
        if (number >= 70)
        {
            Console.WriteLine("Congrats, you've passed your class!");
        }
        else if (number < 70)
        {
            Console.WriteLine("Oh no! anything less than a C is failing! You'll get it next time!");
        }
    }
}