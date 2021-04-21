using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "F:\\项目\\C#轻松学";
            ReadDir(path);

            Console.ReadKey();
        }

        private static void ReadDir(int ddd,string path)
        {
        }

        //类型不一样
        private static void ReadDir(int ddd)
        {
        }

        private static void ReadDir(out int ddd)
        {
            ddd = 2;
        }

        private static void ReadDir(string path)
        {
            //读取文件
            string[] files = Directory.GetFiles(path);
            for (int i = 0; i < files.Length; i++)
            {
                Console.WriteLine(files[i]);
            }
            string[] dirs = Directory.GetDirectories(path);
            for (int i = 0; i < dirs.Length; i++)
            {
                Console.WriteLine(dirs[i]);
                //再次读取这个目录里面的文件和文件夹
                ReadDir(dirs[i]);//递归 本身方法调用自己
            }
        }
    }
}
