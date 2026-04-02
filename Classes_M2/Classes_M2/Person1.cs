using System;
using System.Collections.Generic;
using System.Text;

namespace Classes_M2
{
    public class Person1
    {
        private string _name = "N/A";
        private int _age = 0;

        public string Name
        {
            get { return _name; }
            set { _name = value; }

        }
        public int Age {
            get { return _age; }
            set { _age = value; }
        
        }
    }
}
