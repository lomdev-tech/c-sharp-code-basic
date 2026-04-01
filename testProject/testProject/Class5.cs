using System;
using System.Collections.Generic;
using System.Text;

namespace testProject
{
    internal class Class5
    {
        static void aa(string[] args)
        {
            string? readResult ;
            bool flag = false ;
            Console.WriteLine("请输入用户权限:admin|manager|user");
            do {
                readResult = Console.ReadLine().Trim().ToLower();
                if (readResult !=null) {
                    if (readResult=="admin" || readResult=="manager" || readResult=="user")
                    {
                        flag = true;
                    }
                    else {
                        Console.WriteLine("输入的值无效，请重新输入!");
                    }
                }
            } while (flag!=true);
            Console.WriteLine($"你输入的值{readResult}已被接收");
        }
    }
}
