using System;
using System.Collections;
using System.Collections.Generic;

namespace DemoAddition
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Addition1 addition1 = new Addition1();
            addition1.Add();

            // calling the comparision method of generics
            Generics generics = new Generics();
            generics.Comparision(2.7, 2.7);

            //Array, has specific length, and is type safe
            // has specific length, only can be updated later.

            int[] array = {1,2, 3};
            array[0] = 2;
            array[1] = 3;
            array[2] = 4;
            //array[3] = 5; // System.IndexOutOfRangeException: 'Index was outside the bounds of the array.'
            Console.WriteLine(array[3]);

            //Arraylist is not type safe, it takes any type of value in it bcos it takes object as input.
            ArrayList arrayList1 = new ArrayList(10);

            arrayList1.Add(100);
            arrayList1.Add("Hello"); // accepts all types of data

            //List is type safe, it takes only specific type of data.

            List<int> list = new List<int>();
            list.Add(100);
            // list.Add(("hello");// throws an error, cannot convert string to int 



        }
    }
}
