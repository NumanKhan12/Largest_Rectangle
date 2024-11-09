using LargestRectangle.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LargestRectangle.BusinessCore
{
    public static class RectangleCore
    {
        public static List<RectangleModel> GenerateRandomRectangles(int count)
        {
            var random = new Random();
            var rectangles = new List<RectangleModel>();

            for (int i = 0; i < count; i++)
            {
                int width = random.Next(1, 1000); 
                int height = random.Next(1, 1000); 
                rectangles.Add(new RectangleModel(width, height));
            }

            return rectangles;
        }
        public static RectangleModel FindLargestRectangle(List<RectangleModel> rectangles)
        {
            return rectangles
                .OrderByDescending(r => r.Area)
                .ThenByDescending(r => r.Height)
                .First();
        }
    }
}
