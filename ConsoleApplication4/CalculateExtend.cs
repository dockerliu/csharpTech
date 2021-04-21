using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    static class CalculateExtend //扩展方法所在的类 必须是静态
    {
        public static void Avg(this Calculate c,int a)//扩展方法必须是公开的静态方法 然后想要扩展那个类 就传入那个类的对象 并且带上this
        {
            Console.WriteLine((c.num1 + c.num2) / 2);
        }

        [DllImport("kernel32",SetLastError = true)]
        public static extern int GetCurrentDirectory(int a, StringBuilder b);
    }
}
