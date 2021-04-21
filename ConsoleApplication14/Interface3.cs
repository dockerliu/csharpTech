using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication14
{
    interface Interface3:Interface1,Interface2 //因为3也是接口 所以不需要实现1 和2
    {
        int IN3();
    }
}
