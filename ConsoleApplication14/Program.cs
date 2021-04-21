using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication14
{
    class Program
    {
        static void Main(string[] args)
        {
            Do(new Class1());//我只需要改变这里的参数对象 就可以了
            Do(new Class2());//以后我只需要独立管理Class1 2 3 4 只要实现了接口3
        }

        public static void Do(Interface3 i)
        {
            i.IN1();
        }
    }
}
