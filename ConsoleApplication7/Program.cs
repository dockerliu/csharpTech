using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication7
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p0, p1, p2;
            p0.x = 0;
            p0.y = 0;
            p1.x = 1;
            p1.y = 1;
            p2.x = 2;
            p2.x = 2;

            A(p0);

            Point a = new Point(1,2);
            Point a2 = new Point() { x = 1,y=2 };
            Point a3 = new Point();//无参的还是会存在的

            Point b;
            b.x = 12;
            Console.WriteLine(b.x);

            Console.WriteLine(p1.x);

            Pointx p = new Pointx() {x=0,y=0 };

            Point t = p0;
            Pointx t2 = p;

            t.x = 2;//改变t是不会改变p0 的 因为结构的复制是直接值的复制
            Console.WriteLine(p0.x);

            t2.x = 12;
            Console.WriteLine(p.x);

            Console.ReadKey();
        }

        static void A(Point p)
        {
            Console.WriteLine(p.x);
        }
    }

    struct Point
    {
        public int x;
        public int y;

        public Point(int x,int y)
        {
            this.x = x; //带参构造函数必须对字段进行复制
            this.y = y;
        }
    }

    struct Point1
    {

    }

    class Pointx
    {
        public int x = 12;
        public int y;
    }

    class Poontx1 : Pointx
    {

    }
}
