using System;
using System.Collections.Generic;
using System.Text;

namespace Classes_M3
{
    public  class ByRefExample
    {
        static void aa(string[] args) {

            var value = 20;
            Console.WriteLine("In Main, value = {0}", value);//20
            ModifyValue(ref value);
            Console.WriteLine("Back in Main, value = {0}", value);//20
        }

        private static void ModifyValue(ref int value)//值传递
        {
            value = 30;
            Console.WriteLine("In ModifyValue, parameter value = {0}", value);//30
            return;
        }
    }
}
