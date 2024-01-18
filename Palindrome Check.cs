//Palindrome Check
using System;

class PalindromeCheck
{
    static void Main()
    {
        Console.Write("Enter a word: ");
        string input = Console.ReadLine();

        string reversed = new string(input.Reverse().ToArray());

        if (input.Equals(reversed, StringComparison.OrdinalIgnoreCase))
            Console.WriteLine($"{input} is a palindrome.");
        else
            Console.WriteLine($"{input} is not a palindrome.");
    }
}
