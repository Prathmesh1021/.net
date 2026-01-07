using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProject_Csharp._1_Sample_Examples
{
    internal class ArithmaticOperationsWithFunction
    {
        int a = 10, b = 5, c;
     internal void add() {
            c = a + b;
            Console.WriteLine("Addition:" + c);
        }
    internal void sub() {
            c = a - b;
            Console.WriteLine("Substraction:" + c);
        }
    internal void mul()
        {
            c = a * b;
            Console.WriteLine("Multiplication:" + c);
        }
     internal void div()
        {
            c = a / b;
            Console.WriteLine("Division:" + c);
        }
        internal void mod()
        {
            c = a % b;
            Console.WriteLine("Modules:" + c);
        }

    }
}
