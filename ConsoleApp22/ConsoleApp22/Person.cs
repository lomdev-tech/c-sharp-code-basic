using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace ConsoleApp22
{
    public class Person
    {
      
        //无参构造函数
        public Person() {
            string name = "Person One";
            Console.WriteLine($"Person created: {name}");

        }
        public Person(string fName,string lName) {

            string name = fName + " " + lName;
            Console.WriteLine($"Person created: {name}");

        }
        
    }
    public class Car {
        public string? _modelName;

        public Car(string modelName) => _modelName = modelName;
        //public override string ToString()
        //{
        //    return $"Car:{{_modelName:{_modelName}}}";
        //}
        public void xianglaba(string modelName,string sounds = "baba!") {
            Console.WriteLine($"{modelName}正在发出{sounds}");
        }
    }
    static class Program1 {

        static void Main(string[] args) { 
            Person person = new Person();
            Person person1 = new Person("jack","daniel");
            Car car1 = new Car("xiaomi");
            Car car2 = new Car("xiaomi");
            car1.xianglaba("本田");
            car2.xianglaba("比亚迪", "bubu！");
        }
    }
}
