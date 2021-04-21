using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    static class EmailHelper
    {
        public static void Send()
        {
            Console.WriteLine("静态发送");
        }

        public static void Send1()
        {
            Console.WriteLine("普通发送");
        }

        private static string name;




        private static string id;
    }
}
