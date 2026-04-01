using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp22
{
    public class Phone
    {
        public string? Brand { get; set; }
        public string? Model { get; set; }
        public int Year { get; set; }
        //无参构造器 ： 用于创建对象时初始化属性
        //public Phone() { 


        //}
        //有参构造器 ： 用于创建对象时直接赋值属性
        public Phone(string brand, string model, int year)
        {
            Brand = brand;
            Model = model;
            Year = year;
        }
        public void Call(string phoneNumber)
        {
            Console.WriteLine($"Calling {phoneNumber}...");
        }

        public void Text(string phoneNumber, string message)
        {
            Console.WriteLine($"Texting {phoneNumber}: {message}");
        }

    }
}
