using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication16
{
    public delegate void MyDel<T>();

class Program
    {
        public event MyDel<EventArgs> myEvent;

        static void Main(string[] args)
        {
            Console.ReadKey();
        }

    }

    class Person
    {
        public int Age { set; get; }
    }
}
