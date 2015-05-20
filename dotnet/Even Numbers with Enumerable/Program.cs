using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Even_Numbers_with_Enumerable
{
    class Program
    {
        static void Main(string[] args)
        {
            var evens = System.Linq.Enumerable.Range(1, 100)
                .Where(s => s % 2 == 0).ToList();
            /*
            evens.FindAll(delegate(int i) { Console.WriteLine(i);
                                              return true;
            });
             */
            evens.ForEach( i => Console.WriteLine(i) );


            Console.ReadLine();
        }
    }
}
