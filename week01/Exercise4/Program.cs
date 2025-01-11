using System;
using System.Diagnostics.CodeAnalysis;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished");

        List<int> numbers = new List<int>();

        Console.Write("Enter a number: ");
        string userNumber = Console.ReadLine();
        int num = int.Parse(userNumber);

        while (num != 0)
        {
            numbers.Add(num);
            Console.Write("Enter a number: ");
            num = int.Parse(Console.ReadLine());

        }

        int sum = numbers.Sum();
        Console.WriteLine($"The sum is: {sum}");
        double average = numbers.Average();
        Console.WriteLine($"This is the average: {average}");
        int max = numbers.Max();
        Console.WriteLine($"The largest number is {max}");

    }
}