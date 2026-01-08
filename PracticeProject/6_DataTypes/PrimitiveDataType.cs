using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProject_Csharp._6_DataTypes
{
    internal class PrimitiveDataType
    {
        public void pDataTypeFun()
        {
            int a = 10;//4byte
            byte bt = 2;//1byte
            float c = 23.24F;//4 byte 
            double e = 23345.2;//8 byte 
            bool d = false;//1 byte
            char ch = 'a';//2 byte 
            Console.WriteLine("a={0} ,bt={1}, c={2}, e ={3} , d={4} , ch={5}",a,bt,c,e,d,ch);
        }
    }
}
