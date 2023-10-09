using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jalgpall
{

    public class Stadium
    {
        List<Figure> wallList;

        public Stadium(int width, int height)
        {
            wallList = new List<Figure>();

            Width = width;
            Height = height;

            HorizontalLine upLine = new HorizontalLine(0, width - 2, 0, '#');
            HorizontalLine downLine = new HorizontalLine(0, width - 2, height - 1, '#');
            VerticalLine leftLine = new VerticalLine(0, height - 1, 0, '#');
            VerticalLine rightLine = new VerticalLine(0, height - 1, width - 2, '#');

            wallList.Add(upLine);
            wallList.Add(downLine);
            wallList.Add(leftLine);
            wallList.Add(rightLine);
        }
        public void Draw()
        {
            foreach (var wall in wallList)
            {
                wall.Draw();
            }
        }

        public int Width { get; }

        public int Height { get; }

        public bool IsIn(double x, double y)
        {
            return x >= 0 && x < Width && y >= 0 && y < Height;
        }
    }
}
