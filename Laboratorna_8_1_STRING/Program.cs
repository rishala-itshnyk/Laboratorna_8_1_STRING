using System;

public class Program
{
    public static int Count(string s)
    {
        int count = 0;
        int pos = 0;
        string searchString = "while";

        while ((pos = s.IndexOf(searchString, pos, StringComparison.OrdinalIgnoreCase)) != -1)
        {
            count++;
            pos += searchString.Length;
        }

        return count;
    }

    public static string Change(string s)
    {
        int whileGroupsCount = Count(s);
        string result = "";

        int pos1 = 0, pos2 = 0;
        string searchString = "while";

        while ((pos1 = s.IndexOf(searchString, pos1, StringComparison.OrdinalIgnoreCase)) != -1)
        {
            result += s.Substring(pos2, pos1 - pos2) + "**";
            pos2 = pos1 + searchString.Length;
            pos1 = pos2;
        }

        result += s.Substring(pos2);

        return result;
    }
    
    static void Main()
    {
        Console.WriteLine("Enter string:");
        string str = Console.ReadLine();

        int whileGroupsCount = Count(str);
        Console.WriteLine($"The string contains {whileGroupsCount} occurrences of 'while'");

        string modifiedStr = Change(str);
        Console.WriteLine($"Modified string: {modifiedStr}");
    }
}