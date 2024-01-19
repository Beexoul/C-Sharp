![C# banner](./Banner.jpeg)

# # C-Sharp
C# (pronounced as "C sharp") is a modern, object-oriented programming language developed by Microsoft as part of its .NET platform. It was first introduced in the early 2000s and has since become a popular and widely used language for developing a wide range of applications, including desktop software, web applications, mobile apps, games, and more.

Key features of C# include:

1. **Object-Oriented Programming (OOP):** C# is primarily an object-oriented language, which means it emphasizes the concept of objects and classes. It supports encapsulation, inheritance, and polymorphism, providing a clean and organized approach to programming.

2. **Type-Safe Language:** C# is a statically-typed language, meaning variables need to be declared with their data types at compile-time. This ensures type safety and helps catch errors during development rather than runtime.

3. **Platform Independence:** C# is designed to run on the .NET platform, which makes it capable of running on multiple platforms, including Windows, macOS, and Linux, through the .NET Core or .NET 5 and later runtimes.

4. **Garbage Collection:** C# includes automatic memory management through a garbage collector, which releases memory used by objects that are no longer referenced, thus helping to prevent memory leaks.

5. **Extensive Standard Library:** C# comes with a large standard library, called the .NET Framework (or .NET Core/.NET 5+), which provides a wealth of pre-built classes and functions for various tasks, making development faster and more efficient.

6. **LINQ (Language-Integrated Query):** LINQ is a powerful feature of C# that allows developers to perform complex queries on collections of data directly within the language syntax.

7. **Asynchronous Programming:** C# supports asynchronous programming using `async` and `await` keywords, which allows developers to write responsive applications by handling time-consuming tasks without blocking the main execution thread.

8. **Cross-Language Compatibility:** C# is designed to be interoperable with other .NET languages, such as Visual Basic .NET (VB.NET), F#, and more, enabling developers to combine different languages within the same project.

C# is widely used in various software development domains, including enterprise applications, game development with Unity, web development with ASP.NET, and building cross-platform applications using .NET Core or .NET 5+. It continues to evolve with regular updates and improvements from Microsoft, making it a robust and versatile language for modern software development.

### # List of Some Programs

1. **Hello Worlds:**
```csharp
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Hello, World!");
    }
}

```

2. **Input And Output:**
```csharp
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Hello, World!");
    }
}

```

3. **Arithmetic Operations:**

```csharp
using System;

class Program
{
    static void Main()
    {
        int a = 5;
        int b = 3;
        int sum = a + b;
        int difference = a - b;
        int product = a * b;
        int quotient = a / b;
        int remainder = a % b;

        Console.WriteLine("Sum: " + sum);
        Console.WriteLine("Difference: " + difference);
        Console.WriteLine("Product: " + product);
        Console.WriteLine("Quotient: " + quotient);
        Console.WriteLine("Remainder: " + remainder);
    }
}
```

4. **Looping:**

```csharp
using System;

class Program
{
    static void Main()
    {
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine(i);
        }
    }
}

```

5. **Function**
```csharp 
using System;

class Program
{
    static void Main()
    {
        int result = Add(3, 5);
        Console.WriteLine("The sum is: " + result);
    }

    static int Add(int a, int b)
    {
        return a + b;
    }
}
```

6. **Conditional Statements**
```csharp
using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter your age: ");
        int age = int.Parse(Console.ReadLine());

        if (age >= 18)
        {
            Console.WriteLine("You are an adult.");
        }
        else
        {
            Console.WriteLine("You are a minor.");
        }
    }
}

```

7. **Array**
```csharp 
using System;

class Program
{
    static void Main()
    {
        int[] numbers = { 1, 2, 3, 4, 5 };
        foreach (int num in numbers)
        {
            Console.WriteLine(num);
        }
    }
}
```
8. **Add Two Number**
```csharp
using System;

class AddNumbers
{
    static void Main()
    {
        Console.Write("Enter first number: ");
        int num1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter second number: ");
        int num2 = Convert.ToInt32(Console.ReadLine());

        int sum = num1 + num2;

        Console.WriteLine($"Sum: {sum}");
    }
}
```

9. **Factorial**
```csharp
using System;

class FactorialCalc
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int n = Convert.ToInt32(Console.ReadLine());

        long factorial = 1;

        for (int i = 1; i <= n; i++)
        {
            factorial *= i;
        }

        Console.WriteLine($"Factorial of {n}: {factorial}");
    }
}
```

10. **Simple Calculator**

```csharp
using System;

class SimpleCalculator
{
    static void Main()
    {
        Console.Write("Enter first number: ");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter operator (+, -, *, /): ");
        char op = Convert.ToChar(Console.ReadLine());

        Console.Write("Enter second number: ");
        double num2 = Convert.ToDouble(Console.ReadLine());

        double result = 0;

        switch (op)
        {
            case '+':
                result = num1 + num2;
                break;
            case '-':
                result = num1 - num2;
                break;
            case '*':
                result = num1 * num2;
                break;
            case '/':
                result = num1 / num2;
                break;
            default:
                Console.WriteLine("Invalid operator");
                return;
        }

        Console.WriteLine($"Result: {result}");
    }
}
```

11. **Prime Number Checker**
```csharp
using System;

class PrimeNumberCheck
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int num = Convert.ToInt32(Console.ReadLine());

        bool isPrime = true;

        for (int i = 2; i <= Math.Sqrt(num); i++)
        {
            if (num % i == 0)
            {
                isPrime = false;
                break;
            }
        }

        if (isPrime)
            Console.WriteLine($"{num} is a prime number.");
        else
            Console.WriteLine($"{num} is not a prime number.");
    }
}

```
12. **Fibonacci Series**

```csharp
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
```

13. **Reverse a String**

```csharp
using System;

class ReverseString
{
    static void Main()
    {
        Console.Write("Enter a string: ");
        string input = Console.ReadLine();

        char[] charArray = input.ToCharArray();
        Array.Reverse(charArray);

        string reversedString = new string(charArray);

        Console.WriteLine($"Reversed string: {reversedString}");
    }
}
```
14. **Date and Time**
```csharp
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
```

15. **Palindrome Check**

```csharp
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
```

#### Note New Simple programs are coming in the future.
