using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Calculate
    {
        public int num1;
        public int num2;

        public Calculate(int num1,int num2)
        {
            this.num2 = num2;
            this.num1 = num1;
        }

        public void Sum()
        {
            Console.WriteLine(num1+num2);
        }
    }
}
