using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp8
{
    internal class Class1
    {
        static void Main(string[] args) {

            //    int[] data = new int[3];
            //    string shortenedString = "Hello World!";
            //    Console.WriteLine(shortenedString);



            //int val_A = 2;
            //int val_B = val_A;
            //val_B = 7;

            //Console.WriteLine("--Value Types--");
            //Console.WriteLine($"val_A: {val_A}");
            //Console.WriteLine($"val_B: {val_B}");

            int[] ref_A = new int[1];
            ref_A[0] = 2;
            int[] ref_B = ref_A;
            ref_B[0] = 7;

            Console.WriteLine("--Reference Types--");
            Console.WriteLine($"ref_A[0]: {ref_A[0]}");
            Console.WriteLine($"ref_B[0]: {ref_B[0]}");
        }


    }
}
