using System;
using System.Collections.Generic;
using System.Text;

namespace Classes_M3
{
    public class Contact
    {
        //属性
        public string Name { get; }
        public string Address { get; private set; }

        public Contact(string contactName,string contactAddress) { 
            Name = contactName;
            Address = contactAddress;
        
        }
    }
}
