using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparision
{
    class LineCompare
    {

        int x1, x2, y1, y2;
        int p1, p2, q1, q2;
        public int getElement(int x1,int x2,int y1,int y2,int p1,int p2,int q1,int q2)
        {
            this.x1 = x1;
            this.x2 = x2;
            this.y1 = y1;
            this.y2 = y2;
            this.p1 = p1;
            this.p2 = p2;
            this.q1 = q1;
            this.q2 = q2;
            return 0;
        }
        public int checkLine()
        {

            double line1 = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) * 1.0);
            Console.WriteLine("the length of line is:{0}", line1);


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

            return 0;
        }

    }
}
