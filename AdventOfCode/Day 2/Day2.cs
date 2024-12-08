using System.Text.RegularExpressions;

namespace AdventOfCode.Day_2;
    
public class Day2
{
    public static void Execute()
    {
        var safeReports = 0;
        
        try
        {
            // Read File
            foreach (var line in File.ReadLines("Day 2/input.txt"))
            {
                // Convert row into List of ints
                var numbers = new List<int>(Array.ConvertAll(line.Split(), int.Parse));
                
                // Check if numbers are in increasing/decreasing order
                var isIncreasing = numbers.Zip(numbers.Skip(1), (a, b) => a < b).All(x=> x);
                var isDecreasing = numbers.Zip(numbers.Skip(1), (a, b) => a > b).All(x => x);
                
                // If it is not increasing nor decreasing, continue
                if (!isIncreasing && !isDecreasing) continue;
                
                // Maximum diff between numbers 1-3
                var isDifferenceCorrect = numbers.Zip(numbers.Skip(1), (a, b) => Math.Abs(a - b)).All(n => n >= 1 && n <= 3);

                if (isDifferenceCorrect) safeReports++;
            }
        }
        catch (IOException e)
        {
            Console.WriteLine(e.Message);
        }

        // Output result
        Console.WriteLine(safeReports);
        
    }
}