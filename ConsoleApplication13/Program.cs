using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication13
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student();
            //s.CompareTo(s);//通过自己的对象不能使用了
            IMyComparable i1 = s;
            i1.CompareTo(i1);
            IMyComparable1 i2 = s;
            i2.CompareTo(i2);

            Console.ReadKey();
        }
    }
}
