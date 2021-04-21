using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication12
{
    public class MyEventArgs:EventArgs
    {
        public string message;

        public MyEventArgs(string s)
        {
            this.message = s;
        }
    }
}
