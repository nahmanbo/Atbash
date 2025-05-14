// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

public class AtBash
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
        Console.WriteLine(finalMessage);
    }
    static string Decrypt(string code)
    {
        string decryp_kod = "";
        string small_abc = "abcdefghijklmnopqrstuvwxyz";
        string capital_abc = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        foreach (char c in code)
        {
            if (!char.IsLetter(c))
                decryp_kod += c;
            else if(char.IsUpper(c))
                decryp_kod += capital_abc[capital_abc.Length - 1 - capital_abc.IndexOf(c)];
            else
                decryp_kod += small_abc[small_abc.Length - 1 - small_abc.IndexOf(c)];
        }
        return decryp_kod;
    }

    public static void Main(string[] args)
    {
        string message = "Lfi ulixvh ziv kivkzirmt uli z nzqli zggzxp lm gsv Arlmrhg vmvnb. nGsv ilxpvg fmrgh ziv ivzwb zmw dzrgrmt uli gsv hrtmzo. nYlnyh szev yvvm kozxvw mvzi pvb olxzgrlmh. nMfpsyz urtsgvih ziv hgzmwrmt yb uli tilfmw rmurogizgrlm. nGsv zggzxp droo yv hfwwvm zmw hgilmt -- gsvb dlm’g hvv rg xlnrmt. nDv nfhg hgzb srwwvm zmw pvvk gsv kozm hvxivg fmgro gsv ozhg nlnvmg. nErxglib rh mvzi. Hgzb ivzwb.";
        string[] dangerWords = new string[] {"bomb",  "nukhba", "fighter", "rocket", "secret"};
        string message_decrypt = Decrypt(message);
        PrintAlert(DangerCheck(message_decrypt,dangerWords),message_decrypt);
    }
}

