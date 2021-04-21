using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public abstract class Animal
    {
        //public string name;
        //protected string name;
        //private string name;
        //internal protected string name;
        internal string name;

        public void ShowName()
        {
            Console.WriteLine(name);
        }

        class CC
        {
            public CC()
            {
                //Animal a = new Animal();
                //a.ShowName();
            }
        }

        public abstract void Eat();
    }
}
