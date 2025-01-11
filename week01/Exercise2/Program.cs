using System;

class Program
{
    static void Main(string[] args)
    {
       Console.WriteLine("What is your grade? ");
       string grade = Console.ReadLine();
       int number = int.Parse(grade);

       string letter = "";

       if (number == 90 || number > 90) 
       {
            letter = "A";
       }

       else if (number == 80 || number > 80) 
       {
            letter = "B";
       }

       else if (number == 70 || number > 70) 
       {
            letter = "C";
       }

       else if (number == 60 || number > 60) 
       {
            letter = "D";
       }

       else
       {
            letter = "F";
       }

       Console.WriteLine($"Your grade is {letter}");

       if (number == 70 || number > 70)
       {
            Console.WriteLine("You pass");
       }

       else
       {
            Console.WriteLine("You didn't pass, try harder next time");
       }

    }
}