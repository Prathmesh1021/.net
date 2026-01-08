using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProject_Csharp._7_Operator
{
    internal class IncrementOperator1
    {
        static void Main()
        {
            int a = 10;
            int b = a++ + a++ + a++;
            //33       //10  //11   //12     //13
            Console.WriteLine("a={0} and b={1}", a, b);
        }
    }
}
