using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Son:Father
    {
        //public Son():base("潘")
        //{

        //}

        public Son() : this("潘")
        {

        }

        public Son(string lastName)
        {
            this.lastName = lastName;
        }

        public int salary;

        public new string lastName;

        public override void PrintLastName()
        {
            Console.WriteLine(lastName);
            //Console.WriteLine(this.lastName);
            //Console.WriteLine(base.lastName);
        }
    }
}
