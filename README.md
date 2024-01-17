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
