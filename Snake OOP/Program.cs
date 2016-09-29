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

            List<int> numList = new List<int>();
                numList.Add(4);
                numList.Add(6);
                numList.Add(3);
                numList.Add(8);

                int x = numList[0];
                int y = numList[1];
                int z = numList[2];
                int t = numList[3];

                Console.WriteLine(" ");

                foreach ( int i in numList)
                {
                    Console.WriteLine(i);
                }

            List<char> chList = new List<char>();
                chList.Add('%');
                char r = chList[0];

                Console.WriteLine(" ");
                
                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine(r);
                }



            Console.ReadLine();
        }
    }
}
