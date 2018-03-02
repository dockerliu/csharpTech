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
        decimal Price;

        public void Call(string phoneNumber)
        {
            if (true)
            {
                //这里来验证一下我们的电话号码是否正确
            }
            Console.WriteLine("打电话给{0}", phoneNumber);
        }

        public void CheckInfo()
        {
            Console.WriteLine("颜色 ："+Color);
        }
    }
}
