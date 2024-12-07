// See https://aka.ms/new-console-template for more information

using System.Text.RegularExpressions;

// Init 2 Lists
List<int> col1 = new List<int>();
List<int> col2 = new List<int>();

try
{
    // Read File, Split Into 2 Columns
    foreach (var line in File.ReadLines("input.txt"))
    {
        // Split on Empty Space
        var parts = Regex.Split(line.Trim(), @"\s+");
        col1.Add(int.Parse(parts[0]));
        col2.Add(int.Parse(parts[1]));
    }
}
catch (IOException e)
{
    Console.WriteLine(e.Message);
}

// Create Sorted Tuple
var zipped = col1.OrderBy(x => x).Zip(col2.OrderBy(x => x), (x, y) => new { x, y });

var distance = 0;

// Sum differences 
foreach (var tuple in zipped)
{
    distance += Math.Abs(tuple.x - tuple.y);
}

// Output result
Console.WriteLine(distance);