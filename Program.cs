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
    static string decrypt(string code)
    {
        string code_oflower = code.ToLower();
        string decryp_kod = "";
        string small_abc = "abcdefghijklmnopqrstuvwxyz";

        foreach (char c in code_oflower)
        {
            if (!char.IsLetter(c))
                decryp_kod += c;
            else
                decryp_kod += small_abc[small_abc.Length - 1 - small_abc.IndexOf(c)];
        }
        return decryp_kod;
    }

    public static void Main(string[] args)
    {
        string a = "Hello World Hello World Hello World";
        string[] b = new string[] { "Hello" };
        Console.WriteLine(DangerCheck(a, b));
        Console.WriteLine(decrypt("Lfi ulixvh ziv kivkzirmt uli z nzqli zggzxp lm gsv Arlmrhg vmvnb.\r\nGsv ilxpvg fmrgh ziv ivzwb zmw dzrgrmt uli gsv hrtmzo.\r\nYlnyh szev yvvm kozxvw mvzi pvb olxzgrlmh.\r\nMfpsyz urtsgvih ziv hgzmwrmt yb uli tilfmw rmurogizgrlm.\r\nGsv zggzxp droo yv hfwwvm zmw hgilmt -- gsvb dlm’g hvv rg xlnrmt.\r\nDv nfhg hgzb srwwvm zmw pvvk gsv kozm hvxivg fmgro gsv ozhg nlnvmg.\r\nErxglib rh mvzi. Hgzb ivzwb.\r\n"));

    }
}

