using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication12
{
    class Program
    {
        public static event EventHandler<MyEventArgs> myEevent;

        static void Main(string[] args)
        {
            myEevent += Program_myEevent;
            myEevent(1, new MyEventArgs("www.bamn.cn"));

            Console.ReadKey();
        }

        private static void Program_myEevent(object sender, MyEventArgs e)
        {
            Console.WriteLine(e.message);
        }
    }
}
