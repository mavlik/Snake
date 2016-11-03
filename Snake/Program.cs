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
            Point p1 = new Point(1, 3, '*');
            p1.Draw();

            Point p2 = new Point(4, 5, '#');
            p2.Draw();

            Console.ReadLine();

            int x = 1;
            Func1(x);
            Console.WriteLine("Call Func1. x = " + x);

            int X = 1;
            Func2(x);
            Console.WriteLine("Call Func2. X = " + X);

            Point p3 = new Point(6, 3, '&');
            p3 = p1;
            //p1.x = 8;
            //p1.y = 8;
            p3.Draw();
            Move(p3, 10, 10);
            Console.WriteLine("Call Move. p3.x = " + p3.x + " " + "p3.y = " + p3.y);
            Console.ReadLine();

        }
        static void Func1(int value)
        {
            Console.ReadLine();
        }
        static void Func2(int value)
        {
            Console.ReadLine();
        }
        static void Move(Point p3, int dx, int dy)
        {
            p3.x = p3.x + dx;
            p3.y = p3.y + dy;
            Console.ReadLine();
        }
       
    }
    
    

}
