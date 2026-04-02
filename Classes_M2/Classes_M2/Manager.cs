using System;
using System.Collections.Generic;
using System.Text;

namespace Classes_M2
{
    public class Manager
    {
        private string? _name;
        public string Name
        {
            get {
                return  _name!=null? _name : "N/A";
            
            }
            //set { _name = value; }
        
        }
    }
}
