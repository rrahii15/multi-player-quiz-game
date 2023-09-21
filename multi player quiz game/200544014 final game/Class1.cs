using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Game
{
    internal class Class1
    {//using method overloading
        public int Add(int num1, int num2)//first input
        {
            return num1 + num2;
        }

        public int Add(int num1, int num2, int num3)//second input
        {
            return num1 + num2 + num3;
        }
    }
}
