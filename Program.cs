// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

public class AtBash
{
    static (int, string) DangerCheck(string message, string[] dangerWords)
    {
        int count = 0;
        string[] messageArray = message.Split(" ");
        foreach (string word in messageArray)
            if (dangerWords.Contains(word))
                count++;
        return (count, message);
    }

    static void PrintAlert(int dangerLevel, string message)
    {
        string finalMessage = "";
        if (dangerLevel >= 1 && dangerLevel <= 5)
            finalMessage += "WARNING!!!\n\n";
        else if (dangerLevel >= 6 && dangerLevel <= 10)
            finalMessage += "DANGER!!!\n\n";
        else if (dangerLevel >= 11 && dangerLevel <= 15)
            finalMessage += "ULTRA ALERT!!!\n\n";
        else 
            finalMessage += "The hazard level check was not completed properly.!!!\n\n";
        
        finalMessage += message + "\n\n";
        finalMessage += $"danger level is {dangerLevel}";
    }
    public static void Main(string[] args)
    {
        string a = "Hello World Hello World Hello World";
        string [] b = new string [] { "Hello" };
        Console.WriteLine(DangerCheck(a,b));
    }
}