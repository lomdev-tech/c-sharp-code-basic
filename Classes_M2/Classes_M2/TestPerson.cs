using System;
using System.Collections.Generic;
using System.Text;

namespace Classes_M2
{
    public class TestPerson
    {
        static void Main(string[] args) {
            var p1 = new Person1();
            Console.WriteLine($"Person1 dateail info {p1.Name} {p1.Age}");
            p1.Name = "John";
            p1.Age = 30;
            Console.WriteLine($"Person1 dateail info {p1.Name} {p1.Age}");
            p1.Age += 1;
            Console.WriteLine($"Person1 dateail info {p1.Name} {p1.Age}");


            Console.WriteLine("输入任意键退出");
            Console.ReadKey();
        }
    }
}
