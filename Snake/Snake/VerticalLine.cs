using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class VerticalLine
    {
        List<Point> yList;

        public VerticalLine(int x, int yUp, int yDown, char sym)
        {
            yList = new List<Point>();
            for(int y = yUp; y <= yDown; y++)
            {
                Point p = new Point(x, y, sym);
                yList.Add(p);
            }
        }

        public void Drow()
        {
            foreach(Point p in yList)
            {
                p.Draw();
            }
        }
    }
}
