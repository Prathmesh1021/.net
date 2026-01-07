using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProject_Csharp._1_Sample_Examples
{

    internal class Simple_Interest
    {
        float p, r, t, si;
        internal void CalSi()
        {
            p = 1200;
            r = 2.2f;
            t = 4.5f;
            si = (p * r * t) / 100;

            Console.WriteLine("Simple interest is Result is {0}", si);
        }


    }
}
