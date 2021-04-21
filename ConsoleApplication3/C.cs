using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    partial class C
    {
        partial void ShowTime();

        public void AD()
        {
            ShowTime();//分部方法 只能类内部使用 
        }
    }

    partial class C
    {
        partial void ShowTime()
        {
            Console.WriteLine(DateTime.Now);
        }
    }
}
