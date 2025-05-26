
public class Word()
{
    List<string> myScripture = new List<string>
    {
        "And", "behold,", "I", "tell", "you", "these", "things", "that",
        "ye", "may", "learn", "wisdom;", "that", "ye", "may", "learn", "that",
        "when", "ye", "are", "in", "the", "service", "of", "your", "fellow",
        "beings", "ye", "are", "only", "in", "the", "service", "of", "your", "God."
    };


    private void RemoveWord()
    {
        string randomWord = "_";
        string emptyWord = "";
        int randomNumber = 0;

        while (randomWord.Contains("_") == true)
        {
            Random random = new Random();
            randomNumber = random.Next(0, myScripture.Count);
            randomWord = myScripture[randomNumber];
        }

        int wordLength = randomWord.Length;


        while (wordLength > 0)
        {
            emptyWord = emptyWord + "_";
            wordLength = wordLength - 1;
        }

        myScripture[randomNumber] = emptyWord;

    }

    private void Continue()
    {
        RemoveWord();
        RemoveWord();
        RemoveWord();
    }

    public void DisplayScripture()
    {


        foreach (string word in myScripture)
        {
            Console.Write($"{word} ");
        }
        Continue();

    }
}
