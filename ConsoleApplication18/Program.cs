using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication18
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] s = new string[3] {"microsoft","baidu","google" };
            foreach (var item in s)
            {
                Console.WriteLine(item);
            }

            //定义我们自己的
            var ab = new ApplceBox();
            foreach (Apple item in ab)
            {
                Console.WriteLine(item.Number);
            }

            Console.Read();
        }
    }

    class ApplceBox:IEnumerable
    {
        public Apple[] apples;
        public ApplceBox()
        {
            apples = new Apple[50];
            for (int i = 0; i < 50; i++)
            {
                apples[i] = new Apple() { Number = i };
            }
        }

        public IEnumerator GetEnumerator()
        {
            foreach (var item in apples)
            {
                yield return item;
            }
        }
    }

    public class Apple
    {
        public int Number;
    }
}
