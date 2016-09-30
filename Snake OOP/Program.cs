using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake_OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(1, 3, '*');
            p1.Draw();

            Point p2 = new Point(4, 6, '$');          
            p2.Draw();

            HorizontalLine line = new HorizontalLine(5, 50, 10, '@');
            line.Drow();


            Console.ReadLine();
        }
    }
}
