using System;
using System.Collections.Generic;
using System.Text;

namespace Classes_M2
{
 
    public class Person2
    {
        //字段
     


        public string FirstName {
            get => field ?? "N/A";
            set =>field = value.Trim();
        
        }
        public string LastName {
            get => field ?? "N/A";
            set => field = value.Trim();
        }
    }
}
