using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication13
{
    class Student : Animal, IMyComparable,ICloneable,IMyComparable1
    {
        internal int age;

        public object Clone()
        {
            return this;
        }

        //显式实现方法
        int IMyComparable1.CompareTo(object obj)
        {
            Console.WriteLine("IMyComparable1.CompareTo");
            return 1;
        }

        int IMyComparable.CompareTo(object obj)
        {
            Console.WriteLine("IMyComparable.CompareTo");
            return 0;
        }

        //实现方法

        //public int CompareTo(object obj)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
