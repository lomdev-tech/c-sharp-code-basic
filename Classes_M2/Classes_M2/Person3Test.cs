using System;
using System.Collections.Generic;
using System.Text;

namespace Classes_M2
{
    public class Person3Test
    {
        static void Main(string[] args)
        {
            Person3 person3 = new Person3();
            person3.Name = "Alice";
            person3.Field = "Field";
            Console.WriteLine(person3.Name);
            Console.WriteLine(person3.Field);
        }
    }
}
