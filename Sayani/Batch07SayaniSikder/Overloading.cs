using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch07SayaniSikder
{
    class Overloading
    {
        public void show()
        {
            Console.WriteLine("this is defult parameter");
        }
        public void show(int x)
        {
            Console.WriteLine(x);
        }
        public void show(string s)
        {
            Console.WriteLine("string value is:-" + s);
        }
        public void show(int x, string s)
        {
            Console.WriteLine(x + s);
        }
        public void show(string s, int x)
        {
            Console.WriteLine(s + x);
        }

   
    }
}
