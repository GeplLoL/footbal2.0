using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jalgpall
{
    class VerticalLine : Figure
    {

        public VerticalLine(int yUp, int yDown, int x, char sym)
        {
            plist = new List<Point>();
            for (int y = yUp; y <= yDown; y++)
            {
                Point p = new Point(x, y, sym);
                plist.Add(p);
            }
        }
    }
}
