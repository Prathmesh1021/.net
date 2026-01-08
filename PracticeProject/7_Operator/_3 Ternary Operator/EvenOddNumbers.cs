using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProject_Csharp._7_Operator._3_Ternary_Operator
{
    internal class EvenOddNumbers
    {
        static void Main()
        {
            int num = 23;
            String output = (num % 2 == 0) ? "Even No" : "Odd No";
            Console.WriteLine(output);
        }
    
    }
}