using System;
using System.Runtime.CompilerServices;

/*

For this assignment, write a C# program that has several simple functions:

- DisplayWelcome - Displays the message, "Welcome to the Program!"

- PromptUserName - Asks for and returns the user's name (as a string)

- PromptUserNumber - Asks for and returns the user's favorite number (as an integer)

- SquareNumber - Accepts an integer as a parameter and returns that number squared (as an integer)

- DisplayResult - Accepts the user's name and the squared number and displays them.

Your Main function should then call each of these functions saving the return values and passing data to them as necessary.

*/



class Program
{
    static void Main(string[] args)
    {

        DisplayWelcome();
        string name = PromptUserName();
        int number = PromptUserNumber();
        int squarenumber = SquareNumber(number);
        DisplayResult(squarenumber, name);    

    }

    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }

    static string PromptUserName()
    {
        Console.WriteLine("What is your name?");
        string name = Console.ReadLine();
        return name;
    }

    static int PromptUserNumber()
    {
        Console.WriteLine("What is your favorite number?");
        int number = int.Parse(Console.ReadLine());
        return number;
    }

    static int SquareNumber(int number)
    {
        int square = number * number;
        return square;
    }

    static void DisplayResult(int squarenumber, string name)
    {

        Console.WriteLine($"{name}, the square of your number is {squarenumber}");

    }


}