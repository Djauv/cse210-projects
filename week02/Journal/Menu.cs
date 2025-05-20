
using System.IO;

public class Menu
{

    public string _userchoice;

    public void MenuPrincipal()
    {

        Prompts writedisplay = new Prompts();
        File loadsave = new File();
        List<string> entries = new List<string>();

        while (_userchoice != "5")
        {

            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("> ");
            _userchoice = Console.ReadLine();

            if (_userchoice == "1")
            {
                entries.Add(writedisplay.WritePrompt());
            }
            else if (_userchoice == "2")
            {
                foreach (string entry in entries)
                {
                    Console.WriteLine(entry);
                }
            }
            else if (_userchoice == "3")
            {
                loadsave.LoadFile();
            }
            else if (_userchoice == "4")
            {
                Console.WriteLine("Please input the name of your file: ");
                Console.Write("> ");

                string filename = Console.ReadLine();
                using (StreamWriter outputFile = new StreamWriter(filename))
                {
                    foreach (string entry in entries)
                    {
                        outputFile.WriteLine(entry);
                    }


                }
            }
            else if (_userchoice == "5")
            {
                Console.WriteLine("Quiting Program...");
            }
            else
            {
                Console.WriteLine(":(");
            }
        }


    }


}




