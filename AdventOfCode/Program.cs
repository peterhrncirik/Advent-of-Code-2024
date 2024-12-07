using AdventOfCode.Day_1;
using AdventOfCode.Day_2;

namespace AdventOfCode;
using System;

class Program
{
    static void Main(string[] args)
    {
        // Check if command-line argument for the day is provided
        if (args.Length == 0)
        {
            Console.WriteLine("dotnet run day#");
            return;
        }

        string day = args[0];

        // Switch case to handle different days
        switch (day.ToLower())
        {
            case "day1":
                Day1.Execute();
                break;
            case "day2":
                Day2.Execute();
                break;
            default:
                Console.WriteLine($"Invalid day: {day}. Not found.");
                break;
        }
    }
}
