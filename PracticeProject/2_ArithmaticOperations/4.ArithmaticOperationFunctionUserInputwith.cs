using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProject_Csharp._1_Sample_Examples
{
    internal class ArithmaticOperationFunctionUserInputwith
    {
        int a, b, c;
        internal void accept()
        {
            Console.WriteLine("Enter Your First Number:");
            a =Convert.ToInt32( Console.ReadLine());
            Console.WriteLine("Enter Your Second Number:");
            b = Convert.ToInt32(Console.ReadLine());
        }
        internal void add()
        {
            c = a + b;
            Console.WriteLine("Addition:" + c);
        }
        internal void sub()
        {
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
        static void Main()
        {    
            ArithmaticOperationFunctionUserInputwith obj =new ArithmaticOperationFunctionUserInputwith();
            obj.accept();   
            obj.add();
            obj.sub();
            obj.mul();
            obj.div();
            obj.mod();

        }
    }
}
