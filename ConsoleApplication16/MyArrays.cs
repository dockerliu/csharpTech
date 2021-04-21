using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication16
{
    class MyList<T,tt,ttt,tttd2,ttst2,ttdtd2> where T : struct
    {
        private List<T> data = new List<T>();

        public void AddData(T t)
        {
            data.Add(t);
        }

        public T GetData(int index)
        {
            return data[index];
        }
    }
}
