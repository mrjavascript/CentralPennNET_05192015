using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Expression_Trees
{
    class Program
    {
        static void Main(string[] args)
        {
            // Build the expression
            Expression<Func<int, int, int>> expression 
                = (num1, num2) => num1 + num2;

            // Compile the expression
            Func<int, int, int> compFunc = expression.Compile();

            // Execute!
            int result = compFunc(3, 4);

            Console.WriteLine(result);
            Console.ReadLine();

        }
    }
}
