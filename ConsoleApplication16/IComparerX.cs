using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication16
{
    public interface IComparerX<T>
    {
        bool Compare(T x, T y);
    }
}
