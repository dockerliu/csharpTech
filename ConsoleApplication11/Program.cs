using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication11
{
    class Program
    {

        static void Main(string[] args)
        {
            Class1 c = new Class1();
            c.shoTimeEvent += C_shoTimeEvent;//订阅事件处理函数
            c.Run();
            Console.ReadKey();
        }

        private static void C_shoTimeEvent(MyEventArgs args)
        {
            Console.WriteLine(args.message);
        }
    }


}
