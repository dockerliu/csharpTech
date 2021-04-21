using CN.Bamn;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using CBW = CN.Bamn.Web;

namespace ConsoleApplication5
{
    class Program
    {
        static void Main(string[] args)
        {


            CBW.House h = new CBW.House();

            CBW.Goose g = new CBW.Goose();

            Console.ReadKey();
        }
    }
}
