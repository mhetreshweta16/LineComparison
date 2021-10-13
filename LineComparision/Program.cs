using System;

namespace LineComparision
{
    class Program
    {
        static void Main(string[] args)
        {
            int x1, x2, y1, y2;
            int p1,p2,q1,q2;
            

            Console.WriteLine("Welcome to Line Comparison Computation!");
         
            Console.WriteLine("enter the 1st line  x coordinate");
            x1 = Convert.ToInt32(Console.ReadLine());
            x2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the 1st line y coordinates");
            y1 = Convert.ToInt32(Console.ReadLine());
            y2 = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("enter the 2nd line  x coordinate");
            p1 = Convert.ToInt32(Console.ReadLine());
            p2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the 2nd line y coordinates");
            q1 = Convert.ToInt32(Console.ReadLine());
            q2 = Convert.ToInt32(Console.ReadLine());

            LineCompare line = new LineCompare();
            line.getElement(x1, x2, y1, y2, p1, p2, q1, q2);
            line.checkLine();

            Console.ReadLine();

        }
    }
}
