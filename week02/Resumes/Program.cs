using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Software Enginneer";
        job1._company = "Microsoft";
        job1._starYear = 2015;
        job1._endYear = 2024;

        Job job2 = new Job();
        job2._jobTitle= "Manager";
        job2._company ="Apple";
        job2._starYear = 2011;
        job2._endYear = 2023;

        job1.Display();
        job2.Display();
    }
}