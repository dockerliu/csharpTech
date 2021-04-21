using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication17
{
    class Program
    {
        static void Main(string[] args)
        {
            Friends friendcollection = new Friends();
            foreach (Friend f in friendcollection)
            {
                Console.WriteLine(f.Name);
            }

            Console.Read();
        }
    }

    /// <summary>
    ///  朋友类
    /// </summary>
    public class Friend
    {
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public Friend(string name)
        {
            this.name = name;
        }
    }

    /// <summary>
    ///   朋友集合
    /// </summary>
    public class Friends : IEnumerable
    {
        private Friend[] friendarray;

        public Friends()
        {
            friendarray = new Friend[]
            {
                new Friend("张三"),
                new Friend("李四"),
                new Friend("王五")
            };
        }


        // C# 2.0中简化迭代器的实现
        public IEnumerator GetEnumerator()
        {
            for (int index = 0; index < friendarray.Length; index++)
            {
                // 这样就不需要额外定义一个FriendIterator迭代器来实现IEnumerator
                // 在C# 2.0中只需要使用下面语句就可以实现一个迭代器
                yield return friendarray[index];
            }
        }
    }
}
