using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication14
{
    class Class2 : Interface3
    {
        public int IN1()
        {
            Console.WriteLine("Class2执行代码");
            return 1;
        }

        public int IN2()
        {
            throw new NotImplementedException();
        }

        public int IN3()
        {
            throw new NotImplementedException();
        }
    }
}
