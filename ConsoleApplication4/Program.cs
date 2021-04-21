//using ConsoleApplication4dddd;
using ClassLibrary1;
using ConsoleApplication4dddd;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Son s = new Son();
            //s.lastName = "周";
            //Father f = (Father)s;
            //Father f = (Father)s;
            //f.salary = 123;
            //f.lastName = "周";

            //Daughter d = new Daughter();
            //d.lastName = "张";
            //d.skirt = "连衣裙";

            //Console.WriteLine(s.lastName);
            //Console.WriteLine(d.lastName);

            //s.PrintLastName();

            //f.PrintLastName();//输出周 如果对父类方法进行了override的话 那么就算算父类引用 也执行子类的方法

            //ConsoleApplication4dddd.Dog d = new ConsoleApplication4dddd.Dog();

            //Cat c = new Cat();

            ////Animal a = new Animal();
            ////a.ShowName();

            //Animal a = new Cat();
            //a.Eat();

            //Animal d = new Dog();
            //d.Eat();
            //d.ShowName();//调用抽象类的普通方法

            //Plant p = new Plant();

            ////EmailHelper eh = new EmailHelper();
            //EmailHelper.Send();
            //EmailHelper.Send1();

            Calculate c = new Calculate(123,34);
            c.Sum();
            c.Avg(1); //现在就可以通过.号来用了

            CalculateExtend.Avg(c,1);//也可以当成静态类来用

            StringBuilder b = new StringBuilder();
            b.Length = 250;
            CalculateExtend.GetCurrentDirectory(250, b);
            Console.WriteLine(b.ToString());

            Console.ReadKey();
        }
    }
}
