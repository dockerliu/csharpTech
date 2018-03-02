using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    /// <summary>
    /// 我们这个类是是没什么事
    /// </summary>
    class Program
    {
        /// <summary>
        /// 这是main方法 程序的入口
        /// </summary>
        /// <param name="args">这是命参数</param>
        static void Main(string[] args)//Main方法 必须大写首字母 其实他是被操作系统调用
        {
            /*
             * sdasdds\
             * sdfdsfds
             * sdfdsfdsfds
             * 
            * static
             * static void Main(string[] args)
             */
            //for (int i = 0; i < args.Length; i++)
            //{
            //    Console.WriteLine(args[i]);
            //}
            Console.WriteLine("你好北盟网规范化广泛954ierivgkdporg校豆腐干豆腐干");
            Console.WriteLine("你好北盟网规范化广泛954ierivgkdporg校豆腐干豆腐干2");
            Console.WriteLine("明天我们去打{0}，好啊，怎么样啊，{1}","篮球","校长");
            //标识符就是命名
            int times = 12;
            int Age = 34;

            Int32 AA = 23;

            short hour = 256;

            int CarDeck;
            int carDeck;

            int Class = 2;
            int @class = 3;
            int Program = 34;//深蓝色的是C#的关键字 是C#语法专用的词语 我们不能用

            {
                int age = 21;
                Console.WriteLine(age);
            }
            {

            }

            Player p1;
            p1 = new Player();

            int var1 = 12;
            var1 = 23;
            Console.WriteLine(var1);

            double d1 = 3.4, d2, d3, d4 = 23;
            double dd; int ii;
            //Console.WriteLine(dd);
            dd = d1 + d4;
            Console.WriteLine(dd);
            Console.WriteLine(d1);
            //Console.WriteLine(d2);

            Phone ph;
            //Console.WriteLine(ph);

            Phone ph1 = new Phone();
            ph1.Call("110");

            Console.ReadKey();
        }

        class A
        {

        }
    }

    class Dealer
    {

    }

    class Player
    {

    }

}
