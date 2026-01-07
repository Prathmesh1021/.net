using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProject_Csharp._5_Boxing_UnBoxing_Example
{
    internal class Unboxing
    {
        internal void unboxingfun()// Unboxing Example  with object to int
        {
            object o = 13;
            int a = (int)o;
            Console.WriteLine(a);
        }
    } }
