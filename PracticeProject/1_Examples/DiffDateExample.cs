using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProject_Csharp._1_Examples
{
    internal class DiffDateExample
    {
        public static void Main()
        {
            String date1 = "15052021";
            String date2 = "16062026";
            int d1 = Convert.ToInt32(date1);
            int d2 = Convert.ToInt32(date2);
            int y1 = d1 % 10000;
            int y2 = d2 % 10000;
            Console.WriteLine("Diffrence of Date in Year {0}", y2 - y1);
        }
    }
}
