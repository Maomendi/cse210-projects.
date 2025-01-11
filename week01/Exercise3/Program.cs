using System;

class Program
{
    static void Main(string[] args)
    {
       Random randomGenerator = new Random();
       int number = randomGenerator.Next(1, 11);
       Console.WriteLine(number);

       Console.Write("What number did you guess? ");
       string userNumber = Console.ReadLine();
       int num = int.Parse(userNumber);

       while (num != number)
       {
           
           if (number > num) 
           {
                Console.WriteLine("Higher");
           }
           else
           {
                Console.WriteLine("Lower");
           }
        Console.Write("Guess again: ");
        num = int.Parse(Console.ReadLine());
       }
    }
}