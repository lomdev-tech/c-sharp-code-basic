using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Classes_M2
{
    public class Person4
    {
        public required string FirstName { get; init; }
        [SetsRequiredMembers]//告诉构造器我的成员属性不用强制是否赋值了 我已经处理好了
        public Person4(string firstName) {
        
            FirstName = firstName;
        
        }
        public Person4() { }
    }
}
