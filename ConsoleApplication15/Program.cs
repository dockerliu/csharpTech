using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication15
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 12;
            object o = i;
            //int a = o as int;//因为as 最后可能产生null 但是int 是不允许null
            int? a = o as int?;
            if (a!=null)
            {
                Console.WriteLine(a);
            }
            Console.ReadKey();
        }
    }
}
