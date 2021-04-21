using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication10
{
    delegate int ShowInfoDelegate(out int x);

    class Program
    {
        static void Main(string[] args)
        {
            ShowInfoDelegate siDelegate1 = delegate(out int x) 
            {
                 x = 1;
                 return 100;
            };

            siDelegate1 +=  (out int x) =>
            {
                x = 1;
                return 100;
            };

            siDelegate1 += (out int x) =>
            {
                x = 1;
                return 100;
            };

            siDelegate1 += (out int x) => //没有参数 也需要有一个空括号
            {
                x = 1;
                return 100;
            };

            siDelegate1 += (out int x) => x = 100; //lambad 默认吧100返回去 

            int y;
            int res = siDelegate1(out y);
            Console.WriteLine(res);

            Console.ReadKey();
        }
    }
}
