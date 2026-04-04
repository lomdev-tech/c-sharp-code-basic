using System;
using System.Collections.Generic;
using System.Text;

namespace Classes_M2
{
    public class Test
    {
        static void Main(string[] args)
        {
            var p1 = new Person5() { Name = "Alice"};
            var p2 = new Person5();
            p2.Name = "Bob";
        }
    }
}
