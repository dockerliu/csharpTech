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

        const double PI = 3.1415926; 

        static int price2;

        //var times = 2;

        /// <summary>
        /// 这是main方法 程序的入口
        /// </summary>
        /// <param name="args">这是命参数</param>
        static void Main(string[] args)//Main方法 必须大写首字母 其实他是被操作系统调用
        {
            Gear g1 = new Gear();
            Gear g2 = new Gear();
            g1.number = 12;
            g2.number = 13;

            Console.WriteLine(g1.number);

            #region MyRegion
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
            //Console.WriteLine("你好北盟网规范化广泛954ierivgkdporg校豆腐干豆腐干");
            //Console.WriteLine("你好北盟网规范化广泛954ierivgkdporg校豆腐干豆腐干2");
            //Console.WriteLine("明天我们去打{0}，好啊，怎么样啊，{1}","篮球","校长");
            ////标识符就是命名
            //int times = 12;
            //int Age = 34;

            //Int32 AA = 23;

            //short hour = 256;

            //int CarDeck;
            //int carDeck;

            //int Class = 2;
            //int @class = 3;
            //int Program = 34;//深蓝色的是C#的关键字 是C#语法专用的词语 我们不能用

            //{
            //    int age = 21;
            //    Console.WriteLine(age);
            //}
            //{

            //}

            //Player p1;
            //p1 = new Player();

            //int var1 = 12;
            //var1 = 23;
            //Console.WriteLine(var1);

            //double d1 = 3.4, d2, d3, d4 = 23;
            //double dd; int ii;
            ////Console.WriteLine(dd);
            //dd = d1 + d4;
            //Console.WriteLine(dd);
            //Console.WriteLine(d1);
            ////Console.WriteLine(d2);

            //Phone ph;
            ////Console.WriteLine(ph);

            //Phone ph1 = new Phone();
            //ph1.Call("110");
            //ph1.Price = 1000;
            ////ph1.Corlor = "红色";
            //ph1.SetColor("红色");
            //Console.WriteLine(ph1.Price);

            //ph1.CheckInfo();

            //Phone ph2 = new Phone();
            //Phone ph3 = new Phone();
            //Phone ph4 = new Phone();
            //Phone ph5 = new Phone(); 
            #endregion

            #region MyRegion1
            //Phone p1 = new Phone();
            ////p1.Price = 123;
            //Console.WriteLine(p1.Price);

            //int price;
            ////Console.WriteLine(price);
            //Console.WriteLine(price2);

            ////p1.PlayMusic();
            //Phone.PlayMusic();

            //int one = 123;
            //int two = 234;
            //double average = (one + two) / 2;
            //Console.WriteLine(average);

            //int one1 = 123;
            //int two1 = 234;
            //double average1 = (one1 + two1) / 2;
            //Console.WriteLine(average1);

            ////Console.WriteLine(new Program().GetAve(124,57));
            //Console.WriteLine(GetAve(124, 57));
            //Console.WriteLine(GetAve(1254, 57));
            //Console.WriteLine(GetAve(56, 57));
            //Console.WriteLine(GetAve(15724, 57));
            //Console.WriteLine(GetAve(124, 57));
            //Console.WriteLine(GetAve(124, 57));
            //Console.WriteLine(GetAve(124, 57));
            //Console.WriteLine((124+57)/2); 
            #endregion

            #region MyRegion
            //var a = 2;
            ////a = 2.3; 这里会报错
            //var d = 2.3;
            //var p = new Phone();

            //{
            //    var a2 = 23;
            //    Console.WriteLine(a);
            //    {
            //        Console.WriteLine(a2);
            //        Console.WriteLine(a);
            //        {
            //            Console.WriteLine(a);
            //            if (true)
            //            {
            //                Console.WriteLine(a);
            //                {
            //                    Console.WriteLine(a2);
            //                }
            //            }
            //        }
            //    }
            //    {

            //    }
            //} 


            //Console.WriteLine(a2);

            //var v;//使用var 必须有初始化
            #endregion


            #region MyRegion
            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.WriteLine("半径:{0},面积是：{1}", i, PI * i * i);
            //    Console.WriteLine("半径:{0},周长是：{1}", i, PI * i * 2);
            //    Console.WriteLine("半径:{0},体积是：{1}", i, PI * i * i * i * 4 / 3);
            //    //pi = 3.1415;//常量是不能改变的 声明的时候 就要初始化 一旦
            //    Console.WriteLine("半径:{0},体积是：{1}", i, PI * i * i * i * 4 / 3);
            //}
            //Console.WriteLine(a);

            //int a = 23;
            //Console.WriteLine(a);

            //Console.Write(GetHour());

            //Program pg = new Program();
            //var phone = pg.BuyPhone(1000);
            //phone.Call("110");
            //Console.WriteLine(phone.GetPrice()); 
            #endregion

            //SayHello();

            //GetAve(23,35);

            //int m = 5;
            //Person p = new Person();
            //p.age = 10;

            //Console.WriteLine(p.age + "--" + m);

            //SetParam(ref p, ref m);

            //Console.WriteLine(p.age + "--" + m);


            //int a = 18;//1 必须初始化
            //SetAge(ref a); //传递参数时候 加入ref 并且必须是一个变量 
            //Console.WriteLine(a);//输出19

            //int age2 = 32;
            //Person p2 = new Person();
            ////SetOut(out age2, out p2);
            //Console.WriteLine(age2);
            //Console.WriteLine(p2.age);

            //SayHello("");
            int ddd = 32;
            double d = GetAverage(ddd,23,34,23+23,ddd+34);
            Console.WriteLine(d);

            int[] pss = { 34,34,345,234,234,ddd+3,ddd}; 
            var ds = GetAverage3(pss);
            Console.WriteLine(ds);

            Console.ReadKey();

        }

        static double GetAverage(params int[] pars)
        {
            if (pars.Count()==0)
            {
                return 0;
            }
            return pars.Sum() / pars.Count();
        }

        static double GetAverage3(int[] pars)
        {
            if (pars.Count() == 0)
            {
                return 0;
            }
            return pars.Sum() / pars.Count();
        }

        static void SetAge(ref int age)
        {
            age = age + 1;
        }

        static void SetOut(out int age,out Person p)
        {
            age = 100;
            p = new Person();
            p.age = 1000;
        }

        static void SetParam(ref Person pp,ref int mm)
        {
            pp.age = pp.age + 5;
            mm = mm + 5;
        }

        static void SayHello()
        {
            int hour = GetHour();
            if (hour < 12 || hour > 18)
            {
                return;//如果这里被执行了 那么下面的代码就不会执行
            }

            Console.WriteLine("下午好");
        }

        static double GetAve(int one, int two)
        {
            //Console.WriteLine(a);
            if (true)
            {
                return 2.3;
            }
            //return new Phone();
            return (one + two) / 2;
        }

        static int GetHour()
        {
            return DateTime.Now.Hour;
        }

        Phone BuyPhone(decimal money)
        {
            return new Phone();
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
