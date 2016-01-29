using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            // Отрисовка рамочки
            HorizontalLine upLine = new HorizontalLine(0, 78, 0, '+');
            upLine.Drow();
            HorizontalLine downLine = new HorizontalLine(0, 78, 24, '+');
            downLine.Drow();
            VerticalLine leftLine = new VerticalLine(0, 0, 24, '+');
            leftLine.Drow();
            VerticalLine rightLine = new VerticalLine(78, 0, 24, '+');
            rightLine.Drow();

            //отрисовка точек
            Point p1 = new Point(5, 5, '*');
            p1.Draw();

            Console.ReadLine();
        }
   }
}
