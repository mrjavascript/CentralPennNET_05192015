using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evolution_of_Delegates
{
    class Program
    {
        delegate void MyDelegate(string s);
        static void Foo(string s) { Console.WriteLine(s); }

        static void Main(string[] args)
        {
            // (1) .NET 1.0
            MyDelegate del = new MyDelegate(Foo);

            // (2) .NET 2.0
            MyDelegate M
                = delegate(string s)
                { Console.WriteLine(s); };

            // (3) .NET 3.0 and above
            MyDelegate ME = 
                (x) => { Console.WriteLine(x) };


        }
    }
}
