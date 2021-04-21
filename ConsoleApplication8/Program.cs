using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication8
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student();
            Student s2 = new Student();
            Student s3 = new Student();
            Student s4 = new Student();

            s1.level = Level.不及格;
            s2.level = Level.及格;
            s3.level = Level.良好;
            s4.level = Level.优秀;

            Student s5 = new Student();
            s5.level = Level.不及格;

            Level l = new Level();//枚举也可以用new 默认是第一个
            l = Level.优秀; //通过枚举的名称 可以设置枚举
            Level l2 = l;
            //Level l3 = 1; //虽然枚举本质是整数 但是不能把一个整数赋给它
            Level l3 = (Level)1;//把整数强制转换是可以
        }
    }

    enum Level:long //可以是中文
    {
        不及格 = 1001, //注意不是字符串
        及格 = 101,
        良好 = -1,
        优秀
    }

    class Student
    {
        public Level level;
    }
}
