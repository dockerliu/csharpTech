using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication9
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = new Person[2];
            a[0] = new Person() { age = 1 };
            a[1] = new Person() { age = 2 };

            var b = (Person[])a.Clone();

            a[0].age = 11;
            a[1].age = 12;//改变a的两个person对象的字段 

            foreach (var item in a)
            {
                Console.WriteLine(item.age);
            }

            foreach (var item in b)
            {
                Console.WriteLine(item.age);
            }

            /* 
                11
                12
                11
                12
             */
            Console.ReadKey();
        }

        static void Main1(string[] args)
        {
            var a = new Person[2];
            a[0] = new Person() {age = 1 };
            a[1] = new Person() {age = 2 };

            var b = (Person[])a.Clone();

            a[0] = new Person() { age = 3 };
            a[1] = new Person() { age = 4 };//b是从a克隆出去的 但是因为是值类型 所以是一份新的赋值 互不影响

            foreach (var item in a)
            {
                Console.WriteLine(item.age);
            }

            foreach (var item in b)
            {
                Console.WriteLine(item.age);
            }

            /* 
                3
                4
                1
                2
             */
            Console.ReadKey();
        }
    }

    class Person
    {
        public int age;
    }
}
