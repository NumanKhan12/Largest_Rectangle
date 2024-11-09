using LargestRectangle.BusinessCore;
using LargestRectangle.Models;
using System.Drawing;

Console.WriteLine("Find the Largest Rectangle");
List<RectangleModel> rectangles = RectangleCore.GenerateRandomRectangles(20);

Console.WriteLine("Generated Rectangles:");
foreach (var rect in rectangles)
{
    Console.WriteLine(rect);
}

var largestRectangle = RectangleCore.FindLargestRectangle(rectangles);

Console.WriteLine("\nLargest Rectangle:");
Console.WriteLine(largestRectangle);