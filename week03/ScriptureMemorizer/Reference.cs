
public class Reference()
{
    private string _book = "Mosiah";
    private string _chapter = "2";
    private string _verse = "17";

    public void DisplayReference()
    {
        Console.WriteLine($"{_book} {_chapter}:{_verse}");
    }
}


