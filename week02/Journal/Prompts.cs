
public class Prompts()
{
    Random random = new Random();
    List<string> prompts = new List<string> {"How have you seen the hand of the Lord in your day today?", "What did you do better today than you did yesterday?", "What was the most interesting part of your day?", "What was something new that you learned today?", "What did you accomplish today?"};

    public string WritePrompt()
    {
        List<string> entries = new List<string>();
        int randomNumber = random.Next(0, 5);
        Console.WriteLine(prompts[randomNumber]);
        string entry = Console.ReadLine();
        DateTime theCurrentTime = DateTime.Now;
        string dateText = theCurrentTime.ToShortDateString();
        string completeEntry = "Date: " + dateText + Environment.NewLine + "Prompt: " + prompts[randomNumber] + Environment.NewLine + "Entry: " + entry + Environment.NewLine;

        return completeEntry;

    }

}




