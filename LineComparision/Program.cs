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
            

            double line1 = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) * 1.0);
            Console.WriteLine("the length of line is:{0}", line1);
           


            Console.WriteLine("enter the 2nd line  x coordinate");
            p1 = Convert.ToInt32(Console.ReadLine());
            p2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the 2nd line y coordinates");
            q1 = Convert.ToInt32(Console.ReadLine());
            q2 = Convert.ToInt32(Console.ReadLine());

            double line2 = Math.Sqrt(Math.Pow(p2 - p1, 2) + Math.Pow(q2 - q1, 2) * 1.0);
            Console.WriteLine("the length of line is:{0}", line2);
            
            if (line1 == line2)
            {
                Console.WriteLine("bothline are equal");
            }
            else if (line1 > line2)
            {
                Console.WriteLine("line1 is greater");
            }
            else
            {
                Console.WriteLine("line2 is greater");
            }

            Console.ReadLine();

        }
    }
}
