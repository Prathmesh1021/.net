using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProject_Csharp._1_Examples
{
    internal class SumDateDigit
    {
        public static void Main()
        {
            string date1 = "15082016";
            int d1 = Convert.ToInt32(date1);
            int first = d1 % 10;
            d1= (int) (d1 / 10);
            int second = d1 % 10;
            d1 = (int)(d1 / 10);
            int thired = d1 % 10;
            d1 = (int)(d1 / 10);
            int fourth = d1 % 10;
            d1 = (int)(d1 / 10);
            int fifth = d1 % 10;
            d1 = (int)(d1 / 10);
            int sixth = d1 % 10;
            d1 = (int)(d1 / 10);
            int seven = d1 % 10;
            d1 = (int)(d1 / 10);
            int eight = d1 % 10;
            d1 = (int)(d1 / 10);

            Console.WriteLine(first + second + thired + fourth + fifth + sixth + seven + eight);
        }
    }
}
