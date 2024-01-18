//String Manipulation
using System;

class StringManipulation
{
    static void Main()
    {
        string originalString = "C# Programming";

        // Convert to uppercase
        string upperCase = originalString.ToUpper();
        Console.WriteLine($"Uppercase: {upperCase}");

        // Convert to lowercase
        string lowerCase = originalString.ToLower();
        Console.WriteLine($"Lowercase: {lowerCase}");

        // Substring
        string substring = originalString.Substring(3, 6);
        Console.WriteLine($"Substring: {substring}");

        // Length
        int length = originalString.Length;
        Console.WriteLine($"Length: {length}");
    }
}

