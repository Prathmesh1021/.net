using PracticeProject_Csharp._1_Examples;
using PracticeProject_Csharp._1_Sample_Examples;

namespace Projectpractice
{
    internal class Program
    {
        static void Main()
        {   //Arithmatic Example 3 Object 
            ArithmaticOperationsWithFunction obj = new ArithmaticOperationsWithFunction();
            obj.add();
            obj.sub();
            obj.mul();
            obj.div();
            obj.mod();
            //Simple interest 
            Simple_Interest obj1=new Simple_Interest ();
            obj1.CalSi();
            // Static Variable 2
            StaticVariables2 obj2 = new StaticVariables2();
            obj2.fun1();
            StaticVariables2.fun();
            //
            SwapProgram.Swap();    

   
        }
    }

}