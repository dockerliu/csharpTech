using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4dddd
{
    //internal class Dog
    internal class Dog: Animal
    {
        public Dog()
        {
            //ShowName();
        }

        public override void Eat()
        {
            Console.WriteLine("狗吃饭");
        }
    }
}
