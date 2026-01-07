using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProject_Csharp._1_Examples
{ 
   internal class SwapProgram
    {
        static int a = 5, b = 10;
        internal static void Swap()
        {
            int temp = a;
            a = b;
            b = temp;
            Console.WriteLine("Values Of a={0} and b={1}", a, b);
        }
    }
}
