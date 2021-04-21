using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Employee
    {
        public string firstName;
        public string lastName;
        public string cityOfBirth;

        public string this[int i,int t]
        {
            set
            {
                if (i==0)
                {
                    firstName = value;
                }
                else if(i==1)
                {
                    lastName = value;
                }
                else
                {
                    cityOfBirth = value;
                }
            }

            get
            {
                switch (i)
                {
                    case 0:return firstName;
                    case 1:return lastName;
                    default: return cityOfBirth;
                }
            }
        }
    }
}
