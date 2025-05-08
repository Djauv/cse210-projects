using System;
using System.Diagnostics.CodeAnalysis;

/*
Enter a list of numbers, type 0 when finished.
  Enter number: 18
  Enter number: 36
  Enter number: 2
  Enter number: 48
  Enter number: 6
  Enter number: 12
  Enter number: 9
  Enter number: 0
  The sum is: 131
  The average is: 18.714285714285715
  The largest number is: 48
*/

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        float userNumber = -1;
        
        float sum = 0;

        int length = 0;

        float largest = 0;

        List<float> numbers = new List<float>();

        while (userNumber != 0)
        {
            Console.Write("Enter number:");
            userNumber = float.Parse(Console.ReadLine());
            if (userNumber != 0)
            {
                numbers.Add(userNumber);
                sum += userNumber;
                length += 1;

                if (largest < userNumber)
                {
                    largest = userNumber;
                }

            }
        }
        float average = sum / length;
        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {largest}");


    }
}