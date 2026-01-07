using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProject_Csharp._1_Sample_Examples
{
    internal class ArithmaticOperations
    {
        static void Main()
        {
            int a = 30, b = 20, c;
            c = a + b;
            Console.WriteLine("Addition:" +c);

            c = a - b;
            Console.WriteLine("Substraction:" + c);

            c = a * b;
            Console.WriteLine("Multiplication:" + c);

            c = a / b;
            Console.WriteLine("Division:" + c);

            c = a % b;
            Console.WriteLine("Modules:" + c);
        }
    }
}
