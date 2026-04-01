using System;
using System.Collections.Generic;
using System.Text;

namespace testProject
{
    internal class Class1
    {
        static void aa(string[] args)
        {
            //for (int i = 10;i>=0;i--) {
            //    Console.WriteLine(i);

            //}

            //for (int i = 0; i <10; i+=3)
            //{
            //    Console.WriteLine(i);

            //}

            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine(i);
            //    if (i == 7) break;

            //}

            //string[] names = { "Alex", "Andrew", "John", "David", "Lucy", "Michael" };
            /*
             倒序
             */
            //for (int i = names.Length-1 ; i >=0; i--)
            //{
            //    Console.WriteLine(names[i]);
            //}
            /*
             正序
             */
            //for (int i = 0; i < names.Length; i++)
            //{
            //    Console.WriteLine(names[i]);
            //}
            //使用foreach迭代数组或对象
            //foreach (string name in names) {

            //    Console.WriteLine(name);
            //}
            //foreach (string name in names)
            //{
            //    //foreach 无法重新赋值
            //    if (name == "Alex") name = "Sammy";
            //}
            //for (int i = 0; i < names.Length; i++)
            //{
            //    if (names[i] == "Alex") names[i] = "Sammy";
            //}
            //foreach (string name in names) Console.WriteLine(name);

            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0) Console.WriteLine($"{i} - Fizz");

                else if (i % 5 == 0) Console.WriteLine($"{i} - Buzz");

                else if (i % 3 == 0 && i % 5 == 0) Console.WriteLine($"{i} - FizzBuzz");

                else Console.WriteLine(i);


            }
        }
    }
}
