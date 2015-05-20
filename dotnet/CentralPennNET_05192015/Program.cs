using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace CentralPennNET_05192015
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] testScores = {65, 68, 78, 96, 45, 85, 13, 95, 44};

            int passingCount = 0;
            /*
            foreach (int score in testScores)
            {
                if (score >= 60)
                    passingCount++;
            }
             */
            // passingCount = testScores.Where(x => x > 60).Count();
            passingCount = testScores.Where(delegate(int x) { return x >= 60;  } ).Count();
            Console.WriteLine(String.Format("Number of passing test scores {0}", passingCount));
            Console.ReadLine();

        }

        public bool sdoidsjfoidsji(int x)
        {
            return (x > 60);
        }
    }
}
