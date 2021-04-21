using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    Run();
                }
                catch (Exception ex)
                {
                    //throw;//不带对象的抛出 只能用在catch里面 他会把捕捉的异常对象抛出 抛给调用地方 这里是抛给操作系统
                    Console.WriteLine(ex.Message);
                }
            }
            
            Console.ReadKey();
        }

        private static void Run()
        {
            Console.WriteLine("\r\n请输入一个数：");
            int b = 10;
            try
            {
                int a = Convert.ToInt32(Console.ReadLine());
                if (a==10)
                {
                    throw new Exception("我主动抛出的异常");
                }
                Console.WriteLine(b / a);
            }
            catch (OverflowException ofex)
            {
                throw;
                Console.WriteLine("错误提示：" + ofex.Message);
            }
            catch (FormatException)
            {
                Console.WriteLine("输入的格式不对 不是数字");
            }
            finally
            {
                Console.WriteLine("finally执行了");
            }
        }
    }
}
