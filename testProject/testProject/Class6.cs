using System;
using System.Collections.Generic;
using System.Text;

namespace testProject
{
    internal class Class6
    {
        static void Main(string[] args)
        {
            string[] myStrings = { "I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices" };
            int periodIndex = 0;
            string myString = "";
            for (int i = 0; i < myStrings.Length; i++)
            {
                myString = myStrings[i];

                periodIndex = myString.IndexOf(".");//找到这个.号索引 返回值是字符标 找不到是返回-1
                string mySentence;
                //Console.WriteLine(periodIndex);
                while (periodIndex != -1)
                { //只要找到索引就一直循环
                    mySentence = myString.Remove(periodIndex);//得到第一句话I like pizza.
                    myString = myString.Substring(periodIndex + 1);
                    myString = myString.TrimStart();//去掉开头空格
                    periodIndex = myString.IndexOf(".");//重新找到.号索引
                    Console.WriteLine(mySentence);
                }
                mySentence = myString.Trim();
                Console.WriteLine(mySentence);
            }

        }
    }
}
