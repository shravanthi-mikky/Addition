using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace DemoAddition
{
    public class Generics
    {

        public void Comparision<T>(T num1, T num2)
        {
            if(num1.Equals(num2))
            {
                Console.WriteLine("Numbers are equal");
            }
            else 
            {
                Console.WriteLine("Numbers are not equal");
            }
        }
    }
}
