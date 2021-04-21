using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication11
{
    //声明委托
    public delegate void ShowTimeDeletage(MyEventArgs args);

    class Class1
    {
        //根据委托声明事件
        public event ShowTimeDeletage shoTimeEvent;

        public Class1()
        {
        }

        public void Run()
        {
            //触发事件 所有订阅该事件的方法都会执行
            MyEventArgs args = new MyEventArgs("发生事情了");
            shoTimeEvent(args);
        }
    }
}
