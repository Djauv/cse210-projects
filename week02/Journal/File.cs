using System.IO;

public class File
{

    public void LoadFile()
    {
        Console.WriteLine("Please input the name of your file: ");
        Console.Write("> ");

        string filename = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            Console.WriteLine(line);
        }
    }






}





