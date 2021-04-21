using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Gear
    {
        public int id;

        public const double PI = 3.14; //常量不能标记为static
        public const double PI2 = PI*2;
        //public const double PI3;
        //PI3 = 23;
        public static int gearCount;

        public void ShowCount(string name)
        {
            Console.WriteLine(PI* 12*12);
            Console.WriteLine(name+"齿轮数是："+ gearCount+" ID 是"+ id);
        }

        public void SetValue(int v1, int v2)
        {
            id = v1;
            gearCount = v2;
            AD();
        }

        public static void ShowValue()
        {
            //Console.WriteLine(id);//静态函数 不能访问非静态字段
            AD(); //静态函数可以调用
            Console.WriteLine(gearCount); //静态字段也可以调用
            //BC();//非静态函数也不能用
        }

        public static void AD()
        {

        }

        public void BC()
        {

        }
    }
}
