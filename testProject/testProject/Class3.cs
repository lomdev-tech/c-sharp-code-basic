using System;
using System.Collections.Generic;
using System.Text;

namespace testProject
{
    internal class Class3
    {
        static void aa(string[] args) {
            string? readResult;
            bool vaildEntry = false;
            Console.WriteLine("输入一个至少三个字符的字符串:");
            do
            {
                readResult = Console.ReadLine();
                if (readResult != null)
                {
                    if (readResult.Length >= 3)
                    {

                        vaildEntry = true;
                    }
                    else
                    {
                        Console.WriteLine("你的输入无效，请重新输入");

                    }
                }
            } while (vaildEntry == false);

        }
    }
}
