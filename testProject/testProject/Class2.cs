using System;
using System.Collections.Generic;
using System.Text;

namespace testProject
{
    internal class Class2
    {
        static void aa(string[] args) {
            Random random = new();
            int current = random.Next(1,11);//?

            do
            {
                current = random.Next(1, 11);

                if (current >= 8) continue;

                Console.WriteLine(current);
            } while (current != 7);




            //while (current >= 3) {
            //    Console.WriteLine(current);
            //    current = random.Next(1,11);
            //}
            //Console.WriteLine($"last number: {current}");
        }
    }
}
