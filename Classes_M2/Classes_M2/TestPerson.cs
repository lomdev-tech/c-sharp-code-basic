using System;
using System.Collections.Generic;
using System.Text;

namespace Classes_M2
{
    public class TestPerson
    {
        static void a(string[] args) {
            //var p1 = new Person1()
            //{
            //    Name = "Alice",
            //    Age = 20
            //};
            //p1.Name = "Bob";
            //Console.WriteLine(p1.Name);
            //Console.WriteLine(p1.Age);
            //Console.WriteLine($"Person1 dateail info {p1.Name} {p1.Age}");
            //p1.Name = "John";
            //p1.Age = 30;
            //Console.WriteLine($"Person1 dateail info {p1.Name} {p1.Age}");
            //p1.Age += 1;
            //Console.WriteLine($"Person1 dateail info {p1.Name} {p1.Age}");


            //Console.WriteLine("输入任意键退出");
            //Console.ReadKey();
            var p2 = new Person2() { 
                FirstName = "Alice",
                LastName = "Smith"
            };
            Console.WriteLine(p2.FirstName+" "+p2.LastName);
        }
    }
}
