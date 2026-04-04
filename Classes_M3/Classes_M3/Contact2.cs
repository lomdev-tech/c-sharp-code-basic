using System;
using System.Collections.Generic;
using System.Text;

namespace Classes_M3
{
    public class Contact2
    {
        public string Name { get; private set; }
        public string Address { get;  }


        public Contact2(string contactName,string contactAddress) { 
            Name = contactName;
            Address = contactAddress;
        
        }
        //工厂模式
        public static Contact2 CreateContact(string name ,string address) { 
        
            return new Contact2(name,address);
        }
    }
}
