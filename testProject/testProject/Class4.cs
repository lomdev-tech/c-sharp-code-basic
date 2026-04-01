using System;
using System.Collections.Generic;
using System.Text;

namespace testProject
{
    internal class Class4
    {
        static void aa(string[] args) {
            string? userInput;
            //string? enterValue = "";
            int parseValue = 0;
            bool validNumber = false;//转换成功与否标记
            Console.WriteLine("请输入5-10之间的整数值:");

            do {
                userInput = Console.ReadLine();
                if (userInput != null)
                {
                    //enterValue = userInput;


                }

                //进行转换
                validNumber = int.TryParse(userInput, out parseValue);
                if (validNumber == true)
                {
                    if (parseValue <= 5 || parseValue >= 10)
                    {
                        validNumber = false;
                        Console.WriteLine($"你输入的值{parseValue}不在范围5-10之间,请重新输入!");
                    }


                }
                else
                {

                    Console.WriteLine("无效值,请重新输入!");
                }


            } while (validNumber!=true);
            Console.WriteLine($"你输入的值{parseValue}在符合的范围内");
        }
    }
}
