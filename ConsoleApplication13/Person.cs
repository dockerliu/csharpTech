using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication13
{
    class Person : Animal,IMyComparable
    {
        public int Age
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public event EventHandler myEvent;

        public int CompareTo(object obj)
        {
            throw new NotImplementedException();
        }
    }
}
