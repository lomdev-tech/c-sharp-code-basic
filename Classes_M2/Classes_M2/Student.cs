using System;
using System.Collections.Generic;
using System.Text;

namespace Classes_M2
{
    public class Student
    {
        private string? _name;
        public string Name {

            get{ return _name!=null?_name:"N/A"; }//get访问器
            set { _name = value; }//set访问器
        }
    }
}
