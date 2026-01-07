using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProject_Csharp._1_Sample_Examples
{
    internal class StaticVariables
    {
        static int y = 100;//Global static
        int a = 10;// Global instance // Any time call with object 

        static void Main()
        {
            int y = 10;//Local
            y = 20;//Local 
            Console.WriteLine("y is the static variavle "+y);
            Console.WriteLine("y is the variable "+ StaticVariables.y);
            StaticVariables obj = new StaticVariables();
            Console.WriteLine("a is " + obj.a);

        }
    }
}
