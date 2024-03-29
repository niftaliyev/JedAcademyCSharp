namespace Events;

public class Functions
{
    public void PrintRed(string text)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(text);
        Console.ForegroundColor = ConsoleColor.Gray;
    }
    public void PrintUpper(string text)
    {
        Console.WriteLine(text.ToUpper());
    }
    public void SayHello(string text)
    {
        Console.WriteLine("HELLO!!");
    }
}
