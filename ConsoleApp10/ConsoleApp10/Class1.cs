using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp10
{
    internal class Class1
    {
        static void Main(string[]args) {
            string hello = "hello world";
           int index = hello.IndexOfAny(['e','b']);
            Console.WriteLine($"发现{hello[index]}在索引{index}");
        
        }
    }
}
