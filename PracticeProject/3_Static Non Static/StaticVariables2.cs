using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProject_Csharp._1_Sample_Examples
{
    internal class StaticVariables2
    {
        internal static void fun()
        {
            int a = 10;//static
            Console.WriteLine("Static variable "+a);
        }
        internal void fun1()
        {
            int b = 20;//non static or instance 
            Console.WriteLine("Non Static Or Instance "+b);

        }
    }
}
