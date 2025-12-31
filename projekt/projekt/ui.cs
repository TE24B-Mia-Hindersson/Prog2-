using System;
public class UI
{
    public static void Line ()
    {
        Console.ForegroundColor = ConsoleColor.Gray;
        Console.WriteLine(new string ('═', 50));
        Console.ResetColor();
    }
    public static void Title(string text)
    {
       Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine(text.ToUpper());
        Console.ResetColor(); 
    }
    public static void Success(string text)
    {
       Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine(text);
        Console.ResetColor(); 
    }
    public static void Warning(string text)
    {
       Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(text);
        Console.ResetColor(); 
    }
    public static void Stat(string name, int value)
    {
        if (value >= 60) Console.ForegroundColor = ConsoleColor.Green;
        else if (value >= 30) Console.ForegroundColor = ConsoleColor.Yellow;
        else Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(name + ":" + value);
        Console.ResetColor();
    }
}