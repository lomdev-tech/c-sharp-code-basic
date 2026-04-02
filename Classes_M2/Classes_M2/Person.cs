using System;
using System.Collections.Generic;
using System.Text;

namespace Classes_M2
{
    public class Person
    {
        //字段
        private string? name;
        private int age;

        //属性
        public string Name { get { return name!=null?name:"N/A"; } set { name = value; } }
        public int Age { get { return age; } set { age = value; } }
        //构造器
        public Person(string name,int age) { 
        
            Name = name;
            Age = age;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}");
        }

    }
}
