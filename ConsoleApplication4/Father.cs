using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Father
    {
        public Father()
        {

        }

        public Father(string lastName)
        {
            this.lastName = lastName;
        }

        public string lastName = "张";

        public virtual void PrintLastName()
        {
            Console.WriteLine(lastName);
        }
    }
}
