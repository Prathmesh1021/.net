using PracticeProject_Csharp._1_Examples;
using PracticeProject_Csharp._1_Sample_Examples;
using PracticeProject_Csharp._5_Boxing_UnBoxing_Example;
using PracticeProject_Csharp._6_DataTypes;

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
            //Swap program 
            SwapProgram.Swap();    
            //Boxing
            Boxing obj4 = new Boxing ();
            obj4.boxingfun();
            //unboxing
            Unboxing obj5= new Unboxing (); 
            obj5.unboxingfun();
            // Primitive data Type 
            PrimitiveDataType obj6 = new PrimitiveDataType();
            obj6.pDataTypeFun();
            //Deriverd Data Type 
            DeriverdDataTypes obj7 = new DeriverdDataTypes ();
            obj7.DDataTypefun1();
        }
    }

}