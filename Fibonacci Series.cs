//Fibonacci Series
using System;

class FibonacciSeries
{
    static void Main()
    {
        Console.Write("Enter the number of terms: ");
        int n = Convert.ToInt32(Console.ReadLine());

        int firstTerm = 0, secondTerm = 1;

        Console.WriteLine("Fibonacci Series:");

        for (int i = 0; i < n; i++)
        {
            Console.Write($"{firstTerm} ");

            int temp = firstTerm;
            firstTerm = secondTerm;
            secondTerm = temp + secondTerm;
        }
    }
}