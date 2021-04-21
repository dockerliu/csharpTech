using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Gear g1 = new Gear();
            ////g1.gearCount 无法访问 静态成员 对象
            //g1.ShowCount();
            //Console.WriteLine(Gear.gearCount);//类的外部 通过类名来访问静态字段

            //Gear g1 = new Gear();
            //Gear g2 = new Gear();

            //g1.SetValue(1, 20);
            //g1.ShowCount("g1");

            //g2.SetValue(2,30);
            //g2.ShowCount("g2");

            //g1.ShowCount("g1");

            //Gear.gearCount = 11;
            //Console.WriteLine(Gear.gearCount);

            //Console.WriteLine(Gear.PI);//常量也可以通过类名来调用
            //Console.WriteLine(3.14); //上面的代码编译以后 等同于这个

            MoonCake mc = new MoonCake();
            //mc.age = 21;
            //mc.Color = "ddd";//静态属性 不能通过实例名来访问 静态属性不属于任意一个实例的
            MoonCake.Color = "red";
            //mc.price = 5;

            mc.Price = 5;

            Console.WriteLine(mc.Price);

            MoonCake mc2 = new MoonCake("blue", 12);

            Console.WriteLine(MoonCake.Color);

            MoonCake mc3 = new MoonCake { Price = 12, Money = 23 };

            Employee ep = new Employee();
            ep[0,1] = "北盟";
            ep[1,2] = "网校";
            ep[2,3] = "北京";

            Console.WriteLine(ep[1,1]);

            A a = new A();
            a.age = 12;
            Console.WriteLine(a.ShowAge1());

            C c = new C();
            //c.s

            Console.ReadKey();
        }
    }
}
