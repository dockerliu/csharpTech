using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class MoonCake
    {
        public readonly int age = 23;

        private int pe;

        //当我们不写构造函数的时候 编译器默认帮我们写一个 无参构造函数
        //如果我们写了构造函数 则编译器不会再帮我们添加了
        public MoonCake() 
        {
            age = 12;
        }

        ~MoonCake()
        {

        }

        static MoonCake()
        {
            color = "black";
        }

        public MoonCake(string color,int price)
        {
            int pe = 12;
            this.pe = pe;
            this.price = price;
        }

        private static string color;

        public static string Color
        {
            set
            {
                color = value;
            }

            get
            {
                return color;
            }
        }

        //public string Color
        //{
        //    set; get;
        //}

        private int price;

        public int Price
        {
            set
            {
                Color = "blue";
                int a = 12;
                if (value < 0)
                {
                    value = 0;
                }
                price = value * a; //value 就是其他地方 给属性赋值的时候 的这个值
            }

            get
            {
                return price;
            }
        }

        public int Money
        {
            get;
            set;
        }
    }
}
