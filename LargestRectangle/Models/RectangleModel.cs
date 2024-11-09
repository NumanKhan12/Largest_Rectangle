using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LargestRectangle.Models
{
    public class RectangleModel
    {
        public int Width { get; }
        public int Height { get; }

        public RectangleModel(int width, int height)
        {
            Width = width;
            Height = height;
        }

        public int Area => Width * Height;

        public override string ToString()
        {
            return $"Rectangle [Width: {Width}, Height: {Height}, Area: {Area}]";
        }
    }
}
