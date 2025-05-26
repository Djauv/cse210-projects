using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the ScriptureMemorizer Project.");
        Scripture scripture = new Scripture();

        string finished = "";

        while (finished != "QUIT")
        {
            Console.Clear();
            scripture.DisplayBoth();
            Console.WriteLine("Press enter to continue or QUIT to quit.");
            finished = Console.ReadLine();
        }
    }
        
}