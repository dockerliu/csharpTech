using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    public class Cat : Animal
    {
        public override void Eat()
        {
            Console.WriteLine("猫吃饭");
        }
    }
}
