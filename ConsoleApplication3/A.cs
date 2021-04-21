using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    partial class A
    {
        public int age;
        public int ShowAge()
        {
            return age;
        }
    }

    partial class A
    {
        public int age1;
        public int ShowAge1()
        {
            return age;
        }
    }

    partial class A
    {
        public int age2;
        public int ShowAge2()
        {
            return age1;
        }
    }
}
