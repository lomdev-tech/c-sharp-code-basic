using System;
using System.Collections.Generic;
using System.Text;

namespace Classes_M3
{
    public class RefSwapExample
    {
        static void a(string[] args) {
            int a = 10, b = 20;
            Console.WriteLine("{0}  {1}",a,b);
            Swap(ref a,ref b);
            Console.WriteLine("{0}  {1}",a,b);


        }
        static void Swap(ref int a,ref int b) => (a, b) = (b, a);

        //Console.WriteLine("{0}  {1}", a, b+"变量只在方法内部生效---");


    }
    
}
