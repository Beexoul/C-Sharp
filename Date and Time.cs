//Date and Time
using System;

class DateTimeExample
{
    static void Main()
    {
        DateTime currentDateTime = DateTime.Now;

        Console.WriteLine($"Current Date and Time: {currentDateTime}");
        Console.WriteLine($"Day of Week: {currentDateTime.DayOfWeek}");
    }
}
