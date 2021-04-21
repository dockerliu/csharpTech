using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Phone
    {
        string Color = "黑色",Metail;
        public decimal Price;

        Player p;

        public void SetColor(string color)
        {
            this.Color = color;
        }

        private void SetPrice(decimal price)
        {
            this.Price = price;
        }

        public decimal GetPrice()
        {
            return this.Price;
        }

        public void Call(string phoneNumber)
        {
            int total = 23;
            Phone ph1 = new Phone();
            //ph1.Call("110");
            ph1.CheckInfo();
            if (true)
            {
                //这里来验证一下我们的电话号码是否正确
            }
            Console.WriteLine("打电话给{0}", phoneNumber);
        }

        public void CheckInfo()
        {
            //Call("122");
            SetPrice((decimal)123.3);
            Console.WriteLine("颜色 ："+Color);
            Console.WriteLine("价格 ："+ Price);
        }

        public static void PlayMusic()
        {
            Console.WriteLine("播放音乐");
        }
    }
}
