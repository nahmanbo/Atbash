// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

public class HelloWorld
{
    static int DangerCheck(string message, string[] dangerWords)
    {
        int count = 0;
        string[] messageArray = message.Split(" ");
        foreach (string word in messageArray)
            if (dangerWords.Contains(word))
                count++;
        return count;
    }


public static void Main(string[] args)
    {
        string a = "Hello World Hello World Hello World";
        string [] b = new string [] { "Hello" };
        Console.WriteLine(DangerCheck(a,b));
    }
}