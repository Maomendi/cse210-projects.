using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayMessage();
        string name = PromptUserName();
        int favoriteNumber = PromptUserNumber();
        int squared = SquareNumber(favoriteNumber);
        Console.WriteLine($"the square of your favorite number is: {squared}");
    }

        static void DisplayMessage()
        {
            Console.WriteLine("Welcome to the program");
            
        }

       static string PromptUserName()
        {
            Console.Write("What is your name? ");
            string name = Console.ReadLine();
            return name;
        }

        static int PromptUserNumber()
        {
            Console.Write("What is your favorite number? ");
            string number = Console.ReadLine();
            int num = int.Parse(number);
            return num;
        }

        static int SquareNumber(int num)
        {
            int squared = num * num;
            Console.WriteLine($"{squared}");
            return squared;
        }
    }
